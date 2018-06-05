﻿

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
            this.btnTextoVoz.Clicked += BtnTextoVoz_Clicked;
            this.btnPlataforma.Clicked += BtnPlataforma_Clicked;
            
        }

        

        private async void BtnPlataforma_Clicked(object sender, EventArgs e)
        {
            await Task.Delay(5000).ConfigureAwait(false);
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
             {
                 Device.BeginInvokeOnMainThread(() =>
                 this.txtAviso.Text = DateTime.Now.ToString());
                 return true;
             });
            
        }

        private void BtnTextoVoz_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextVoz>();
            service.Spek("Esto es Xamarin Forms y Dependecy Service");
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
