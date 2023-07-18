using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        int gspuan = 0, fbpuan = 0, tspuan = 0, bjkpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayac++;
            
            if (sayac == 1)
            {
                int fbgol=rastgele.Next(0,6), gsgol= rastgele.Next(0, 6), bjkgol= rastgele.Next(0, 6), tsgol= rastgele.Next(0, 6);
                
                label1.Text = "1. Hafta Macları";
                label2.Text = "Fenerbahçe";
                label3.Text = "Beşiktaş";
                label4.Text = "Galatasaray";
                label5.Text = "Trabzonspor";

                label8.Text = fbgol.ToString();
                label10.Text = bjkgol.ToString();
                label9.Text=gsgol.ToString  ();
                label11.Text=tsgol.ToString ();

                if (fbgol > bjkgol)
                {
                    fbpuan += 3;
                    label_fbpuan.Text = fbpuan.ToString();
                }
                else if (bjkgol > fbgol)
                {
                    bjkpuan += 3;
                    label_bjkpuan.Text=bjkpuan.ToString();
                }
                else
                {
                    fbpuan++;
                    bjkpuan++;
                    label_fbpuan.Text = fbpuan.ToString();
                    label_bjkpuan.Text = bjkpuan.ToString();

                }

                if (gsgol > tsgol)
                {
                    gspuan += 3;
                    label_gspuan.Text =(gspuan.ToString());

                }
                else if (tsgol > gsgol)
                {
                    tspuan += 3;
                    label_tspuan.Text=tspuan.ToString();
                }
                else
                {
                    tspuan++;
                 
                    gspuan++;
                    label_gspuan.Text = (gspuan.ToString());
                    label_tspuan.Text = tspuan.ToString();
                }


            }

            if (sayac == 2)
            {
                int fbgol = rastgele.Next(0, 6), gsgol = rastgele.Next(0, 6), bjkgol = rastgele.Next(0, 6), tsgol = rastgele.Next(0, 6);
                
                //ts-fb
                //gs-bjk
                label1.Text = "2. Hafta Macları";
                label2.Text = "Trabzonspor";
                label3.Text = "Fenerbahçe";
                label4.Text = "Galatasaray";
                label5.Text = "Beşiktaş";

                label8.Text = tsgol.ToString();
                label10.Text = fbgol.ToString();
                label9.Text = gsgol.ToString();
                label11.Text=bjkgol.ToString ();

                if (tsgol > fbgol)
                {
                    tspuan += 3;
                    label_tspuan.Text = tspuan.ToString();
                }
                else if (fbgol > tsgol)
                {

                    fbpuan+=3;
                    label_fbpuan.Text = fbpuan.ToString();

                }
                else
                {
                    fbpuan++;
                    tspuan++;
                    label_fbpuan.Text = fbpuan.ToString();
                    label_tspuan.Text=tspuan.ToString();

                }

                if (gsgol > bjkgol)
                {

                    gspuan += 3;
                    label_gspuan.Text = gspuan.ToString();

                }
                else if (bjkgol > gsgol)
                {
                    bjkpuan+=3;
                    label_bjkpuan.Text = bjkpuan.ToString();

                }
                else
                {
                    bjkpuan++;
                    gspuan++;
                    label_bjkpuan.Text = bjkpuan.ToString();
                    label_gspuan.Text = gspuan.ToString();

                }
                
            }

            if (sayac == 3)
            {
                label1.Text = "3. Hafta Maçları";
                int fbgol = rastgele.Next(0, 6), gsgol = rastgele.Next(0, 6), bjkgol = rastgele.Next(0, 6), tsgol = rastgele.Next(0, 6);

                //fb-gs
                //bjk-ts

                label2.Text = "Fenerbahçe";
                label3.Text = "Galatasaray";
                label4.Text = "Beşiktaş";
                label5.Text = "Trabzonspor";

                label8.Text = fbgol.ToString();
                label10.Text = gsgol.ToString();
                label9.Text = bjkgol.ToString();
                label11.Text = tsgol.ToString();

                if (fbgol > gsgol)
                {
                    fbpuan += 3;
                    label_fbpuan.Text = fbpuan.ToString();

                }
                else if (gsgol > fbgol)
                {

                    gspuan += 3;
                    label_gspuan.Text = gspuan.ToString();

                }
                else
                {
                    gspuan++;
                    fbpuan++;
                    label_gspuan.Text=gspuan.ToString();
                    label_fbpuan.Text=fbpuan.ToString();

                }


                if (bjkgol > tsgol)
                {

                    bjkpuan += 3;
                    label_bjkpuan.Text = bjkpuan.ToString();

                }
                else if (tsgol > bjkgol)
                {
                    tspuan += 3;
                    label_tspuan.Text = tspuan.ToString();

                }
                else
                {
                    tspuan++;
                    bjkpuan++;
                    label_tspuan.Text=tspuan.ToString();
                    label_bjkpuan.Text = bjkpuan.ToString();

                }

                if (fbpuan > gspuan && fbpuan > bjkpuan && fbpuan > tspuan)
                {
                    label13.Text = "ŞAMPİYON FENERBAHÇE";
                    pictureBox1.ImageLocation = @"C:\Users\Azat\Desktop\takım resimleri\fb.jpg";

                }
                else if (gspuan > fbpuan && gspuan > bjkpuan && gspuan > tspuan)
                {
                    label13.Text = "ŞAMPİYON GALATASARAY";
                    pictureBox1.ImageLocation = @"C:\Users\Azat\Desktop\takım resimleri\gs.jpg";

                }
                else if (bjkpuan > gspuan && bjkpuan > fbpuan && bjkpuan > tspuan)
                {
                    label13.Text = "ŞAMPİYON BEŞİKTAŞ";
                    pictureBox1.ImageLocation = @"C:\Users\Azat\Desktop\takım resimleri\bjk.jpg";
                }
                else if (tspuan > fbpuan && tspuan > gspuan && tspuan > bjkpuan)
                {
                    label13.Text = "ŞAMPİYON TRABZONSPOR";
                    pictureBox1.ImageLocation = @"C:\Users\Azat\Desktop\takım resimleri\ts.jpg";

                }
                button1.Text = "Lig Bitti";
                button1.Enabled = false;



            }
            
               
            

        }
    }
}
