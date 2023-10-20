
namespace ConsoleApp1
{
    internal class Podship: Chassi.MyTypename
    {

        public Podship() : base()
        {
            this.name = "Подшипник";
            this.designation = "П.1";
            this.GUID = "6225e5d7-09dc-45ef-91aa-c0b2195688ca";
            this.cnt = 1;
            this.sale = "да";
        }

        public string show()
        {
            string str = string.Format("|{0,15}|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }
    }
}
