using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace WindowsFormUI.Forms
{
    public partial class ColorForm : Form
    {
        private IColorService _colorService;
        public ColorForm()
        {
            InitializeComponent();
            _colorService = new ColorManager(new EfColorDal());
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            ColorGridControl.DataSource = _colorService.GetAll();
        }
    }
}
