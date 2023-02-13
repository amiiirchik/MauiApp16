﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace MauiApp16;

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

        builder.UseMauiCommunityToolkit();
        builder.UseMauiCommunityToolkitMediaElement();
        builder.UseMauiCommunityToolkitCore();
        builder.UseMauiCommunityToolkitMarkup();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
