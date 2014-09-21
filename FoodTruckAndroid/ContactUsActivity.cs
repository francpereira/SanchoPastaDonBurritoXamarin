
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
using Android.Content.PM;

namespace FoodTruckAndroid
{
	[Activity (Label = "Contactenos", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class ContactUsActivity : Activity
	{

		AnimationDrawable contactUsAnimation;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.ContactUsActivity);

			ActionBar actionBar = ActionBar;
			actionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			ActionBar.Tab tab = actionBar.NewTab ();
			tab.SetText ("Menu");
			//tab.SetIcon (Resource.Drawable.tab_home);
			tab.TabSelected += (sender, e) => {
				StartActivity(typeof(MenuActivity));
			}; 

			//tab.Select ();


			actionBar.AddTab (tab, false);

			tab = actionBar.NewTab ();
			tab.SetText("Mapa");
			tab.TabSelected += (sender, e) => {

				//var geoUri = Android.Net.Uri.Parse ("geo:18.413615,-66.098316?z=17&q=18.413615,-66.098316(Don Burrito y Sancho Pasta)");
				//var mapIntent = new Intent (Intent.ActionView, geoUri);
				//StartActivity (mapIntent);

				StartActivity(typeof(MapActivity));

			};
			actionBar.AddTab (tab, false);

			tab = actionBar.NewTab ();
			tab.SetText ("Contactenos");
			tab.TabSelected += (sender, e) => {


			};
			actionBar.AddTab (tab, true);


			ImageView contactUsImage = FindViewById<ImageView>(Resource.Id.imageViewContact);

			contactUsImage.SetBackgroundResource(Resource.Drawable.contactusanim);
			contactUsAnimation = (AnimationDrawable) contactUsImage.Background;
			contactUsAnimation.Start ();
		
		}
	}
}

