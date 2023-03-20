using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    internal class Item
    {
        public string Name;
        public int Quantity;
        public int Value;

        public Item(string name, int quant, int val) 
        {
            Name = name;
            Quantity = quant;
            Value = val;
        }

        public Item(string[] data)
        {
            Name = data[0];
            Quantity = int.Parse(data[1]);
            Value = int.Parse(data[2]);
        }

        
    }
}
