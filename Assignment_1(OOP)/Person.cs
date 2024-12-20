using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_OOP_
{
    //Q2 struct

    internal struct Person
    {
        #region Property
        public string Name;
        public int Age;
        #endregion
        #region Constructor
        public Person(string _Name,int _Age)
        {
            Name = _Name;   
            Age = _Age;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Person name:{Name} ,Person Age:{Age}";
        }
        #endregion


    }
}
