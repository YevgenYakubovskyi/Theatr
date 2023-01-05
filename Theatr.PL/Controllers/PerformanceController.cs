
using AutoMapper;
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
    public class PerformanceController
    {

        private readonly IManagePerfomanceService _service;
        public PerformanceController(IManagePerfomanceService service)
        {
            _service = service;
        }
        public IEnumerable<PerformanceViewModel> GetPerformencesByGenre(string genre)
        {
            try
            {
                return convertPerformences(_service.FindByGenreName(genre));
            }
            catch(ValidationException ex)
            {
                ExceptionMy(ex.Message);
                return null;
            }
        }



        
        public IEnumerable<PerformanceViewModel> GetPerformance()
        {
            var performances = _service.GetAll();
            return convertPerformences(performances).ToList();
        }
        public IEnumerable<GenreViewModel> LoadGenre(string performance)
        {
            
            var genresDTO = _service.GetGenreOfPerformance(performance);
            var genres = genresDTO.Select(a => new GenreViewModel()
            {
                Id = a.Id,
                Name = a.Name
            });
            return genres;
        }
        public PerformanceViewModel LoadPerf(string name)
        {

            var performanceDTO = _service.FindByName(name);
            return performanceDTO.Select(a => new PerformanceViewModel()
            {
                Id = a.Id,
                Name = a.Name,
                Date = a.Date,
                Authors = new List<AuthorViewModel>(a.Authors.Select(b =>
                new AuthorViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                })),
                Genres = new List<GenreViewModel>(a.Genres.Select(b =>
                new GenreViewModel()
                {
                    Id = b.Id,
                    Name = b.Name
                })),
                Tickets = new List<TicketViewModel>(a.Tickets.Select(b =>
                new TicketViewModel()
                {
                    Id = b.Id,
                    Price = b.Price,
                    TicketCategory = b.TicketCategory,
                    TicketState = b.TicketState
                }))

            }).First();
        }
        public IEnumerable<PerformanceViewModel> GetPerformancesByTime(string date1, string date2)
        {
            var start = DateTime.Parse(date1);
            var end = DateTime.Parse(date2);
            return convertPerformences(_service.FindByTime(start, end));
        }
        public IEnumerable<PerformanceViewModel> convertPerformences(IEnumerable<PerformanceDTO> performanceDTO)
        {
            return performanceDTO.Select(performance => new PerformanceViewModel()
            {
                Id = performance.Id,
                Date = performance.Date,
                Name = performance.Name,
                Authors = new List<AuthorViewModel>(performance.Authors.Select(a =>
                new AuthorViewModel()
                {
                    Id = a.Id,
                    Name = a.Name
                })),
                Genres = new List<GenreViewModel>(performance.Genres.Select(a =>
                new GenreViewModel() { 
                    Id = a.Id, Name = a.Name 
                    }))
            });
        }

        public PerformanceViewModel GetPerformanceById(int id)
        {
                var a = _service.FindPerfomance(id);

                return new PerformanceViewModel
                {
                    Id = a.Id,
                    Date = a.Date,
                    Name = a.Name,
                    
                };

            }
        

        public IEnumerable<PerformanceViewModel> GetPerformencesByName(string name)
        {

            var performances = _service.FindByName(name);
            return convertPerformences(performances).ToList();
            
        }
        private void ExceptionMy(string a)
        {
            throw new ValidationException(a," ");
        }
        
        public IEnumerable<PerformanceViewModel> GetPerformencesByAuthor(string author)
        {
            try
            {
                var perf = _service.FindByAuthorName(author);
                return convertPerformences(perf);
            }
            catch(ValidationException ex)
            {
                ExceptionMy(ex.Message);
                return null;
            }
        }
        public string SellTicket(TicketViewModel ticket, UserViewModel user)
        {
            var ticketDTO = new TicketDTO()
            {
                Id = ticket.Id,
                TicketState = ticket.TicketState,
                UserId = ticket.UserId,
                User = new UserDTO
                {
                    Email = user.Email,
                    Password = user.Password,
                    Name = user.Name,
                    Surname = user.Surname
                }
            };
            var userDTO = new UserDTO()
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                Password = user.Password,
                Tickets = (IEnumerable<TicketDTO>)user.Tickets
            };

            try
            {
                _service.SellTicket(ticketDTO, userDTO);
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
            return $"User \"{ user.Name + " " + user.Surname }\" buy ticket succesfully ";
        }
    }
}