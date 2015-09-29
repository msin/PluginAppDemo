using System.Collections.ObjectModel;

namespace CIL.Interfaces
{
    public interface IMain
    {
        ObservableCollection<IPlugin> Plugins { get; set; }
        IPlugin SelectedPlugin { get; set; }
        IForm SelectedForm { get; set; }
    }
}
