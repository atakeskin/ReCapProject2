using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WindowsFormUI.Forms
{
    public partial class BrandForm : Form
    {
        private IBrandService _brandService;
        private int id = 0;
        public BrandForm()
        {
            InitializeComponent();
            _brandService = new BrandManager(new EfBrandDal());
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            GetAllToBrandGridControl();
        }

        private void GetAllToBrandGridControl()
        {
            BrandGridControl.DataSource = _brandService.GetAll();
        }

        private void BrandAddBtn_Click(object sender, EventArgs e)
        {
            _brandService.Add(new Brand
            {
                Name = BrandNameTextEdit.Text
            });

            GetAllToBrandGridControl();
        }

        private void BrandRefreceBtn_Click(object sender, EventArgs e)
        {
            GetAllToBrandGridControl();
        }

        private void BrandUpdateBtn_Click(object sender, EventArgs e)
        {
            _brandService.Update(new Brand
            {
                Id = Convert.ToInt32(BrandIdTextEdit.Text),
                Name = BrandNameTextEdit.Text
            });

            GetAllToBrandGridControl();
        }

        private void BrandDeleteBtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult dialogResult = MessageBox.Show(_brandService.GetById(id).Data.Name + " markasını silmek istediğinizden eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _brandService.Delete(new Brand
                    {
                        Id = id
                    });
                }
            }
            GetAllToBrandGridControl();
        }
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


        }
       
        private void BrandGridView_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {

        }

        private void BrandGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            int index = BrandGridView.FocusedRowHandle;

            if (index >= 0)
            {
                id = Convert.ToInt32(BrandGridView.GetRowCellValue(index, "Id").ToString());
            }

            var brand = _brandService.GetById(id);
            BrandIdTextEdit.Text = brand.Data.Id.ToString();
            BrandNameTextEdit.Text = brand.Data.Name;
        }
    }
}
