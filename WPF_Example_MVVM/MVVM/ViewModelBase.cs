using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Example_MVVM.MVVM
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnProPertyChanged([CallerMemberName] string proeprtyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proeprtyName));
        }
    }
}
