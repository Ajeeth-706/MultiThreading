using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread T1 = new Thread(CatchLog);
            T1.Start();
            InitializeComponent();
        }
        private void CatchLog()
        {
            Thread.Sleep(3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread T2 = new Thread(CatchLog);
            T2.Start();
            textBox1.Text = File.ReadAllText("C:\\MultiThreading\\Sample1.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread T3 = new Thread(CatchLog);
            T3.Start();
            textBox2.Text = File.ReadAllText("C:\\MultiThreading\\Sample2.txt");
        }
    }
}
