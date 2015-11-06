using System.Collections.ObjectModel;
using System.Linq;
using CIL;
using CIL.Interfaces;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ShellAppDemo.ViewModels
{
    public class MainVM : IMain
    {
        public virtual ObservableCollection<IPlugin> Plugins { get; set; }
        public virtual IPlugin SelectedPlugin { get; set; }
        public virtual IForm SelectedForm { get; set; }
        public virtual bool IsBusy { get; set; }

        private IDispatcherService _dispatcherService;
        private ISplashScreenService _splashScreenService;
        private INavigationService _frameService;

        public void OnLoaded()
        {
            _dispatcherService = this.GetService<IDispatcherService>();
            _splashScreenService = this.GetService<ISplashScreenService>();
            _frameService = this.GetService<INavigationService>();

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
            _frameService.Navigate(SelectedForm.View, null, this);
        }

        protected void OnIsBusyChanged()
        {
            if (IsBusy)
                _dispatcherService.BeginInvoke(() => _splashScreenService.ShowSplashScreen());
            else
                _dispatcherService.BeginInvoke(() => _splashScreenService.HideSplashScreen());
        }
    }
}
