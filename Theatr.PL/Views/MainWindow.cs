﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theatr.PL.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var registerWindow = new RegistrationWindow();
            registerWindow.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void autorizationButton_Click(object sender, EventArgs e)
        {
            Hide();
            var autorizationWindow = new AutorizationWindow();
            autorizationWindow.Show();
        }
    }
}
