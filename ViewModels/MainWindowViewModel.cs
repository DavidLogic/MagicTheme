using MagicTheme.Helpers.MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheme.ViewModels
{
    public  class MainWindowViewModel:NotifyProperty
    {
        private string currentTheme;
        public string  CurrentTheme
        {
            get
            {
                return currentTheme;
            }
            set
            {
                if(CanChangeProperty())
                {
                     currentTheme = value;
                    RaisePropertyChanged(CurrentTheme);
                }
               
            }
        }
    }
}
