using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rrt.Presenters.Views
{
    public interface IRegisterView
    {
        void SetController(AuthController controller);
        bool Register(string Email, string Name, string Password, bool RememberMe);
        void ShowError();

        string Email { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        bool RememberMe { get; set; }
    }
}
