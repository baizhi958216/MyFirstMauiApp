using MyFirstMauiApp.ViewModel;

namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
        InitializeComponent();//定义在xaml的组件会在此时实例化
        BindingContext = vm;
    }
}

