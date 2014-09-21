
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
using Android.Support.V4.App;
using FoodTruckClassLibrary;
using Android.Support.V4.View;
using DK.Ostebaronen.Droid.ViewPagerIndicator;
using Android.Content.PM;

namespace FoodTruckAndroid
{
	[Activity (Label = "Don Burrito y Sancho Pasta", Icon = "@drawable/appicon", ScreenOrientation = ScreenOrientation.Portrait)]		
	public class MenuActivity : FragmentActivity
	{
		MenuManager menuManager;
		ViewPager viewPager;
		MenuPagerAdapter menuPagerAdapter;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			menuManager = new MenuManager();
			menuManager.GetAllMenuOptions();

			SetContentView (Resource.Layout.MenuActivity);
			// Create your application here


			ActionBar actionBar = ActionBar;
			actionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			ActionBar.Tab tab = actionBar.NewTab ();
			tab.SetText ("Menu");
			//tab.SetIcon (Resource.Drawable.tab_home);
			tab.TabSelected += (sender, e) => {
			}; 

			//tab.Select ();


			actionBar.AddTab (tab);

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
			
				StartActivity(typeof(ContactUsActivity));
			};
			actionBar.AddTab (tab, false);


			menuPagerAdapter = new MenuPagerAdapter (SupportFragmentManager, menuManager);

			viewPager = FindViewById<ViewPager>(Resource.Id.menuPager);
			viewPager.Adapter = menuPagerAdapter;

			var indicator = FindViewById<CirclePageIndicator>(Resource.Id.indicator);
			indicator.SetViewPager(viewPager);

		}
	}
}

