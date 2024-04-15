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
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
            con = new SqlConnection(@";Data Source=3EZZDIN\SQLEXPRESS;Initial Catalog=dictionnary;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var word = textBox1.Text;
            var trans = textBox2.Text;
            var ex = textBox3.Text;

            string req = String.Format("UPDATE words SET trans='{0}',exampl='{1}' WHERE word='{2}'",trans,ex,word);
            cmd = new SqlCommand(req, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Word Updated");
        }
    }
}
