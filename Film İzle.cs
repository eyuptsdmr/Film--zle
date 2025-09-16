using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje19Form_WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;


        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Eyüp Taşdemir tarafından yapılmıştır","bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Text = "Mad Max";
        }

        private void aşkTesadüfleriSeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=1qjMQ1xBldI");

        }

        private void theNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=BjJcYdEOI0k");
            label1.Text = "Not:Seni Seviyorum";
        }

        private void siccin4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=rivB0DjQixs");
            label1.Text = "Siccin4";
        }

        private void ınterstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=zSWdZVtXT7E");
            label1.Text = "Interstellar";
        }
    }
}
