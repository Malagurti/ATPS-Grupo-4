using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AgendaAPS.Model
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            this.Master = new Menu();
            this.Detail = new NavigationPage(new Detail());
            App.MasterPage = this;

        }
    }
}
