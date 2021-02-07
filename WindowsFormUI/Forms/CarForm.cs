using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace WindowsFormUI.Forms
{
    public partial class CarForm : Form
    {
        private ICarService _carService;
        public CarForm()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
        }

        
        private void CarForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            CarGridControl.DataSource = _carService.GetCarDetails();
        }
    }
}
