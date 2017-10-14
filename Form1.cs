using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace AppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void load_from_file_Click(object sender, EventArgs e)

        {  
            try
            {        
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "x509 certificate (*.cer; *.crt)|*.cer;*.crt";
                openFileDialog.ShowDialog();
                var cert_paths = openFileDialog.FileNames[0];    
                if (cert_paths.Equals(""))
                {
                    int num = (int)MessageBox.Show("Выберите сертификат!");
                }
                else
                {
                        this.import_cert(cert_paths);
                }
            }
            catch (System.Exception exf)
	        {

                MessageBox.Show("Пожалуйста, приложите скриншот или текст этого отчета в письме технической поддержке или преподавателю\n\n" + exf.Message + "\nin load from file procedure");
	        }
        }

        private void load_from_server_Click(object sender, EventArgs e)
        {
            try
            { 
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://www.avalon.ru/ca/AVALON CA.crt", "AVALON_CA.crt");
                this.import_cert("AVALON_CA.crt");
            }
            catch (System.Exception exs)
            {

                MessageBox.Show("Пожалуйста, приложите скриншот или текст этого отчета в письме технической поддержке или преподавателю\n\n" + exs.Message + "\nin load from server procedure");
            }
        }
        public void import_cert(string path)
        {
            try
            {
                X509Certificate2 x509Certificate2 = new X509Certificate2(path);
                X509Store x509Store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadWrite);
                foreach (X509Certificate2 certificate in x509Store.Certificates)
                {
                    if (certificate.SerialNumber == x509Certificate2.SerialNumber)
                    {
                        int num = (int)MessageBox.Show("Сертификат уже установлен!");
                        x509Store.Close();
                        return;
                    }
                }
                x509Store.Add(new X509Certificate2(X509Certificate.CreateFromCertFile(path)));
                foreach (X509Certificate2 certificate in x509Store.Certificates)
                {
                    if (certificate.SerialNumber == x509Certificate2.SerialNumber)
                    {
                        int num = (int)MessageBox.Show("Установка сертификата выполнена успешно!");
                        x509Store.Close();
                        return;
                    }
                }
                int num1 = (int)MessageBox.Show("Неизвестная ошибка! Сертификат отсутствует!");
                x509Store.Close();
            }
            catch (System.Exception exi)
            {

                MessageBox.Show("Пожалуйста, приложите скриншот или текст этого отчета в письме технической поддержке или преподавателю\n\n" + exi.Message + "\nin import procedure");
            }
        }
    }
}
