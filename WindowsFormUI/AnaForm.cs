using System.Windows.Forms;
using WindowsFormUI.Forms;
using WindowsFormUI.Forms.Users;

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

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserFrm userFrm = new UserFrm();
            GetForm(userFrm);
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomerFrm customerFrm = new CustomerFrm();
            GetForm(customerFrm);
        }

        private void btnRental_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RentalFrm rentalFrm = new RentalFrm();
            GetForm(rentalFrm);
        }
    }
}
