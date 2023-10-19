using ConsoleApp1.Chassi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Robot
{
    internal class MyRobot : MyTypename
    {
        public MyRobot() : base()
        {
            this.name = "Робот";
            this.designation = "Р.1";
            this.GUID = "d3cdd74e-1704-4636-a2d6-b35179fdb559";
            this.cnt = 1;
            this.sale = "нет";

        }

        public string show()
        {
            string str = string.Format("|{0,5}\t\t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }

        public string show(int value)
        {
            string str = string.Format("|{0,5}\t\t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt() * value, isSale());
            return str;
        }
    }
}
