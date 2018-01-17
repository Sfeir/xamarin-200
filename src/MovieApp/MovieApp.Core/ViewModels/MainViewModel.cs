using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using MovieApp.Core.Models;
using MovieApp.Core.Store;
using Xamarin.Forms;

namespace MovieApp.Core.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public IList<Movie> Movies { get; }

        private Movie selectedMovie;
        public Movie SelectedMovie
        {
            get
            {
                return selectedMovie;
            }
            set
            {
                if (selectedMovie != null)
                {
                    NavigateToDetailPage();
                    selectedMovie = null;
                }

                selectedMovie = value;
                OnPropertyChanged();
            }
        }

        private readonly INavigation navigation;

        public MainViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            Movies = new MovieRepository().Movies;
        }

        private async void NavigateToDetailPage()
        {
            await navigation.PushAsync(new DetailsPage(selectedMovie));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
