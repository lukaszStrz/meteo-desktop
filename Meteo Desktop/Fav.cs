namespace Meteo_Desktop
{
    class Fav
    {
        public string Name { get; set; }

        public Meteo_Lib.Coordinates Coord { get; set; }

        public Fav(string key, string val)
        {
            Name = key;
            var vals = val.Trim().Split(';');
            double lat, lng;
            if (vals.Length == 2 && double.TryParse(vals[0], out lat) && double.TryParse(vals[1], out lng))
            {
                Coord = new Meteo_Lib.Coordinates(lat, lng);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
