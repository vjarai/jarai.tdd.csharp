namespace jarai.tdd4b.Adapter;

public class AppleCharger
{
    public virtual int LiefereStromViaLightning()
    {
        var strom = 1000;

        Console.WriteLine($"AppleCharger liefert {strom} mA via Lightning");

        return strom;
    }
}