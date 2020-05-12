﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timpKR
{
    public partial class CheckExist : Form
    {
        public CheckExist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] readText = File.ReadAllLines(DataBank.pathK);
                int sch = 0;
                for (int i = 0; i < readText.Length; i += 3)
                {
                    if (readText[i] == textBox1.Text) sch++;
                }
                if (sch == 0) MessageBox.Show(" Совпадений не найдено");
                else
                {
                    int ind = Array.IndexOf(readText, textBox1.Text);
                    string pr1 = readText[ind + 2];
                    string pr2 = readText[ind + 1];
                    MessageBox.Show(" Есть в наличии " + pr1 + " шт. по тарифу " + pr2 + " р. в сутки ");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Каталог отсутствует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 back = new Form1();
            back.ShowDialog();
            Close();
        }
    }
}
