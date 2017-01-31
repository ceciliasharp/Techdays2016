using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class Demo1
    {
        public Demo1()
        {
            string[] lines = { "First line", "Second line", "Third line" };

            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
    }

    public class Demo2
    {

    }
}
