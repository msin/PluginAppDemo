using System.Windows.Controls;
using DevExpress.Xpf.WindowsUI.Navigation;

namespace CIL.Controls
{
    public class NavControl : UserControl, INavigationAware
    {
        public void NavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter == null) return;


            DataContext = e.Parameter;
        }

        public void NavigatingFrom(NavigatingEventArgs e)
        { }

        public void NavigatedFrom(NavigationEventArgs e)
        { }
    }
}
