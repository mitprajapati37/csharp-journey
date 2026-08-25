//Array cleaning

//Console.Write("Enter the size of array :-");
//int.TryParse(Console.ReadLine(), out int size);
//int[] price = new int[size];

//for (int i = 0; i < price.Length; i++)
//{
//    Console.Write($"Enter the number [{i}]:-");
//    int.TryParse(Console.ReadLine(), out price[i]);

//}
////Array.Clear(price, 0, price.Length);
////Console.WriteLine(Array.IndexOf(price, 30));


//foreach (int i in price)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine($" Even :- {i}");
//    }
//    else
//    {
//        Console.WriteLine($"odd :- {i}");
//    }
//}


//Console.Write("Enter the Number :-");
// int.TryParse(Console.ReadLine(), out int size);
//int mul = 1;
//int sum = 0;
//int[] arr = new int[size];
//for(int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Enter the number [{i} :-]");
//    int.TryParse(Console.ReadLine(), out arr[i]);
//}
//foreach(int i in arr)
//{

//    mul = mul * i;
//    sum = sum + i;
//    Console.WriteLine(mul);
//    Console.WriteLine(sum);
//}


// Create a List 



//List<int> id= new();
//List<String> names= new();

////Console.Write("Enter the Roll Number:-");
////int.TryParse(Console.ReadLine(), out int rno);

////Console.Write("Enter the Name of Student :-");
////string name = Console.ReadLine();

//id.Add(10);
//names.Add("mit");
//id.Add(20);
//names.Add("chitt");
////id.Remove(20);
//Console.WriteLine(id.IndexOf(3));


//for (int i = 0; i < id.Count; i++)
//{
//    Console.WriteLine($"my id is {id[i]} and Name is {names[i]}");

//}


//List<int> even = new List<int>();
//List<int> odd = new List<int>();
//Console.Write("Enter the number :-");
//int.TryParse(Console.ReadLine() , out int a);
//for (int i = 0; i<a;i++)
//{
//    if(i % 2 == 0)
//    {
//        even.Add(i);
//    }
//    else
//    {
//        odd.Add(i);
//    }
//}
//foreach (int i in even)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine(Environment.NewLine);
//foreach(int i in odd)
//{
//    Console.Write($"{i} ");
//}

//Console.WriteLine();


//int[] number = new int[] { 10, 20, 30, 40, 50, 60 };
////Array.Clear(number, 0, number.Length);

//Console.WriteLine(Array.IndexOf(number, 60)); 

//foreach (int numberItem in number)
//{
//    Console.WriteLine(numberItem);
//}


// Even Odd script

//List<int> even = new List<int>();
//List<int> odd = new List<int>();

//Console.Write("what do you want to Enter the number :- ");
//int.TryParse(Console.ReadLine(), out int number);

//for (int i = 0; i <= number; i++)
//{
//    if(i % 2 == 0)
//    {
//        even.Add(i);

//    }
//    else
//    {
//        odd.Add(i);
//    }

//}
//foreach (int i in even)
//{
//    Console.WriteLine($"{i} ");
//}
//Console.WriteLine(Environment.NewLine);

//foreach (int i in odd)
//{
//    Console.WriteLine($"{i}");
//}


//multiply of (7,5) -> 7 ,14,21,28,35 

//List<int> number = new List<int>();

//Console.Write("Enter the number :-");
//int.TryParse(Console.ReadLine(), out int num);

//Console.Write("Enter the length of you want to go steps :- ");
//int.TryParse(Console.ReadLine(), out int ln);
//for(int i=1;i<=ln;i++)
//{
//    number.Add(num);
//    Console.WriteLine(num*i);
//}



//List <int> ids = new List<int>();
//List <string> names = new List<string>();
//Dictionary<string, int> marks = new Dictionary<string, int>();

//Console.WriteLine("1.Add");
//Console.WriteLine("2.View All");
//Console.WriteLine("3.Search by ID");
//Console.WriteLine("4.Search by Name");
//Console.WriteLine("4.Update Marks");
//Console.WriteLine("5.Delete");
//Console.WriteLine("6.class Toper");
//Console.WriteLine("7.subject Everage");
//Console.WriteLine("8.Exit");

//Console.Write("Enter your choice :- ");

//while (true)
//{
//    if (!int.TryParse(Console.ReadLine(), out int ch))
//    {
//        Console.Write("please Enter Valid Choice :-");
//        //int.TryParse(Console.ReadLine(), out ch);
//    }

//    switch (ch)
//    {
//        case 1:
            
//            Console.Write("Enter the Id :-");
//            int.TryParse(Console.ReadLine(), out int id);
//            if(id == null)
//            {
//                Console.WriteLine("Please Enter Id :-");
//                int.TryParse(Console.ReadLine(), out id);
//            }
//            else if(ids.Contains(id))
//            {
//                Console.Write("Id Allready Exits");
//                int.TryParse(Console.ReadLine(), out id);
//            }
//            else
//            {
//                ids.Add(id);
//            }
//            Console.Write("Enter Your Name :-");
//            string name = Console.ReadLine();
//            if (string.IsNullOrEmpty(name))
//            {
//                Console.Write("please enter valid name :- ");
//                name = Console.ReadLine();
//            }
//            else
//            {
//                names.Add(name);
//            }
               
//            break;
//        case 2:

//            break;

//    }
//}
