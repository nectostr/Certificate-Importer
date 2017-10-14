using System.Windows.Forms;
namespace AppTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

	        catch (System.Exception e)
	        {

                MessageBox.Show("Пожалуйста, приложите скриншот или текст этого отчета в письме технической поддержке или преподавателю\n\n" + e.Message);
	        }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.load_from_file = new System.Windows.Forms.Button();
            this.load_from_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load_from_file
            // 
            this.load_from_file.Location = new System.Drawing.Point(48, 25);
            this.load_from_file.Name = "load_from_file";
            this.load_from_file.Size = new System.Drawing.Size(198, 47);
            this.load_from_file.TabIndex = 0;
            this.load_from_file.Text = "Загрузить из файла";
            this.load_from_file.UseVisualStyleBackColor = true;
            this.load_from_file.Click += new System.EventHandler(this.load_from_file_Click);
            // 
            // load_from_server
            // 
            this.load_from_server.Location = new System.Drawing.Point(48, 92);
            this.load_from_server.Name = "load_from_server";
            this.load_from_server.Size = new System.Drawing.Size(198, 46);
            this.load_from_server.TabIndex = 1;
            this.load_from_server.Text = "Загрузить с сервера (автоматически)";
            this.load_from_server.UseMnemonic = false;
            this.load_from_server.UseVisualStyleBackColor = true;
            this.load_from_server.Click += new System.EventHandler(this.load_from_server_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 159);
            this.Controls.Add(this.load_from_server);
            this.Controls.Add(this.load_from_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Importer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_from_file;
        private System.Windows.Forms.Button load_from_server;

    }
}

