using System.Collections.ObjectModel;
using CIL.Interfaces;
using CIL.ViewModels;

namespace Plugin1.ViewModels
{
    public class PluginVM : IPlugin
    {
        public virtual ObservableCollection<IForm> Forms { get; set; }
        public virtual string Name { get; set; }
        public virtual string Desc { get; set; }

        public PluginVM()
        {
            Name = "Plugin1";
            Desc = "Plugin1 Description";

            Forms = new ObservableCollection<IForm>
            {
                FormVM.Factory("P1View1",
                    "TableView",
                    "Plugin1 View1 description",
                    "pack://application:,,,/DevExpress.Images.v15.1;component/Images/Grid/Grid_32x32.png"),

                FormVM.Factory("P1View2",
                    "CardView",
                    "Plugin1 View2 description",
                    "pack://application:,,,/DevExpress.Images.v15.1;component/Images/Grid/Cards_32x32.png"),

                FormVM.Factory("P1View3",
                    "TreeView",
                    "Plugin1 View3 description",
                    "pack://application:,,,/DevExpress.Images.v15.1;component/Images/Filter Elements/TreeView_32x32.png"),
            };
        }
    }
}
