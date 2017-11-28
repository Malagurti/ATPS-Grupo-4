using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgendaAPS.ViewModel;

namespace AgendaAPS.Model
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await App.NavigateMaster(new listaDesejo());
        }
    }
}