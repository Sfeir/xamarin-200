using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

namespace MovieApp.Core.Models
{
    public class Movie : INotifyPropertyChanged
    {
        private const string baseImageUrl = "http://image.tmdb.org/t/p/w320";

        public int Id { get; set; }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        public string Image => baseImageUrl + PosterPath;

        public override string ToString()
        {
            return Title;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
