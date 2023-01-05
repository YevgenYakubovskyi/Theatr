using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theatr.PL.Models;
using Theatr.PL.Controllers;
using Ninject;
using Theatr.BLL.Interfaces;

namespace Theatr.PL.Views
{
    public partial class AutorizationWindow : Form
    {
        private AutorizationController autorizationController;


        public AutorizationWindow()
        {
            IKernel kernel = Program.Kernel;
            var autorizationService = kernel.Get<IAuthorizationService>();
            autorizationController = new AutorizationController(autorizationService);
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void autorizationButton_Click(object sender, EventArgs e)
        {
            string EmailInForm = this.textBox3.Text;
            string PasswordInForm = this.textBox4.Text;

            UserViewModel currentUser = new UserViewModel
            {
                Email = EmailInForm,
                Password = PasswordInForm
            };
            string result = autorizationController.Login(currentUser);
            if (!result.Equals("Password is wrong") && !result.Equals("Hello, admin") && !result.Equals("There is no such User"))
            {
                Hide();
                var profileWindow = new ProfileWindow(currentUser);
                profileWindow.Show();
            }
            else
            {
                MessageBox.Show(result, "Result");
            }
        }
    }
}
