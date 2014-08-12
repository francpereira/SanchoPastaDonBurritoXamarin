
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace FoodTruckAndroid
{
	[Activity (Label = "MapActivity")]			
	public class MapActivity : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MapActivity);

			MapFragment mapFrag = (MapFragment) FragmentManager.FindFragmentById(Resource.Id.map);
			GoogleMap map = mapFrag.Map;
			if (map != null) {
				// The GoogleMap object is ready to go.
				map.MapType = GoogleMap.MapTypeNormal;

				//GoogleMapOptions mapOptions = new GoogleMapOptions()
				LatLng location = new LatLng (18.413615, -66.098316);
				CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
				builder.Target (location);
				builder.Zoom (15);


				CameraPosition cameraPosition = builder.Build();
				CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition (cameraPosition);

				map.MoveCamera(cameraUpdate);

				MarkerOptions markerOpt1 = new MarkerOptions();
				markerOpt1.SetPosition(new LatLng(18.413615, -66.098316));
				markerOpt1.SetTitle("Sancho Pasta y Don Burrito");
				map.AddMarker(markerOpt1);

			}
		}
	}
}

