using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteostationClient
{
    public partial class AuthForm : Form
    {
        public HttpService _httpService = new HttpService();
       
        public AuthForm()
        {
            InitializeComponent();
            labelInfo.Text = "";
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                labelInfo.Text = "Logging in..";
                var res = await _httpService.SignInAsync(textBoxLogin.Text, textBoxPassword.Text);
                res.EnsureSuccessStatusCode();
                labelInfo.Text = "";
                var mainForm = new StatisticsForm();
                Hide();
                mainForm.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                labelInfo.Text = $"An error occured while logging";
            }

            
    }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            Hide();
            registerForm.ShowDialog();
            Show();
        }
    }
}
