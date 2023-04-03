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
        /// <summary>
        /// ReadFile parses all lines of a single file sequentially and stores them in a list of string arrays
        /// ReadFile accepts a single IMyFile, delimitedFile, and has an out parameter called lines
        /// </summary>
        /// <param name="delimitedFile">The file to parse</param>
        /// <param name="lines">The List of string arrays representing individual lines of data</param>
        /// <returns>returns true if the file is succesfully read, false if not</returns>
        public bool ReadFile(IMyFile delimitedFile, out List<string[]> lines)
        {
            // Set the value of lines to a new, blank list
            lines = new List<string[]>();

            // Start a try-catch block, this will catch any errors that occur while reading lines
            try
            {
                // StreamReader implements IDisposable and can be used within a using statement
                // Always implement with a using block as shown below
                // See: https://learn.microsoft.com/en-us/dotnet/api/system.idisposable?view=net-7.0
                using (StreamReader reader = new StreamReader(delimitedFile.FilePath))
                {
                    // Continue looping as long as reader is not at the end of the stream
                    while (!reader.EndOfStream)
                    {
                        // Create a new string array from the current line, split by the delimiter of the current file
                        // The dilimiter is always a comma "," in this project, but pipe "|" is another common delimiter
                        string[] lineItems = reader.ReadLine()?.Split(delimitedFile.Delimiter) ?? new string[0]; // This end piece, the "?? new string[0]" just creates a new blank array if the previous result was null

                        // Add the newly collected lineItems to the lines list
                        lines.Add(lineItems);
                    }
                }
            }
            catch (Exception)
            {
                // If an Exception is thrown while we attempt to read the file, we return false instead of true
                return false;
            }
            
            // If the try-catch block runs with no exceptions, we return true
            return true;
        }

        /// <summary>
        /// Returns a list of all file paths (stored as strings) in the directoryPath (directoryPath comes from Constant class)
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllFiles()
        {
            return Directory.GetFiles(directoryPath).ToList();
        }
    }
}
