public class GetName
{
    public string Name;
}

class program
{
    static void Main()
    {
        GetName gn = new GetName();
        

        gn.Name = "mit";
        Console.WriteLine(gn.Name);

    }
}
