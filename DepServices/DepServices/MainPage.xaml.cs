

namespace DepServices
{
    using DepServices.DependencyServices;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.btnMessage.Clicked += BtnMessage_Clicked;
		}

        private async void BtnMessage_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlatMessage>();
            var message = service.GetMessage();
            await DisplayAlert("Serive",
                          message,
                          "ok");
        }
    }
}
