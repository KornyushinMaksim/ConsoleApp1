
namespace ConsoleApp1.Chassi
{
    internal class ToChassi : Chassi.MyTypename
    {
        public ToChassi()
            :base()
        {
            this.name = "Шасси";
            this.designation = "Ш.1";
            this.GUID = "f40adb09-2c75-482d-99cc-347dec048307";
            this.cnt = 1;
            this.sale = "нет";
        }

        public string show()
        {
            string str = string.Format("|{0,7}\t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }
    }
}
