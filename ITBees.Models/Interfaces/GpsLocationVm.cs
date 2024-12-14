using ITBees.Models.Common;

namespace ITBees.Models.Interfaces
{

    public class GpsLocationVm
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ushort Altitude { get; set; }

        public GpsLocationVm()
        {
            
        }

        public GpsLocationVm(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public GpsLocationVm(double latitude, double longitude, ushort altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        public GpsLocationVm(GpsLocation x)
        {
            Latitude = x.Latitude;
            Longitude = x.Longitude;
            Altitude = x.Altitude;
        }
    }
}