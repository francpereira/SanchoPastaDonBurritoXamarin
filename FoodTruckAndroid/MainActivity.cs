using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FoodTruckClassLibrary;

namespace FoodTruckAndroid
{
	[Activity (Label = "FoodTruckAndroid", Icon = "@drawable/newicon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		Button buttonPrev;
		Button buttonNext;
		TextView menuName;
		TextView menuDescription;
		ImageView imgMenu;

		MenuManager menu;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			menu = new MenuManager();
			menu.GetAllMenuOptions();

			buttonPrev = FindViewById<Button> (Resource.Id.btnMovePrevious);
			buttonNext = FindViewById<Button> (Resource.Id.btnMoveNext);
			menuName = FindViewById<TextView> (Resource.Id.txtMenuName);
			menuDescription = FindViewById<TextView> (Resource.Id.txtMenuDescription);
			imgMenu = FindViewById<ImageView> (Resource.Id.imgMenu);

			UpdateUI();

			buttonNext.Click += delegate {
				menu.MoveNext();
				UpdateUI();
 			};

			buttonPrev.Click += delegate {
				menu.MovePrevious();
				UpdateUI();
			};
		}

		private void UpdateUI()
		{
			menuName.Text = menu.CurrentMenuOption().name;
			menuDescription.Text = menu.CurrentMenuOption().description;
		
			int resourceInt = Resources.GetIdentifier (menu.CurrentMenuOption().imageFile, "drawable", "FoodTruckAndroid.FoodTruckAndroid");
			imgMenu.SetImageResource(resourceInt);

	    }
	}
}


