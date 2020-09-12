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
        ItemModel itemA = new ItemModel();
        ItemModel itemB = new ItemModel();
        ItemModel result = new ItemModel();
        public BinarySummatorViewModel()
        {
            GetResCommand = new Command(GetResult);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void GetResult()
        {
            result.getAsSumOf(itemA, itemB);
            OnPropertyChanged();
            OnPropertyChanged(nameof(DisplayMessage));
        }

        public int ItemAValue
        {
            get { return itemA.getValue(); }
            set { itemA.setValue(value); }
        }

        public int ItemBValue
        {
            get { return itemB.getValue(); }
            set { itemB.setValue(value); }
        }

        public string DisplayMessage
        {
            get { return $"The sum of A and B is: {result.getValue()}"; }
        }

        public Command GetResCommand { get; }
    }
}
