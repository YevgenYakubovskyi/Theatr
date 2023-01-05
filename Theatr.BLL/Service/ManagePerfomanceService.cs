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
using AutoMapper;

namespace Theatr.BLL.Service
{
    public class ManagePerfomanceService : IManagePerfomanceService
    {
        private EFUnitOfWork UnitOfWork;

        public ManagePerfomanceService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public IEnumerable<PerformanceDTO> GetAll()
        {
            var performances = UnitOfWork.Perfomances.GetAll();
            return performances.Select(performance => new PerformanceDTO
            {
                Id = performance.Id,
                Name = performance.Name,
                Authors = performance.Authors.Select(a => new AuthorDTO
                {
                    Id = a.Id,
                    Name = a.Name
                }),
                Genres = performance.Genres.Select(a=> new GenreDTO
                { 
                    Id = a.Id,
                    Name = a.Name
                }),
                Date = performance.Date
            });
            var performanceDal = UnitOfWork.Perfomances.GetAll().ToList();
            if (performanceDal.Count() == 0) throw new ValidationException("No performance found");

            return MapPerformance(performanceDal);
        }

        public IEnumerable<PerformanceDTO> FindByAuthorId(int authorId)
        {
            var performanceDal = UnitOfWork.Authors.Get(authorId).Perfomances;
            var performance = performanceDal.Select(a => new PerformanceDTO
            {
                Id = a.Id,
                Name = a.Name,
                Date = a.Date,
                Genres = (ICollection<GenreDTO>)a.Genres.Select(t => t.Name),
                Tickets = (ICollection<TicketDTO>)a.Tickets.Select(t => new TicketDTO
                {
                    TicketCategory = t.TicketCategory,
                    Price = t.Price,
                    TicketState = t.TicketState
                }),
                Authors = (ICollection<AuthorDTO>)a.Authors.Select(t => t.Name)
            });
            return performance;
        }

        public IEnumerable<PerformanceDTO> FindByDate(DateTime fromDateTime, DateTime toDateTime)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<Performance, PerformanceDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Performance>, List<PerformanceDTO>>(UnitOfWork.Perfomances.Find(e => e.Date.CompareTo(fromDateTime) > 0 && e.Date.CompareTo(toDateTime) < 0));
        }





        public PerformanceDTO FindPerfomance(int id)
        {
            if (id < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            Performance performance = UnitOfWork.Perfomances.Get(id);
            if (performance == null)
                throw new ValidationException("Perfomance was not found", "");
            return new PerformanceDTO
            {
                Id = performance.Id,
                Name = performance.Name,
                Date = performance.Date
            };
        }
        public string SellTicket(TicketDTO ticketDTO, UserDTO userDTO)
        {

            var ticketDal = UnitOfWork.Tickets.Get(ticketDTO.Id);
            var userDal = UnitOfWork.Users.Get(userDTO.Id);
            ticketDal.TicketState = ticketDTO.TicketState;
            ticketDal.UserId = ticketDTO.UserId;
            userDal.Tickets.Add(ticketDal);
            UnitOfWork.Tickets.Update(ticketDal);
            UnitOfWork.Users.Update(userDal);
            UnitOfWork.Save();
            return "";

        }


        



        public void UpdateTicket(int ticketId, int price, string category, int perfomanceId, string state)
        {
            var ticketDal = UnitOfWork.Tickets.Get(ticketId);
            ticketDal.Price = price;
            ticketDal.TicketCategory = category;
            ticketDal.TicketState = state;
            ticketDal.Perfomance = UnitOfWork.Perfomances.Get(perfomanceId);
            UnitOfWork.Tickets.Update(ticketDal);
            UnitOfWork.Save();
        }
        public IEnumerable<GenreDTO> GetAllGenres()
        {
            var genresDal = UnitOfWork.Genres.GetAll();
            return genresDal.Select(a => new GenreDTO
            {
                Id = a.Id,
                Name = a.Name
            });
        }

        public IEnumerable<PerformanceDTO> FindByGenreName(string genreName)
        {
            var genre = UnitOfWork.Genres.GetByName(genreName);
            if (genre == null) throw new ValidationException("No such genre name", " ");
            return MapPerformance(genre.Perfomances);
        }
        public IEnumerable<PerformanceDTO> FindByName(string name)
        {
            var performances = UnitOfWork.Perfomances.Find(a => a.Name.Contains(name));
            return MapPerformance(performances);
        }
        public IEnumerable<PerformanceDTO> FindByAuthorName(string authorName)
        {
            var author = UnitOfWork.Authors.GetByName(authorName);
            if (author == null) throw new ValidationException("No such author name", " ");
            return MapPerformance(author.Perfomances);
        }

        public IEnumerable<PerformanceDTO> FindByTime(DateTime start, DateTime end)
        {
            var performances = UnitOfWork.Perfomances.Find(a => a.Date > start && a.Date < end);
            return MapPerformance(performances);
        }
        
        public IEnumerable<GenreDTO> GetGenresByPerformanceId(int id)
        {
            var performance = UnitOfWork.Perfomances.Get(id);
            if (performance == null) throw new ValidationException("No performance with such id", " ");
            return performance.Genres.Select(a => new GenreDTO()
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();
        }
        public IEnumerable<TicketDTO> GetTicketsByPerformanceId(int id)
        {
            var performance = UnitOfWork.Perfomances.Get(id);
            if (performance == null) throw new ValidationException("No performance with such id", " ");
            return performance.Tickets.Select(a => new TicketDTO()
            {
                Id = a.Id,
                Price = a.Price,
                TicketCategory = a.TicketCategory,
                TicketState = a.TicketState
            }).ToList();
        }
        public IEnumerable<AuthorDTO> GetAuthorsByPerformanceId(int id)
        {
            var performance = UnitOfWork.Perfomances.Get(id);
            if (performance == null) throw new ValidationException("No performance with such id", " ");
            return performance.Authors.Select(a => new AuthorDTO()
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();
        }
        private IEnumerable<PerformanceDTO> MapPerformance(IEnumerable<Performance> performancesDal)
        {
            try
            {
                return performancesDal.Select(a => new PerformanceDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    Date = a.Date,
                    Authors = GetAuthorsByPerformanceId(a.Id),
                    Genres = GetGenresByPerformanceId(a.Id),
                    Tickets = GetTicketsByPerformanceId(a.Id),
                });
            }
            catch
            {
                throw new ValidationException("List of performance clear with such parametr"," ");
            }
        }

        public IEnumerable<GenreDTO> GetGenreOfPerformance(string performanceName)
        {
            var genres = UnitOfWork.Genres.GetByNamePerformance(performanceName);
            return genres.Select(a => new GenreDTO
            {
                Id = a.Id,
                Name = a.Name
            });
        }
    }
}
