using System;

namespace Get_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Data.Get_Temperature(Data.Cities.Kyiv));
            Console.WriteLine(Data.Get_Temperature(Data.Cities.Odesa));
        }
    }
}
