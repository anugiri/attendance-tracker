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
        private OleDbDataAdapter adp;
        private DataTable tbl;
        private DataRow row;
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
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\attendance.accdb;");
                conn.Open();
                adp = new OleDbDataAdapter("select '*from table1'", conn);
                tbl = new DataTable();
                adp.Fill(tbl);
                row = tbl.Rows[i];
                textBox1.Text = Convert.ToString(row[0]);
                textBox2.Text = Convert.ToString(row[1]);
                textBox3.Text = Convert.ToString(row[2]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      }
    }
}
