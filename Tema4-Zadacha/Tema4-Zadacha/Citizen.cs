using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Zadacha
{
    class Citizen
    {
        private string name;
        private int age;
        private string id { get; set; }

        public Citizen(string name, int age,string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

    }
}
