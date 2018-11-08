using System;

using Xamarin.Forms;

namespace AttentionSeeker
{
    public class GreetingPage : ContentPage
    {
        public GreetingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

