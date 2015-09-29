using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CIL;
using CIL.Interfaces;
using DevExpress.Mvvm.UI;
using SimpleInjector;

namespace ShellAppDemo
{
    public class ShellBuilder
    {
        /// <summary>
        /// Registering plugins dynamically
        /// https://simpleinjector.readthedocs.org/en/latest/advanced.html#plugins
        /// </summary>
        public void Build()
        {
            var pluginDirectory = AppDomain.CurrentDomain.BaseDirectory;

            var assemblies = new DirectoryInfo(pluginDirectory).GetFiles()
                .Where(file => file.Extension == ".dll" && file.Name.StartsWith("Plugin"))
                .Select(file => Assembly.LoadFile(file.FullName))
                .ToList();

            ViewLocator.Default = new ViewLocator(assemblies);

            IoC.Instance.RegisterPackages(assemblies);

            IoC.Instance.RegisterCollection<IPlugin>(IoC.PluginTypes);
        }
    }
}
