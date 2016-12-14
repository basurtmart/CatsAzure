using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cats.Views
{
    public partial class DetailsPage : ContentPage
    {
        Models.Cat SelectedCad;
        public DetailsPage(Models.Cat selectedCat)
        {
            InitializeComponent();
            this.SelectedCad = selectedCat;
            BindingContext = this.SelectedCad;
            ButtonWebSite.Clicked += ButtonWebSite_Clicked;
        }

        private void ButtonWebSite_Clicked(object sender, EventArgs e)
        {
            if (SelectedCad.WebSite.StartsWith("http"))
            {
                Device.OpenUri(new Uri(SelectedCad.WebSite));
            }
        }
    }
}
