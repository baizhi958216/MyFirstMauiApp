﻿using Microsoft.Extensions.Logging;
using MyFirstMauiApp.ViewModel;

namespace MyFirstMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();
		
		//每次进入都实例化一次
		builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailViewModel>();
		return builder.Build();
    }
}
