using System;
using System.IO;

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
