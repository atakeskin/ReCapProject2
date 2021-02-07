using System;
using System.Data;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WindowsFormUI.Forms
{
    public partial class CarForm : Form
    {
        private ICarService _carService;
        private IBrandService _brandService;
        private IColorService _colorService;
        public CarForm()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            _brandService = new BrandManager(new EfBrandDal());
            _colorService = new ColorManager(new EfColorDal());
        }

        
        private void CarForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            CarGridControl.DataSource = _carService.GetCarDetails();
            BranIdTextEdit.Properties.ValueMember = "Id";
            BranIdTextEdit.Properties.DisplayMember = "Name";
            BranIdTextEdit.Properties.DataSource = _brandService.GetAll();
            ColorIdTextEdit.Properties.ValueMember = "Id";
            ColorIdTextEdit.Properties.DisplayMember = "Name";
            ColorIdTextEdit.Properties.DataSource = _colorService.GetAll();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void CarGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = CarGridView.FocusedRowHandle;
            int id = 0;
            if (index >= 0)
            {
                id = Convert.ToInt32(CarGridView.GetRowCellValue(index, "Id").ToString());
            }


            Car car = _carService.GetById(id);
            CarIdTextEdit.Text = car.Id.ToString();
            BranIdTextEdit.Text = _brandService.GetById(car.BrandId).Name;
            ColorIdTextEdit.Text = _colorService.GetById(car.ColorId).Name;
            PlakaNoTextEdit.Text = car.PlakaNo;
            DailyPriceTextEdit.Text = car.DailyPrice.ToString();
            DescriptionTextEdit.Text = car.Description;
            ModelYearTextEdit.Text = car.ModelYear.ToString();
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            _carService.Add(new Car
            {
                BrandId = BranIdTextEdit.ItemIndex,
                ColorId = ColorIdTextEdit.ItemIndex,
                PlakaNo = PlakaNoTextEdit.Text,
                ModelYear = ModelYearTextEdit.DateTime,
                DailyPrice = Convert.ToDecimal(DescriptionTextEdit.Text),
                Description = DescriptionTextEdit.Text
            });
        }
    }
}
