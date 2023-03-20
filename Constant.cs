using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    internal class Constant
    {
        private const string folderName = "temp";

        private const string writeFolder = "out";


        public static string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);

        public static string writeDirectory = Path.Combine(directoryPath, writeFolder);
    }
}
