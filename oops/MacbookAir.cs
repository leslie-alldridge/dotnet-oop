using System;
public class MacBookAir : Laptop
{
    public bool TouchScreen => false;

    public void TurnOff()
    {
        Console.WriteLine("Turning off Macbook Air");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on Macbook Air");
    }
}