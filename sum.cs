public class Add
{
    public int a;
    public int b;
    public int add() 
    {
        return a + b;
    }
}

    public class program
    {
        public static void Main(String[] args)
        {
            Add a = new Add();
            a.a = 100;
            a.b = 200;

            Console.WriteLine(a.add());
        }
}
