﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWindowsApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2460/api/Users/GetUser");
            HttpResponseMessage response = client.GetAsync("api/Users/GetUser").Result;
            if (response.IsSuccessStatusCode)
            {
                this.Hide();

                Dashboard dashbard = new Dashboard();
                dashbard.Show();
            }
        }
    }
}
