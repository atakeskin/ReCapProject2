using System.Windows.Forms;
using WindowsFormUI.Forms;

namespace WindowsFormUI
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }


        private void CarCrudBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarForm carForm = new CarForm();
            GetForm(carForm);
        }


        private void BrandCrudBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            GetForm(brandForm);
        }


        private void ColorCrudBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColorForm colorForm = new ColorForm();
            GetForm(colorForm);
        }

        private void GetForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
    }
}
