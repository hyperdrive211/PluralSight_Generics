using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PluralSight_Generics
{
    class Employee
    {
        public String Name {
            get; 
        }

        public Employee(string name) {
            this.Name = name; 
        }
    }
}
