using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Work work = new Work();




            Console.WriteLine(work.allTable());
            Console.WriteLine(work.nomenklatureTable());
            Console.WriteLine("Сколько роботов вам нужно?");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(work.resTable(value));

            //work.myWriter("myFolder\\allTables.txt", work.allTable());
            //work.myWriter("myFolder\\nomenklatureTable.txt", work.nomenklatureTable());
            //work.myWriter("myFolder\\resTable.txt", work.resTable(value));

            try
            {
                StreamWriter write = new StreamWriter("1allTables.txt");
                write.WriteLine(work.allTable());
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                StreamWriter write = new StreamWriter("1nomenklatureTable.txt");
                write.WriteLine(work.nomenklatureTable());
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                StreamWriter write = new StreamWriter("1resTable.txt");
                write.WriteLine(work.resTable(value));
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
