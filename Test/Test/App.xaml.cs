﻿using Test.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainViewModel.GetInstance().Login = new LoginViewModel();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
