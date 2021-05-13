using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using WayGuideManager.Helpers;
using WayGuideManager.Views;

namespace WayGuideManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return this.Container.Resolve<Shell>();
        }

        protected override void InitializeShell(Window shell)
        {
            Application.Current.MainWindow = shell;
            Application.Current.MainWindow.Hide();
        }

        protected override void OnInitialized()
        {
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var splashScreen = new SplashView();
            splashScreen.Show();
            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith(async _ =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                splashScreen.Close();
                Application.Current.MainWindow.Show();
            }, TaskScheduler.FromCurrentSynchronizationContext());
            
        }
        public const string Splash = "Splash";
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<object, SplashView>(ViewKeys.Splash);
            containerRegistry.Register<object, WayGuideManagerMain>(ViewKeys.WayGuideManagerHome);
            containerRegistry.Register<object, PasswordView>(ViewKeys.PasswordView);
        }
    }
}
