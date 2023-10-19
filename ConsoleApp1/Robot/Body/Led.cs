using ConsoleApp1.Chassi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Body
{
    internal class Led : MyTypename
    {
        public Led() : base()
        {
            this.name = "Светодиод";
            this.designation = "Св.1";
            this.GUID = "a84d9d02-0c71-4547-9227-311b259943c2";
            this.cnt = 10;
            this.sale = "да";

        }

        public string show()
        {
            string str = string.Format("|{0,13}\t|{1,15}|{2,45}|{3,5}|{4,10}|",
                getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }

        public string show(int value)
        {
            string str = string.Format("|{0,13}\t|{1,15}|{2,45}|{3,5}|{4,10}|",
                getName(), getDesignition(), getGUID(), getCnt() * value, isSale());
            return str;
        }
    }
}
