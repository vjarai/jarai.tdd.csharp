namespace jarai.tdd4b.Adapter;

public class ApplePhone
{
    public void Charge(AppleCharger appleCharger)
    {
        int strom = appleCharger.LiefereStromViaLightning();

        Console.WriteLine($"ApplePhone lädt mit {strom} mA");
    }
}