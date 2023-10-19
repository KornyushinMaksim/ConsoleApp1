using ConsoleApp1.Robot.Chassi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Chassi
{
    internal class ToChassi : Chassi.MyTypename
    {
        private Stupica[] stupicas;
        private Wheel[] wheels;
        private MyFrame frame;
        private int cntStupica;
        private int cntWheels;
        private string strStupicca;

        public ToChassi()
            :base()
        {
            this.name = "Шасси";
            this.designation = "Ш.1";
            this.GUID = "f40adb09-2c75-482d-99cc-347dec048307";
            this.cnt = 1;
            this.sale = "нет";
            this.stupicas = new Stupica[4];
            this.wheels = new Wheel[4];
            this.frame = new MyFrame();
            this.cntWheels = 0;
            this.cntStupica = 0;
            for (int i = 0; i < 4; i++)
            {
                this.stupicas[i] = new Stupica();
                this.strStupicca += stupicas[i].show();
                this.wheels[i] = new Wheel();
                this.cntWheels++;
                this.cntStupica++;
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
