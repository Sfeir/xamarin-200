using MovieApp.Core.Models;
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

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new DetailsPage((Movie)e.SelectedItem));
        }
    }
}
