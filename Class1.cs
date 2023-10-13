using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string firstname;
        public string lastname;
        public float height;
        public float weigth;

        public string getdata()
        {
            return $"Imie i nazwisko; {firstname} {lastname}\nWzrost: {height} cm, waga {weigth} kg";
        }
    }
}
