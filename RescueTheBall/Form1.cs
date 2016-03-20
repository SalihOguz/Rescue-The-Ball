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
    public partial class Form1 : Form
    {
        public List <PictureBox> kutular = new List <PictureBox>();
        public int duzhiz = 5, yanyon = 0, saniye = 0, can=3, gidenkutu=0; //gidenkutu kutu vuruldukça artar, oyunun bitmesi için
        public bool dikyon, bolum1=false; //dikyon true top yukarı demek yani top.Top--, false aşağı / Bölüm 1 bitirilmemiş 
        public static int puan = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            kutular.Add(pictureBox1);
            kutular.Add(pictureBox2);
            kutular.Add(pictureBox3);
            kutular.Add(pictureBox4);
            kutular.Add(pictureBox5);
            kutular.Add(pictureBox6);
            kutular.Add(pictureBox7);
            kutular.Add(pictureBox8);
            kutular.Add(pictureBox9);
            kutular.Add(pictureBox10);
            kutular.Add(pictureBox11);
            kutular.Add(pictureBox12);
            kutular.Add(pictureBox13);
            kutular.Add(pictureBox14);
            kutular.Add(pictureBox15);
            kutular.Add(pictureBox16); 
            kutular.Add(pictureBox17);
            kutular.Add(pictureBox18);
            kutular.Add(pictureBox19);
            kutular.Add(pictureBox20);
            kutular.Add(pictureBox21);
            kutular.Add(pictureBox22);
            kutular.Add(pictureBox23);
            kutular.Add(pictureBox24);
            kutular.Add(pictureBox25);
            kutular.Add(pictureBox26);
            kutular.Add(pictureBox27);
            kutular.Add(pictureBox28);
            kutular.Add(pictureBox29);
            kutular.Add(pictureBox30);
            kutular.Add(pictureBox31);
            kutular.Add(pictureBox32);
            kutular.Add(pictureBox33);
            kutular.Add(pictureBox37);
            kutular.Add(pictureBox36);
            kutular.Add(pictureBox38);
            kutular.Add(pictureBox39);
            kutular.Add(pictureBox40);
            kutular.Add(pictureBox41);
            kutular.Add(pictureBox42);
            kutular.Add(pictureBox43);
            kutular.Add(pictureBox44);
            kutular.Add(pictureBox45);
            kutular.Add(pictureBox46);
            kutular.Add(pictureBox47);
            kutular.Add(pictureBox48);
            kutular.Add(pictureBox49);
            kutular.Add(pictureBox50);
        }

         public void tarama() //Kutuların vurulması
        {
            for (int i = 0; i < kutular.Count; i++)
            {

                if (kutular[i].Bottom >= top.Top && kutular[i].Left<=top.Left && kutular[i].Right >= top.Right && kutular[i].Top < top.Top)//Alttan kareye çarpma
                {
                    kutular[i].Visible = false;
                    kutular[i].Left = 1500;
                    dikyon = false;
                    gidenkutu++;
                    puanhesap();
                    break;
                }

                if (kutular[i].Top <= top.Bottom && kutular[i].Left <= top.Left && kutular[i].Right >= top.Right && kutular[i].Bottom> top.Bottom) //Yukarıdan kareye çarpma
                {
                    kutular[i].Visible = false;
                    kutular[i].Left = 1500;
                    gidenkutu++;
                    dikyon = true;
                    puanhesap();
                    break;
                }

                if(kutular[i].Right >= top.Left && kutular[i].Top <= top.Top && kutular[i].Bottom >=top.Bottom && kutular[i].Left < top.Left) //Soldan kareye çarpma
                {
                    kutular[i].Visible = false;
                    kutular[i].Left = 1500;
                    puanhesap();
                    gidenkutu++;
                   if(yanyon<0)
                    yanyon += -2 * yanyon;
                    else
                        yanyon -= 2 * yanyon;
                    break;
                }
                if (kutular[i].Left <= top.Right && kutular[i].Top <= top.Top && kutular[i].Bottom >= top.Bottom && kutular[i].Right > top.Right) //Sağdan kareye çarpma
                {
                    kutular[i].Visible = false;
                    kutular[i].Left = 1500;
                    puanhesap();
                    gidenkutu++;
                    if (yanyon < 0)
                        yanyon += -2 * yanyon;
                    else
                        yanyon -= 2 * yanyon;
                    break;
                }                    

                if (gidenkutu == kutular.Count) //Kazandı
                    bolum1 = true;
            }
        }

         private void top_Tick(object sender, EventArgs e) //Topun hareketi
        {
            bitis();
            label2.Text = puan.ToString();
            progressBar1.Visible = false;

            if (top.Bottom >= cubuk.Top && top.Left >= cubuk.Left && top.Right <= cubuk.Right && top.Top < cubuk.Top)
            {
                dikyon = true;

                if (cubuk.Right >= top.Right - 7 && top.Right - 7 >= cubuk.Right - 15)
                    yanyon = 9;

                if (cubuk.Right-15 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 30)
                    yanyon = 8;

                if (cubuk.Right - 30 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 45)
                    yanyon = 7;

                if (cubuk.Right - 45 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 60)
                    yanyon = 6;

                if (cubuk.Right - 60 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 75)
                    yanyon = 5;

                if (cubuk.Right - 75 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 90)
                    yanyon = 4;

                if (cubuk.Right - 90 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 105)
                    yanyon = 3;

                if (cubuk.Right - 105 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 120)
                    yanyon = 2;

                if (cubuk.Right - 120 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 133)
                    yanyon = 1;

                if (cubuk.Right - 133 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 137)//ORTA
                    yanyon = 0;

                if (cubuk.Right - 137 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 150)
                    yanyon = -1;

                if (cubuk.Right - 150 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 165)
                    yanyon = -2;

                if (cubuk.Right - 165 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 180)
                    yanyon = -3;

                if (cubuk.Right - 180 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 195)
                    yanyon = -4;

                if (cubuk.Right - 195 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 210)
                    yanyon = -5;

                if (cubuk.Right - 210 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 225)
                    yanyon = -6;

                if (cubuk.Right - 225 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 240)
                    yanyon = -7;

                if (cubuk.Right - 240 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 255)
                    yanyon = -8;

                if (cubuk.Right - 255 > top.Right - 7 && top.Right - 7 >= cubuk.Right - 270)
                    yanyon = -9;
            
            
            
            
            }

            if (dikyon == false) //Yukarı-Aşağı hareket
                 top.Top += duzhiz;
            else
                 top.Top -= duzhiz;

            if (top.Left > 0 && top.Right < 885 && top.Top>0)//Sağa-Sola hareket
                top.Left += yanyon; 

            else if (top.Left <= 1)// Dışarı çıkmaması için
            {
                yanyon += -2 * yanyon;
                top.Left += yanyon;
            }
            else if (top.Right >= 885)
            {
                yanyon -= 2 * yanyon;
                top.Left += yanyon;
            }
            else if (top.Top <= 0)
            {
                dikyon = false;
            }
            
             tarama();
        }

         void puanhesap()
         {
             if (saniye <= 5)
                 puan += 500;
             else if (saniye <= 10)
                 puan += 300;
             else if (saniye <= 20)
                 puan += 250;
             else if (saniye <= 30)
                 puan += 150;
             else if (saniye <= 45)
                 puan += 75;
             else if (saniye <= 55)
                 puan += 25;
             else
                 puan += 5;
         }

         void bitis()
         {
             if (bolum1 == true) //Bölümü kazandı
             {
                 kayit.Start();
                 top.Visible = false;
                 cubuksag.Stop();
                 cubuksola.Stop();
                 toptimer.Stop();
                 zaman.Stop();
             }

             if (top.Bottom > 532 && can!=0) // Bir can kaybetti
             {
                 can--;
                 toptimer.Stop();
                 if(can!=0)
                 tur.Start();
             }
             if (top.Bottom > 532 && can==0) //Yenildi
             {
                 can3.Visible = false;
                 button1.Visible = false;
                 cubuksag.Stop();
                 cubuksola.Stop();
                 toptimer.Stop();
                 zaman.Stop();
                 kayit.Start();
             }
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            puan = 0;
            saniye = 0;
            duzhiz = 5; 
            yanyon = 0; 
            can=3;
            gidenkutu = 0;
            dikyon=false;
            bolum1 = false;
            cubuksag.Stop();
            cubuksola.Stop();
        }

        private void cubuksola_Tick(object sender, EventArgs e)
        {
            if(cubuk.Left>=6)
              cubuk.Left -= 5;
        }

        private void cubuksag_Tick(object sender, EventArgs e)
        {
            if (cubuk.Right <= 893)
            cubuk.Left += 5;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (label3.Visible == false && label4.Visible == false)
                {
                    cubuksola.Start();
                    cubuksag.Stop();
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (label3.Visible == false && label4.Visible==false)
                {
                    cubuksag.Start();
                    cubuksola.Stop();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                cubuksag.Stop();
                cubuksola.Stop();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if(button1.Visible==true)
                basla();
            }
        }

        private void zaman_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
        }

        private void kayit_Tick(object sender, EventArgs e) //Son olaylar
        {
            label3.Visible = true;
            progressBar1.Visible = true;

            if(progressBar1.Value<100)
            progressBar1.Value += 5;

            if (progressBar1.Value == 100)
            {
                skor skorform = new skor();
                skorform.Show();
                this.Hide();
                kayit.Stop();
            }
        }

        private void tur_Tick(object sender, EventArgs e) //Can kaybetme olayları
        {
            progressBar1.Visible = true;
            if (progressBar1.Value < 100)
                progressBar1.Value += 5;

            if (can == 2)
            {
                label4.Text = "2 canınız kaldı";
                can1.Visible = false;
            }
            if (can == 1)
            {
                label4.Text = "1 canınız kaldı";
                can2.Visible = false;
            }
            
            label4.Visible = true;
            top.Visible = false;

            if (progressBar1.Value == 100)
            {
                label4.Visible = false;
                progressBar1.Value = 0;
                top.Visible = true;
                button1.Visible = true;
                top.Left = 428;
                top.Top = 365;
                progressBar1.Visible = false;
                tur.Stop();
            }
        }

        void basla() // Oyuna başlamak için
        {
            yanyon = 0;
            toptimer.Start();
            zaman.Start();
            button1.Visible = false;
            cubuk.Left = 307;
            cubuksag.Stop();
            cubuksola.Stop();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            basla();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
     }
 }

