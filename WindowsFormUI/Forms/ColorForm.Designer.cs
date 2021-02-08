
namespace WindowsFormUI.Forms
{
    partial class ColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorForm));
            this.ColorGridControl = new DevExpress.XtraGrid.GridControl();
            this.ColorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ColorIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ColorRefreceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ColorDeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ColorUpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ColorAddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ColorNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorGridControl
            // 
            this.ColorGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorGridControl.Location = new System.Drawing.Point(0, 268);
            this.ColorGridControl.MainView = this.ColorGridView;
            this.ColorGridControl.Name = "ColorGridControl";
            this.ColorGridControl.Size = new System.Drawing.Size(774, 253);
            this.ColorGridControl.TabIndex = 2;
            this.ColorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ColorGridView});
            // 
            // ColorGridView
            // 
            this.ColorGridView.GridControl = this.ColorGridControl;
            this.ColorGridView.Name = "ColorGridView";
            this.ColorGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ColorGridView_FocusedRowChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Color Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 19);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Id";
            // 
            // ColorIdTextEdit
            // 
            this.ColorIdTextEdit.Enabled = false;
            this.ColorIdTextEdit.Location = new System.Drawing.Point(106, 39);
            this.ColorIdTextEdit.Name = "ColorIdTextEdit";
            this.ColorIdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorIdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ColorIdTextEdit.Properties.BeepOnError = false;
            this.ColorIdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.ColorIdTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.ColorIdTextEdit.Properties.MaskSettings.Set("mask", "99999");
            this.ColorIdTextEdit.Size = new System.Drawing.Size(100, 26);
            this.ColorIdTextEdit.TabIndex = 11;
            // 
            // ColorRefreceBtn
            // 
            this.ColorRefreceBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorRefreceBtn.Appearance.Options.UseFont = true;
            this.ColorRefreceBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColorRefreceBtn.ImageOptions.Image")));
            this.ColorRefreceBtn.Location = new System.Drawing.Point(556, 172);
            this.ColorRefreceBtn.Name = "ColorRefreceBtn";
            this.ColorRefreceBtn.Size = new System.Drawing.Size(131, 44);
            this.ColorRefreceBtn.TabIndex = 15;
            this.ColorRefreceBtn.Text = "Yenile";
            this.ColorRefreceBtn.Click += new System.EventHandler(this.ColorRefreceBtn_Click);
            // 
            // ColorDeleteBtn
            // 
            this.ColorDeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorDeleteBtn.Appearance.Options.UseFont = true;
            this.ColorDeleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColorDeleteBtn.ImageOptions.Image")));
            this.ColorDeleteBtn.Location = new System.Drawing.Point(405, 172);
            this.ColorDeleteBtn.Name = "ColorDeleteBtn";
            this.ColorDeleteBtn.Size = new System.Drawing.Size(131, 44);
            this.ColorDeleteBtn.TabIndex = 16;
            this.ColorDeleteBtn.Text = "Sil";
            this.ColorDeleteBtn.Click += new System.EventHandler(this.ColorDeleteBtn_Click);
            // 
            // ColorUpdateBtn
            // 
            this.ColorUpdateBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorUpdateBtn.Appearance.Options.UseFont = true;
            this.ColorUpdateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColorUpdateBtn.ImageOptions.Image")));
            this.ColorUpdateBtn.Location = new System.Drawing.Point(257, 172);
            this.ColorUpdateBtn.Name = "ColorUpdateBtn";
            this.ColorUpdateBtn.Size = new System.Drawing.Size(131, 44);
            this.ColorUpdateBtn.TabIndex = 17;
            this.ColorUpdateBtn.Text = "Güncelle";
            this.ColorUpdateBtn.Click += new System.EventHandler(this.ColorUpdateBtn_Click);
            // 
            // ColorAddBtn
            // 
            this.ColorAddBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorAddBtn.Appearance.Options.UseFont = true;
            this.ColorAddBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColorAddBtn.ImageOptions.Image")));
            this.ColorAddBtn.Location = new System.Drawing.Point(106, 172);
            this.ColorAddBtn.Name = "ColorAddBtn";
            this.ColorAddBtn.Size = new System.Drawing.Size(131, 44);
            this.ColorAddBtn.TabIndex = 18;
            this.ColorAddBtn.Text = "Kaydet";
            this.ColorAddBtn.Click += new System.EventHandler(this.ColorAddBtn_Click);
            // 
            // ColorNameTextEdit
            // 
            this.ColorNameTextEdit.Location = new System.Drawing.Point(106, 83);
            this.ColorNameTextEdit.Name = "ColorNameTextEdit";
            this.ColorNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ColorNameTextEdit.Properties.BeepOnError = false;
            this.ColorNameTextEdit.Size = new System.Drawing.Size(181, 26);
            this.ColorNameTextEdit.TabIndex = 19;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 521);
            this.Controls.Add(this.ColorNameTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ColorIdTextEdit);
            this.Controls.Add(this.ColorRefreceBtn);
            this.Controls.Add(this.ColorDeleteBtn);
            this.Controls.Add(this.ColorUpdateBtn);
            this.Controls.Add(this.ColorAddBtn);
            this.Controls.Add(this.ColorGridControl);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ColorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ColorGridView;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ColorIdTextEdit;
        private DevExpress.XtraEditors.SimpleButton ColorRefreceBtn;
        private DevExpress.XtraEditors.SimpleButton ColorDeleteBtn;
        private DevExpress.XtraEditors.SimpleButton ColorUpdateBtn;
        private DevExpress.XtraEditors.SimpleButton ColorAddBtn;
        private DevExpress.XtraEditors.TextEdit ColorNameTextEdit;
    }
}