using System.Collections.ObjectModel;
using CIL.Interfaces;
using CIL.ViewModels;

namespace Plugin2.ViewModels
{
    public class PluginVM : IPlugin
    {
        public virtual ObservableCollection<IForm> Forms { get; set; }
        public virtual string Name { get; set; }
        public virtual string Desc { get; set; }

        public PluginVM()
        {
            Name = "Plugin2";
            Desc = "Plugin2 Description";

            Forms = new ObservableCollection<IForm>
            {
                FormVM.Factory("P2View1",
                    "TableView",
                    "Plugin2 View1 description",
                    "pack://application:,,,/DevExpress.Images.v15.1;component/Images/Grid/Grid_32x32.png"),

                FormVM.Factory("P2View2",
                    "CardView",
                    "Plugin2 View2 description",
                    "pack://application:,,,/DevExpress.Images.v15.1;component/Images/Grid/Cards_32x32.png"),

                FormVM.Factory("P2View3",
                    "TreeView",
                    "Plugin2 View3 description",
                    "pack://application:,,,/DevExpress.Images.v15.1;component/Images/Filter Elements/TreeView_32x32.png"),
            };
        }
    }
}
