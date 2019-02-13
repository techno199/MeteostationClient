using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteostationClient
{
    public partial class RegisterForm : Form
    {
        public HttpService _httpService { get; set; } = new HttpService();
        public RegisterForm()
        {
            InitializeComponent();

            labelInfo.Text = "";
        }

        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "Making coffie..";

            try
            {
                var res = await _httpService.SignUpAsync(
                textBoxLogin.Text,
                textBoxPassword.Text
            );
                res.EnsureSuccessStatusCode();
                MessageBox.Show("Successfuly registered. Now you can sign in");
                Close();
            }
            catch
            {
                MessageBox.Show("An error occured while register");
            }
            finally
            {
                labelInfo.Text = "";
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
