using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
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

        public void DisplayInventory()
        {
            foreach (var item in inventory.Items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
