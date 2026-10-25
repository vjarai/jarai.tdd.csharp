namespace jarai.tdd6.DependencyInjection.DIY.Application;

public class UserInterface
{
    public UserInterface(IViewModel viewModel)
    {
        ViewModel = viewModel;
    }

    public IViewModel ViewModel { get; set; }
}