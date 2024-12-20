using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1__OOP
{
    internal class Employee
    {
        #region Attributes
        public int ID;
        private string Name;
        Gender Sex;
        private decimal salary;//start with small letter and its property start with capital one
        #endregion
        #region Constructor
        public Employee(int _ID, string _Name, Gender _Sex, decimal _salary)
        {
            ID = _ID;
            Name = _Name;
            Sex = _Sex;
            this.salary = _salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"ID:{ID} \n Name:{Name} \n Sex: {Sex} \n Salary: {salary}";
        }
        #endregion
        #region Encapsulation
        //separate data definition(properties) from its use 
        //(setter,gitter,property,indexer)
        //Getter
        public string GetName()
        {
            return Name ;
        }
        //Setter
        public void SetName(string value)
        {
            //control data validation
            Name = value.Length<=5?value:value.Substring(0,5) ;
        }
        //Applying Property
        //1-Full Property
        //public decimal Salary //if i need to validate
        //{
        //    get
        //    {
        //        return salary;
        //    }
        //    private set{ //to prevent send
        //        salary = value;
        //    }
        //}
//2-Automatic Property
        public decimal NewAtrr { get; set; }//Syntax Sugar
        #endregion
    }
}
