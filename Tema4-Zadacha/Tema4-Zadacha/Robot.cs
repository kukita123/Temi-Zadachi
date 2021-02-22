using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Zadacha
{
    class Robot
    {
        private string name;
        private string id;

        public Robot(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
