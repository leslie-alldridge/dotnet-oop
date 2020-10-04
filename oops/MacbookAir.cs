using System;

public class MacbookAir : Laptop
{
    public override void TurnOn()
    {
        this.BootROMLoaded();
        this.BootROMRunning();
        base.PowerOnSelfTest();
        this.FindBooterFile();
        Console.WriteLine("Turn on specific to Macbook Air");
    }

    private void BootROMLoaded()
    {
        Console.WriteLine("Boot ROM loaded.");
    }
    private void BootROMRunning()
    {
        Console.WriteLine("Boot ROM Running.");
    }
    private void FindBooterFile()
    {
        Console.WriteLine("FindBooterFile Running.");
    }
}