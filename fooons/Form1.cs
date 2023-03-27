using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fooons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"c:\930202.jpg");
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"c:\930202.jpg");
        }
    }
}
