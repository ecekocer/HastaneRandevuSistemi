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
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
            logLabel.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = ad.Text;
            String lastName = soyad.Text;
            string tcNumber = tcKimlik.Text;
            string profession = uzmanlik.SelectedItem.ToString();

            Doktor newDoctor = new Doktor(firstName, lastName, tcNumber, profession);
            GlobalList.DoktorListesi.Add(newDoctor);

            logLabel.Text = string.Format("Doktor kaydı oluşturuldu: {0} {1} - TC: {2}", firstName, lastName, tcNumber);
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
