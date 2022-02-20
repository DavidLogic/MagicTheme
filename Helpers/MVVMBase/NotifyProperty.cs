using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheme.Helpers.MVVMBase
{
    public class NotifyProperty : INotifyPropertyChanged
    {
        public delegate bool ShouldChangePropertyEventHandler(object sender, PropertyChangedEventArgs e);
        public event ShouldChangePropertyEventHandler ShouldChangeProperty;

        public event PropertyChangedEventHandler PropertyChanged;

        internal bool CanChangeProperty([CallerMemberName] string propertyName = "")
        {
            return ShouldChangeProperty == null || ShouldChangeProperty(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
