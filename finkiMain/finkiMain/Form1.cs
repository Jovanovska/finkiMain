using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace finkiMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kopce1_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"D:\Documents and Settings\User\My Documents\GitHub\finkiMain\finkiMain\finkiMain\Resources\button-16.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"D:\Documents and Settings\User\My Documents\GitHub\finkiMain\finkiMain\finkiMain\Resources\button-16.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"D:\Documents and Settings\User\My Documents\GitHub\finkiMain\finkiMain\finkiMain\Resources\HeyThere.wav");
            sound.PlayLooping();
        }


    }
}
