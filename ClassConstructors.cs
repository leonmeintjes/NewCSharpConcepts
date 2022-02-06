using System;
using System.Dynamic;
using System.Security.Policy;

namespace NewCSharpConcepts
{
    
    

    public class ClassConstructors
    {
        public int Age { get; set; }
        public string? Name { get; set; }

        //Constructors have 
        //    - No return value (not event null)
        //    - Same name as
        //    - zero or more parameters
        public ClassConstructors(int age, string name)
        {
        Age = age;
        Name = name;
        }

        //default constructors
        // Any constructor without parameters ---> can only have one of each type not both (cannot have default and explicit constructors in same class)
        public ClassConstructors()
        {
            
        }
    }

}

