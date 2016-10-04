using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendancetraker
{
    public partial class Form3 : Form
    {
        private OleDbConnection conn;
        private OleDbDataAdapter adp;
        private DataTable tbl;
         private DataRow row;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox1.Text;
                string name= textBox2.Text;
                string address = textBox3.Text;
                string faculty = textBox4.Text;
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\attendance.accdb;");
                conn.Open();
                string str="insert into table1([code],[name],[address],[faculty])values('"+code+"','"+name+"','"+address+"','"+faculty+"')";
                OleDbCommand cmd = new OleDbCommand(str, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
