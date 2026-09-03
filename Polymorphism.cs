// // ------------------------- Compile time Polymorphism

////class Calculation
////{
////    public int add(int a, int b)
////    {
////        return a + b;
////    }
////    public int add(int b, int a, int c)
////    {
////        return b + a + c;
////    }
////    public string concate(string a,string b)
////    {
////        return a + b;
////    }
////    public string concate(string a, string b,string c)
////    {
////        return a + b +c;
////    }
////}

////class Program
////{
////    public static void Main(string[] args)
////    {
////        Calculation cl = new Calculation();
////        Console.WriteLine(cl.add(10, 20));

////        Console.WriteLine(cl.add(10, 20, 30));
////        Console.WriteLine(cl.concate("mit","prajapati"));
////        Console.WriteLine(cl.concate("mit","Prajapati","101"));

////    }
////}


////----------------------------RunTime Polymorphism --------------------------------------------

////class A
////{
////    public virtual void Add()
////    {
////        Console.WriteLine("A class");
////    }
////}
////class B:A
////{
////    public override void Add()
////    {
////        Console.WriteLine("B Class");
////    }
////}
////class Program
////{
////    public static void Main(string[] args)
////    {
////        A a = new B();
////        a.Add();
////        a.Add();
////    }
////}



//------------------------------------------------------------------------------------


//class Vehical
//{
//    public string Brand;
//    public string Model;
//    public int Year;

//    public Vehical(string brand,string model,int year)
//    {
//        this.Brand = brand;
//        this.Model = model;
//        this.Year = year;
//    }
//    public virtual decimal CalculateTax()
//    {
//        return 0;
//    }

//}
//class Car:Vehical
//{
//    public int CarId;
//    public Car(string brand,string model,int year,int carid) :base(brand,model,year)
//    {
//        CarId = carid;
//    }
//    public override decimal CalculateTax()
//    {
//        return 5000;
//    }
//}

//class MoterCycle : Vehical
//{
//    public int MoterCycleId;
//    public MoterCycle(string brand,string model,int year,int motercycleid):base(brand,model,year)
//    {
//        this.MoterCycleId = motercycleid;
//    }
//    public override decimal CalculateTax()
//    {
//        return 1000;
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Vehical> vehicals = new List<Vehical>();

//        vehicals.Add(new Car("TATA", "Siyara", 2026, 37));
//        vehicals.Add(new MoterCycle("Hero", "Splender", 2026, 137));

//        foreach(Vehical i in vehicals)
//        {
//            Console.WriteLine(i.Brand + " " + i.Model + " " +" " + i.Year +" "+ i.CalculateTax());
//        }


//    }   
//}


// ---------------------------------------------------------------------------------

//class Student
//{
//    public int Id;
//    public string Name;
//    public string ClassName;

//    public Student(int id,string name,string classname)
//    {
//        this.Id = id;
//        this.Name = name;
//        this.ClassName = classname;

//    }

//    public virtual decimal TotalFee()
//    {
//        return 0;
//    }
//}

//class Department : Student
//{
//    public string DName;
//    public Department(int id,string name,string classname,string Dname):base(id,name,classname)

//    {
//        this.DName = Dname;
//    }

//    public override decimal TotalFee()
//    {
//        return 100000;
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Student> c = new List<Student>();
//        c.Add(new Department(1, "Mit", "Div-A", "MCA"));
//        c.Add(new Department(1, "Mit", "Div-A", "BCA"));
//        foreach (Student student in c)
//        {
//            Console.WriteLine(student.Id +" " + " "+ student.Name+" "+ student.ClassName +" " + ((Department)student).DName + " " + student.TotalFee() );
//        }

//    }
//}


// ---------------------------------------------------------------------------------------------


//class Vehical
//{
//    public string Brand;
//    public string Model;
//    public int Year;

//    public Vehical(string brand, string model, int year)
//    {
//        this.Brand = brand;
//        this.Model = model;
//        this.Year = year;
//    }

