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
        ItemModel itemModel = new ItemModel();
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
            itemModel.getSumOf(itemModel.itemA, itemModel.itemB);
            OnPropertyChanged();
            OnPropertyChanged(nameof(DisplayMessage));
        }

        public int ItemAValue
        {
            get { return itemModel.itemA.getValue(); }
            set { itemModel.itemA.setValue(value); }
        }

        public int ItemBValue
        {
            get { return itemModel.itemB.getValue(); }
            set { itemModel.itemB.setValue(value); }
        }

        public string DisplayMessage
        {
            get { return $"The sum of A and B is: {itemModel.result.getValue()}"; }
        }

        public Command ComputeResultCommand { get; }
    }
}
