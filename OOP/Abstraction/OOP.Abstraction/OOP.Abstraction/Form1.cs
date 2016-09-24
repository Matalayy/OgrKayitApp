﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            // Cari cari = new Cari();
            CariMusteri musteri = new CariMusteri();
            musteri.CariKodu = "AB342";
            HavaleYap(musteri);

            //

            CariTedarikci tedarikci = new CariTedarikci();
            tedarikci.CariKodu = "bb5448";
            HavaleYap(tedarikci);
        }

        void HavaleYap(Cari c)
        {
            string[] bankalar = c.getBanks();
        }
    }
}
