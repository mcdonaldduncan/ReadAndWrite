using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    internal class Game
    {
        // This is the player of the "game" 
        // The player has an inventory which we will add items to
        // If we wanted a second player, we would make an additional instance of the player class and that player would also have an inventory
        Player player = new Player("Duncan", 24, 99, 99, 99);

        // This is an instance of our FileReader class, we will use it to get all the files and also to read individual files
        FileReader reader = new FileReader();

        // This is a list of IMyFile interfaces, if you look at the code, we add MyFile class instances. Because MyFile implements the 
        // IMyFile interface, it can be referenced as the interface
        List<IMyFile> files = new List<IMyFile>();

        // This is a list of strings that we will set to be the names of all files in our target directory
        List<string> fileNames = new List<string>();
        
        public void Initialize()
        {
            // Start off by collecting all files as strings
            fileNames = reader.GetAllFiles();

            // For each string fileName in fileNames
            foreach (var fileName in fileNames)
            {
                // Create a new MyFile instance using the fileName
                MyFile temp = new MyFile(fileName);

                // Add the new MyFile instance to the files List
                files.Add(temp);
            }

            // We use an if statement here because reader.ReadFile() returns a boolean to indicate success
            // We have to include the out parameter and in this case we give it a type and name so it can be initialized
            if (reader.ReadFile(files[0], out List<string[]> newInfo))
            {
                // If the file read was succesful, we loop over the new info and convert all info into items
                foreach (var info in newInfo)
                {
                    // Create a new Item instance from the current info
                    Item temp = new Item(info);

                    // Add the newly created Item instance to the player inventory
                    player.inventory.Items.Add(temp);
                    // Player -> Inventory -> Items
                }
            }
        }
        
        /// <summary>
        /// Public Game method to invoke player displayinventory
        /// </summary>
        public void Display()
        {
            player.DisplayInventory();
        }
        

    }
}
