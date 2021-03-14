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
        public City toBeReturnedCity;

        public addUpdateForm(int openingCode, int countyID)
        {
            InitializeComponent();
            this.OPENING_CODE = openingCode;
            this.countyID = countyID;

            setupFormElements();
        }

        private void setupFormElements()
        {
            if(OPENING_CODE == constants.UPDATE_MODE)
            {
                this.cityIDLabel.Visible = false;
                this.cityIDTextBox.Visible = false;
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

        private void handleUpdateMode()
        {

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
                    handleUpdateMode();
                    break;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
