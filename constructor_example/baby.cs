using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_example
{
    public class baby
    {

        //property tanımlamaları
        public DateTime dateofbirth { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        //default
        public baby()
            {
            dateofbirth =  DateTime.Now;
            Console.WriteLine("ıngaaaa");


            }
        //alternative 

        public baby(string name, string surname)
        {

            name = name;
            surname = surname;
            dateofbirth = DateTime.Now;

            Console.WriteLine($"ıngaaaaaa");


        }

        //method to print baby information

        public void PrintInformation()
        {
            Console.WriteLine($"name: {name} surname: {surname} date of birth: {dateofbirth} ");

        }
    }
}
