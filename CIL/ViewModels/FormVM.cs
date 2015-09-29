using System;
using CIL.Interfaces;
using DevExpress.Mvvm.POCO;

namespace CIL.ViewModels
{
    public class FormVM : IForm
    {
        public static readonly Func<string, string, string, string, IForm> Factory =
            ViewModelSource.Factory((string view, string name, string desc, string icon) => new FormVM(view, name, desc, icon));

        public virtual string Icon { get; set; }
        public virtual string View { get; set; }
        public virtual string Name { get; set; }
        public virtual string Desc { get; set; }

        public FormVM(string view, string name, string desc, string icon)
        {
            View = view;
            Name = name;
            Desc = desc;
            Icon = icon;
        }
    }
}
