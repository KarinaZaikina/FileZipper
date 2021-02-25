using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileZipper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonArchiveFiles_Click(object sender, EventArgs e)
        {
            ArchiveFiles newForm = new ArchiveFiles();
            newForm.Show();
        }

        private void buttonArchiveDir_Click(object sender, EventArgs e)
        {
            ArchiveDir newForm2 = new ArchiveDir();
            newForm2.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Інформація про програмне забезпечення: \n @FileZipper 2021 \n Zaikina K.E. KNT128");
        }
    }
}
