using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieApp.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddMoviePage : ContentPage
    {
        public AddMoviePage()
        {
            InitializeComponent();

            this.TitleEntry.Text = "The Dark Knight";

            this.OverviewEditor.Text =
                "Dans ce nouveau volet, Batman augmente les mises dans sa guerre contre le crime. Avec l'appui du lieutenant de police Jim Gordon et du procureur de Gotham, Harvey Dent, Batman vise à éradiquer le crime organisé qui pullule dans la ville. Leur association est très efficace mais elle sera bientôt bouleversée par le chaos déclenché par un criminel extraordinaire que les citoyens de Gotham connaissent sous le nom de Joker.";

            this.ReleaseDatePicker.Date = new DateTime(2008, 08, 10);
        }
    }
}