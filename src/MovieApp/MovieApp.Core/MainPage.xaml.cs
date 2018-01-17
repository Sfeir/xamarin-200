using MovieApp.Core.Store;
using Xamarin.Forms;

namespace MovieApp.Core
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MovieRepository().Movies;
        }
    }
}
