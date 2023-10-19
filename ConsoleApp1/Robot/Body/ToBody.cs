using ConsoleApp1.Chassi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Body
{
    internal class ToBody : MyTypename
    {
        private Led[] leds;
        public ToBody() : base()
        {
            this.name = "Корпус";
            this.designation = "К.2";
            this.GUID = "8fabed69-d1d7-4668-8e07-1c20f998332c";
            this.cnt = 1;
            this.sale = "нет";
            this.leds = new Led[10];
            for (int i = 0; i < 10; i++)
            {
                this.leds[i] = new Led();
            }
        }

        public string show()
        {
            string str = string.Format("|{0,7}\t|{1,15}|{2,45}|{3,5}|{4,10}|",
                getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }

        public string show(int value)
        {
            string str = string.Format("|{0,7}\t|{1,15}|{2,45}|{3,5}|{4,10}|",
                getName(), getDesignition(), getGUID(), getCnt() * value, isSale());
            return str;
        }
    }
}
