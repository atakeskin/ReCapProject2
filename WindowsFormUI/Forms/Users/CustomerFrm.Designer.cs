
namespace WindowsFormUI.Forms.Users
{
    partial class CustomerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFrm));
            this.gcCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gwUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerId = new DevExpress.XtraEditors.TextEdit();
            this.btnCustomerYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomerKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCustomerList
            // 
            this.gcCustomerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcCustomerList.Location = new System.Drawing.Point(0, 282);
            this.gcCustomerList.MainView = this.gwUser;
            this.gcCustomerList.Name = "gcCustomerList";
            this.gcCustomerList.Size = new System.Drawing.Size(800, 253);
            this.gcCustomerList.TabIndex = 21;
            this.gcCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwUser});
            // 
            // gwUser
            // 
            this.gwUser.GridControl = this.gcCustomerList;
            this.gwUser.Name = "gwUser";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(132, 95);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerName.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerName.Properties.BeepOnError = false;
            this.txtCustomerName.Size = new System.Drawing.Size(181, 26);
            this.txtCustomerName.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 19);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Company Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 54);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.BeepOnError = false;
            this.txtUserName.Size = new System.Drawing.Size(181, 26);
            this.txtUserName.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 19);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "User Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 19);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Id";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(132, 12);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerId.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerId.Properties.BeepOnError = false;
            this.txtCustomerId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtCustomerId.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtCustomerId.Properties.MaskSettings.Set("mask", "99999");
            this.txtCustomerId.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerId.TabIndex = 22;
            // 
            // btnCustomerYenile
            // 
            this.btnCustomerYenile.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerYenile.Appearance.Options.UseFont = true;
            this.btnCustomerYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserYenile.ImageOptions.Image")));
            this.btnCustomerYenile.Location = new System.Drawing.Point(374, 183);
            this.btnCustomerYenile.Name = "btnCustomerYenile";
            this.btnCustomerYenile.Size = new System.Drawing.Size(131, 44);
            this.btnCustomerYenile.TabIndex = 28;
            this.btnCustomerYenile.Text = "Yenile";
            // 
            // btnCustomerSil
            // 
            this.btnCustomerSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerSil.Appearance.Options.UseFont = true;
            this.btnCustomerSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSil.ImageOptions.Image")));
            this.btnCustomerSil.Location = new System.Drawing.Point(374, 123);
            this.btnCustomerSil.Name = "btnCustomerSil";
            this.btnCustomerSil.Size = new System.Drawing.Size(131, 44);
            this.btnCustomerSil.TabIndex = 29;
            this.btnCustomerSil.Text = "Sil";
            // 
            // btnCustomerGuncelle
            // 
            this.btnCustomerGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerGuncelle.Appearance.Options.UseFont = true;
            this.btnCustomerGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserGuncelle.ImageOptions.Image")));
            this.btnCustomerGuncelle.Location = new System.Drawing.Point(374, 73);
            this.btnCustomerGuncelle.Name = "btnCustomerGuncelle";
            this.btnCustomerGuncelle.Size = new System.Drawing.Size(131, 44);
            this.btnCustomerGuncelle.TabIndex = 30;
            this.btnCustomerGuncelle.Text = "Güncelle";
            // 
            // btnCustomerKaydet
            // 
            this.btnCustomerKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerKaydet.Appearance.Options.UseFont = true;
            this.btnCustomerKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserKaydet.ImageOptions.Image")));
            this.btnCustomerKaydet.Location = new System.Drawing.Point(374, 13);
            this.btnCustomerKaydet.Name = "btnCustomerKaydet";
            this.btnCustomerKaydet.Size = new System.Drawing.Size(131, 44);
            this.btnCustomerKaydet.TabIndex = 31;
            this.btnCustomerKaydet.Text = "Kaydet";
            // 
            // CustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.gcCustomerList);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnCustomerYenile);
            this.Controls.Add(this.btnCustomerSil);
            this.Controls.Add(this.btnCustomerGuncelle);
            this.Controls.Add(this.btnCustomerKaydet);
            this.Name = "CustomerFrm";
            this.Text = "CustomerFrm";
            this.Load += new System.EventHandler(this.CustomerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gwUser;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCustomerId;
        private DevExpress.XtraEditors.SimpleButton btnCustomerYenile;
        private DevExpress.XtraEditors.SimpleButton btnCustomerSil;
        private DevExpress.XtraEditors.SimpleButton btnCustomerGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCustomerKaydet;
    }
}