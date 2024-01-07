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
    public partial class HastaForm : Form
    {
        public HastaForm()
        {
            InitializeComponent();
            logLabel.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HastaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = ad.Text;
            String lastName = soyad.Text;
            string tcNumber = tcKimlik.Text;

            Hasta newPatient = new Hasta(firstName, lastName, tcNumber);
            GlobalList.HastaListesi.Add(newPatient);

            logLabel.Text = string.Format("Hasta kaydı oluşturuldu: {0} {1} - TC: {2}", firstName, lastName, tcNumber);


        }
    }
}
