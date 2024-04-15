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
    public partial class Form3 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(@";Data Source=3EZZDIN\SQLEXPRESS;Initial Catalog=dictionnary;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var word = textBox1.Text;

            string req = string.Format("DELETE FROM words WHERE word='{0}'", word);
            cmd = new SqlCommand(req, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Word Deleted");
           
        }

        
    }
}
