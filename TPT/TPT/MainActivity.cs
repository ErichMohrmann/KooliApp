using Android.App;
using Android.Widget;
using Android.OS;

namespace TPT
{
    [Activity(Label = "TPT", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button KooliTutvustus = FindViewById<Button>(Resource.Id.Description);
            Button KooliUudised = FindViewById<Button>(Resource.Id.News);
            Button KooliTunniplaan = FindViewById<Button>(Resource.Id.TimeTable);
            Button KooliKasulikudLingid = FindViewById<Button>(Resource.Id.UsefulLinks);
            Button KooliTundideAjad = FindViewById<Button>(Resource.Id.Times);

            KooliTutvustus.Click += delegate {
                StartActivity(typeof(TutvustusActivity));

            };

            KooliUudised.Click += delegate {
                StartActivity(typeof(UudisedActivity));

            };

            KooliTunniplaan.Click += delegate {
                StartActivity(typeof(TunniplaanActivity));

            };

            KooliKasulikudLingid.Click += delegate {
                StartActivity(typeof(KasulikudActivity));

            };

            KooliTundideAjad.Click += delegate {
                StartActivity(typeof(AjadActivity));

            };
        }
    }
}

