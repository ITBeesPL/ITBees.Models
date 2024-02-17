using ITBees.Models.Common;

namespace ITBees.Models.Interfaces
{

    public class GpsLocationVm
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GpsLocationVm()
        {
            
        }

        public GpsLocationVm(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public GpsLocationVm(GpsLocation x)
        {
            Latitude = x.Latitude;
            Longitude = x.Longitude;
        }
    }
}