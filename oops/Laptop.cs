using System;

public interface Laptop
{
    void TurnOn()
    {
        Console.WriteLine("Turning on.");

    }
    void TurnOff()
    {
        Console.WriteLine("Turning off.");
    }
    bool TouchScreen { get; }
}