using System.Collections.ObjectModel;
using CIL.Interfaces;
using DevExpress.Mvvm.POCO;

namespace Plugin2.ViewModels
{
    public class ViewModel2
    {
        private readonly IMain _main;

        public virtual ObservableCollection<Item2VM> Items { get; set; }

        public ViewModel2(IMain main)
        {
            _main = main;
        }

        public void OnLoaded()
        {
            var factory = ViewModelSource.Factory((int id, int parent) => new Item2VM(id, parent));

            Items = new ObservableCollection<Item2VM>
            {
                factory(10, 0),
                factory(20, 0),
                factory(30, 0),
                factory(40, 0),
                factory(50, 0),
                factory(60, 10),
                factory(70, 20),
                factory(80, 30),
                factory(90, 40),
                factory(100, 50),
            };
        }
    }
}
