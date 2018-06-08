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
    [Activity(Label = "Tunniplaan")]
    public class TunniplaanActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Tunniplaan);
            WebView webview = FindViewById<WebView>(Resource.Id.WVTunniplaan);

            webview.LoadUrl("https://tpt.siseveeb.ee/veebivormid/tunniplaan");
        }
    }
}