using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{

    public partial class child1 : Form
    {
        private int openFormsCount = 1; // Start with 1 because the main form is open

        public child1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }
        private void Newform(Form form)
        {
            if (openFormsCount < 2)
            {
                openFormsCount++;
                form.FormClosed += (s, args) => openFormsCount--;
                form.ShowDialog(); // ShowDialog blocks the main form until the new form is closed
            }
            else
            {
                MessageBox.Show("Only two forms can be open at the same time.");
            }

        }
        private void child1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Newform(new Login());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Newform(new Form1());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Newform(new Register());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Newform(new Update());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newform(new Delete());
        }
    }
}
