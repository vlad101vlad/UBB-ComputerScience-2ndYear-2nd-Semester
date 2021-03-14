using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Domain
{
    public class City
    {
        int ID;
        String name;
        int countryID;

        public City()
        {

        }

        public City(int ID, string name, int countryID)
        {
            this.ID = ID;
            this.name = name;
            this.countryID = countryID;
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

        public int getCountryID()
        {
            return this.countryID;
        }

        public void setCountryID(int newCountryID)
        {
            this.countryID = newCountryID;
        }

    }
}
