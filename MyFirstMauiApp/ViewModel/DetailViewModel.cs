﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMauiApp.ViewModel;

[QueryProperty("Text","Text")]
public partial class DetailViewModel:ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
