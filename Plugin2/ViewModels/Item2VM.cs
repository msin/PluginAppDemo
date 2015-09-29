using System;

namespace Plugin2.ViewModels
{
    public class Item2VM
    {
        public virtual int Id { get; set; }
        public virtual int ParentId { get; set; }
        public virtual string Item { get; set; }
        public virtual DateTime Date { get; set; }

        public Item2VM(int id, int parent)
        {
            Id = id;
            ParentId = parent;
            Item = "Item" + id;
            Date = DateTime.Today;
        }
    }
}