//    public virtual decimal CalculateTax()
//    {
//        return 0;
//    }

//    public override string ToString()
//    {
//        return Brand + " " + Model + " " + Year;
//    }
//}

//class Car : Vehical
//{
//    public int CarId;

//    public Car(string brand, string model, int year, int carId)
//        : base(brand, model, year)
//    {
//        this.CarId = carId;
//    }

//    public override decimal CalculateTax()
//    {
//        return 5000;
//    }

//    public override string ToString()
//    {
//        return "Car: " + Brand + " " + Model +
//               " " + Year + " ID: " + CarId +
//               " Tax: " + CalculateTax();
//    }
//}


//class MoterCycle : Vehical
//{
//    public int MoterCycleId;

//    public MoterCycle(string brand, string model, int year, int moterCycleId)
//        : base(brand, model, year)
//    {
//        this.MoterCycleId = moterCycleId;
//    }

//    public override decimal CalculateTax()
//    {
//        return 1000;
//    }

//    public override string ToString()
//    {
//        return "Motorcycle: " + Brand + " " + Model +
//               " " + Year + " ID: " + MoterCycleId +
//               " Tax: " + CalculateTax();
//    }
//}

//class Bus : Vehical
//{
//    public int BusId;

//    public Bus(string brand, string model, int year, int busId)
//        : base(brand, model, year)
//    {
//        this.BusId = busId;
//    }

//    public override decimal CalculateTax()
//    {
//        return 8000;
//    }

//    public override string ToString()
//    {
//        return "Bus: " + Brand + " " + Model +
//               " " + Year + " ID: " + BusId +
//               " Tax: " + CalculateTax();
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Vehical> vehicals = new List<Vehical>();

//        vehicals.Add(new Car("TATA", "Siyara", 2026, 37));
//        vehicals.Add(new MoterCycle("Hero", "Splender", 2026, 137));
//        vehicals.Add(new Bus("Volvo", "B9R", 2026, 101));

//        foreach (Vehical vehicle in vehicals)
//        {
//            Console.WriteLine(vehicle);
//        }
//    }
//}

//class Vehical
//{
//    public string Brand;
//    public string Model;
//    public int Year;
//    public Vehical(string brand,string model,int year)
//    {
//        this.Brand = brand;
//        this.Model = model;
//        this.Year = year;
//    }
//    public virtual decimal CalculateTex()
//    {
//        return 0;
//    }

//    public override string ToString()
//    {
//        return "Brand :-" + Brand +
//               "Model :-" + Model +
//               "Year :-" + Year +
//               "Tex :-" + CalculateTex();
//    }
//}



//class Car : Vehical
//{
//    public int CarAverage;
//    public Car(string brand,string model,int year,int caraverage):base(brand,model,year)
//    {
//        this.CarAverage = caraverage;
//    }
//    public override decimal CalculateTex()
//    {
//        return 5000;

//    }
//    public override string ToString()
//    {
//        return "Brand :-" + Brand + " Model:-" + Model + " Year:-" + Year + " CarAverage" + CarAverage + " Tax:-" + CalculateTex();
                
//    }
//}
//class MoterCycle:Vehical
//{
//    public int TotalMeter;
//    public MoterCycle(string brand,string model,int year,int totalmeter):base(brand,model,year)
//    {
//        this.TotalMeter = totalmeter;
//    }
//    public override decimal CalculateTex()
//    {
//        return 15000;
//    }
//    public override string ToString()
//    {
//        return Brand + Model + Year + TotalMeter + CalculateTex();
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Vehical> vehicals = new List<Vehical>();
//        vehicals.Add(new Car("TATA", "Siyara", 2026, 50));
//        vehicals.Add(new MoterCycle("hero", "Splender", 2018, 480));
//        foreach(Vehical vehical in vehicals)
//        {
//            Console.WriteLine(vehical);
//        }
//    }
    
//}
