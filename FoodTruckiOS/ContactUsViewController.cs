
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FoodTruckiOS
{
	public partial class ContactUsViewController : UIViewController
	{
		public ContactUsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//.Layer.CornerRadius = 10f; 

			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

