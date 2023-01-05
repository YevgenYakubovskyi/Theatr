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
    public class RegistrationController
    {
        private readonly IRegistrationService _service;
        public RegistrationController(IRegistrationService service)
        {
            _service = service;
        }

        public string Register(UserViewModel user)
        {
            var userDTO = new UserDTO()
            {
                Password = user.Password,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
            };
            try
            {
                _service.Register(userDTO);
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
            return $"User \"{ user.Name + " " +  user.Surname }\" registered succesfully ";
        }
    }
}