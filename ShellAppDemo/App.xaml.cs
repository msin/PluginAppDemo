using System;
using System.IO;
using System.Windows;
using CIL;
using CIL.Interfaces;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo.Logger;
using ShellAppDemo.ViewModels;

namespace ShellAppDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;

            Bootstrap();

            new MainWindow().Show();
        }

        private void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            File.WriteAllText("FatalError " + DateTime.Now.ToString("yy-MM-dd HH-mm-ss") + ".log", e.ExceptionObject.ToString());
        }

        private static void Bootstrap()
        {
            IoC.Instance.RegisterSingleton(typeof(IMain), ViewModelSource.GetPOCOType(typeof(MainVM)));

            var builder = new ShellBuilder();
            builder.Build();

            IoC.Instance.Verify();
        }

        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e)
        {
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
