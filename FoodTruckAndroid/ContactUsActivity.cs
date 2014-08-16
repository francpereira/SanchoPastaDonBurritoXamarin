
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
using Android.Graphics.Drawables;

namespace FoodTruckAndroid
{
	[Activity (Label = "Contactenos")]			
	public class ContactUsActivity : Activity
	{

		AnimationDrawable contactUsAnimation;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.ContactUsActivity);


			ImageView contactUsImage = FindViewById<ImageView>(Resource.Id.imageViewContact);

			contactUsImage.SetBackgroundResource(Resource.Drawable.contactusanim);
			contactUsAnimation = (AnimationDrawable) contactUsImage.Background;
			contactUsAnimation.Start ();
		
		}
	}
}

