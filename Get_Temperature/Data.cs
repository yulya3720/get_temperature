using System;
using System.Collections.Generic;
using System.Text;

namespace Get_Temperature
{
    public static class Data
    {
        public enum Cities
        {
            Kyiv,
            Odesa
        }

        public static Dictionary<Cities, string> Temperatures = new Dictionary<Cities, string>
        {
            {Cities.Kyiv, ""},
            {Cities.Odesa, ""}
        };

        public static string Get_Temperature(Cities city)
        {
            Logic.SendTempRequest(city).Wait();
            return Temperatures[city];
        }
    }
}
