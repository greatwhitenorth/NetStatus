using System;
using System.Collections.Generic;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

using Xamarin.Forms;

namespace NetStatus
{
    public partial class NetworkViewPage : ContentPage
    {
        public NetworkViewPage()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
            base.OnAppearing();
            var enumerator = CrossConnectivity.Current.ConnectionTypes.GetEnumerator();
            ConnectionDetails.Text = enumerator.Current.ToString();
            //ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.ToString();
		}
	}
}
