using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yon3Odev
{

    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
       
        }


        private void hspl_btn_Click(object sender, EventArgs e)
        {
            if (x1_txtbx.Text == "" || x2_txtbx.Text == "")
            {
                uyari_lbl.Text = "Lütfen Geçerli Bir Sayı Giriniz.Boş Bırakmayınız.";
            }
            else
            {
                int a = Convert.ToInt32(x1_txtbx.Text);
                int b = Convert.ToInt32(x2_txtbx.Text);

                if (a < -3 || a > 3 || b < -2 || b > 2)
                {

                   uyari_lbl.Text = "Lütfen Girdiğiniz Değerleri Kontrol Ediniz.";
                   
                }
                else
                {
                    //int d = Convert.ToInt32(x1_txtbx.Text);
                    //int c = Convert.ToInt32(x2_txtbx.Text);
                    int toplam = 0;
                    toplam = ((4 - 2 * (a * a) + ((a * a * a * a) / 3)) * (a * a)) + (a * b) + (-4 + (4 * (b * b)) * (b * b));
                    snc_lbl.Text = toplam.ToString();
                }
            }

            panel1.Show();
        }

        private void x1_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tmz_bttn_Click(object sender, EventArgs e)
        {
            uyari_lbl.Text = " ";
            snc_lbl.Text = " ";
            x1_txtbx.Text = " ";
            x2_txtbx.Text = " ";
        }
    }
    }

