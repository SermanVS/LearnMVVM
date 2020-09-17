using LearnMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace LearnMVVM.ViewModel
{
    class BinarySummatorViewModel : INotifyPropertyChanged
    {
        private SummatorModel summatorModel = new SummatorModel();
        public BinarySummatorViewModel()
        {
            ComputeResultCommand = new Command(ComputeResult);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void ComputeResult()
        {
            summatorModel.setResultAsSum();
            OnPropertyChanged();
            OnPropertyChanged(nameof(DisplayMessage));
        }

        public int itemA
        {
            get { return summatorModel._itemA.getValue(); }
            set { summatorModel._itemA.setValue(value); }
        }

        public int itemB
        {
            get { return summatorModel._itemB.getValue(); }
            set { summatorModel._itemB.setValue(value); }
        }

        public int result
        {
            get { return summatorModel._result.getValue(); }
        }

        public string DisplayMessage
        {
            get { return $"The sum of A and B is: { result }"; }
        }

        public Command ComputeResultCommand { get; }
    }
}
