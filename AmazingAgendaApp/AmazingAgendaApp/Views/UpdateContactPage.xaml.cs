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
	public partial class UpdateContactPage : ContentPage
	{
        private ContactMobileViewModel _contact;

        public UpdateContactPage ()
		{
			InitializeComponent ();
		}

        public UpdateContactPage(ContactMobileViewModel contact)
        {
            InitializeComponent();
            _contact = contact;
            EntryName.Text = _contact.Name;
            EntryPhone.Text = _contact.Phone;
        }

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            _contact.Name = EntryName.Text;
            _contact.Phone = EntryPhone.Text;
            App.ContactAppService.Update(_contact);
            Navigation.PopModalAsync();
        }
    }
}