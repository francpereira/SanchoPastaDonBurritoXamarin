using System;
using Android.Support.V4.App;
using FoodTruckClassLibrary;

namespace FoodTruckAndroid
{
	public class MenuPagerAdapter : FragmentStatePagerAdapter
	{

		MenuManager menuManager;

		public MenuPagerAdapter (FragmentManager fm, MenuManager mm):base(fm)
		{
			menuManager = mm;
		}

		#region implemented abstract members of PagerAdapter

		public override int Count {
			get {
				return menuManager.Length;
			}
		}

		#endregion

		#region implemented abstract members of FragmentStatePagerAdapter

		public override Fragment GetItem (int position)
		{
			//menuManager.MoveTo(position);
			//MenuFragment mf = new MenuFragment ();
			//mf.menu = menuManager.CurrentMenuOption(); 
			return MenuFragment.NewInstance(position);
		}

		#endregion


	}
}

