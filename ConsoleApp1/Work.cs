using ConsoleApp1.Body;
using ConsoleApp1.Chassi;
using ConsoleApp1.Robot.Chassi;
using ConsoleApp1.Robot;

namespace ConsoleApp1
{
    class Work
    {
        MyRobot robot = new MyRobot();
        ToChassi toChassi = new ToChassi();
        Wheel wheel = new Wheel();
        Stupica stupica = new Stupica();
        Podship podship = new Podship();
        MyFrame myFrame = new MyFrame();
        ToBody body = new ToBody();
        Led led = new Led();

        public string allTable()
        {
            string str = string.Format("\t\t\tНеобходимые детали для 1 робота\n\n") +
            string.Format(new string('-', 15 + 15 + 45 + 5 + 10 + 6) + "\n") +
            string.Format("|{0,15}|{1,15}|{2,45}|{3,5}|{4,10}|\n",
                "Наименование", "Обозначение", "GUID", "Шт", "Покупное") +
            string.Format(new string('-', 15 + 15 + 45 + 5 + 10 + 6) + "\n") +
            string.Format(robot.show() + "\n") +
            string.Format(toChassi.show() + "\n") +
            string.Format(wheel.show() + "\n") +
            string.Format(stupica.show() + "\n") +
            string.Format(podship.show() + "\n") +
            string.Format(myFrame.show() + "\n") +
            string.Format(body.show() + "\n") +
            string.Format(led.show() + "\n") +
            string.Format("\n\n");
            return str;
        }

        public string resTable(int value)
        {
            string str = string.Format("\t\t\tНеобходимые детали для " + value + " робота(ов)\n\n") +
            string.Format(new string('-', 15 + 45 + 5 + 6) + "\n") +
            string.Format("|{0,15}|{1,45}|{2,5}|\n",
                "Наименование", "GUID", "Шт") +
            string.Format(new string('-', 15 + 45 + 5 + 6) + "\n") +
            string.Format(toChassi.show(value) + "\n") +
            string.Format(wheel.show(value) + "\n") +
            string.Format(stupica.show(value) + "\n") +
            string.Format(podship.show(value) + "\n") +
            string.Format(myFrame.show(value) + "\n") +
            string.Format(body.show(value) + "\n") +
            string.Format(led.show(value) + "\n") +
            string.Format("\n\n");
            return str;
        }

        public string nomenklatureTable()
        {
            string str = string.Format("\t\t\tПодключения номенклатур\n\n") +
            string.Format(new string('-', 45 + 45 + 5 + 6) + "\n") +
            string.Format("|{0,45}|{1,45}|{2,5}|\n",
                "Родительский GUID", "Дочерний GUID", "Шт") +
            string.Format(new string('-', 45 + 45 + 5 + 6) + "\n") +
            string.Format(robot.showNomenlk("null") + "\n") +
            string.Format(toChassi.showNomenlk(robot.getGUID()) + "\n") +
            string.Format(wheel.showNomenlk(toChassi.getGUID()) + "\n") +
            string.Format(stupica.showNomenlk(toChassi.getGUID()) + "\n") +
            string.Format(podship.showNomenlk(stupica.getGUID()) + "\n") +
            string.Format(myFrame.showNomenlk(toChassi.getGUID()) + "\n") +
            string.Format(body.showNomenlk(robot.getGUID()) + "\n") +
            string.Format(led.showNomenlk(body.getGUID()) + "\n") +
            string.Format("\n\n");
            return str;

        }

        public void myWriter(string path, string file)
        {
            WorkFile workFile = new WorkFile(path, file);
        }
    }
}
