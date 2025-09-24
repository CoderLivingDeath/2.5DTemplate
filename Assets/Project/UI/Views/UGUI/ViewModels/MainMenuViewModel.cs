using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using UnityEngine;

public partial class MainMenuViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string title = "Project";

    [ObservableProperty]
    private string play_btn_text = "Play";

    [ObservableProperty]
    private string settings_btn_text = "Settings";

    [ObservableProperty]
    private string exit_btn_text = "Exit";

    [RelayCommand]
    public void Play()
    {
        Debug.Log("Play");
    }

    [RelayCommand]
    public void Settings()
    {
    }

    [RelayCommand]
    public void Exit()
    {
    }
}