﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float vize, final, ortalama, hesap;

            vize=Convert.ToInt32(txtVize.Text);
            final=Convert.ToInt32(txtFinal.Text);

            ortalama = (vize * 40 / 100) + (final * 60 / 100);
            lblOrtalama.Text="Ortalama: " + ortalama;

         
        }
    }
}
