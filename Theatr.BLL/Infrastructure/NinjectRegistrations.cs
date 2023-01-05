using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Theatr.BLL.Interfaces;
using Theatr.BLL.Service;

namespace Theatr.BLL.Infrastructure
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthorizationService>().To<AuthorizationService>();
            Bind<IManagePerfomanceService>().To<ManagePerfomanceService>();
            Bind<IRegistrationService>().To<RegistrationService>();
        }
    }
}
