using System.Collections.ObjectModel;

namespace CIL.Interfaces
{
    public interface IPlugin
    {
        ObservableCollection<IForm> Forms { get; set; }
        string Name { get; set; }
        string Desc { get; set; }
    }
}
