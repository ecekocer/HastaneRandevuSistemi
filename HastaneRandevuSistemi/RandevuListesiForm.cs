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
    public partial class RandevuListesiForm : Form
    {
        public RandevuListesiForm()
        {
            InitializeComponent();
            comboBox1.DataSource = GlobalList.RandevuListesi;
            logLabel.Text = "";
        }

        private void RandevuListesiForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevu selectedAppointment = comboBox1.SelectedItem as Randevu;
            if (selectedAppointment != null)
            {
                GlobalList.RandevuListesi.Remove(selectedAppointment);
                logLabel.Text = "Randevu iptal edildi.";
                comboBox1.DataSource = GlobalList.RandevuListesi;
            }
        }
    }
}
