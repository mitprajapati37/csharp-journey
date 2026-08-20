public class Add
{
    public int a;
    public int b;
    public int add()
    {
        return a + b;
    }

    public int subtract()
    {
        return b - a;
    }
    public int mul()
    {
        return a* b;
    }

    public int div()
    {
        return a / b;
    }


}

    public class program
    {
        public static void Main(String[] args)
        {
            Add a = new Add(); 
            a.a = 100;
            a.b = 200;

            Console.WriteLine(a.add());    //output :- 300


        Add b= new Add();
        b.a = 10;
        b.b = 20;

        Console.WriteLine(b.subtract()); //output:- 10

        Add c = new Add();
        c.a = 5;
        c.b = 5;
        Console.WriteLine(c.mul()); //output:- 25


        Add d = new Add();
        d.a = 10;
        d.b = 2;

        Console.WriteLine(d.div());    // output :- 5


    }
}
