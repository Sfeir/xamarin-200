using MovieApp.Core.Models;
using MovieApp.Core.Store;
using MovieApp.Core.ViewModels;
using Xamarin.Forms;

namespace MovieApp.Core
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var viewModel = new MainViewModel(Navigation);
            BindingContext = viewModel;
        }
    }
}
