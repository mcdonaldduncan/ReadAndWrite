using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReadAndWrite.Constant;

namespace ReadAndWrite
{
    internal class MyFile : IMyFile
    {
        public string FilePath { get; set; }

        public MyFile(string _fileName) 
        {
            FilePath = Path.Combine(directoryPath, _fileName);
        }
    }
}
