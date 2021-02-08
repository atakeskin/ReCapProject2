
namespace WindowsFormUI.Forms
{
    partial class BrandForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandForm));
            this.BrandGridControl = new DevExpress.XtraGrid.GridControl();
            this.BrandGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BrandIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BrandRefreceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.BrandDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.BrandUpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.BrandAddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.BrandNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandGridControl
            // 
            this.BrandGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrandGridControl.Location = new System.Drawing.Point(0, 268);
            this.BrandGridControl.MainView = this.BrandGridView;
            this.BrandGridControl.Name = "BrandGridControl";
            this.BrandGridControl.Size = new System.Drawing.Size(800, 253);
            this.BrandGridControl.TabIndex = 1;
            this.BrandGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BrandGridView});
            // 
            // BrandGridView
            // 
            this.BrandGridView.GridControl = this.BrandGridControl;
            this.BrandGridView.Name = "BrandGridView";
            this.BrandGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.BrandGridView_FocusedRowChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Brand Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Id";
            // 
            // BrandIdTextEdit
            // 
            this.BrandIdTextEdit.Enabled = false;
            this.BrandIdTextEdit.Location = new System.Drawing.Point(106, 41);
            this.BrandIdTextEdit.Name = "BrandIdTextEdit";
            this.BrandIdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandIdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.BrandIdTextEdit.Properties.BeepOnError = false;
            this.BrandIdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.BrandIdTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.BrandIdTextEdit.Properties.MaskSettings.Set("mask", "99999");
            this.BrandIdTextEdit.Size = new System.Drawing.Size(100, 26);
            this.BrandIdTextEdit.TabIndex = 3;
            // 
            // BrandRefreceBtn
            // 
            this.BrandRefreceBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandRefreceBtn.Appearance.Options.UseFont = true;
            this.BrandRefreceBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BrandRefreceBtn.ImageOptions.Image")));
            this.BrandRefreceBtn.Location = new System.Drawing.Point(556, 174);
            this.BrandRefreceBtn.Name = "BrandRefreceBtn";
            this.BrandRefreceBtn.Size = new System.Drawing.Size(131, 44);
            this.BrandRefreceBtn.TabIndex = 7;
            this.BrandRefreceBtn.Text = "Yenile";
            this.BrandRefreceBtn.Click += new System.EventHandler(this.BrandRefreceBtn_Click);
            // 
            // BrandDeleteBtn
            // 
            this.BrandDeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandDeleteBtn.Appearance.Options.UseFont = true;
            this.BrandDeleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BrandDeleteBtn.ImageOptions.Image")));
            this.BrandDeleteBtn.Location = new System.Drawing.Point(405, 174);
            this.BrandDeleteBtn.Name = "BrandDeleteBtn";
            this.BrandDeleteBtn.Size = new System.Drawing.Size(131, 44);
            this.BrandDeleteBtn.TabIndex = 8;
            this.BrandDeleteBtn.Text = "Sil";
            this.BrandDeleteBtn.Click += new System.EventHandler(this.BrandDeleteBtn_Click);
            // 
            // BrandUpdateBtn
            // 
            this.BrandUpdateBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandUpdateBtn.Appearance.Options.UseFont = true;
            this.BrandUpdateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BrandUpdateBtn.ImageOptions.Image")));
            this.BrandUpdateBtn.Location = new System.Drawing.Point(257, 174);
            this.BrandUpdateBtn.Name = "BrandUpdateBtn";
            this.BrandUpdateBtn.Size = new System.Drawing.Size(131, 44);
            this.BrandUpdateBtn.TabIndex = 9;
            this.BrandUpdateBtn.Text = "Güncelle";
            this.BrandUpdateBtn.Click += new System.EventHandler(this.BrandUpdateBtn_Click);
            // 
            // BrandAddBtn
            // 
            this.BrandAddBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandAddBtn.Appearance.Options.UseFont = true;
            this.BrandAddBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BrandAddBtn.ImageOptions.Image")));
            this.BrandAddBtn.Location = new System.Drawing.Point(106, 174);
            this.BrandAddBtn.Name = "BrandAddBtn";
            this.BrandAddBtn.Size = new System.Drawing.Size(131, 44);
            this.BrandAddBtn.TabIndex = 10;
            this.BrandAddBtn.Text = "Kaydet";
            this.BrandAddBtn.Click += new System.EventHandler(this.BrandAddBtn_Click);
            // 
            // BrandNameTextEdit
            // 
            this.BrandNameTextEdit.Location = new System.Drawing.Point(106, 81);
            this.BrandNameTextEdit.Name = "BrandNameTextEdit";
            this.BrandNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.BrandNameTextEdit.Properties.BeepOnError = false;
            this.BrandNameTextEdit.Size = new System.Drawing.Size(181, 26);
            this.BrandNameTextEdit.TabIndex = 11;
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.BrandNameTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BrandIdTextEdit);
            this.Controls.Add(this.BrandRefreceBtn);
            this.Controls.Add(this.BrandDeleteBtn);
            this.Controls.Add(this.BrandUpdateBtn);
            this.Controls.Add(this.BrandAddBtn);
            this.Controls.Add(this.BrandGridControl);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrandGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl BrandGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BrandGridView;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit BrandIdTextEdit;
        private DevExpress.XtraEditors.SimpleButton BrandRefreceBtn;
        private DevExpress.XtraEditors.SimpleButton BrandDeleteBtn;
        private DevExpress.XtraEditors.SimpleButton BrandUpdateBtn;
        private DevExpress.XtraEditors.SimpleButton BrandAddBtn;
        private DevExpress.XtraEditors.TextEdit BrandNameTextEdit;
    }
}