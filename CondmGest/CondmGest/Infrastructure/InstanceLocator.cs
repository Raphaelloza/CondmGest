using System;
using System.Collections.Generic;
using System.Text;

namespace CondmGest.Infrastructure
{
    using ViewModels;
    
    class InstanceLocator
    {
        //Ligar la MainPage con mi MainPageView
        #region Properties
        public MainViewModel Main //Prop
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator() //Ctor
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
