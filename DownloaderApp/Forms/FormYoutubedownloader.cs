using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloaderApp.Forms
{
    public partial class FormYoutubedownloader : Form
    {
        public FormYoutubedownloader()
        {
            InitializeComponent();
        }

        private void FormYoutubedownloader_Load(object sender, EventArgs e)
        {
            Program.frmMain.Hide();
        }

        private void FormYoutubedownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmMain.Show();
        }
    }
}
