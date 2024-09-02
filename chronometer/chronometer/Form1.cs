using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace chronometer
{
    public partial class Form1 : Form
    {
        Stopwatch oSW = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oSW.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0,0, 0, 0, (int)oSW.ElapsedMilliseconds);

            txtmin.Text = ts.Minutes.ToString().Length<2 ? '0'+ ts.Minutes.ToString() : ts.Minutes.ToString();
            txtseg.Text = ts.Seconds.ToString().Length<2 ? '0'+ ts.Seconds.ToString() : ts.Seconds.ToString();
            txtmil.Text = ts.Milliseconds.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oSW.Reset();
            txtmin.Text = "00";
            txtseg.Text = "00";
            txtseg.Text = "000";
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oSW.Stop();
        }
    }
}
