using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.BLL.DTO;
using Theatr.BLL.Infrastructure;
using Theatr.BLL.Interfaces;
using Theatr.PL.Models;

namespace Theatr.PL.Controllers
{
    public class ProfileController
    {
        private readonly IAuthorizationService _service;
        public ProfileController(IAuthorizationService service)
        {
            _service = service;
        }

        public UserViewModel GetUser(UserViewModel user)
        {
            UserDTO currentUser = _service.FindUser(user.Email);
            return new UserViewModel
            {
                Id = currentUser.Id,
                Name = currentUser.Name,
                Email = currentUser.Email,
                Surname = currentUser.Surname,
                Password = currentUser.Password
            };
        }

        public IEnumerable<TicketViewModel> GetTicketsByUserId(int id)
        {
            var tickets = _service.GetTicketsByUserId(id);
            return convertTickets(tickets).ToList();
        }
        private IEnumerable<TicketViewModel> convertTickets(IEnumerable<TicketDTO> ticketDTO)
        {
            return ticketDTO.Select(ticket => new TicketViewModel()
            {
                Id = ticket.Id,
                PerfomanceId = ticket.PerfomanceId,
                TicketState = ticket.TicketState,
                TicketCategory = ticket.TicketCategory,
                Price = ticket.Price,
                UserId = ticket.UserId
            });
        }
    }
}