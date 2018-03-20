using System;

namespace ChillAndHeat
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Wind chill: 35.74 + 0.6215T - 35.75(V^0.16) + 0.4275T(V^0.16)
			double t = 45.0; // in fahrenhiet
			double v = 15.0; // in MPH
			double windChill = 35.74 + 0.6215 * t - 35.75 * Math.Pow(v, 0.16) + 0.4275 * t * Math.Pow(v, 0.16);

			Console.WriteLine("Wind chill: " + windChill);


			// Heat Index = -42.379 + 2.04901523T + 10.14333127R
			// - 0.22475541TR
			// - 6.83783 x 10-3T^2
			// - 5.481717 x 10 - 2R^2 
			// + 1.22874 x 10 - 3T^2R 
			// + 8.5282 x 10 - 4TR^2 
			// - 1.99 x 10 - 6T^2R^2
			t = 90.0; // in fahrenheit
			double r = 85; // in percent
			double heatIndex = -42.379 + 2.04901523 * t + 10.14333127 * r
			                      - 0.22475541 * t * r
			                      - 0.00683783 * Math.Pow(t,2)
			                      - 0.05481717 * Math.Pow(r,2)
			                      + 0.00122874 * Math.Pow(t,2) * r 
			                      + 0.00085282 * t * Math.Pow(r,2)
			                      - 0.00000199 * Math.Pow(t,2) * Math.Pow(r,2);

			Console.WriteLine("Heat index: " + heatIndex);
		}
	}
}
