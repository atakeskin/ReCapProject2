using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

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
            CarGridControl.DataSource = _carService.GetCarDetailsByCarProperty().Data;
            BranIdTextEdit.Properties.ValueMember = "Id";
            BranIdTextEdit.Properties.DisplayMember = "Name";
            BranIdTextEdit.Properties.DataSource = _brandService.GetAll().Data;
            ColorIdTextEdit.Properties.ValueMember = "Id";
            ColorIdTextEdit.Properties.DisplayMember = "Name";
            ColorIdTextEdit.Properties.DataSource = _colorService.GetAll().Data;
            lUEBrandName.Properties.ValueMember = "Id";
            lUEBrandName.Properties.DisplayMember = "Name";
            lUEBrandName.Properties.DataSource = _brandService.GetAll().Data;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void CarGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            WriteToTextBoxByCarGridView();
        }
        int id = 0;
        private void WriteToTextBoxByCarGridView()
        {
            int index = CarGridView.FocusedRowHandle;

            if (index >= 0)
            {
                id = Convert.ToInt32(CarGridView.GetRowCellValue(index, "Id").ToString());
            }


            var car = _carService.GetById(id).Data;
            CarIdTextEdit.Text = car.Id.ToString();
            BranIdTextEdit.Text = _brandService.GetById(car.BrandId).Data.Name;
            ColorIdTextEdit.Text = _colorService.GetById(car.ColorId).Data.Name;
            PlakaNoTextEdit.Text = car.PlakaNo;
            DailyPriceTextEdit.Text = car.DailyPrice.ToString();
            DescriptionTextEdit.Text = car.Description;
            ModelYearTextEdit.Text = car.ModelYear.ToString();
            CarNameTextEdit.Text = car.Name;
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ModelYearTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCarBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DeleteCarBtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult dialogResult = MessageBox.Show(_carService.GetById(id).Data.PlakaNo + " plakalı arabayı silmek istediğinizden eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _carService.Delete(new Car
                        {
                            Id = id
                        });
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.InnerException.InnerException.Message);
                    }
                }

            }
            GetAllToCarGridControl();
        }

        private void AnaFrmPanelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lUEBrandName_EditValueChanged(object sender, EventArgs e)
        {

            CarGridControl.DataSource = _carService.GetCarDetailsByCarProperty(c=>c.BrandId==Convert.ToInt32(lUEBrandName.EditValue.ToString())).Data;
        }

        private void CarGridControl_Click(object sender, EventArgs e)
        {

        }

        private void CarGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            WriteToTextBoxByCarGridView();
        }

        private void txtSearchByPlate_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchByPlate.Text))
            {
                CarGridControl.DataSource = _carService.GetCarDetailsByCarProperty(c=>c.PlakaNo.ToLower().Contains(txtSearchByPlate.Text.ToLower())).Data;

            }
            else
            {
                GetAllToCarGridControl();
            }
        }
    }
}
