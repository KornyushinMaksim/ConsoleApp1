using ConsoleApp1.Chassi;

namespace ConsoleApp1.Body
{
    internal class ToBody : MyTypename
    {        public ToBody() : base()
        {
            this.name = "Корпус";
            this.designation = "К.2";
            this.GUID = "8fabed69-d1d7-4668-8e07-1c20f998332c";
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
