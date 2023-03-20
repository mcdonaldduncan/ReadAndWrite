using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    internal class Game
    {
        Inventory inventory = new Inventory();
        FileReader reader = new FileReader();

        List<IMyFile> files = new List<IMyFile>();

        List<string> fileNames;
        
        public void Initialize()
        {
            fileNames = reader.GetAllFiles();

            foreach (var fileName in fileNames)
            {
                files.Add(new MyFile(fileName));
            }

            if (reader.ReadFile(files[0], out List<string[]> newInfo))
            {
                foreach (var info in newInfo)
                {
                    inventory.Items.Add(new Item(info));
                }
            }

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
