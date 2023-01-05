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
    public partial class TicketWindow : Form
    {
        private ProfileController profileController;
        private static PerformanceController _performanceController;
        private string selectedItem;

        private UserViewModel result;
        private bool state = false;

        public TicketWindow(UserViewModel currentUser)
        {
            IKernel kernel = Program.Kernel;
            var profileService = kernel.Get<IAuthorizationService>();
            profileController = new ProfileController(profileService);
            var performanceService = kernel.Get<IManagePerfomanceService>();
            _performanceController = new PerformanceController(performanceService);
            InitializeComponent();
            result = profileController.GetUser(currentUser);
            List<TicketViewModel> tickets = (List<TicketViewModel>)profileController.GetTicketsByUserId(result.Id);
            this.newsList.Items.Clear();
            foreach (var ticket in tickets)
            {

                ListViewItem listItem = new ListViewItem();
                if (ticket.UserId == result.Id)
                {
                    var performance = _performanceController.GetPerformanceById(ticket.PerfomanceId);
                    listItem.Text = ticket.Id.ToString();
                    listItem.SubItems.Add(performance.Name.ToString());
                    listItem.SubItems.Add(performance.Date.ToString());
                    listItem.SubItems.Add(ticket.TicketCategory);
                    listItem.SubItems.Add(ticket.TicketState);
                }
                this.newsList.Items.Add(listItem);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Close();
            var profileWindow = new ProfileWindow(result);
            profileWindow.Show();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //Performance list
            Close();
            var performanceListWindow = new PerformancesListWindow(result);
            performanceListWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<TicketViewModel> tickets = (List<TicketViewModel>)profileController.GetTicketsByUserId(result.Id);

            var ticId = int.Parse(selectedItem);
            foreach (var ticket in tickets.Where(a => a.Id.Equals(ticId)))
            {
                if (ticket.TicketState == "Brone")
                {
                    ticket.TicketState = "Sold";
                    ticket.UserId = result.Id;
                    _performanceController.SellTicket(ticket, result);
                    state = true;
                    break;
                }
            }
            if (state)
            {
                MessageBox.Show("You buy ticket. \nGo to another page to update");
            }
            else
            {
                MessageBox.Show("No tickets with such category");
            }
        }

        private void newsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < newsList.SelectedItems.Count; i++)
            {
                selectedItem = newsList.SelectedItems[i].SubItems[0].Text;
                state = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
