using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Single_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // delegate for call function that return one value 
        public delegate void print(string s);

        public void value(string s)
        {
            label1.Text = s;
        }
        public void start_th()
        {
            label1.Invoke(new print(value),new object[] { "Thread started"});
            label1.BackColor = Color.Green;
            Thread.Sleep(1000);
            label1.Invoke(new print(value), new object[] { "Thread died" });
            label1.BackColor = Color.Coral;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(start_th);
            th.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       public void vhange()
        {
            label2.BackColor = Color.Green;
            Thread.Sleep(4000);
            label2.BackColor = Color.LightGray;
  

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread nth = new Thread(new ThreadStart(vhange) );
            nth.Start();
        }
    }
}
