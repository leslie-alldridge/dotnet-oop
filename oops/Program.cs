using System;
using System.Collections.Generic;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop asusZenbook = new AsusZenbook();
            Laptop macbookAir = new MacbookAir();

            asusZenbook.TurnOn();
            macbookAir.TurnOn();

        }
    }
}
