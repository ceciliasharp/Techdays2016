using System;
using System.IO;
using System.Web;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line", "Third line" };

            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

            var d = new DemoClass();
            d.ThrowException();
            var t = d.Value.Property().Text;

        }
    }


}
