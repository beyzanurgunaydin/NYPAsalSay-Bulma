﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            int sayac = 0;
            listBox1.Items.Clear();
            int x = (int)Convert.ToInt64(textBox1.Text);
            if (x < 2)
            {
                MessageBox.Show("Asal Sayı Bulunamadı.");
            }
            else
            {
                for (int i = 2; i <= x; i++)
                {
                    int kontrol = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }

            label2.Text =  sayac + " adet Asal Sayı Bulundu.";
        }
    }
}
