using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Service;

namespace Lab1
{
    public partial class mainWindow : Form
    {
        CountyService countyService;


        public mainWindow(CountyService countyService)
        {
            InitializeComponent();
            setCountyService(countyService);
        }

        

        void setCountyService(CountyService newService)
        {
            this.countyService = newService;
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            DataTable counties = countyService.getCounties();

            parentTableGridView.DataSource = counties;
        }

        private void parentTableGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            parentTableGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            parentTableGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void parentTableGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CitiesWindow citiesWindow = new CitiesWindow();
            citiesWindow.Show();
        }
    }
}
