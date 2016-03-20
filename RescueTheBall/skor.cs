using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RescueTheBall
{
    public partial class skor : Form
    {
        public skor()
        {
            InitializeComponent();
        }

        private void skor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreDataSet1.Skor' table. You can move, or remove it, as needed.
            //this.skorTableAdapter1.Fill(this.scoreDataSet1.Skor);
            //this.skorTableAdapter.Fill(this.scoreDataSet.Skor);
            ekleme();
            listele();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=score.accdb");

        void baglan()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM skor", conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        void ekleme()
        {
            baglan();
            OleDbCommand kom = new OleDbCommand("INSERT INTO Skor (Isim, Skor) VALUES ('" + giris.isim + "','" + Form1.puan + "')", conn);
            kom.ExecuteNonQuery();
            listele();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris ana = new giris();
            ana.Show();
            this.Hide();
        }

        private void skor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
