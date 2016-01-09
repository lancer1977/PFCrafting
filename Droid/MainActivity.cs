using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PFCrafting;

namespace Droid
{
    [Activity(
            Label = "PF Crafting",
            //MainLauncher=true,
            Icon = "@drawable/Icon",
            ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
        )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, ICurrentActivity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            ToastNotificatorImplementation.Init(this);
            Insights.Initialize("4fb11a6171fc4812a535220450bdd9a58144bae2", this);
            //MR.Gestures.Android.Settings.LicenseKey = "ALZ9-BPVU-XQ35-CEBG-5ZRR-URJQ-ED5U-TSY8-6THP-3GVU-JW8Z-RZGE-CQW6";
#if TEST_CLOUD
			Xamarin.Forms.Forms.ViewInitialized += (object sender, Xamarin.Forms.ViewInitializedEventArgs e) => {
				if (!string.IsNullOrWhiteSpace(e.View.StyleId)) {
					e.NativeView.ContentDescription = e.View.StyleId;
				}};
#endif
            DroidBootstrapper.Run();
            IOC.Instance.RegisterSingleton<INavigationBarController>(new NavigationBarControllerDroid(SetNavigationBarColor));
            IOC.Instance.RegisterSingleton<ICurrentActivity>(this);
            SetNavigationBarColor();
            LoadApplication(new App());
        }


        public void SetNavigationBarColor(string hex = "#00263A")
        {
            RunOnUiThread(() => {
                ActionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor(hex)));

            }
            );
        }
          
}

