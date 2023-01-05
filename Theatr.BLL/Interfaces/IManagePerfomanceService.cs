using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.BLL.DTO;
using AutoMapper;

namespace Theatr.BLL.Interfaces
{
    public interface IManagePerfomanceService
    {
        IEnumerable<PerformanceDTO> FindByTime(DateTime start, DateTime end);
        PerformanceDTO FindPerfomance(int id);
        IEnumerable<PerformanceDTO> GetAll();
        IEnumerable<GenreDTO> GetGenreOfPerformance(string performanceName);
        IEnumerable<GenreDTO> GetGenresByPerformanceId(int id);
        IEnumerable<PerformanceDTO> FindByDate(DateTime fromDateTime, DateTime toDateTime);
        IEnumerable<PerformanceDTO> FindByName(string name);
        IEnumerable<PerformanceDTO> FindByAuthorId(int authorId);
        IEnumerable<PerformanceDTO> FindByGenreName(string genreName);
        IEnumerable<PerformanceDTO> FindByAuthorName(string authorName);
        string SellTicket(TicketDTO ticketDTO, UserDTO userDTO);
        void UpdateTicket(int ticketId, int price, string category, int perfomanceId, string state);
    }
}
