using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReadAndWrite.Constant;

namespace ReadAndWrite
{
    internal class FileReader
    {
        public bool ReadFile(IMyFile delimitedFile, out List<string[]> lines)
        {
            lines = new List<string[]>();

            try
            {
                using (StreamReader sr = new StreamReader(delimitedFile.FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        var lineItems = sr.ReadLine()?.Split(",") ?? new string[0];

                        lines.Add(lineItems);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            
            return true;
            
        }

        public List<string> GetAllFiles()
        {
            return Directory.GetFiles(directoryPath).ToList();
        }
    }
}
