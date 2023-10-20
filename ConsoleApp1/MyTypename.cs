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
        
        public string show(int value)
        {
            string str = string.Format("|{0,15}|{1,45}|{2,5}|",
               getName(), getGUID(), getCnt() * value);
            return str;
        }

        public string showNomenlk(string strGUID)
        {
                string str = string.Format("|{0,45}|{1,45}|{2,5}|",
                   strGUID, getGUID(), getCnt());
                return str;
        }
    }
}
