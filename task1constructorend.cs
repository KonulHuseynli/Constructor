using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Person
    {
        public Person(string n,string sn,int a)
        {
            Name = n;
            SurName = sn;
            Age = a;
            if(Age>18)
            {
                IsAdult = true;
            }
            else
            {
                IsAdult = false;
            }
        }
        public string Name;
        public string SurName;
        public int Age;
        public bool IsAdult;
        public void constructor()
        {
            Console.WriteLine(IsAdult);
        }
    }
}
