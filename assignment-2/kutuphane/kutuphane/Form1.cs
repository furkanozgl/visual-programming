using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapeklemeekrani kitapEKLEMEEKRANİ =new kitapeklemeekrani(this);
            kitapEKLEMEEKRANİ.Show();
        }
        public void kitapEkle(string kitapadi)
        {
            listBox1.Items.Add(kitapadi);
           
        }
        public void kitapyazariEkle(string kitapyazari)
        {
            listBox1.Items.Add(kitapyazari);

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);//seçilen satırı silme(remove metodu int değer alır index değerini siler)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
