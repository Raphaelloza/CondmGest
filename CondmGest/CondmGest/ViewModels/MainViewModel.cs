using System;
using System.Collections.Generic;
using System.Text;

//La MainViewModel encargada de administradar las demas ViewModels

namespace CondmGest.ViewModels
{
    class MainViewModel
    {
        #region ViewModels

            public LoginViewModel Login
            {
                get;
                set;
            }

        #endregion

        #region Constructors

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

        #endregion
    }
}
