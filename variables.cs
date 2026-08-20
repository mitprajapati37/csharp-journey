// variables


public class add
{
    public int a;   // Instance Variable
    public int b;
    public int Addition(int x,int y)  //perameterized variable
    {
        this.a = x;
        this.b = y;
        return x + y;   // return a values
    }
}
public class Program   //Create  Class 
{
    public static void Main()   // Create a Main() methods 
    {
        add a = new add();   // Create a Object of the add()
        

        Console.WriteLine(a.Addition(50,50));  //pass a arguments and Get output :- 100
    }
}
