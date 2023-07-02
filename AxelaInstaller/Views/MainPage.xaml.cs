using AxelaInstaller.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace AxelaInstaller.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
