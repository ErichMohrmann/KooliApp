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
    [Activity(Label = "Kasulikud lingid")]
    public class KasulikudActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KasulikudLingid);

            WebView webview = FindViewById<WebView>(Resource.Id.WVKasulik);
            webview.LoadUrl("https://www.tptlive.ee/opilasele/)");
        }
    }
}