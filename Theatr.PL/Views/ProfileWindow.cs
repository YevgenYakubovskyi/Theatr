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
    public partial class ProfileWindow : Form
    {
        private ProfileController profileController;
        private UserViewModel result;

        public ProfileWindow(UserViewModel currentUser)
        {
            IKernel kernel = Program.Kernel;
            var profileService = kernel.Get<IAuthorizationService>();
            profileController = new ProfileController(profileService);
            InitializeComponent();
            result = profileController.GetUser(currentUser);
            label8.Text = result.Email;
            label7.Text = result.Surname;
            label6.Text = result.Name;

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            var ticketWindow = new TicketWindow(result);
            ticketWindow.Show();
        }


    }
}
