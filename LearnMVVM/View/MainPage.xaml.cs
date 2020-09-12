using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using LearnMVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnMVVM.View
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BinarySummatorViewModel();
        }
    }
}