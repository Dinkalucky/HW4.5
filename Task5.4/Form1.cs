using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var color = ConfigurationManager.AppSettings.Get("eyesColor");
            Color back = Color.FromName(color);
            button3.BackColor = back;
            button2.BackColor = back;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var color = ConfigurationManager.AppSettings.Get("lipsColor");
            Color back = Color.FromName(color);
            button5.BackColor = back;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var color = ConfigurationManager.AppSettings.Get("noseColor");
            Color back = Color.FromName(color);
            button4.BackColor = back;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var color = ConfigurationManager.AppSettings.Get("eyesColor");
            Color back = Color.FromName(color);
            button3.BackColor = back;
            button2.BackColor = back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var color = ConfigurationManager.AppSettings.Get("skinColor");
            Color back = Color.FromName(color);
            button1.BackColor = back;
        }
    }
}
