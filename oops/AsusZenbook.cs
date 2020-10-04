using System;

public class AsusZenbook : Laptop
{
    public override void TurnOn()
    {
        base.PowerOnSelfTest();
        this.BIOSROM();
        this.BootLoader();
        this.OSConfig();
        this.Security();
        Console.WriteLine("Turn on specific to Asus Zenbook");
    }

    private void BIOSROM()
    {
        Console.WriteLine("BIOS ROM process");
    }
    private void BootLoader()
    {
        Console.WriteLine("BootLoader process");
    }
    private void OSConfig()
    {
        Console.WriteLine("OS config process");
    }
    private void Security()
    {
        Console.WriteLine("Security logon process");
    }
}