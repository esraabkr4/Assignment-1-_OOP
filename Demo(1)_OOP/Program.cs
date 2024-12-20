namespace Demo_1__OOP
{
    //what can write in namespace
    //class,struct(structor),interface,enum
    //allowed access_modifier inside name space
    //internal(default access modifier),public
    enum Grades
    {
        //Labeles
        A,B,C,D,F
    }
    enum Gender
    {
        Male=1,Female=2,M=1,F=2
    }
    internal class Program
    {
        //what can write in class or struct
        //attribute(field or variable),property(indexer),functions(constructor,setter,getter,method),event
        //allowed access_modifier inside struct
        //private,internal,public
        //allowed access_modifier inside class
        //private,private protected,protected,internal,internal protected,public
        static void Main(string[] args)
        {
            #region Access Modifiers
            //Private=>can be seen only inside its class or struct
            //internal=>can be seen insite its project
            //public=>can be seen everywere
            //what can write in namespace
            //class,struct(structor),interface,enum
            //allowed access_modifier inside name space
            //internal(default access modifier),public
            //what can write in class or struct
            //attribute(field or variable),property(indexer),functions(constructor,setter,getter,method),event
            //allowed access_modifier inside struct
            //private,internal,public
            //allowed access_modifier inside class
            //private,private protected,protected,internal,internal protected,public
            //what can write in Interfaces
            //signature for property,signature for method,default implemented method
            //default access modifier inside interface is =>public
            #endregion
           
            #region Enum
            /*value data type*/
            Grades grades = Grades.A;
            if (grades == Grades.A)
                Console.WriteLine("Congratulation A+");
            else
                Console.WriteLine("Sorry");
            #endregion
            #region Struct
            Point p1;//declare for object from type point(value data type)
            //CLR will allocate 8bytes on intialize at stack
            p1 = new Point();//for choose parameterless constructor
            //new just for constructor choise
            Console.WriteLine(p1.x);
            p1 = new Point(3,5);
            Console.WriteLine(p1.ToString());
            #endregion
            #region Encapsulation
            //to protect data
            Employee emp=new Employee(12,"mona",Gender.Female,3000);
            emp.ID = 20;//Setter
            Console.WriteLine(emp.ID);//Getter
            emp.SetName("Esraa");
            Console.WriteLine(emp.GetName());
            #endregion
           
        }
    }
}
