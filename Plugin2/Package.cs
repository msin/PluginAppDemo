using CIL;
using DevExpress.Mvvm.POCO;
using Plugin2.ViewModels;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Plugin2
{
    public class Package : IPackage
    {
        public void RegisterServices(Container container)
        {
            IoC.PluginTypes.Add(ViewModelSource.GetPOCOType(typeof(PluginVM)));

            IoC.Instance.RegisterSingleton(typeof(ViewModel2), ViewModelSource.GetPOCOType(typeof(ViewModel2)));
        }
    }
}
