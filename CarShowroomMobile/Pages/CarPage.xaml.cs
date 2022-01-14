using CarShowroomMobile.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarShowroomMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarPage : ContentPage
    {
        bool isNewItem;
        public CarPage(bool isNew = false)
        {
            InitializeComponent();
            isNewItem = isNew;
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Car car = new Car
            {
                VinNumber = Vin_Number.Text,
                Price = Convert.ToDecimal(_Price.Text),
                Colour = _Colour.Text,
                IdModelNavigation = new Model
                {
                    Name = _ModelName.Text,
                    IdBodyNavigation = new Body
                    {
                        Name = _BodyName.Text,
                        Door = Convert.ToInt32(_Door.Text),
                        Volume = Convert.ToInt32(_BodyVolume.Text),
                    },
                    IdBrandNavigation = new Brand
                    {
                        Name = _BrandName.Text
                    },
                    IdClassNavigation = new Class
                    {
                        Name = _ClassName.Text
                    },
                    IdEngineNavigation = new Engine
                    {
                        Type = _engineType.Text,
                        HP = Convert.ToInt32(_Power.Text),
                        Volume = Convert.ToDouble(_EngineVolume.Text),
                        Consumption = Convert.ToInt32(_Consumption.Text)
                    },
                    IdGearboxNavigation = new Gearbox
                    {
                        Type = _GearboxType.Text,
                        Number = Convert.ToInt32(_GearboxNumber.Text)
                    },
                    IdGenerationNavigation = new Generation
                    {
                        Year = Convert.ToInt16(_Year.Text),
                        Produced = Convert.ToInt32(_Produced.IsChecked)
                    }
                },
                IdShowroomNavigation = new CarShowroom
                {
                    Name = _ShowroomName.Text,
                    Address = _Address.Text,
                    Phone = _Phone.Text,
                    Email = _Email.Text,
                }
            };

            await App.CarManager.SaveTaskAsync(car, isNewItem);
            await Navigation.PopAsync();
        }

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            Car car = (Car)BindingContext;
            await App.CarManager.DeleteTaskAsync(car);
            await Navigation.PopAsync();
        }

        private async void OnCancelButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}