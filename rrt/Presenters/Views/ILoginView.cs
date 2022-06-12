using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rrt.Presenters.Views
{
    public interface ILoginView
    {
        void SetController(AuthController controller);
        bool Login(string Email, string Password);
        void ShowError();

        string Email { get; set; }
        string Password { get; set; }
    }
}
