using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using mobilecore;

namespace androidcore
{
	[Activity (Label = "android-core", MainLauncher = true)]
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
			TextView textView = FindViewById<TextView> (Resource.Id.main_text);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++); };
			
			textView.SetText (new MyDomain().getMyDomain());
		}
	}
}


