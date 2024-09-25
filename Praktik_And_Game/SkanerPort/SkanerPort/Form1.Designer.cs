namespace SkanerPort
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tIPAddress = new System.Windows.Forms.TextBox();
            this.nBeginPort = new System.Windows.Forms.NumericUpDown();
            this.nEndPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tIPAddress
            // 
            this.tIPAddress.Location = new System.Drawing.Point(112, 21);
            this.tIPAddress.Multiline = true;
            this.tIPAddress.Name = "tIPAddress";
            this.tIPAddress.Size = new System.Drawing.Size(198, 22);
            this.tIPAddress.TabIndex = 0;
            // 
            // nBeginPort
            // 
            this.nBeginPort.Location = new System.Drawing.Point(418, 22);
            this.nBeginPort.Name = "nBeginPort";
            this.nBeginPort.Size = new System.Drawing.Size(48, 20);
            this.nBeginPort.TabIndex = 1;
            // 
            // nEndPort
            // 
            this.nEndPort.Location = new System.Drawing.Point(515, 22);
            this.nEndPort.Name = "nEndPort";
            this.nEndPort.Size = new System.Drawing.Size(48, 20);
            this.nEndPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Порты с:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(472, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "по:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 317);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Порт";
            this.columnHeader1.Width = 251;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Открыт";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Закрыт";
            this.columnHeader3.Width = 321;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 408);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(633, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сканировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nEndPort);
            this.Controls.Add(this.nBeginPort);
            this.Controls.Add(this.tIPAddress);
            this.Name = "Form1";
            this.Text = "Сканер портов";
            ((System.ComponentModel.ISupportInitialize)(this.nBeginPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEndPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tIPAddress;
        private System.Windows.Forms.NumericUpDown nBeginPort;
        private System.Windows.Forms.NumericUpDown nEndPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
    }
}

