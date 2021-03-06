﻿using System;
using System.IO;
using System.Windows.Forms;

namespace timpKR
{
    public partial class Client_information : Form
    {
        public Client_information()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 back = new Form1();
            back.ShowDialog();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] clients = File.ReadAllLines(DataBank.pathC);
                int sch = 0;
                for (int i = 0; i < clients.Length; i += 3)
                {
                    if (clients[i] == textBox1.Text) sch++;
                }
                if (sch == 0) MessageBox.Show(" Совпадений не найдено");
                else
                {
                    int ind = Array.IndexOf(clients, textBox1.Text);
                    string pr1 = clients[ind];
                    string pr2 = clients[ind + 1];
                    string pr3 = clients[ind + 2];
                    MessageBox.Show(" Клиент с номером " + pr1 + ". \n ФИО - " + pr2 + ". \n Пользовался прокатом - " + pr3 + " р.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Список отсутствует!");
            }
        }
    }
}
