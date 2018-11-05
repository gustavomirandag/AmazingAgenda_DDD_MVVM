using AmazingAgenda.Application.AppServices;
using AmazingAgenda.Domain.Service.Services;
using AmazingAgenda.Infrastructure.Repositories;
using AmazingAgendaApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AmazingAgendaApp
{
    public partial class App : Application
    {
        public static ContactMobileAppService ContactAppService { get; set; }
        public App()
        {
            InitializeComponent();

            //Infrastructure
            ContactRamRepository repository = new ContactRamRepository();

            //Domain.Service
            ContactService contactService = new ContactService(repository);

            //Application Layer
            ContactAppService = new ContactMobileAppService(contactService);

            MainPage = new NavigationPage(new ListContactsPage());
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
