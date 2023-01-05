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
    public partial class BuyTicketWindow : Form
    {
        private PerformanceViewModel performance;
        private static ProfileController profileController;
        private static readonly PerformanceController _performanceController;
        private static readonly ProfileController _userController;
        private UserViewModel user;
        static BuyTicketWindow()
        {
            IKernel kernel = Program.Kernel;
            var performanceManagerService = kernel.Get<IManagePerfomanceService>();
            var userManagerService = kernel.Get<IAuthorizationService>();
            var profileService = kernel.Get<IAuthorizationService>();
            profileController = new ProfileController(profileService);
            _performanceController = new PerformanceController(performanceManagerService);
            _userController = new ProfileController(userManagerService);
        }
        public BuyTicketWindow(UserViewModel user, PerformanceViewModel performanceModel)
        {
            performance = performanceModel;
            InitializeComponent();
            this.user = profileController.GetUser(user);
            LoadData();
            //UpdateVisualData();
        }
        private void LoadData()
        {
            var genres = performance.Genres.ToList();
            foreach (var genre in genres)
            {
                this.genreListBox.Items.Add(genre.Name);
            }
            var authors = performance.Authors.ToList();
            foreach (var author in authors)
            {
                authorsListBox.Items.Add(author.Name);
            }
            performanceNameInWindow.Text = performance.Name;
            yourName.Text = user.Name;
            yourLastname.Text = user.Surname;
            var tickets = performance.Tickets.ToList();
            var countOfGoodTickets = 0;
            foreach (var i in tickets)
            {
                if (i.TicketState == "Can be sold")
                {
                    countOfGoodTickets += 1;
                }
            }
            if (countOfGoodTickets == 0)
            {
                MessageBox.Show("No tickets(", "Error");
                Close();
                var performancesListWindow = new PerformancesListWindow(user);
                performancesListWindow.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ticCat = ticketCategory.SelectedItem.ToString();
            var tickets = performance.Tickets.ToList();
            var countOfTicCat = 0;
            float price = 0;
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.TicketCategory + " " + ticket.Price);
                if ((ticket.TicketCategory == ticCat) && (ticket.TicketState == "Can be sold"))
                {
                    countOfTicCat += 1;
                    price = ticket.Price;
                }
            }
            if (countOfTicCat == 0)
            {
                MessageBox.Show("No tickets with this category", "Error");
            }
            else
            {
                MessageBox.Show("We have " + countOfTicCat + " tickets with this category \n Price: " + price , "YEAH");
            }
            
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            var ticCat = ticketCategory.SelectedItem.ToString();
            var tickets = performance.Tickets.ToList();
            var state = false;
            foreach(var ticket in tickets.Where(a => a.TicketCategory.Equals(ticCat)))
            {
                if(ticket.TicketState == "Can be sold")
                {
                    ticket.TicketState = "Sold";
                    ticket.UserId = user.Id;
                    _performanceController.SellTicket(ticket, user);
                    state = true;
                    break;
                }
            }
            if (state)
            {
                MessageBox.Show("You buy ticket");
            }
            else
            {
                MessageBox.Show("No tickets with such category");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ticCat = ticketCategory.SelectedItem.ToString();
            var tickets = performance.Tickets.ToList();
            var state = false;
            foreach (var ticket in tickets.Where(a => a.TicketCategory.Equals(ticCat)))
            {
                if (ticket.TicketState == "Can be sold")
                {
                    ticket.TicketState = "Brone";
                    ticket.UserId = user.Id;
                    _performanceController.SellTicket(ticket, user);
                    state = true;
                    break;
                }
            }
            if (state)
            {
                MessageBox.Show("You brone ticket");
            }
            else
            {
                MessageBox.Show("No tickets with such category");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var performanceListWindow = new PerformancesListWindow(user);
            performanceListWindow.Show();
        }

    }
}
