
class Program
{
    static List<int> sid = new List<int>();
    static List<string> sname = new List<string>();
    static List<Dictionary<string, int>> smarks =
    new List<Dictionary<string, int>>();
    public static void Main(string[] args)
    {
        
        Console.WriteLine("1.Add");
        Console.WriteLine("2.View All");
        Console.WriteLine("3.search by Id");
        Console.WriteLine("4.search by Name");
        Console.WriteLine("5.Update Marks");
        Console.WriteLine("6.delete");
        Console.WriteLine("7.Class Toper");
        Console.WriteLine("8.Average");
        Console.WriteLine("9.Exit");
        while (true)
        {
            Console.Write("Enter the your choice :?");
        int.TryParse(Console.ReadLine(), out int ch);
        
            switch (ch)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Viewall();
                    break;
                case 3:
                    searchbyId();
                    break;
                case 4:
                    searchbyName();
                    break;
                case 5:
                    UpdateMarks();
                    break;
                case 6:
                    Deleted();
                    break;
                case 7:
                    ClassTopper();
                    break;
                case 8:
                    Average();
                    break;
                case 9:
                    Console.WriteLine("exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice..");
                    break;
            }
        }
    }



    static void Add()
    {
        Console.Write("Enter the Id : ");
        int.TryParse(Console.ReadLine(), out int rno);
        if(sid.Contains(rno))
        {
            Console.WriteLine("Already exist ");
        }
        Console.Write("Enter the Name:-");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Invalid name");
            return;
        }
        sid.Add(rno);
        sname.Add(name);
        Console.Write("How many subject:-");
        int.TryParse(Console.ReadLine(), out int subjectcount);

        Dictionary<string,int> stumarks = new Dictionary<string,int>();
        for(int i = 0; i < subjectcount; i++)
        {
            Console.Write("Enter the subject :-");
            string subject = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(subject))
            {
                Console.Write("Is null");
                i--;
                return;

            }
            if(sname.Contains(subject))
            {
                Console.Write("Subject already exist");
                i--;
                return;
            }
            Console.Write("Enter marks :- ");
            int.TryParse(Console.ReadLine(), out int mark);
            if(mark <0 || mark >100)
            {
                Console.Write("please enter marks between 0 - 100");
                i--;
                return;
            }
            stumarks.Add(subject, mark);
           
        }

        smarks.Add(stumarks);
    }

    static void Viewall()
    {
        if (sid.Count == 0)
        {
            Console.WriteLine("No student found.");
            return;
        }

        int index = 0;

        foreach (int id in sid)
        {
            Console.WriteLine($"\nID   : {id}");
            Console.WriteLine($"Name : {sname[index]}");

            foreach (var item in smarks[index])
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            index++;
        }
    }

    static void searchbyId()
    {
        Console.Write("Enter the student ID: ");
        int.TryParse(Console.ReadLine(), out int searchid);

        int index = sid.IndexOf(searchid);

        if (index == -1)
        {
            Console.WriteLine("Student ID not found.");
            return;
        }

        Console.WriteLine("Student Found");
        Console.WriteLine($"ID   : {sid[index]}");
        Console.WriteLine($"Name : {sname[index]}");

        foreach (var item in smarks[index])
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

    static void searchbyName()
    {
        Console.Write("Enter the name: ");
        string searchname = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(searchname))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        int index = sname.IndexOf(searchname);

        if (index == -1)
        {
            Console.WriteLine("Not Found");
            return;
        }

        Console.WriteLine("Student Found");
        Console.WriteLine($"ID   : {sid[index]}");
        Console.WriteLine($"Name : {sname[index]}");

        foreach (var item in smarks[index])
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

    static void UpdateMarks()
    {
        Console.Write("Enter the student ID: ");
        int.TryParse(Console.ReadLine(), out int searchid);

        int index = sid.IndexOf(searchid);

        if (index == -1)
        {
            Console.WriteLine("Student ID not found.");
            return;
        }

        Console.WriteLine($"ID   : {sid[index]}");
        Console.WriteLine($"Name : {sname[index]}");

        Console.Write("Enter the subject name: ");
        string subject = Console.ReadLine();

        if (!smarks[index].ContainsKey(subject))
        {
            Console.WriteLine("Subject not found.");
            return;
        }

        Console.Write("Enter new marks: ");
        int.TryParse(Console.ReadLine(), out int newMark);

        if (newMark < 0 || newMark > 100)
        {
            Console.WriteLine("Please enter marks between 0 and 100.");
            return;
        }

        smarks[index][subject] = newMark;

        Console.WriteLine("Marks updated successfully.");
    }

    static void Deleted()
    {
        Console.Write("Enter the DeleteID");
        int.TryParse (Console.ReadLine(), out int did);
        
        int index = sid.IndexOf(did);
        if(index == -1)
        {
            Console.Write("Not found");
            return;
       }
        sid.RemoveAt(index);
        sname.RemoveAt(index);
        smarks.RemoveAt(index);
    }

    static void ClassTopper()
    {
        if (smarks.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        int topperIndex = 0;
        double highestPercentage = 0;

        for (int i = 0; i < smarks.Count; i++)
        {
            int totalMarks = 0;
            int totalSubjects = smarks[i].Count;

            foreach (var item in smarks[i])
            {
                totalMarks += item.Value;
            }

            double percentage =
                (double)totalMarks / (totalSubjects * 100) * 100;

            if (percentage > highestPercentage)
            {
                highestPercentage = percentage;
                topperIndex = i;
            }
        }
        Console.WriteLine($"ID   {sid[topperIndex]}");
        Console.WriteLine($"Name {sname[topperIndex]}");
        Console.WriteLine($"Percentage {highestPercentage:F2}%");
    }


    static void Average()
    {
        Console.Write("Enter Subject Name: ");
        string subject = Console.ReadLine();

        int totalMarks = 0;
        int studentCount = 0;


        foreach (var studentMarks in smarks)
        {
            if (studentMarks.ContainsKey(subject))
            {
                totalMarks += studentMarks[subject];
                studentCount++;
            }
        }

        if (studentCount == 0)
        {
            Console.WriteLine("Subject not found.");
            return;
        }

        double average = (double)totalMarks / studentCount;

        Console.WriteLine($"Subject {subject}");
        Console.WriteLine($"Average Marks {average:F2}");
    }


}
