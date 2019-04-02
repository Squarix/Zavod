using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace Zavod.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page Welcome;
        private Page SignIn;
        
        public Page CurrentPage { get; set; }
        public int Clicks { get; set; }

        public MainViewModel()
        {
            using (Model.ZavodDB db = new Model.ZavodDB())
            {
                
            }
            SignIn  = new View.SignIn();
            Welcome = new View.Welcome();
            CurrentPage = Welcome;
        }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Clicks++;
                });
            }
        }

        public ICommand SwitchSignIn
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    CurrentPage = SignIn;
                    UpdateLayout();
                });
            }
        }
    }
}
