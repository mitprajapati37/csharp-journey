public class GetName
{
    public string Name;
}

class program
{
    static void Main() //Program does not contain a static 'Main' method suitable for an entry point   

        // in Main method Allwas Capotal
    {
        GetName gn = new GetName();
        

        gn.Name = "mit";
        Console.WriteLine(gn.Name);

    }
}
