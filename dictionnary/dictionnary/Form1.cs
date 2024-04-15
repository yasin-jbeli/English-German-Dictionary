using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace dictionnary


{
    
    public partial class Form1 : Form
    {
        
    public Form1()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

            
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 addword = new Form2();
            addword.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 deleteword = new Form3();
            deleteword.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 updateword = new Form4();
            updateword.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            var word = textBox1.Text;
            string connectionString = "Data Source=3EZZDIN\\SQLEXPRESS;Initial Catalog=dictionnary; integrated security=true";
            if (!radioButton1.Checked)
            {
                string sql = string.Format("SELECT * FROM words where word='{0}'", word);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows) { textBox2.Text = "Word Not Found!\r\n\r\nCheck your spelling or add new word."; }
                    else
                    {
                        while (reader.Read())
                        {
                            string type = reader.GetString(1);
                            string trans = reader.GetString(2);
                            string ex = reader.GetString(3);
                            string resq = String.Format("Type: {0} \r\nMeaning: {1} \r\nExample: {2}", type, trans, ex);
                            textBox2.Text = resq;
                        }
                    }
                }
            }

            else
            {
                radioButton1.Checked = false;
                string sql = string.Format("SELECT * FROM words where trans='{0}'", word);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows) { textBox2.Text = "Wort Nicht Gefunden!\r\n\r\nÜberprüfen Sie Ihre Rechtschreibung oder fügen Sie ein neues Wort hinzu."; }
                    else
                    {
                        while (reader.Read())
                        {

                            string type = reader.GetString(1);
                            if (type == "Noun") { type = "Nomen"; }
                            if (type == "Adjective") { type = "Adjektiv"; }
                            string word1 = reader.GetString(0);
                            string ex = reader.GetString(3);
                            string resq = String.Format("Art: {0} \r\nBedeutung: {1} \r\nBeispiel: {2}", type, word1, ex);
                            textBox2.Text = resq;


                        }
                    }
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ß = alt + 0223\r\n\r\nä = alt + 0228 \r\n\r\nö = alt + 0246\r\n\r\nü = alt + 0252\r\n\r\nÄ = alt + 142\r\n\r\nÖ = alt + 153\r\n\r\nÜ = alt + 154\r\n");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this app was created by Yasin Jbeli & Yassin Abbes using the .NET Framework/Diese Anwendung wurde von Yasin Jbeli & Yassin Abbes unter Verwendung des .NET Frameworks erstellt");
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=3EZZDIN\\SQLEXPRESS;Initial Catalog=dictionnary; integrated security=true";
                string sql = "SELECT * FROM words";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "CSV file (*.csv)|*.csv";
                        saveFileDialog1.Title = "Save the dictionary database as a CSV file";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                            {
                                using (CsvWriter cw = new CsvWriter(sw, System.Globalization.CultureInfo.CurrentCulture))
                                {
                                    cw.WriteHeader<Word>();
                                    while (reader.Read())
                                    {
                                        Word word = new Word
                                        {
                                            word = reader.GetString(0),
                                            type = reader.GetString(1),
                                            trans = reader.GetString(2),
                                            ex = reader.GetString(3)
                                        };
                                        cw.WriteRecord(word);
                                    }
                                }
                            }
                            MessageBox.Show("Database exported successfully.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data to export.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        class Word
        {
            public string word { get; set; }
            public string type { get; set; }
            public string trans { get; set; }
            public string ex { get; set; }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            



            try
            {
                string connectionString = "Data Source=3EZZDIN\\SQLEXPRESS;Initial Catalog=dictionnary; integrated security=true";

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "CSV file (*.csv)|*.csv";
                openFileDialog1.Title = "Select a CSV file to import";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        using (CsvReader cr = new CsvReader(sr, System.Globalization.CultureInfo.CurrentCulture))
                        {
                            cr.Configuration.HeaderValidated = null;
                            cr.Configuration.MissingFieldFound = null;
                            IEnumerable<Word> records = cr.GetRecords<Word>();
                            foreach (Word record in records)
                            {
                                string sql = string.Format("INSERT INTO words(word,type,trans,ex) VALUES ('{0}','{1}','{2}','{3}')", record.word, record.type, record.trans, record.ex);
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    SqlCommand command = new SqlCommand(sql, connection);
                                    connection.Open();
                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        // record inserted successfully
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show("Data imported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
