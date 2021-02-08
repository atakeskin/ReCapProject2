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
            GetAllToCarGridControl();
        }

        private void GetAllToCarGridControl()
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
        int id = 0;
        private void CarGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = CarGridView.FocusedRowHandle;
            
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
            CarNameTextEdit.Text = car.Name;
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(PlakaNoTextEdit.Text +" "+, "Sonuç", MessageBoxButtons.OK);
            _carService.Add(new Car
            {
                Name = CarNameTextEdit.Text,
                BrandId = Convert.ToInt32(BranIdTextEdit.EditValue.ToString()),
                ColorId = Convert.ToInt32(ColorIdTextEdit.EditValue.ToString()),
                PlakaNo = PlakaNoTextEdit.Text,
                ModelYear = ModelYearTextEdit.DateTime,
                DailyPrice = Convert.ToDecimal(DailyPriceTextEdit.Text),
                Description = DescriptionTextEdit.Text
            });
            GetAllToCarGridControl();
        }

        private void ModelYearTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCarBtn_Click(object sender, EventArgs e)
        {
            _carService.Update(new Car
            {
                Id = Convert.ToInt32(CarIdTextEdit.Text),
                BrandId = Convert.ToInt32(BranIdTextEdit.EditValue.ToString()),
                ColorId = Convert.ToInt32(ColorIdTextEdit.EditValue.ToString()),
                Name = CarNameTextEdit.Text,
                PlakaNo = PlakaNoTextEdit.Text,
                ModelYear = ModelYearTextEdit.DateTime,
                DailyPrice = Convert.ToDecimal(DailyPriceTextEdit.Text),
                Description = DescriptionTextEdit.Text
            });

            GetAllToCarGridControl();
        }

        private void DeleteCarBtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult dialogResult = MessageBox.Show(_carService.GetById(id).PlakaNo + " plakalı arabayı silmek istediğinizden eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _carService.Delete(new Car
                    {
                        Id = id
                    });
                }

            }
            GetAllToCarGridControl();
        }

        private void AnaFrmPanelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
