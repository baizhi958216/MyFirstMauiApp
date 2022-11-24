using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyFirstMauiApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrEmpty(text))
            return;
        Items.Add(text);
        //Add out item
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}
