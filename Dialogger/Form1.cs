using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dialogger
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutClick(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
