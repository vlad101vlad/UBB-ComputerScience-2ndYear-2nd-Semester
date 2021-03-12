using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Domain
{
    class Country
    {
        int ID;
        String name;

        public Country(int iD, string name)
        {
            ID = iD;
            this.name = name;
        }

        int getID()
        {
            return this.ID;
        }

        void setID(int newID)
        {
            this.ID = newID;
        }

        String getName()
        {
            return this.name;
        }

        void setName(String newName)
        {
            this.name = newName;
        }
    }
}
