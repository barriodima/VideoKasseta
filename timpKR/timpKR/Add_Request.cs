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
    public partial class Add_Request : Form
    {
        public Add_Request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Введите название кассеты, которое нужно удалить из списка");
                Hide();
                List_of_requests go = new List_of_requests();
                go.ShowDialog();
                Close();
            }
            using (StreamWriter stream = new StreamWriter(DataBank.pathLOR, true))
            {
                stream.WriteLine(textBox1.Text);
            }
            Hide();
            List_of_requests back = new List_of_requests();
            back.ShowDialog();
            Close();
        }
    }
}
