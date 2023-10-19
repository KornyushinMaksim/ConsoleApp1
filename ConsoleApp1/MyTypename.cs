using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Chassi
{
    abstract public class MyTypename
    {
        protected string name;
        protected string designation;
        protected string GUID;
        protected int cnt;
        protected string sale;

        protected MyTypename()
        {
            this.name = null;
            this.designation = null;
            this.GUID = null;
            this.cnt = 0;
            this.sale = "нет";
        }

        public string getName()
        {
            return this.name;
        }

        public string getDesignition()
        {
            return this.designation;
        }

        public string getGUID()
        {
            return this.GUID;
        }

        public int getCnt()
        {
            return this.cnt;
        }

        public string isSale()
        {
            return this.sale;
        }
        
        public string show()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", this.name, this.designation, this.GUID, this.cnt, this.sale);
        }
    }
}
