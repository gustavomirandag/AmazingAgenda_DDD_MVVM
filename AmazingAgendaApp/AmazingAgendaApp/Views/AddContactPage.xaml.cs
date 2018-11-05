using AmazingAgenda.Application.ViewModels.Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmazingAgendaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddContactPage : ContentPage
	{
		public AddContactPage ()
		{
			InitializeComponent ();
		}

        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            App.ContactAppService.Add(new ContactMobileViewModel() { Name = EntryName.Text, Phone = EntryPhone.Text });
            Navigation.PopModalAsync(true);
        }
        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}