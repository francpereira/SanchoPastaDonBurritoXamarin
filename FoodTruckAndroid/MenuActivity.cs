
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

namespace FoodTruckAndroid
{
	[Activity (Label = "Don Burrito y Sancho Pasta", Icon = "@drawable/newicon")]		
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

			actionBar.AddTab (tab);

			tab = actionBar.NewTab ();
			tab.SetText("Mapa");
			//tab.SetIcon(Resource.Drawable.tab_terms);
			tab.TabSelected += (sender, e) => {

				//var geoUri = Android.Net.Uri.Parse ("geo:18.413615,-66.098316");
				var geoUri = Android.Net.Uri.Parse ("geo:18.413615,-66.098316?z=17&q=18.413615,-66.098316(Don Burrito y Sancho Pasta)");
				var mapIntent = new Intent (Intent.ActionView, geoUri);
			    StartActivity (mapIntent);
				//Intent intent = new Intent(Intent.ActionView, geoUri);


				//var streetViewUri = Android.Net.Uri.Parse (
				//	"google.streetview:cbll=18.413615,-66.098316&cbp=1,90,,0,1.0&mz=20");  
				//var streetViewIntent = new Intent (Intent.ActionView, streetViewUri);  
				//StartActivity (streetViewIntent);

			};
			actionBar.AddTab (tab);

			tab = actionBar.NewTab ();
			tab.SetText ("Contactenos");
			//tab.SetIcon (Resource.Drawable.tab_home);
			tab.TabSelected += (sender, e) => {

				StartActivity(typeof(MapActivity));
			
			};
			actionBar.AddTab (tab);





			menuPagerAdapter = new MenuPagerAdapter (SupportFragmentManager, menuManager);

			viewPager = FindViewById<ViewPager>(Resource.Id.menuPager);
			viewPager.Adapter = menuPagerAdapter;



		}
	}
}

