using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayBaloonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _Show_Click(object sender, EventArgs e)
        {
            TrayBalloon.TrayBalloon tb = new TrayBalloon.TrayBalloon();
            tb.BackgroundLocation = @".\background.bmp";
            tb.SoundLocation = @".\sndMsg.wav";
            tb.Title = _Title.Text;
            tb.Message = _Text.Text;
            tb.Run();
        }
    }
}
