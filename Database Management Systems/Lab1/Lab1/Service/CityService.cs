using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lab1.Repository;
using Lab1.Domain;

namespace Lab1.Service
{
    public class CityService
    {
        private CityRepository cityRepository;

        public CityService(CityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public void addNewCity(City newCity)
        {
            cityRepository.addNewCity(newCity);
        }

        public void updateCity(City updatedCity)
        {
            cityRepository.updateCity(updatedCity);
        }

        public void deleteCity(int cityID)
        {
            cityRepository.deleteCity(cityID);
        }

        public DataTable getCities(int countyID)
        {
            return this.cityRepository.getCitiesDataTable(countyID);
        }

    }
}
