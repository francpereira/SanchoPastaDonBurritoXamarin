// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FoodTruckiOS
{
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgMenu { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblPrecio { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView viewNameDescription { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgMenu != null) {
				imgMenu.Dispose ();
				imgMenu = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
			if (lblPrecio != null) {
				lblPrecio.Dispose ();
				lblPrecio = null;
			}
			if (txtDescription != null) {
				txtDescription.Dispose ();
				txtDescription = null;
			}
			if (viewNameDescription != null) {
				viewNameDescription.Dispose ();
				viewNameDescription = null;
			}
		}
	}
}
