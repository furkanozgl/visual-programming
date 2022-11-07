using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final;
            double sonuc;

            try
            {
                vize = Convert.ToInt32(numericUpDown1.Value);
                //vize notu
                final = Convert.ToInt32(numericUpDown2.Value);
                //final notu
                sonuc = vize * 0.4 + final * 0.6;
                label3.Text = sonuc.ToString();
                
                

                    //puana göre durumu göstermek için
                    if (sonuc < 50 || final <50)
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "KALDINIZ";
                    }
                    else
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "GEÇTİNİZ";
                    }

                    if (0 < sonuc && sonuc <= 39)
                    {
                        label4.Text = "FF";
                    }
                    if (39 < sonuc && sonuc <= 49)
                    {
                        label4.Text = "FD";
                    }
                    if (49 < sonuc && sonuc <= 56)
                    {
                        label4.Text = "DD";
                    }
                    if (56 < sonuc && sonuc <= 63)
                    {
                        label4.Text = "DC";
                    }
                    if (63 < sonuc && sonuc <= 70)
                    {
                        label4.Text = "CC";
                    }
                    if (70 < sonuc && sonuc <= 77)
                    {
                        label4.Text = "CB";
                    }
                    if (77 < sonuc && sonuc <= 84)
                    {
                        label4.Text = "BB";
                    }
                    if (84 < sonuc && sonuc <= 90)
                    {
                        label4.Text = "BA";
                    }
                    if (90 < sonuc && sonuc <= 100)
                    {
                        label4.Text = "AA";
                    }
                
                    label3.Visible=true;
                    label4.Visible=true;
                    label5.Visible=true;
                
            }
            catch(Exception ex)
            {

            }

        }
    }
}
