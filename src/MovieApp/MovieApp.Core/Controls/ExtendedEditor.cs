using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MovieApp.Core.Controls
{
    public class ExtendedEditor : Editor
    {
        public ExtendedEditor()
        {
            this.TextChanged += (sender, args) =>
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    this.InvalidateMeasure();
                }
            };
        }
    }
}
