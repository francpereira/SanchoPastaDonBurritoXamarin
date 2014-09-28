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
	[Register ("MapaViewController")]
	partial class MapaViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.MapKit.MKMapView map { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (map != null) {
				map.Dispose ();
				map = null;
			}
		}
	}
}
