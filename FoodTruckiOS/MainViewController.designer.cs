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
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnNext { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnPrevious { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblMenuTitle { get; set; }

		[Action ("btnNext_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnNext_TouchUpInside (UIButton sender);

		[Action ("btnPrevious_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnPrevious_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnNext != null) {
				btnNext.Dispose ();
				btnNext = null;
			}
			if (btnPrevious != null) {
				btnPrevious.Dispose ();
				btnPrevious = null;
			}
			if (lblMenuTitle != null) {
				lblMenuTitle.Dispose ();
				lblMenuTitle = null;
			}
		}
	}
}
