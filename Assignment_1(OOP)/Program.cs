using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;

namespace Assignment_1_OOP_
{   //Q1 enum
    enum WeekDays  { MonDay, TuesDay, WednesDay, ThursDay, Friday, SaturDay, SunDay };
    
    //Q3 enum
    enum Season { Spring, Summer, Autumn, Winter };
    //Q4 enum
    enum Permissions { Read, write, Delete, Execute }
    //Q5 enum
    enum Colors { red, green, blue }
    internal class Program
    {
        static void Main(string[] args)
        {
            /**************************Enum and Struct*******************************/

            #region Q1
            ////1. Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as 
            ////its members.Then, write a C# program that prints out all the days of the week
            ////using this enum.

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion

            #region Q2
            ////2. Define a struct "Person" with properties "Name" and "Age".
            ////Create an array of three "Person" objects and populate it with data.Then, 
            ////write a C# program to display the details of all the persons in the array.

            //Person[] personsArr = new Person[3];
            //personsArr[0] = new Person("Ahmed", 25) ;
            //personsArr[1] = new Person("Mona", 19);
            //personsArr[2] = new Person("Ali", 33);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(personsArr[i]);
            //}
            #endregion

            #region Q3
            ////3. Create an enum called "Season" with the four seasons(Spring, Summer, 
            ////Autumn, Winter) as its members.Write a C# program that takes a season name 
            ////as input from the user and displays the corresponding month range for that season. 
            ////Note range for seasons ( spring march to may , summer june to august , 
            ////autumn September to November , winter December to February)

            //bool flag;
            //Season UserSeason;
            //do
            //{
            //    Console.WriteLine("Please Enter Season Name (Spring, Summer, Autumn, Winter)");
            //    flag=Enum.TryParse(Console.ReadLine(), out UserSeason);
            //}while(!flag);
            //switch (UserSeason)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Month Range is from march to may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Month Range is from june to august");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Month Range is from September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Month Range is from December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Season Name");
            //        break;
            //}
            #endregion

            #region Q4
            ////4. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ////Create Variable from previous Enum to Add and Remove Permission from variable, 
            ////check if specific Permission is existed inside variable

            //Permissions UserPer=Permissions.write & Permissions.Delete;
            //Console.WriteLine(UserPer);
            ////only permission Read is exist neither Add nor Remove are exist in it
            #endregion

            #region Q5
            ////5. Create an enum called "Colors" with the basic colors(Red, Green, Blue) 
            ////as its members.Write a C# program that takes a color name as input from the user 
            ////and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Please Enter any Color to check if Primary");
            //Colors userColor;
            //bool flag=Enum.TryParse(Console.ReadLine().ToLower(),out userColor);
            //if(flag)
            //    Console.WriteLine("This Is A Primary Color");
            //else
            //    Console.WriteLine("Not Primary Color");
            #endregion

            #region Q6
            ////6. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
            ////Write a C# program that takes two points as input from the user and calculates the 
            ////distance between them.

            //Point[] PointsArr=new Point[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    bool flag1 = false,flag2=false;
            //    do
            //    {
            //        Console.WriteLine($"Enter Point{i + 1} X");
            //        flag1=int.TryParse(Console.ReadLine(),out PointsArr[i].X);
            //        Console.WriteLine($"Enter Point{i + 1} Y");
            //        flag2 = int.TryParse(Console.ReadLine(), out PointsArr[i].Y);
            //    }
            //    while (!flag1||!flag2);

            //}
            //Point P=new Point();
            //P.Distance(PointsArr[0],PointsArr[1]);
            #endregion

            #region Q7
            ////7. Create a struct called "Person" with properties "Name" and "Age". 
            ////Write a C# program that takes details of 3 persons as input from the user 
            ////and displays the name and age of the oldest person.

            Person[] PersonsArr = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                bool flag = false;
                Console.WriteLine($"Enter Person{i + 1} Name");
                PersonsArr[i].Name = Console.ReadLine();
                do
                {
                    Console.WriteLine($"Enter Person{i + 1} Age");
                    flag = int.TryParse(Console.ReadLine(), out PersonsArr[i].Age);
                }
                while (!flag);
            }
            Program.OldestPerson(PersonsArr);
            #endregion

        }
        //Q7 function
        static void OldestPerson(Person[] persons)
        {
            Person OldestOne = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > OldestOne.Age)
                    OldestOne = persons[i];
            }
            Console.WriteLine($"The Oldest One: {OldestOne}");
        }
    }
}
