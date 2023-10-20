using ConsoleApp1.Chassi;

namespace ConsoleApp1.Robot.Chassi
{
    internal class MyFrame : MyTypename
    {
        public MyFrame() : base()
        {
            this.name = "Рама";
            this.designation = "Р.1";
            this.GUID = "b033e784-ac2f-4f3a-b1f5-916a0a81af66";
            this.cnt = 1;
            this.sale = "нет";
        }

        public string show()
        {
            string str = string.Format("|{0,8} \t|{1,15}|{2,45}|{3,5}|{4,10}|",
               getName(), getDesignition(), getGUID(), getCnt(), isSale());
            return str;
        }
    }
}
