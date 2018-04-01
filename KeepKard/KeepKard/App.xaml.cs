using System;
using KeepKard.ViewModels;
using KeepKard.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace KeepKard
{
    public partial class App : PrismApplication
    {
        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}

        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            try
            {
                InitializeComponent();

                NavigationService.NavigateAsync("Home");
            }
            catch (Exception ex)
            {
                
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Home, HomeViewModel>();
            containerRegistry.RegisterForNavigation<PessoalPage>();
            containerRegistry.RegisterForNavigation<ProfessionalPage>();
            containerRegistry.RegisterForNavigation<HomeCarouselPage>();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
    }
}
