using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WindowsFormUI.Forms
{
    public partial class ColorForm : Form
    {
        private IColorService _colorService;
        private int id = 0;
        public ColorForm()
        {
            InitializeComponent();
            _colorService = new ColorManager(new EfColorDal());
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            ColorGridControl.DataSource = _colorService.GetAll();
        }

        private void ColorRefreceBtn_Click(object sender, EventArgs e)
        {
            GetAllToColorGridControl();
        }

        private void ColorAddBtn_Click(object sender, EventArgs e)
        {
            _colorService.Add(new Color
            {
                Name = ColorNameTextEdit.Text
            });

            GetAllToColorGridControl();
        }

        private void GetAllToColorGridControl()
        {
            ColorGridControl.DataSource = _colorService.GetAll();
        }

        private void ColorUpdateBtn_Click(object sender, EventArgs e)
        {
            _colorService.Update(new Color
            {
                Id = Convert.ToInt32(ColorIdTextEdit.Text),
                Name = ColorNameTextEdit.Text
            });

            GetAllToColorGridControl();
        }

        private void ColorDeleteBtn_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult dialogResult = MessageBox.Show(_colorService.GetById(id).Name + " rengi silmek istediğinizden eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _colorService.Delete(new Color
                    {
                        Id = id
                    });
                }
            }
            GetAllToColorGridControl();
        }

        private void ColorGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = ColorGridView.FocusedRowHandle;

            if (index >= 0)
            {
                id = Convert.ToInt32(ColorGridView.GetRowCellValue(index, "Id").ToString());
            }

            Color color = _colorService.GetById(id);
            ColorIdTextEdit.Text = color.Id.ToString();
            ColorNameTextEdit.Text = color.Name;
        }
    }
}
