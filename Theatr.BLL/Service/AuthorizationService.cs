using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.BLL.DTO;
using Theatr.BLL.Infrastructure;
using Theatr.BLL.Interfaces;
using Theatr.DAL.Entities;
using Theatr.DAL.EF;
using Theatr.DAL.Interfaces;
using Theatr.DAL.Repositories;

namespace Theatr.BLL.Service
{
    class AuthorizationService : IAuthorizationService
    {
        private EFUnitOfWork UnitOfWork;

        public AuthorizationService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public UserDTO FindUser(string email)
        {
            var usersDal = UnitOfWork.Users.Find(ex => ex.Email.Equals(email));
            var usersDTO = usersDal.Select(a => new UserDTO
            {
                Id = a.Id,
                Email = a.Email,
                Password = a.Password,
                Name = a.Name,
                Surname = a.Surname,
                Tickets = a.Tickets.Select(b => new TicketDTO
                {
                    Id = b.Id,
                    PerfomanceId = b.PerfomanceId,
                    TicketState = b.TicketState,
                    Price = b.Price,
                    TicketCategory = b.TicketCategory,
                    UserId = b.UserId
                })
            }).ToList();
            if (usersDTO.Count == 0)
                throw new ValidationException("There is no such User", "");

            UserDTO userDTO = usersDTO[0];
            return userDTO;
        }
        public TicketDTO FindTicket(int id)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<Performance, PerformanceDTO>()).CreateMapper();
            if (id < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var ticket = UnitOfWork.Tickets.Get(id);
            if (ticket == null)
                throw new ValidationException("Ticket not found", "");
            return new TicketDTO
            {
                Id = ticket.Id,
                Price = ticket.Price,
                TicketState = ticket.TicketState,
                TicketCategory = ticket.TicketCategory,
                Perfomance = mapper.Map<Performance, PerformanceDTO>(UnitOfWork.Perfomances.Get(ticket.PerfomanceId)),
                User = mapper.Map<User, UserDTO>(UnitOfWork.Users.Get(ticket.UserId))
            };
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(UnitOfWork.Users.GetAll());
        }
        public IEnumerable<TicketDTO> GetAllTickets()
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<Ticket, TicketDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Ticket>, List<TicketDTO>>(UnitOfWork.Tickets.GetAll());
        }

        public UserDTO Login(string email, string password)
        {
            var usersDal = UnitOfWork.Users.Find(ex => ex.Email.Equals(email));
            var usersDTO = usersDal.Select(a => new UserDTO
            {
                Id = a.Id,
                Email = a.Email,
                Password = a.Password
            }).ToList();
            if (usersDTO.Count == 0)
                throw new ValidationException("There is no such User", "");

            UserDTO userDTO = usersDTO[0];

            if (userDTO.Password.Equals(password))
            {
                return userDTO;
            }
            else
            {
                throw new ValidationException("Password is wrong", "");
            }
        }
        public void BuyOrBroneTicket(int ticketId, int userId, string state)
        {
            var ticketDal = UnitOfWork.Tickets.Get(ticketId);
            ticketDal.User = UnitOfWork.Users.Get(userId);
            ticketDal.TicketState = state;
            var userDal = UnitOfWork.Users.Get(userId);
            UnitOfWork.Tickets.Update(ticketDal);
            UnitOfWork.Users.Update(userDal);
            UnitOfWork.Save();
        }

        public IEnumerable<TicketDTO> GetTicketsByUserId(int userId)
        {
            var ticketsDal = UnitOfWork.Tickets.Find(ex => ex.UserId.Equals(userId));
            var ticketsDTO = ticketsDal.Select(a => new TicketDTO
            {
                Id = a.Id,
                UserId = a.UserId,
                Price = a.Price,
                PerfomanceId = a.PerfomanceId,
                TicketCategory = a.TicketCategory,
                TicketState = a.TicketState
            }).ToList();
            if (ticketsDTO.Count == 0)
                throw new ValidationException("You don't have a ticket", "");
            return ticketsDTO;
        }
    }
}
