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
		UIButton btnNext { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnPrev { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblName { get; set; }

		[Action ("btnNext_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnNext_TouchUpInside (UIButton sender);

		[Action ("btnPrev_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnPrev_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnNext != null) {
				btnNext.Dispose ();
				btnNext = null;
			}
			if (btnPrev != null) {
				btnPrev.Dispose ();
				btnPrev = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
		}
	}
}
