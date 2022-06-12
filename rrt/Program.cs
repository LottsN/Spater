using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rrt
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILoginView loginView = new ILoginView();
            IRegisterView registerView = new IRegisterView();
            IAuthService authService = new IAuthService();
            AuthController controller = new AuthController(loginView, registerView, authService);
            Application.Run(new Form1());
        }
    }
}
