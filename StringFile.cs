string a = "mit prajapati";
string b = "prajapati";
Console.WriteLine(a);   // output :-mit prajapati
Console.WriteLine(b);   // output  :-prajapati

Console.WriteLine(a + b);  // Output:- mit prajapatiprajapati

Console.WriteLine(a.ToUpper());   // Output :- MIT PRAJAPATI

Console.WriteLine(b.ToUpper());   // Output :-  PRAJAPATI

Console.WriteLine(a.Length);      // Output  :- 13

Console.WriteLine(b.Length);      // Output  :- 9

string c = "       hello, world!             ";
Console.WriteLine(c.Trim());       // Output  :-hello, world!

Console.WriteLine(a.Replace("m", "ch")); // Output :- chit prajapati

Console.WriteLine(a.StartsWith("mit"));  // Output :-  True

Console.WriteLine(a.EndsWith("ati"));    //output :-  True

Console.WriteLine(a.Contains(a));  //Output :- True

