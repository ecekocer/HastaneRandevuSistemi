﻿using System;
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
    public partial class HastaneSistemiForm : Form
    {
        public HastaneSistemiForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaForm newForm = new HastaForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DoktorForm newForm = new DoktorForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuForm newForm = new RandevuForm();
            newForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuListesiForm newForm = new RandevuListesiForm();
            newForm.Show();
        }
    }
}
