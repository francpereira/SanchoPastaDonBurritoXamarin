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
	[Register ("ContactViewController")]
	partial class ContactViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView lblEmail { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView lblPhoneNum { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView lblUrlFacebook { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView viewEmailLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView viewFaceBookLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView viewTelefonoLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblEmail != null) {
				lblEmail.Dispose ();
				lblEmail = null;
			}
			if (lblPhoneNum != null) {
				lblPhoneNum.Dispose ();
				lblPhoneNum = null;
			}
			if (lblUrlFacebook != null) {
				lblUrlFacebook.Dispose ();
				lblUrlFacebook = null;
			}
			if (viewEmailLabel != null) {
				viewEmailLabel.Dispose ();
				viewEmailLabel = null;
			}
			if (viewFaceBookLabel != null) {
				viewFaceBookLabel.Dispose ();
				viewFaceBookLabel = null;
			}
			if (viewTelefonoLabel != null) {
				viewTelefonoLabel.Dispose ();
				viewTelefonoLabel = null;
			}
		}
	}
}
