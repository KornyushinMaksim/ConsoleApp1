using System;

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

            //запись в файл сводной таблицы
            work.myWriter("1allTables.txt", work.allTable());
            //запись в файл таблицы с зависимостями номенклатур
            work.myWriter("1nomenklatureTable.txt", work.nomenklatureTable());
            //запись в файл таблицы  с итоговым количеством
            work.myWriter("1resTable.txt", work.resTable(value));       
        }
    }
}
