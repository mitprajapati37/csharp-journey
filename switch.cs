// using switch Create a Calculator.
int c;
Console.Write("Enter the number1 :-");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number1 :-");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1.Addition");
Console.WriteLine("2.subtraction");
Console.WriteLine("3.multiplication");
Console.WriteLine("4.Division");
Console.WriteLine("5.modulo");
Console.WriteLine("choose the number");
int ch = Convert.ToInt32(Console.ReadLine());
switch(ch)
{
    case 1:
        c = n1 + n2;
        Console.WriteLine($"sum of {n1} and {n2} equals too {c}");
        break;
    case 2:
        c= n1 - n2;
        Console.WriteLine($"sum of {n1} and {n2} equals too {c}");
        break;
    case 3:
        c=n1*n2;
        Console.WriteLine($"sum of {n1} and {n2} equals too {c}");
        break;
    case 4:
        c = n1 / n2;
        Console.WriteLine($"sum of {n1} and {n2} equals too {c}");
        break;
    case 5:
        c = n1 % n2;
        Console.WriteLine($"sum of {n1} and {n2} equals too {c}");
        break;
    default:
        Console.WriteLine("Entered Invalid Number Please Enter Valid number ") ; break;


}
