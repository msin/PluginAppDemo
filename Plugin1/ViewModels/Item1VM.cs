using System;

namespace Plugin1.ViewModels
{
    public class Item1VM
    {
        public virtual int Id { get; set; }
        public virtual int ParentId { get; set; }
        public virtual string Item { get; set; }
        public virtual DateTime Date { get; set; }

        public Item1VM(int id, int parent)
        {
            Id = id;
            ParentId = parent;
            Item = "Item" + id;
            Date = DateTime.Today;
        }
    }
}
