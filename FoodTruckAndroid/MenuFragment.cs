
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
		int bundlePosition;

		public static Fragment NewInstance (int position)
		{
			MenuFragment f = new MenuFragment ();
			// Supply num input as an argument.
			Bundle args = new Bundle();
			args.PutInt("position", position);

			f.Arguments = args;

			return f;

		}

		//public MenuOption menu { get; set;}


		//

		//TextView menuName;
		//TextView menuDescription;
		//ImageView imgMenu;
		//TextView menuPrice;


		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			bundlePosition = Arguments != null ? Int32.Parse(Arguments.Get("position").ToString()) : 1;

		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View viewRoot = inflater.Inflate (Resource.Layout.MenuFragment, container, false);

			TextView menuName = viewRoot.FindViewById<TextView> (Resource.Id.txtMenuName);
			TextView menuDescription = viewRoot.FindViewById<TextView> (Resource.Id.txtMenuDescription);
			ImageView imgMenu = viewRoot.FindViewById<ImageView> (Resource.Id.imgMenu);
			TextView menuPrice = viewRoot.FindViewById<TextView> (Resource.Id.txtMenuPrice);

			MenuManager allMenu= new MenuManager();
			allMenu.GetAllMenuOptions();
		    allMenu.MoveTo (bundlePosition);
			MenuOption menu = allMenu.CurrentMenuOption();


			menuName.Text = menu.name;
			menuDescription.Text = menu.description;
			menuPrice.Text = String.Format("{0:C}", menu.price);//.ToString();

			int resourceInt = Resources.GetIdentifier (menu.imageFile, "drawable", "FoodTruckAndroid.FoodTruckAndroid");
			imgMenu.SetImageResource(resourceInt);

			return viewRoot;

		}
	}
}

