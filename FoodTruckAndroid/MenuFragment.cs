
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using FoodTruckClassLibrary;
using Android.Support.V4.App;

namespace FoodTruckAndroid
{
	public class MenuFragment : Fragment
	{
		public MenuOption menu { get; set;}

		TextView menuName;
		TextView menuDescription;
		ImageView imgMenu;
		TextView menuPrice;


		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View viewRoot = inflater.Inflate (Resource.Layout.MenuFragment, container, false);

			menuName = viewRoot.FindViewById<TextView> (Resource.Id.txtMenuName);
			menuDescription = viewRoot.FindViewById<TextView> (Resource.Id.txtMenuDescription);
			imgMenu = viewRoot.FindViewById<ImageView> (Resource.Id.imgMenu);
			menuPrice = viewRoot.FindViewById<TextView> (Resource.Id.txtMenuPrice);

			menuName.Text = menu.name;
			menuDescription.Text = menu.description;
			menuPrice.Text = String.Format("{0:C}", menu.price);//.ToString();

			int resourceInt = Resources.GetIdentifier (menu.imageFile, "drawable", "FoodTruckAndroid.FoodTruckAndroid");
			imgMenu.SetImageResource(resourceInt);

			return viewRoot;

		}
	}
}

