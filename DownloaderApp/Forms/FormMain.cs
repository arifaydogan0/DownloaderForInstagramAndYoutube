using DownloaderApp.Properties;
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
    public partial class FormMain : Form
    {
        static Size p1;
        static Size p2;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            p1 = pictureBox1.Size;
            p2 = pictureBox2.Size;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = p1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.frmMain.Visible = false;
            Program.frmInsta.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(pictureBox2.Size.Width - 10, pictureBox2.Size.Height - 10);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = p2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.frmMain.Visible = false;
            Program.frmYoutube.Visible = true;
        }
    }
}
