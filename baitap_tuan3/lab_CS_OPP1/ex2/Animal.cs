using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    abstract class Animal
    {
        protected string Type;
        protected string Name;

        public Animal(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public abstract string MakeSound();
        public virtual string GetInfo()
        {
            return $"Animal Type: {Type}, Name: {Name}";
        }
    }
}
