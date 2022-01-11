﻿using CarShowroomMobile.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarShowroomMobile
{
    public partial class App : Application
    {
        public static ItemManager CarManager { get; private set; }
        public App()
        {
            InitializeComponent();

            CarManager = new ItemManager(new RestService());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
