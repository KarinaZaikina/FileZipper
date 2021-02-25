using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Ionic.Zip;

namespace FileZipper
{
    public partial class ArchiveDir : Form
    {
        private bool stop = false;
        string Password;
        public ArchiveDir()
        {
            InitializeComponent();
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            dialog.SelectedPath = Environment.CurrentDirectory;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxFolder.Text = dialog.SelectedPath;
            }
        }

        private void buttonZip_Click(object sender, EventArgs e)
        {
            try
            {
                labelCount.Text = "0";
                labelProcessing.Text = "---";

                if (textBoxFolder.Text == "")
                {
                    MessageBox.Show("Оберіть директорію", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Directory.Exists(textBoxFolder.Text))
                {
                    MessageBox.Show("Оберіть дійсну директорію!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBoxExtension.Text == "" && !checkBoxDir.Checked)
                {
                    MessageBox.Show("Вкажіть розширення", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (checkBoxDir.Checked)
                {
                    ZipDirectories();
                }
                else
                {
                    ZipFiles();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZipFiles()
        {

            var files = Directory.GetFiles(textBoxFolder.Text, "*." + textBoxExtension.Text);

            if (files == null || files.Length == 0)
            {
                MessageBox.Show("Файлів не знайдено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = 1;

            new Thread(() =>
            {
                foreach (var file in files)
                {
                    if (stop)
                    {
                        stop = false;
                        Thread.CurrentThread.Abort();
                    }

                    var zippedName = textBoxFolder.Text + "\\" + GetFileNameNoExtension(file) + ".zip";
                    var fileName = GetFileName(file);

                    labelProcessing.Invoke((MethodInvoker)delegate
                    {
                        labelProcessing.Text = fileName;
                        labelProcessing.Refresh();
                    });

                    Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile();
                    zip.AlternateEncoding = Encoding.UTF8;
                    zip.AlternateEncodingUsage = ZipOption.Always;
                    zip.Password = (Password);
                    zip.ParallelDeflateThreshold = -1;
                    zip.AddEntry(fileName, File.ReadAllBytes(file));
                    
                    if (File.Exists(zippedName))
                    {
                        File.Delete(zippedName);
                    }

                    zip.Save(zippedName);

                    labelCount.Invoke((MethodInvoker)delegate
                    {
                        labelCount.Text = index.ToString();
                        labelCount.Refresh();
                    });

                    index++;
                }

                labelProcessing.Invoke((MethodInvoker)delegate
                {
                    labelProcessing.Text = "Виконано!";
                    MessageBox.Show("Операція архівації пройшла успішно!");
                    labelProcessing.Refresh();
                    this.Close();
                });
            }).Start();
        }

        private void ZipDirectories()
        {
            var dirs = Directory.GetDirectories(textBoxFolder.Text);

            if (dirs == null || dirs.Length == 0)
            {
                MessageBox.Show("Директорій не знайдено", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = 1;

            new Thread(() =>
            {
                foreach (var dir in dirs)
                {
                    if (stop)
                    {
                        stop = false;
                        Thread.CurrentThread.Abort();
                    }

                    labelProcessing.Invoke((MethodInvoker)delegate
                    {
                        labelProcessing.Text = GetFileName(dir);
                        labelProcessing.Refresh();
                    });

                    var zippedName = textBoxFolder.Text + "\\" + GetFileName(dir) + ".zip";
                    Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile();
                    zip.AlternateEncoding = Encoding.UTF8;
                    zip.AlternateEncodingUsage = ZipOption.Always;
                    zip.Password = (Password);
                    zip.ParallelDeflateThreshold = -1;
                    zip.AddDirectory(dir);
                    
                    if (File.Exists(zippedName))
                    {
                        File.Delete(zippedName);
                    }

                    zip.Save(zippedName);

                    labelCount.Invoke((MethodInvoker)delegate
                    {
                        labelCount.Text = index.ToString();
                        labelCount.Refresh();
                    });

                    index++;
                }


                labelProcessing.Invoke((MethodInvoker)delegate
                {
                    labelProcessing.Text = "Виконано!";
                    MessageBox.Show("Операція архівації пройшла успішно!");
                    labelProcessing.Refresh();
                    this.Close();
                });
            }).Start();
        }

        public static string GetFileNameNoExtension(string file)
        {
            if (string.IsNullOrEmpty(file)) return "";
            var fileName = file.Substring(file.LastIndexOf("\\") + 1);
            var indexExtension = fileName.LastIndexOf(".");

            if (indexExtension == -1)
            {
                return fileName;
            }
            else
            {
                return fileName.Substring(0, fileName.LastIndexOf("."));
            }
        }

        public static string GetFileName(string file)
        {
            if (string.IsNullOrEmpty(file)) return "";
            return file.Substring(file.LastIndexOf("\\") + 1);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void checkBoxDir_CheckedChanged(object sender, EventArgs e)
        {
            textBoxExtension.Enabled = !checkBoxDir.Checked;
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
