using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FoodTruckiOS
{
	partial class MenuViewController : UIViewController
	{
		public MenuViewController (IntPtr handle) : base (handle)
		{
		}

		partial void btnPrev_TouchUpInside (UIButton sender)
		{
			lblName.Text = "Prev Clicked";
		}

		partial void btnNext_TouchUpInside (UIButton sender)
		{
			lblName.Text = "Next Clicked";
		}
	}
}
