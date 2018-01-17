using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Core.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieApp.Core
{
    public partial class DetailsPage : ContentPage
    {
        private Movie movie;
        private Movie Movie => movie ?? (movie = BindingContext as Movie);

        public DetailsPage(Movie movie)
        {
            InitializeComponent();

            BindingContext = movie;
        }
    }
}