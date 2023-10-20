
namespace ConsoleApp1
{
    internal class Wheel : Chassi.MyTypename
    {
        public Wheel() : base()
        {
            this.name = "Колесо";
            this.designation = "К.1";
            this.GUID = "c4b91c94-3c2c-4fb3-9a0a-d79c51f432b0";
            this.cnt = 4;
            this.sale = "да";
        }

        public new string show()
        {
            string str = string.Format("|{0,10}  \t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }
    }
}
