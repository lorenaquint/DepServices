
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DepServices.DependencyServices;
using DepServices.Droid.DepndencyService;
using Xamarin.Forms;
[assembly:Dependency(typeof(AndroidMessage))]
namespace DepServices.Droid.DepndencyService
{
    
    public class AndroidMessage : IPlatMessage
    {
        public string GetMessage()
        {
            return "Estoy desde Android";
        }
    }
}