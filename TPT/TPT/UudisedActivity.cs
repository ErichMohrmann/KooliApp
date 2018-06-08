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
using Android.Webkit;

namespace TPT
{
    [Activity(Label = "Uudised")]
    public class UudisedActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Tunniplaan);
            WebView webview = FindViewById<WebView>(Resource.Id.WVTunniplaan);

            webview.LoadUrl("https://www.tptlive.ee/category/uudised/");
        }
    }
}