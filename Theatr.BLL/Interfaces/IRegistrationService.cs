using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.BLL.DTO;

namespace Theatr.BLL.Interfaces
{
    public interface IRegistrationService
    {
        void Register(UserDTO user);
        void DeleteUser(int id);
    }
}
