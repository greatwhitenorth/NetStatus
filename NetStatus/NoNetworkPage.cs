﻿using System;

using Xamarin.Forms;

namespace NetStatus
{
    public class NoNetworkPage : ContentPage
    {
        public NoNetworkPage()
        {
            BackgroundColor = Color.FromRgb(0xf0, 0xf0, 0xf0);

            Content = new StackLayout
            {
                Children = {
                    new Label() { 
                        Text = "No Network Connection Available",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromRgb(0x40,0x40,0x40),}
                }
            };
            /*Content = new Label()
            {
                Text = "No Network Connection Available",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromRgb(0x40,0x40,0x40),
            };*/
        }
    }
}

