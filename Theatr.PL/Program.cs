using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using Theatr.BLL.Infrastructure;
using Theatr.PL.Views;

namespace Theatr.PL
{
    public static class Program
    {
        public static IKernel Kernel { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Kernel = new StandardKernel();
            Kernel.Load(new NinjectRegistrations());
            Application.Run(new MainWindow());

        }
    }
}
