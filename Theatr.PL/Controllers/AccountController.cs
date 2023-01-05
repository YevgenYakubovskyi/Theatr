using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.PL.Models;

namespace Theatr.PL.Controllers
{
    public static class AccountController
    {
        private static UserViewModel _account;
        public static void Set(UserViewModel account)
        {
            _account = account;
        }

        public static void Reset()
        {
            _account = null;
        }

        public static UserViewModel Get()
        {
            return _account;
        }
    }
}
