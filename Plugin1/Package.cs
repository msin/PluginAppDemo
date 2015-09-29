using CIL;
using DevExpress.Mvvm.POCO;
using Plugin1.ViewModels;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace Plugin1
{
    public class Package : IPackage
    {
        public void RegisterServices(Container container)
        {
            IoC.PluginTypes.Add(ViewModelSource.GetPOCOType(typeof(PluginVM)));

            IoC.Instance.RegisterSingleton(typeof(ViewModel1), ViewModelSource.GetPOCOType(typeof(ViewModel1)));
        }
    }
}
