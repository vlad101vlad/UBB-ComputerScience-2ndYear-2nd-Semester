using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Lab1.Repository;

namespace Lab1.Service
{
    public class CityService
    {
        private CityRepository cityRepository;

        public CityService(CityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public DataTable getCities(int countyID)
        {
            return this.cityRepository.getCitiesDataTable(countyID);
        }

    }
}
