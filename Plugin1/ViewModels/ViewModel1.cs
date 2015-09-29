using System.Collections.ObjectModel;
using CIL.Interfaces;
using DevExpress.Mvvm.POCO;

namespace Plugin1.ViewModels
{
    public class ViewModel1
    {
        private readonly IMain _main;

        public virtual ObservableCollection<Item1VM> Items { get; set; }

        public ViewModel1(IMain main)
        {
            _main = main;
        }

        public void OnLoaded()
        {
            var factory = ViewModelSource.Factory((int id, int parent) => new Item1VM(id, parent));

            Items = new ObservableCollection<Item1VM>
            {
                factory(1, 0),
                factory(2, 0),
                factory(3, 0),
                factory(4, 0),
                factory(5, 0),
                factory(6, 1),
                factory(7, 2),
                factory(8, 3),
                factory(9, 4),
                factory(10, 5),
            };
        }
    }
}
