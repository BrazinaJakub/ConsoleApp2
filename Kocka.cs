using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Kocka
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }
        

        //Constructor
        public Kocka(string _name, int _age)
        {
            Name = _name;
            Age = _age;            
        }



    }
}
