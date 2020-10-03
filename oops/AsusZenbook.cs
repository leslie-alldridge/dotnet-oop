using System;

public class AsusZenbook : Laptop
{
    public bool TouchScreen => true;
    public void TurnOn()
    {
        Console.WriteLine("Turn on specific to Asus Zenbook");
    }
    public void TurnOff()
    {
        Console.WriteLine("Turning off Zenbook");
    }
}