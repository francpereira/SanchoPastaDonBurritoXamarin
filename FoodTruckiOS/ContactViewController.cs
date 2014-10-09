using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FoodTruckiOS
{
	partial class ContactViewController : UIViewController
	{
		public ContactViewController (IntPtr handle) : base (handle)
		{

		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			viewTelefonoLabel.Layer.CornerRadius = 10f;
			viewEmailLabel.Layer.CornerRadius = 10f;
			viewFaceBookLabel.Layer.CornerRadius = 10f;
		}

	}
}
