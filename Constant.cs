using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    /// <summary>
    /// The constant class simply holds constant data that we will refer back to multiple places in the project
    /// It is almost like a Utility class but just holds information instead of methods/functions
    /// </summary>
    internal class Constant
    {
        // This is the name of the folder we will be reading from
        private const string folderName = "saveData";

        // This does not get used in this example, but this is the name of the folder we want to write to
        private const string writeFolder = "out";

        // This is the directory path for the folder of the name we specified above
        // Path.Combine() takes strings (assumed to be directory paths) and combines them into a full path.
        // In this case, we pass in the current directory with Directory.GetCurrentDirectory() and we combine our folder name to get the path to that folder
        public static string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);

        // Very similar to the line above, this is combining our directorypath variable with our additional write folder
        public static string writeDirectory = Path.Combine(directoryPath, writeFolder);
    }
}
