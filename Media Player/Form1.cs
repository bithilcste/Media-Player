using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuartzTypeLib;


namespace Media_Player
{
    public partial class Form1 : Form
    {
        string output = "Developted By : Md.Shahadat Mahamud Bithil \n\n Dept : Computer Science & Telecommunication Engineering , NSTU \n\n E-mail : Bithilnstu@gmail.com";

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playToolStripMenuItem.Visible = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Media Files|*.wav;*.mp3;*.mp4;*.mp2;*.mkv;*.wma|All Files|*.*";

            //if (DialogResult.OK == open.ShowDialog())
            //{
            //    //Access the Imediacontrol interface
            //    QuartzTypeLib.FilgraphManager gm = new QuartzTypeLib.FilgraphManager();
            //    QuartzTypeLib.IMediaControl mc = (QuartzTypeLib.IMediaControl)gm;
            //    //specify the file
            //    mc.RenderFile(open.FileName);
            //    //Start playing Audio Asynchronously
            //    mc.Run();
            //}
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            playToolStripMenuItem.Visible = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void heplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(output, "    About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbltime.Text = dt.ToString();
        }  
    }
}
