using System.Collections.ObjectModel;
using System.Linq;
using CIL;
using CIL.Interfaces;
using DevExpress.Mvvm;

namespace ShellAppDemo.ViewModels
{
    public class MainVM : IMain
    {
        public virtual ObservableCollection<IPlugin> Plugins { get; set; }
        public virtual IPlugin SelectedPlugin { get; set; }
        public virtual IForm SelectedForm { get; set; }

        protected virtual INavigationService FrameService { get { return null; } }

        public void OnLoaded()
        {
            var plugins = IoC.Instance.GetAllInstances<IPlugin>();

            Plugins = new ObservableCollection<IPlugin>(plugins);

            SelectedPlugin = Plugins.FirstOrDefault();
        }

        protected void OnSelectedPluginChanged()
        {
            SelectedForm = SelectedPlugin.Forms.FirstOrDefault();
        }

        protected void OnSelectedFormChanged()
        {
            FrameService.Navigate(SelectedForm.View, null, this);
        }
    }
}
