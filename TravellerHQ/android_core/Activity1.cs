using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using mobilecore;

namespace android_core
{
	[Activity (Label = "android_core", MainLauncher = true)]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			TextView text=FindViewById<TextView> (Resource.Id.main_text);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++); };
			
			text.Text = new MyDomain().getMyDomain();
		}
	}
}


