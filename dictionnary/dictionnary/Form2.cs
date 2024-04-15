using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionnary
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand res;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data source=3EZZDIN\SQLEXPRESS;Initial Catalog=dictionnary;Integrated Security=True");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var word = textBox1.Text;
            var type = textBox2.Text;
            var trans = textBox3.Text;
            var ex = textBox4.Text;

            try
            {
                string sqlreq=String.Format("insert into words values('{0}','{1}','{2}','{3}');",word,type,trans,ex);
                res = new SqlCommand(sqlreq, con);
                con.Open();
                res.ExecuteNonQuery();
                MessageBox.Show("Word Added");
                con.Close();
                
                
            }

            catch(Exception) { Console.WriteLine("error"); }

    } }
}
