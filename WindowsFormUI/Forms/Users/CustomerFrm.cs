using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace WindowsFormUI.Forms.Users
{
    public partial class CustomerFrm : Form
    {
        private ICustomerService _customerService;
        public CustomerFrm()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            gcCustomerList.DataSource = _customerService.GetAll().Data;
        }
    }
}
