using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Supplier
    {
        private int id;
        private string name;
        private int contactinfo;

        public Supplier(int id, string name, int contactinfo)
        {
            this.id = id;
            this.name = name;
            this.contactinfo = contactinfo;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Contactinfo { get => contactinfo; set => contactinfo = value; }
    }
}

    

