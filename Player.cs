using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    /// <summary>
    /// The Player class is just a hypothetical example of what a player/character could look like in your game
    /// In this case, we only really care about the Inventory
    /// </summary>
    internal class Player
    {
        string Name;
        int Age;
        int ATK;
        int DEF;
        int INT;

        public Inventory inventory { get; set; }

        public Player(string name, int age, int _atk, int _def, int _int) 
        {
            Name = name;
            Age = age;
            ATK = _atk;
            DEF = _def;
            INT = _int;

            inventory = new Inventory();
        }

        /// <summary>
        /// Displays the current inventory of this player instance to the console
        /// </summary>
        public void DisplayInventory()
        {
            // Loop over all items in the inventory items
            foreach (var item in inventory.Items)
            {
                // Print the item name
                Console.WriteLine(item.Name);
            }
        }
    }
}
