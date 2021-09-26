using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
    public class Order
    {
        public string Description { get; set; }

        public int Id { get; }

        private static List<Item> _instances = new List<Item> { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }
    }
}
