using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using FoodTruckClassLibrary;

namespace FoodTruckiOS
{
	partial class MenuViewController : UIViewController
	{

		public MenuOption menuOption { get; set;} 
		public int MenuOptionPosition { get; set; }

		public MenuViewController (IntPtr handle) : base (handle)
		{
		}



		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UpdateUI();
		}

		void UpdateUI ()
		{
			lblName.Text = menuOption.name;
			txtDescription.Text = menuOption.description;
			imgMenu.Image = UIImage.FromBundle (menuOption.imageFile + ".jpg");

		}
	}
}
