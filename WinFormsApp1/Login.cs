using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : child1
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Hello" && password == "World")
            {
                MessageBox.Show("LoggedIn successfully!");
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
