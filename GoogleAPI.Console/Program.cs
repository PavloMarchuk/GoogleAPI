using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAPI.Console
{
	class Program
	{
		static void Main(string[] args)

		{
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
			//System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("uk_UA");
			
			string address = "Оболонський проспект, 36Д, Київ";

		
				

			/*string strUrl = string.Format("http://maps.google.com./maps/api/geocode/json&address={0}&sensor=false", System.Web.HttpUtility.UrlEncode(address));*/

			GoogleLocationService locationService = new GoogleLocationService();
			MapPoint point = locationService.GetLatLongFromAddress(address);
			// витягти адресу з координат (можна )
			//locationService.GetAddressFromLatLang(point.Latitude, point.Longitude);
			
			System.Console.WriteLine($"{point.Latitude},{point.Longitude}");
			//50.519432,30.5003759

				// витягти адресу з координат (можна )
				AddressData add = locationService.GetAddressFromLatLang(50.519432, 30.5003759);
			System.Console.WriteLine(add.Address);

		}
	}
}
