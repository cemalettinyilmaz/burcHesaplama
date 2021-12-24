using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burcuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
             
          
            DateTime dogumtarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
            TimeSpan fark = DateTime.Now.Date.Subtract(dogumtarihi);
            int yas = Convert.ToInt32(fark.TotalDays);
            lblYasadiginizGun.Text = yas.ToString();
            lblYasiniz.Text = (yas / 365).ToString();

            int ay = Convert.ToInt32(dtpDogumTarihi.Value.Month);
            int gun = Convert.ToInt32(dtpDogumTarihi.Value.Day);

            if ((ay == 12 && gun >= 21) || (ay == 1 && gun <= 19))
                lblBurcunuz.Text = "Oğlak";
            if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 19))
                lblBurcunuz.Text = "Kova";
            if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
                lblBurcunuz.Text = "Balık";
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                lblBurcunuz.Text = "Koç";
            if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 20))
                lblBurcunuz.Text = "Boğa";
            if ((ay == 5 && gun >= 21) || (ay == 6 && gun <= 21))
                lblBurcunuz.Text = "İkizler";
            if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
                lblBurcunuz.Text = "yengec";
            if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 23))
                lblBurcunuz.Text = "Aslan";
            if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 23))
                lblBurcunuz.Text = "Başak";
            if ((ay == 9 && gun >= 24) || (ay == 10 && gun <= 22))
                lblBurcunuz.Text = "Terazi";
            if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 22))
                lblBurcunuz.Text = "Akrep";
            if ((ay == 11 && gun >= 23) || (ay == 12 && gun <= 20))
                lblBurcunuz.Text = "Yay";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
