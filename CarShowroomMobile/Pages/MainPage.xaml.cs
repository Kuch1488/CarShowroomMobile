using CarShowroomMobile.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarShowroomMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            CarList.ItemsSource = await App.CarManager.GetCars();
        }

        private async void OnAddItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarPage
            {

            });
        }

        private async void OnItemSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarPage
            {

            });
        }
    }
}
