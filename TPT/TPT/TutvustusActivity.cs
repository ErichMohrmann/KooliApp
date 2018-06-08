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
    [Activity(Label = "Kooli tutvustus")]
    public class TutvustusActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KooliTutvustus);
            
            WebView webview = FindViewById<WebView>(Resource.Id.WVTutvustus);
            webview.LoadUrl("https://www.tptlive.ee/sisseastujale/");


        }
    }
}