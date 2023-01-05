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
using Theatr.PL.Views;
using Theatr.PL.Controllers;
using Ninject;
using Theatr.BLL.Interfaces;

namespace Theatr.PL.Views
{
    public partial class PerformancesListWindow : Form
    {
        private string selectedItem;
        private ProfileController profileController;
        private static PerformanceController _performanceController;
        private IEnumerable<PerformanceViewModel> _performances;

        private UserViewModel result;
        public PerformancesListWindow(UserViewModel currentUser)
        {
            IKernel kernel = Program.Kernel;
            var profileService = kernel.Get<IAuthorizationService>();
            profileController = new ProfileController(profileService);
            var performanceService = kernel.Get<IManagePerfomanceService>();
            _performanceController = new PerformanceController(performanceService);
            InitializeComponent();
            result = profileController.GetUser(currentUser);
            ShowPerformances();

        }
        private void ShowPerformances()
        {

            List<PerformanceViewModel> performances = (List<PerformanceViewModel>)_performanceController.GetPerformance();
            this.newsList.Items.Clear();
            Help(performances);
        }




        private void searchButton_Click(object sender, EventArgs e)
        {
            var choise = findComboBox.SelectedIndex;
            switch (findComboBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("You didn`t select anything", "Error");
                    break;
                case 0:
                    newsList.Items.Clear();
                    var performanceByName = _performanceController.GetPerformencesByName(inputBox.Text);
                    Help(performanceByName);
                    break;
                case 1:
                    newsList.Items.Clear();
                    try
                    {
                        var performanceByAuthor = _performanceController.GetPerformencesByAuthor(inputBox.Text);
                        if (performanceByAuthor != null) Help(performanceByAuthor);
                    }
                    catch
                    {
                        newsList.Items.Clear();
                    }

                    break;
                case 2:
                    newsList.Items.Clear();
                    try
                    {
                        var performanceByGenre = _performanceController.GetPerformencesByGenre(inputBox.Text);
                        if (performanceByGenre != null) Help(performanceByGenre);
                    }
                    catch
                    {
                        newsList.Items.Clear();
                    }
                    break;
                case 3:
                    newsList.Items.Clear();
                    var performanceByDate = _performanceController.GetPerformancesByTime(dateTimeStart.Value.ToString(), dateTimeEnd.Value.ToString());
                    if (performanceByDate != null) Help(performanceByDate);
                    break;
            }

        }

        public void Help(IEnumerable<PerformanceViewModel> performances) 
        {
            foreach (var performance in performances)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = performance.Name;
                string authors = "";
                string genres = "";
                performance.Authors.ToList().ForEach(author => authors += $"{author.Name}; ");
                performance.Genres.ToList().ForEach(genre => genres += $"{genre.Name}; ");

                listItem.SubItems.Add(performance.Date.ToString());
                listItem.SubItems.Add(authors);
                listItem.SubItems.Add(genres);

                this.newsList.Items.Add(listItem);
            }

        }
        

        private void findComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.findComboBox.SelectedItem.Equals("Date"))
            {
                this.dateTimeStart.Enabled = true;
                this.dateTimeEnd.Enabled = true;
            }
            else
            {
                this.dateTimeStart.Enabled = false;
                this.dateTimeEnd.Enabled = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.inputBox.Clear();
            ShowPerformances();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Performance list
            Close();
            var ticketsWindow = new TicketWindow(result);
            ticketsWindow.Show();
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            
            for (var i = 0; i < newsList.SelectedItems.Count; i++)
            {
                selectedItem = newsList.SelectedItems[i].SubItems[0].Text;
            }
        }

        private void autorizationButton_Click(object sender, EventArgs e)
        {
            if(selectedItem == null)
            {
                MessageBox.Show("You don't select performance","Error");
                return;
            }

            var performance = _performanceController.LoadPerf(selectedItem);

            Close();
            try
            {
                var buyTicketWindow = new BuyTicketWindow(result, performance);
                buyTicketWindow.Show();
            }
            catch { return; }

        }
    }
}
