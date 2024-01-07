using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();

            logLabel.Text = "";
            comboBox1.DataSource = GlobalList.HastaListesi;
            comboBox2.DataSource = GlobalList.DoktorListesi;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta selectedPatient = comboBox1.SelectedItem as Hasta;
            Doktor selectedDoctor = comboBox2.SelectedItem as Doktor;
            DateTime date = tarih.Value.Date;
            String time = saat.Text;

            Randevu newAppointment = new Randevu(date, time, selectedDoctor, selectedPatient);
            GlobalList.RandevuListesi.Add(newAppointment);
            logLabel.Text = "Randevu oluşturuldu..";
        }

        private void logLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
