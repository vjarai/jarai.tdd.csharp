namespace jarai.tdd6.DependencyInjection.DIY.Application;

public interface IViewModel
{
    Buchhaltung Buchhaltung { get; set; }
    Lagerverwaltung Lagerverwaltung { get; set; }
}

public class ViewModel : IViewModel
{
    public ViewModel(Lagerverwaltung lagerverwaltung, Buchhaltung buchhaltung)
    {
        Lagerverwaltung = lagerverwaltung;
        Buchhaltung = buchhaltung;
    }

    public Buchhaltung Buchhaltung { get; set; }

    public Lagerverwaltung Lagerverwaltung { get; set; }
}