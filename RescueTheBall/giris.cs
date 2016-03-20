using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RescueTheBall
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        public static string isim;

        private void button1_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skor yuksek = new skor();
            yuksek.Show();
            this.Hide();
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
