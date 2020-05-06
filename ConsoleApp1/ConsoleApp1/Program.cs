using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri address2 = new Uri("https://intra.ema.kpmg.com/sites/ZA/HR/Lists/My%20Performance%20Development%20%20MyPD%20%20%20promoted%20links/Tiles.aspx#InplviewHash75cbd3f1-b3bf-45a4-a370-a2059dbc3195=ShowInGrid%3DTrue");

            Console.WriteLine("Hello World!" + address2.AbsolutePath);
        }
    }
}
