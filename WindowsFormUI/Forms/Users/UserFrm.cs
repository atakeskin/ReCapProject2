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
    public partial class UserFrm : Form
    {
        private IUserService _userService;
        public UserFrm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {
            gcUserList.DataSource = _userService.GetAll().Data;
        }
    }
}
