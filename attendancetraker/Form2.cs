using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendancetraker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "anu";
            string password = "giri";
            if (username == textBox1.Text && password ==textBox2.Text)
            {
                MessageBox.Show("You are now successfully logged in!", "Success!");
                Form3 f3 = new Form3(); // Instantiate a Form3 object.
                f3.Show(); // Show Form3 and
                this.Close();   
            }
            else
                MessageBox.Show("Username or Password is incorrect!", "Error!");
        }
        }
    }

