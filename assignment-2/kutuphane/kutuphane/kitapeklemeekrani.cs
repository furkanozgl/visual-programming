using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class kitapeklemeekrani : Form
    {
        Form1 anaekran;
        public kitapeklemeekrani(Form1 parametredengelenanaekran)
        {
            InitializeComponent();
            anaekran = parametredengelenanaekran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaekran.kitapEkle(textBox1.Text);
            anaekran.kitapyazariEkle(textBox2.Text);
            anaekran.Show();
        }
        
    }
}
