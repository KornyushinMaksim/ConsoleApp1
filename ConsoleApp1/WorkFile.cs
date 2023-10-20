using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WorkFile
    {

        public WorkFile(string path, string file)
        {
            try
            {
                StreamWriter write = new StreamWriter(path);
                write.WriteLine(file);
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
