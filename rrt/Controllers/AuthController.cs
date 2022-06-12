using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rrt.Controllers
{
    public class AuthController
    {
        ILoginView _loginView;
        IRegisterView _registerView;
        IAuthService _authService;

        public AuthController(ILoginView loginView, IRegisterView registerView, IAuthService authService)
        {
            _loginView = loginView;
            _registerView = registerView;
            _authService = authService;
            loginView.SetController(this);
            registerView.SetController(this);
        }
    }
}
