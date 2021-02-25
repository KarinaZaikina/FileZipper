using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
namespace FileZipper
{
    public partial class ArchiveFiles : Form
    {
        string Password;
        public ArchiveFiles()
        {
            InitializeComponent();
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(openFileDialog1.FileName);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    listBox1.Items.RemoveAt(0);
                }
            }
        }

        private void buttonZip_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                using (ZipFile zipFile = new ZipFile())
                {
                    zipFile.AlternateEncoding = Encoding.UTF8;
                    zipFile.AlternateEncodingUsage = ZipOption.Always;
                    zipFile.Password = (Password);
                    foreach (string item in listBox1.Items)
                    {
                        ZipEntry ze = zipFile.AddFile(item, "\\");
                    }

                    zipFile.Save(textBox1.Text);
                    MessageBox.Show("Операція архівації файлів пройшла успішно!");
                    this.Close();
                }
            }
            else MessageBox.Show("Оберіть файли для архівації", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void Сheck_Password(object sender, EventArgs e)
        {
            if (IsPassword.Checked)
            {
                PasswordTextBox.Enabled = true;
            }
            else
            {
                PasswordTextBox.Enabled = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordTextBox.Text;
        }
    }
}
