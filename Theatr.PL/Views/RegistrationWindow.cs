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
    public partial class RegistrationWindow : Form
    {
        private RegistrationController registrationController;

        public RegistrationWindow()
        {
            IKernel kernel = Program.Kernel;
            var registrationService = kernel.Get<IRegistrationService>();
            registrationController = new RegistrationController(registrationService);
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string NameInForm = this.textBox1.Text;
            string LastnameInForm = this.textBox2.Text;
            string EmailInForm = this.textBox3.Text;
            string PasswordInForm = this.textBox4.Text;

            UserViewModel newUser = new UserViewModel
            {
                Name = NameInForm,
                Surname = LastnameInForm,
                Email = EmailInForm,
                Password = PasswordInForm
            };
            string result = registrationController.Register(newUser);
            MessageBox.Show(result, "Registration result");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
