using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Domain
{
    class City
    {
        int ID;
        String name;
        int countryID;

        public City(int ID, string name, int countryID)
        {
            this.ID = ID;
            this.name = name;
            this.countryID = countryID;
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

        int getCountryID()
        {
            return this.countryID;
        }

        void setCountryID(int newCountryID)
        {
            this.countryID = newCountryID;
        }

    }
}
