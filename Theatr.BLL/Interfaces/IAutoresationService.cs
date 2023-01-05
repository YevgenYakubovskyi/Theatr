using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.BLL.DTO;

namespace Theatr.BLL.Interfaces
{
    public interface IAuthorizationService
    {
        UserDTO FindUser(string email);
        TicketDTO FindTicket(int id);
        IEnumerable<TicketDTO> GetAllTickets();
        IEnumerable<UserDTO> GetAllUsers();
        IEnumerable<TicketDTO> GetTicketsByUserId(int userId);
        UserDTO Login(string email, string password);
        void BuyOrBroneTicket(int ticketId, int userId, string state);
    }
}
