using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MovieType
    {
        private int id { get; }
        private string name { get; set; } //nazwa gatunku
        public MovieType(string n)
        {
            name = n;
        }
        public string toString()
        {
            return this.name;
        }
    }
}
