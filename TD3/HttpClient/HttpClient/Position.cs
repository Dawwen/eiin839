namespace HttpClientJson
{
    internal class Position
    {
        public float lat { get; set; }
        public float lng { get; set; }

        public override string ToString()
        {
            return "Latitude: " + lat + "  Co-Longitude: " + lng;
        }
    }
}