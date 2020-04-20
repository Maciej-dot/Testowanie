using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Person
    {
        private int id { get; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private DateTime bornDate { get; set; }
        public Person(string f, string l, DateTime b)
        {
            firstName = f;
            lastName = l;
            bornDate = b;
        }
        public string toString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
