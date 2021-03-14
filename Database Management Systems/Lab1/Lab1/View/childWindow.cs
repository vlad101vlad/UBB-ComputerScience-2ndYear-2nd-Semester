using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Domain;
using Lab1.Service;

namespace Lab1
{
    public partial class CitiesWindow : Form
    {
        CityService cityService;
        int countyID;

        public CitiesWindow(County currentCounty, CityService cityService)
        { 
            InitializeComponent();

            this.cityService = cityService;
            countyID = currentCounty.getID();

            this.countyLabel.Text = currentCounty.getName();
        }

        private void CitiesWindow_Load(object sender, EventArgs e)
        {
            citiesDataGridView.DataSource = cityService.getCities(countyID);
        }
    }
}
