namespace FileZipper
{
    partial class ArchiveDir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveDir));
            this.checkBoxDir = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonZip = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.IsPassword = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDir
            // 
            this.checkBoxDir.AutoSize = true;
            this.checkBoxDir.Location = new System.Drawing.Point(514, 193);
            this.checkBoxDir.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDir.Name = "checkBoxDir";
            this.checkBoxDir.Size = new System.Drawing.Size(101, 21);
            this.checkBoxDir.TabIndex = 23;
            this.checkBoxDir.Text = "Директорії";
            this.checkBoxDir.UseVisualStyleBackColor = true;
            this.checkBoxDir.CheckedChanged += new System.EventHandler(this.checkBoxDir_CheckedChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Khaki;
            this.buttonStop.Location = new System.Drawing.Point(345, 326);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(149, 43);
            this.buttonStop.TabIndex = 22;
            this.buttonStop.Text = "Зупинити";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelProcessing
            // 
            this.labelProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessing.Location = new System.Drawing.Point(124, 394);
            this.labelProcessing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcessing.MaximumSize = new System.Drawing.Size(240, 0);
            this.labelProcessing.MinimumSize = new System.Drawing.Size(240, 0);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(240, 15);
            this.labelProcessing.TabIndex = 21;
            this.labelProcessing.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Процес:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(163, 426);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(16, 17);
            this.labelCount.TabIndex = 19;
            this.labelCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Кількість файлів:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxExtension.Location = new System.Drawing.Point(38, 193);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(456, 22);
            this.textBoxExtension.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Вкажіть розширення файлів, які необхідно додати до архіву";
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.BackColor = System.Drawing.Color.Khaki;
            this.buttonOpenFolder.Location = new System.Drawing.Point(514, 131);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(56, 28);
            this.buttonOpenFolder.TabIndex = 15;
            this.buttonOpenFolder.Text = "...";
            this.buttonOpenFolder.UseVisualStyleBackColor = false;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Оберіть папку, яка містить файли для архівації";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFolder.Location = new System.Drawing.Point(39, 131);
            this.textBoxFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(455, 22);
            this.textBoxFolder.TabIndex = 13;
            // 
            // buttonZip
            // 
            this.buttonZip.BackColor = System.Drawing.Color.Khaki;
            this.buttonZip.Location = new System.Drawing.Point(38, 326);
            this.buttonZip.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(152, 43);
            this.buttonZip.TabIndex = 12;
            this.buttonZip.Text = "Заархівувати";
            this.buttonZip.UseVisualStyleBackColor = false;
            this.buttonZip.Click += new System.EventHandler(this.buttonZip_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Архівація файлів за розширенням ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(38, 265);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(456, 22);
            this.PasswordTextBox.TabIndex = 26;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // IsPassword
            // 
            this.IsPassword.AutoSize = true;
            this.IsPassword.Location = new System.Drawing.Point(38, 236);
            this.IsPassword.Margin = new System.Windows.Forms.Padding(4);
            this.IsPassword.Name = "IsPassword";
            this.IsPassword.Size = new System.Drawing.Size(131, 21);
            this.IsPassword.TabIndex = 25;
            this.IsPassword.Text = "Додати пароль";
            this.IsPassword.UseVisualStyleBackColor = true;
            this.IsPassword.CheckedChanged += new System.EventHandler(this.Сheck_Password);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(466, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Вийти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(514, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(183, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "або директорій";
            // 
            // ArchiveDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(628, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.IsPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxDir);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelProcessing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.buttonZip);
            this.MaximizeBox = false;
            this.Name = "ArchiveDir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileZipper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDir;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonZip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox IsPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}