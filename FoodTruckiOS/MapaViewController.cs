using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using MonoTouch.MapKit;
using MonoTouch.CoreLocation;

namespace FoodTruckiOS
{
	partial class MapaViewController : UIViewController
	{


		public MapaViewController (IntPtr handle) : base (handle)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			// set map center and region
			double lat = 18.413615; 
			double lon = -66.098316;
			var mapCenter = new CLLocationCoordinate2D (lat, lon);
			var mapRegion = MKCoordinateRegion.FromDistance (mapCenter, 2000, 2000);
			map.CenterCoordinate = mapCenter;
			map.Region = mapRegion;


			// add an annotation
			map.AddAnnotation (new MKPointAnnotation (){
				Title="Sancho Pasta y Don Burrito",
				Coordinate = new CLLocationCoordinate2D (lat, lon)
			});


		}


	}
}
