﻿using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using WpfApp.Views;

namespace WpfApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override IContainerExtension CreateContainerExtension() => new UnityContainerExtension();

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        ContainerRegistration.RegisterTypes(containerRegistry);
    }

    protected override Window CreateShell() => Container.Resolve<MainWindow>();

    protected override void InitializeShell(Window shell)
    {
        base.InitializeShell(shell);

        shell?.Show();
    }
}