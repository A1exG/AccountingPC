using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Accounting.DesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        //private Iservice _service;
        //public ShellViewModel(Iservice service)
        //{
        //    _service = service;
        //}

        private LoginViewModel _loginVM;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVM = loginVM;
            ActivateItem(_loginVM);
        }
    }
}
