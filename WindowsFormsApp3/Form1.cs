using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*label1.Text = DateTime.Today.ToLongDateString();
            label1.Text += "-";
            label2.Text = DateTime.Now.ToLongTimeString(); */
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 1);
        }
        void changethecolor()
        {
            Random rnd = new Random();
            int yeniR = rnd.Next(255);
            int yeniG = rnd.Next(255);
            int yeniB = rnd.Next(255);
            label1.ForeColor = Color.FromArgb(yeniB, yeniG, yeniR);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size - 1);
        }
    }
}
