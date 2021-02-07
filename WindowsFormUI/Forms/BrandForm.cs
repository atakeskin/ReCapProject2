using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace WindowsFormUI.Forms
{
    public partial class BrandForm : Form
    {
        private IBrandService _brandService;
        public BrandForm()
        {
            InitializeComponent();
            _brandService = new BrandManager(new EfBrandDal());
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            BrandGridControl.DataSource = _brandService.GetAll();
        }
    }
}
