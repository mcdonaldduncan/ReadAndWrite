using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReadAndWrite.Constant;

namespace ReadAndWrite
{
    /// <summary>
    /// MyFile class handles the data required to track individual files
    /// </summary>
    internal class MyFile : IMyFile
    {
        // This is the path specific to this file, FilePath is set in the constructor
        public string FilePath { get; set; }

        // This is the name of the file, use for reporting or visualization
        public string FileName { get; set; } 

        // This is the delimiter specific to this file. For this project, always comma ","
        public string Delimiter { get; set; }

        /// <summary>
        /// MyFile Constructor takes the filename and initializes the MyFile object with FilePath set
        /// Delimiter is always comma for this application but could be different for different data
        /// </summary>
        /// <param name="_fileName">This is the name of the file, we collect this data in findallfiles</param>
        public MyFile(string _fileName) 
        {
            FilePath = Path.Combine(directoryPath, _fileName);
            FileName = _fileName.Substring(_fileName.LastIndexOf(@"\") + 1);
            Delimiter = ",";
        }
    }
}
