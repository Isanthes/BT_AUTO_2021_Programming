﻿using System;
using System.Collections.Generic;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        public enum Browsers
        {
            Chrome,
            Edge,
            Firefox
        }
        static void Main(string[] args)
        {
            // Course01(args);
            // Course02(args);
            // Course03(args);
            // Course04();
            // Course05();
            // Course06();
            // Course07();
            // Course08();
            try
            {
                Course09(args);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        private static void RecursiveMethod()
        {
            RecursiveMethod();
        }
        private static void Course09(string[] args)
        {
            try
            {
                Console.WriteLine(args[1]);
                int x = int.Parse(args[0]);
                int z = 7 / x;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of bounds");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Failed to convert to int !!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ooop there is an exception !!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("The finally block always executes !!");
            }

            Shape sh = new Shape();
            try
            {
                sh.Draw();
            }
            finally
            {
                sh.Dispose();
            } 

            //this is equivalent to try/finally from above
            using(Shape s2 = new Shape())
            {
                s2.Draw();
            }
            

    
            throw new BtException("End of the call");

        }

        static void Course01(string [] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;
            const int MAX_NUMBER = 5;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere");
            Console.WriteLine(6 + 2);
            Console.WriteLine("6 + 2");

            int numberOfStudents = 5;
            int count;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;
            short s = 5;
            ulong ul = 65;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudents;

            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;
            char ch = '1'; // '1' != 1

            string myString = "Ana are mere si pere";
            string result = myString + " si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberFloat * a);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5; //x = x+5;
            // x++<=> x= x+1
            //++x <=> x= x+1
            Console.WriteLine(x++);
            Console.WriteLine((x <= a));

            int number = 8;
            Console.WriteLine("Number tested is " + number);
            if (number >= 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            if (number <= 40 && number >= 0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failed!");
                }
                else
                {
                    Console.WriteLine("Student passed!");
                }
            }
            else
            {
                Console.WriteLine("Grade is invalid");
            }

            //One line if / else
            String message = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(message);

            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Not a valid day");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid day");
                        break;
                    }
            }

            // WHILE
            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }

            // DO WHILE
            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }
            while (counter <= MAX_NUMBER);

            // FOR
            for (counter = 0; counter <= MAX_NUMBER; counter++)
            {
                // Console.WriteLine("Current number is: " + counter);
                Console.WriteLine("Current number is: {0}", counter);
            }

            // FOREACH
            foreach (string argument in args)
            {
                Console.WriteLine("The argument is: {0}", argument);
            }


            // LEEP YEAR

            foreach (string yr in args)
            {
                int febDays = 28;
                int year = int.Parse(yr);
                if (year < 1900 || year > 2016)
                {
                    Console.WriteLine("Year is ot of valid bounds (1900-2016)");
                }
                else
                {
                    if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        febDays = 29;
                    }
                }

                Console.WriteLine("February has {0} days for year {1} ", febDays, year);
            }
        }
        static void Course02(string [] args)
        {
            Circle c1 = new Circle();
            Circle c2; //c2 will be null !!!
            c1.SetRadius(10);
            //double area = c1.GetArea();
            c1.PrintCircle();
            
            Circle c3 = new Circle();
            c3.SetRadius(5);
            c3.PrintCircle();
           
            foreach(string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(p));

                Square s = new Square();
                s.SetSide(Double.Parse(p));

                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(p), Double.Parse(p));

                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();
            }

            Person p1 = new Person();
            p1.SetName("Cristi");
            p1.SetSex('M');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPerson();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();

           
        } 
        static void Course03(string [] args)
        {
            //ComputeConversion(args);
            CurrencyCalculator(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, 'a', "17d");
            // Console.WriteLine(ConcatenateStrings(args));
            Random rnd = new Random();
            GuessNumber(rnd.Next(1,1000));
        }
        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape2(5, 3);
            Console.WriteLine();
            DrawShapeOutline(10,15);
            Console.WriteLine();
            DrawFullShapeCorners(10, 13);

            Circle c1 = new Circle(); // instantiate c1 with default (no params) constructor 
            Circle c2 = new Circle(10); // instantiate c2 with constructor having 1 double parapeter
            c1.PrintCircle();
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Cristi", 'M', new string[] { "Romanian" }, false, new DateTime());
            p1.PrintPerson();
            p2.PrintPerson();

            Rectangle r1 = new Rectangle(2,7);
            r1.PrintRectangle();

            Square s1 = new Square(6);
            s1.PrintSquare();

            StructExample se = new StructExample();
            StructExample.MyStruct myStruct = new StructExample.MyStruct();
            myStruct.Assign(10, "abc");
            Console.WriteLine(myStruct.ComputeSum());

            StructExample.Rectangle3d r2 = new StructExample.Rectangle3d();
            r2.Assign(2, 5, 7);
            Console.WriteLine(r2.GetVolume());
        }
        static void Course05()
        {
            DrawShapeOutline(5);
            DrawShapeOutline(10, 5);
            DrawFullShapeCorners(6);
            DrawFullShape(7);

            Circle c = new Circle(4);
            c.Draw();
            Triangle t1 = new Triangle(5, 7, 9);
            t1.Draw();
            Square s1 = new Square(5); 
            Rectangle r1 = new Rectangle(2, 7);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(c.ToString());
            Console.WriteLine(t1.ToString());
            Console.WriteLine(r1.ToString());
            Console.WriteLine(s1.ToString());

            Teacher teacher1 = new Teacher("Programming", "UPB", 2000, "Gigel Programator", 'M');
            teacher1.PrintTeacher();

            Student student1 = new Student("An 1",true,true,"Andreea",'F');
            student1.PrintStudent();



        }

        private static void Course07()
        {
            Square s1 = new Square();
            Rectangle r1 = new Rectangle();
            Shape sh1 = new Shape();

            //polymorphism
            IShape s2 = new Square(); 
            IShape r2 = new Rectangle();
            IShape sh2 = new Shape(); 

            List<string> lista = new List<string>();
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(s2);
            shapeList.Add(r2);
            shapeList.Add(sh2);
            shapeList.Add(s1);

            s1.Draw();
            s2.Draw();
            s2.State();
            ((AbstractShape)s2).DoSomething();

            ((Square)s2).PrintSquare();

            //ex of using polymorphism 
            Shape sh3;
            string type = "rectangle";
            switch (type)
            {
                case "square":
                    {
                        sh3 = new Square();
                        break;
                    }
                case "rectangle":
                    {
                        sh3 = new Rectangle();
                        break;
                    }
                default:
                    {
                        sh3 = new Shape();
                        break;
                    }
            }
            sh3.Draw();
            sh3.Erase();

            IIntf ob1 = new MyParticularShape();
            IClass ob2 = new MyParticularShape();
            ob1.Print();
            ob2.Print();

            PartialClass pc = new PartialClass();
            pc.Method1();
            pc.Method2();
        }
        private static void Course06()
        {
            Car c1 = new Car(20, true, 90);
            Car c2 = new Car(0, false, -90);
            c1.Start();
            c1.Accelerate();
            c1.TurnLeft();
            c1.TurnRight();
            Console.WriteLine(Car.ConvertHpToKw(150));
            c2.Start();
            c2.GearUp();
            c2.Accelerate(20);
            c2.Steer(20);
            c2.Accelerate(10);
            c2.TurnLeft();
            c2.GearUp();
            c2.Accelerate();
            c2.PrintCar();

            c2.CarBrand = "Name";

            Rectangle r1 = new Rectangle(3, 4);
            r1.PrintRectangle();
            r1.SetLength(-10);
            r1.PrintRectangle();

        }
        private static void Course08()
{
            Person p = new Person ("Ionel", "Ionescu", "str. Fraternitatii nr.5", "Cluj-Napoca", "RO");
            Employee e = new Employee("Makaduku", "Makao","-","Ananarivo","Madagascar", 1500);
            PartTimeEmployee pe = new PartTimeEmployee("Andrei","Antonescu","str.Teilor nr.7","Iasi","RO",1000);
            Person.PrintPersonStatic(p);
            Employee.PrintPersonStatic(e);
            Employee.PrintPersonStatic(pe);
        
            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            Shape s1 = new Shape();
            Rectangle r1 = new Rectangle();
            Shape[] shapes = new Shape[2] { s1, r1 };

            foreach(int x in intArray)
            {
                Console.WriteLine(x);
            }
            for(int i = 0; i< intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            List<string> myList = new List<string>();
            myList.Add("Alex");
            myList.Add("Bianca");
            myList.Add("Andrei");

            Console.WriteLine(myList.IndexOf("Alex"));
            Console.WriteLine(myList[0]);

            foreach(string s in myList)
            {
                Console.WriteLine(s);
            }
            for(int i =0; i<myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            String stringDemo = "ana are mere"; // a:3, n:1, r:2, e:3, m:1
            Dictionary<char, int> characterFreq = new Dictionary<char, int>();
            foreach(char c in stringDemo) // a,n,a, ,a,r,e, ,m,e,r,e
            {
                if (characterFreq.ContainsKey(c))
                {
                    characterFreq[c]=characterFreq[c] + 1;
                }
                else
                {
                    characterFreq.Add(c, 1);
                }
            }

            foreach(char key in characterFreq.Keys)
            {
                Console.WriteLine("{0}:{1}", key,characterFreq[key]);
            }
            foreach (KeyValuePair<char,int> kvp in characterFreq)
            {
                Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
            }

           // SortedList<int, string> listSorted = new SortedList<int, string>();
            var listSorted = new SortedList<int, string>();
            listSorted.Add(6, "abc");
            listSorted.Add(10, "abcd");
            listSorted.Add(1, "xyz");

            foreach(int key in listSorted.Keys)
            {
                Console.WriteLine("{0}, {1}",key, listSorted[key]);
            }

            //HashSet<int> hs = new HashSet<int>(intArray);
            var hs = new HashSet<int>(intArray);
            hs.Add(1);
            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }

            var myQueue = new Queue<int>();
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(100);
            myQueue.Enqueue(1);
            int value = myQueue.Dequeue();
            Console.WriteLine("Queue elements: {0}", myQueue.Count);

            var myStack = new Stack<int>();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(100);
            myStack.Push(1);
            int stackVal = myStack.Pop(); //return 1
            Console.WriteLine("Stack elements: {0}", myStack.Count);

            Console.WriteLine(Browsers.Firefox);

            

        }

        public static void DrawShapeOutline(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with * counting width
                {
                    if (j == 0 || j == height - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }  
                }
                Console.WriteLine();
            }
        }

        public static void DrawShapeOutline(int l)
        {
            DrawShapeOutline(l, l);
        }

        public static void DrawFullShapeCorners(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with * counting width
                {
                    if ((j==0 && i==0) || (j==0 && i==width-1) || (j==height-1 && i==0) || (j==height-1 && i==width-1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DrawFullShapeCorners(int l) 
        {
            DrawFullShapeCorners(l, l);
        }

        public static void DrawFullShape(int width, int height)
        {
            for (int j = 0; j < height; j++)
            { 
                for (int i = 0; i < width; i++) // this will print a single line with * counting width
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DrawFullShape(int l)
        {
            DrawFullShape(l, l);
        }

        public static void DrawFullShape2(int width, int height)
        {
            string s = "";
            for (int i = 0; i < width; i++) // this will print a single line with * counting width
            {
                s += "*";
            }
            for (int j = 0; j < height; j++)
            {
                Console.WriteLine(s);
            }
        }

        static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        static int TestValue(int testVal, int target)
        {
  
            if (testVal < target)
            {
                Console.WriteLine("Number to be guessed is higher!");
                return -1;
            }
            if (testVal > target)
            {
                Console.WriteLine("The number to be guessed is lower");
                return 1;
            }
            Console.WriteLine("Bazinga! This is the number");
            return 0;
        }

        static void GuessNumber(int n)
        {
            int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Number chosen is {0}", currentNumber);
            }
            while (TestValue(currentNumber, n) != 0);
            
        }

        static Shape GetShape(int x, int y, double a, char t, string s)
        {
            Console.WriteLine(x);
            return new Shape();
        }

        static string ConcatenateStrings(string[] args)
        {
            string returnString = "";
            foreach(string s in args)
            {
                returnString += s; // returnString = returnString + s; 
                
            }
            return returnString;
        }

        static void ComputeConversion(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("The application recives only 3 parameters: amount, currency, exchange rate");
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
            }
        } 
        static void CurrencyCalculator(double amount, string currency, double convertionRate)
        {
            Console.WriteLine("By converting {0} {1} in to RON we obtain {2} RON", amount, currency, amount * convertionRate);
        }
    }
 }
