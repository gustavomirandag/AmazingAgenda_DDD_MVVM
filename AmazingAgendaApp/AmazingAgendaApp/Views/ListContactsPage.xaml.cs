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
	public partial class ListContactsPage : ContentPage
	{
		public ListContactsPage ()
		{
			InitializeComponent ();
            ListViewContacts.ItemsSource = App.ContactAppService.ObservableContacts;
            ListViewContacts.ItemTapped += ListViewItems_ItemTapped;
        }

        private void ListViewItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new UpdateContactPage((ContactMobileViewModel)e.Item));
            ListViewContacts.SelectedItem = null;
        }

        private void ButtonAddItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddContactPage(), true);
        }

        private void ButtonRemove_Clicked(object sender, EventArgs e)
        {
            Guid itemId = (Guid)((Button)sender).CommandParameter;
            App.ContactAppService.Remove(itemId);
        }
    }
}