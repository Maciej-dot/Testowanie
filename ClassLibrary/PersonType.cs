using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class PersonType
    {
        private int id { get; }
        private string name { get; set; } //nazwa wykonywanej roli w filmie, aktor itp
        public PersonType(string n)
        {
            name = n;
        }
        public string toString()
        {
            return this.name;
        }
    }
}
