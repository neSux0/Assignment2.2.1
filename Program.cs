namespace A5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }
    class Phone
    {
        public string os = "None";
        public virtual void Call()
        {
            Console.WriteLine("This is a phone.");
        }
    }

    class IPhone : Phone
    {
        public IPhone()
        {
            os = "IOS";
        }
        public override void Call()
        {
            Console.WriteLine("This is an Iphone.");
        }
    }

    class Android: Phone
    {
        public Android()
        {
           os = "Android OS";
        }
        public override void Call()
        { 
            Console.WriteLine("This is an Android.");
        }
    }
}
