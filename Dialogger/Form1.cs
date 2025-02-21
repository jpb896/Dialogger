using System;
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

        private void SpawnDialog(object sender, EventArgs e)
        {
            MessageBoxIcon messageBoxIcon = new MessageBoxIcon();
            if (comboBox1.SelectedItem == "Error")
            {
                messageBoxIcon = MessageBoxIcon.Error;
            }
            else if (comboBox1.SelectedItem == "Warning")
            {
                messageBoxIcon = MessageBoxIcon.Warning;
            }
            else if (comboBox1.SelectedItem == "Information")
            {
                messageBoxIcon = MessageBoxIcon.Information;
            }
            else
            {
                messageBoxIcon = MessageBoxIcon.None;
            }
                MessageBox.Show(this, textBox2.Text,
                                       textBox1.Text, MessageBoxButtons.OK,
                                       messageBoxIcon,
                                       MessageBoxDefaultButton.Button1, 0);
        }
    }
}
