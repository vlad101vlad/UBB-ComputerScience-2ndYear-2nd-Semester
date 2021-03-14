using Lab1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace Lab1.Service
{
    public class CountyService
    {
        private CountyRepository countyRepository;

        public CountyService(CountyRepository countyRepository)
        {
            this.countyRepository = countyRepository;
        }

        public DataTable getCounties()
        {
            return countyRepository.getCounties();
        }
    }
}
