﻿using HouseMovingAssistant.Helpers;
using HouseMovingAssistant.Views;

namespace HouseMovingAssistant;

public partial class App : Application
{
	public static Realms.Sync.App RealmApp;
	public App()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(TaskStatsPage), typeof(TaskStatsPage));
		Routing.RegisterRoute(nameof(EditTaskPage), typeof(EditTaskPage));

        RealmApp = Realms.Sync.App.Create(AppConfig.RealmAppId);
        MainPage = new AppShell();
	}

	protected override void OnStart()
    {
		
    }
}
