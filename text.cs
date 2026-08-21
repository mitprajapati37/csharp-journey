string str = "Mit prajapati";

Console.WriteLine(str);

char m = 'm';
Console.WriteLine(m);


Console.WriteLine("--------------------String Built-In Methods------------------------------");

Console.WriteLine(str.Replace("m","ch"));   //output :- chit prajapati

Console.WriteLine(str.ToLower());  // output :- mitprajapati

Console.WriteLine(str.ToUpper());  // output :- MIT PRAJAPATI

Console.WriteLine(str.Trim());     // output :-  Mit prajapati

Console.WriteLine(str.StartsWith("mit"));   // output :-  False

Console.WriteLine(str.EndsWith("ti"));      // output :-  True
