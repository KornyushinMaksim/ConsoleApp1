
namespace ConsoleApp1
{
    internal class Stupica : Chassi.MyTypename
    {
        public Stupica() : base()
        {
            this.name = "Ступица";
            this.designation = "С.1";
            this.GUID = "a2e61f10-15a1-425c-a5bb-6f37158f7467";
            this.cnt = 4;
            sale = "нет";
        }

        public new string show()
        {
            string str = string.Format("|{0,11} \t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }
    }
}
