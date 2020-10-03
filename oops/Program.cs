using System;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macbookAir = new MacBookAir();
            Laptop asusZenbook = new AsusZenbook();

            macbookAir.TurnOn();
            macbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();

            Console.WriteLine(macbookAir.TouchScreen);
            Console.WriteLine(asusZenbook.TouchScreen);

        }
    }
}
