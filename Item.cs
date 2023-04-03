using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    /// <summary>
    /// Item is a class that represents a set of items in our theoretical game/shop
    /// </summary>
    internal class Item
    {
        // Name, Quantity, and Value are the data points that make up a single Item or Item instance
        public string Name;
        public int Quantity;
        public int Value;

        /// <summary>
        /// This Constructor takes three individual values and creates a new item
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quant"></param>
        /// <param name="val"></param>
        public Item(string name, int quant, int val) 
        {
            Name = name;
            Quantity = quant;
            Value = val;
        }

        /// <summary>
        /// This constructor takes an array of data and assigns the first three values to Name, Quantity and Value
        /// DISCLAIMER: This example is not good practice 
        /// what if the data is empty, what if it only contains two strings, what if one of the strings parsed to a number is not a number?
        /// If you implement something similar, think about how you can make this a bit better
        /// </summary>
        /// <param name="data"></param>
        public Item(string[] data)
        {
            Name = data[0];
            Quantity = int.Parse(data[1]);
            Value = int.Parse(data[2]);
        }
    }
}
