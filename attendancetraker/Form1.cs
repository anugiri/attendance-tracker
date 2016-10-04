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
    public partial class Form1 : Form
    {
        private OleDbConnection conn;
        //private OleDbDataAdapter adp;
        //private DataTable tbl;
       // private DataRow row;
        public int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // int id=Convert.ToInt32(textBox1.Text);
                string code=textBox1.Text;
                string time=textBox2.Text;
                string date=textBox3.Text;
                //string faculty
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\attendance.accdb;");
                conn.Open();
               string str="insert into Table2([code],[time],[date])values('" + code +"','" + time +"','"+ date +"')";
    
               // tbl = new DataTable();
                //adp.Fill(tbl);
                //row = tbl.Rows[i];
                OleDbCommand cmd =new OleDbCommand(str,conn);
                cmd.ExecuteNonQuery();
               /* textBox1.Text = Convert.ToString(row[0]);
                textBox2.Text = Convert.ToString(row[1]);
                textBox3.Text = Convert.ToString(row[2]);*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      }

        private void Form1_Load(object sender, EventArgs e)
        {
           // textBox4.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox3.Text=DateTime.Now.ToString("yyyy-MM-dd");
            textBox2.Text = DateTime.Now.ToString("hh:mm tt");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form2 frm = new Form2();
             frm.Show();
        }
        }
    }

