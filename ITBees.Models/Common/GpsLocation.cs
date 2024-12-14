namespace ITBees.Models.Common
{

    public partial class GpsLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ushort Altitude { get; set; }

        public GpsLocation()
        {

        }

        public GpsLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public GpsLocation(double latitude, double longitude, ushort altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }
    }
}