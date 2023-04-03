using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    /// <summary>
    /// IMyFile interface is a contract we can use to handle different file types simultaneously
    /// Notice that most collections in this proj are usinng IMyFile yet are able to hold MyFile objects
    /// </summary>
    internal interface IMyFile
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Delimiter { get; set; }
    }
}
