namespace jarai.tdd2.OutsideInTDD.Tests;

public class FakeKalenderService : IKalenderService
{
    public DateTime Now()
    {
        return new DateTime(2023, 1, 1);
    }
}