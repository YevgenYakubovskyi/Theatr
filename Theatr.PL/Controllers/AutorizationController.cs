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
    public class AutorizationController
    {
        private readonly IAuthorizationService _service;
        public AutorizationController(IAuthorizationService service)
        {
            _service = service;
        }

        public string Login(UserViewModel user)
        {

            var Password = user.Password;
            var Email = user.Email;
            try
            {
                UserDTO userDTO = _service.Login(Email, Password);

                return $"User \"{ userDTO.Name + " " + userDTO.Surname }\" login succesfully ";
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
        }
    }
}