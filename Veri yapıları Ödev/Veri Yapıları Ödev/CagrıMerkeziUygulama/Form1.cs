﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagrıMerkeziProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CagriMerkezi.GetInstance().AramaYap(new Musteri("Haşim","Sazlıogulları", IslemTuru.Ticari));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
