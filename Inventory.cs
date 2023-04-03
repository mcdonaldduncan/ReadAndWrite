using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    /// <summary>
    /// The inventory is just a wrapper for a List of Items
    /// Theoretically, you could add additional methods to an inventory to handle unique add/remove behavior or any other complexities you might need
    /// </summary>
    internal class Inventory
    {
        public List<Item> Items;

        public Inventory() 
        {
            Items = new List<Item>();
        }
    }
}
