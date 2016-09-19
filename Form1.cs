using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        string[] times = { "7:05", "7:45", "8:15", "8:40" };
        Color[] color = {Color.Red, Color.PowderBlue, Color.Orange, Color.Yellow};
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "Select a movie";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < listBox1.Items.Count; ++x)
                if (listBox1.GetSelected(x))
                {
                    label2.Text = "Starting time is " + times[x];
                    this.BackColor = color[x];
                }
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            string timesString = "\n";
            for(int x = 0; x < times.Length; ++x)
                timesString += times[x] + "\n";
            label3.Text = "Times are " + timesString; 
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}