using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MovieState
    {
        private int id { get; }
        private string name { get; set; } // rodzaj; upcoming itp
        public MovieState(string n) // bylo w diagramie klas, ale nie wiem czy jest potrzebne,
                                    // są trzy typy z ktorych sie wybiera (juz zapisane w bazie)
        {
            name = n;
        }
        public string toString() 
        {
            return this.name;
        }
    }
}
