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
using Lab1.View;

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

        private void citiesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            citiesDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            citiesDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            citiesDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void addNewCityButton_Click(object sender, EventArgs e)
        {
            int cityID = (int)citiesDataGridView.SelectedCells[0].Value;
            using (addUpdateForm addUpdateForm = new addUpdateForm(constants.ADD_MODE, countyID, 0))
            {

                var result = addUpdateForm.ShowDialog();
                if (result == DialogResult.OK)
                    this.cityService.addNewCity(addUpdateForm.toBeReturnedCity);
            }
        }

        private void updateSelectedCityButton_Click(object sender, EventArgs e)
        {
            int cityID = (int)citiesDataGridView.SelectedCells[0].Value;
            using (addUpdateForm addUpdateForm = new addUpdateForm(constants.UPDATE_MODE, countyID, cityID))
            {
                

                var result = addUpdateForm.ShowDialog();
                if (result == DialogResult.OK)
                    this.cityService.addNewCity(addUpdateForm.toBeReturnedCity);

            }
            
            
        }

        private void deleteSelectedCityButton_Click(object sender, EventArgs e)
        {
            int cityID = (int)citiesDataGridView.SelectedCells[0].Value;

            this.cityService.deleteCity(cityID);
        }
    }
}
