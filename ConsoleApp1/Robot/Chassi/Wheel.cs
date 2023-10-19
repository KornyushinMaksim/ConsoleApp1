using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Wheel : Chassi.MyTypename
    {
        private Stupica stupica;

        public Wheel() : base()
        {
            this.name = "Колесо";
            this.designation = "К.1";
            this.GUID = "c4b91c94-3c2c-4fb3-9a0a-d79c51f432b0";
            this.cnt = 4;
            this.sale = "да";
            this.stupica = new Stupica();
        }

        public new string show()
        {
            string str = string.Format("|{0,10}  \t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }

        public new string show(int value)
        {
            string str = string.Format("|{0,10}  \t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt() * value, isSale());
            return str;
        }
    }
}
