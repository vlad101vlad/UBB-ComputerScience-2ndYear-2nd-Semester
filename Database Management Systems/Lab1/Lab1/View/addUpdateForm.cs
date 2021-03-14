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

namespace Lab1.View
{
    public partial class addUpdateForm : Form
    {
        private int OPENING_CODE;
        private int countyID;
        private int cityID;
        public City toBeReturnedCity;

        public addUpdateForm(int openingCode, int countyID, int cityID)
        {
            InitializeComponent();
            this.OPENING_CODE = openingCode;
            this.countyID = countyID;
            this.cityID = cityID;

            setupFormElements();
        }

        private void setupFormElements()
        {
            this.cityIDTextBox.Text = this.cityID.ToString();
            this.informationLabel.Text = "You are trying to update a city";

            if(OPENING_CODE == constants.ADD_MODE)
            {
                this.cityIDLabel.Visible = false;
                this.cityIDTextBox.Visible = false;
                this.informationLabel.Text = "You are trying to add a new city";
            }
            this.countyIDTextBox.Text = countyID.ToString();

        }

        private City handleAddMode()
        {
            City newCity = new City();
            newCity.setName(cityNameTextBox.Text);
            newCity.setCountryID(Int32.Parse(countyIDTextBox.Text));
            return newCity;
        }

        private City handleUpdateMode()
        {
            City newCity = new City();
            newCity.setID(cityID);
            newCity.setName(cityNameTextBox.Text);
            newCity.setCountryID(Int32.Parse(countyIDTextBox.Text));
            return newCity;
        }

        private void addUpdateForm_Load(object sender, EventArgs e)
        {
            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            switch (OPENING_CODE)
            {
                case constants.ADD_MODE:
                    toBeReturnedCity = handleAddMode();
                    break;
                case constants.UPDATE_MODE:
                    toBeReturnedCity = handleUpdateMode();
                    break;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
