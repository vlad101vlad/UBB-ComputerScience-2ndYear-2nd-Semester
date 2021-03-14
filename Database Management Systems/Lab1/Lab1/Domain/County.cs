using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Domain
{
    public class County
    {
        int ID;
        String name;

        public County(int iD, string name)
        {
            ID = iD;
            this.name = name;
        }

        public int getID()
        {
            return this.ID;
        }

        public void setID(int newID)
        {
            this.ID = newID;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }
    }
}
