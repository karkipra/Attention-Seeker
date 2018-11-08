using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AttentionSeeker
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("You Clicked!", "Pratik", "OK");
        }
    }
}
