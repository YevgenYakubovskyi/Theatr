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
    public class RegistrationService : IRegistrationService
    {
        private EFUnitOfWork UnitOfWork;

        public RegistrationService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public void DeleteUser(int id)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<User, UserDTO>()).CreateMapper();
            if (UnitOfWork.Users.Get(id) == null)
                throw new ValidationException("User doesn`t exist", "");
            UnitOfWork.Users.Delete(id);
            UnitOfWork.Save();
        }

        public void Register(UserDTO user)
        {
            if (user == null)
                throw new ValidationException("No info about user", "");
            var testUser = UnitOfWork.Users.Find(u => u.Email.Equals(user.Email));
            if (testUser.Count() > 0)
                throw new ValidationException("Email is taken", "");
            var NewUser = new User
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password            
            };
            UnitOfWork.Users.Create(NewUser);
            UnitOfWork.Save();
        }
    }
}
