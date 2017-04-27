using System;
using System.IO;
using System.Linq;

namespace Texter
{

        public class NewStringText
        {
            public int NumberOfLines;
            public string FirstLine;

            public string ToTxt(string fileName, string targetFile)
            {
                StreamWriter writeToFile = new StreamWriter(targetFile);
                var lines = File.ReadAllLines(fileName);
                var csv = lines.ToArray();

                foreach (var c in csv)
                {
                    var replace = c.Replace("\t", "");
                    writeToFile.WriteLine(replace);
                }
                writeToFile.Close();

                var test = File.ReadLines(targetFile).First();
                FirstLine = File.ReadLines(targetFile).First();
                NumberOfLines = File.ReadLines(targetFile).Count();

                return test;
            }

            
        }
}
