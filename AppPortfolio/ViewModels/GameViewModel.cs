using CommunityToolkit.Mvvm.ComponentModel;

namespace AppPortfolio.ViewModels;

public partial class GameViewModel : Global
{
    [ObservableProperty]
    bool _isAnimationPlayGif;
    public GameViewModel()
    {
        LoadGif();
    }

    private async void LoadGif()
    {
        await Task.Delay(1000); 
        IsAnimationPlayGif = true;
    }
}
