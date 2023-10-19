using ConsoleApp1.Body;
using ConsoleApp1.Chassi;
using ConsoleApp1.Robot;
using ConsoleApp1.Robot.Chassi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRobot robot = new MyRobot();
            ToChassi toChassi = new ToChassi();
            Wheel wheel = new Wheel();
            Stupica stupica = new Stupica();
            Podship podship = new Podship();
            MyFrame myFrame = new MyFrame();
            ToBody body = new ToBody();
            Led led = new Led();

            Console.WriteLine("\t\t\tНеобходимые детали для 1 робота\n\n");

            Console.WriteLine(new string('-', 15 + 15 + 45 + 5 + 10 + 6));
            Console.WriteLine("|{0,15}|{1,15}|{2,45}|{3,5}|{4,10}|",
                "Наименование", "Обозначение", "GUID", "Шт", "Покупное");
            Console.WriteLine(new string('-', 15 + 15 + 45 + 5 + 10 + 6));
            Console.WriteLine(robot.show());
            Console.WriteLine(toChassi.show());
            Console.WriteLine(wheel.show());
            Console.WriteLine(stupica.show());
            Console.WriteLine(podship.show());
            Console.WriteLine(myFrame.show());
            Console.WriteLine(body.show());
            Console.WriteLine(led.show());
            Console.WriteLine("\n\n");

            Console.WriteLine("Сколько роботов вам нужно?");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t\t\tНеобходимые детали для " + value + " робота(ов)\n\n");


            Console.WriteLine(new string('-', 15 + 15 + 45 + 5 + 10 + 6));
            Console.WriteLine("|{0,15}|{1,15}|{2,45}|{3,5}|{4,10}|",
                "Наименование", "Обозначение", "GUID", "Шт", "Покупное");
            Console.WriteLine(new string('-', 15 + 15 + 45 + 5 + 10 + 6));
            Console.WriteLine(robot.show(value));
            Console.WriteLine(toChassi.show(value));
            Console.WriteLine(wheel.show(value));
            Console.WriteLine(stupica.show(value));
            Console.WriteLine(podship.show(value));
            Console.WriteLine(myFrame.show(value));
            Console.WriteLine(body.show(value));
            Console.WriteLine(led.show(value));
            Console.WriteLine("\n\n");
        }
    }
}
