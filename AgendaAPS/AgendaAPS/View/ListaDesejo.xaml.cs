using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Content;

namespace AgendaAPS.Model
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaDesejo : ContentPage
    {
        /*
        public ListaDesejos()
        {
            InitializeComponent();
        }
        */

        public async void AlterarDesejo_Click(object sender, EventArgs e)
        {
            await App.NavigateMaster(new AlterarDesejo());
        }

        public async void InserirDesejo_Click(object sender, EventArgs e)
        {
            await App.NavigateMaster(new InserirDesejo());

        }
        public async void DetalharDesejo_Click(object sender, EventArgs e)
        {
            await App.NavigateMaster(new DetalheDesejo());

        }
    }
}