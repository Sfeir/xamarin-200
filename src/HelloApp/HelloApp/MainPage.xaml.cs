using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NameEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            helloLabel.Text = $"Hello {nameEntry.Text}";
        }
    }
}
