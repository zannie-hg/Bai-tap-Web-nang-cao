using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public virtual void Sleep()
        {
            Console.WriteLine("Animals like sleeping");
        }
        public Animal() { }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat(); //pt truu tuong, k the cai dat o lop cha
        //cac lop con ke thua tu cai dat
       
    }
}
