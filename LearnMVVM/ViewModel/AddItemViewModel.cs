using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace LearnMVVM.ViewModel
{
    class AddItemViewModel : INotifyPropertyChanged
    {
        public AddItemViewModel()
        {
            val1 = val2 = 0;
            GetResCommand = new Command(GetResult);
        }

        int val1, val2, res;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int Val1
        {
            get { return val1;  }
            set
            {
                val1 = value;

                //OnPropertyChanged();
                //OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public int Val2
        {
            get { return val2; }
            set
            {
                val2 = value;

                //OnPropertyChanged();
                //OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public int Res
        {
            get { return val1 + val2; }
        }

        void GetResult()
        {
            res = val1 + val2;
            OnPropertyChanged();
            OnPropertyChanged(nameof(DisplayMessage));
        }
        public string DisplayMessage
        {
            get { return $"The result is value is: {Res}"; }
        }

        public Command GetResCommand { get; }
    }
}
