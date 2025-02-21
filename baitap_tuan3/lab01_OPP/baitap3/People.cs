using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class People
    {
        protected int ID;
        protected string Name;

        public People() // Constructor mặc định
        {
            ID = 0;
            Name = "Unknown";
        }

        public People(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void SetID(int id) { ID = id; }
        public int GetID() { return ID; }

        public void SetName(string name) { Name = name; }
        public string GetName() { return Name; }
    }
}
