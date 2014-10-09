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

			viewNameDescription.Layer.CornerRadius = 10f; 

			UpdateUI();
		}

		void UpdateUI ()
		{
			lblName.Text = menuOption.name;
			txtDescription.Text = menuOption.description;
			lblPrecio.Text = String.Format ("{0:C}", menuOption.price.ToString());
			imgMenu.Image = UIImage.FromBundle (menuOption.imageFile + ".jpg");

		}
	}
}
