
namespace WindowsFormUI.Forms.Users
{
    partial class UserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFrm));
            this.gcUserList = new DevExpress.XtraGrid.GridControl();
            this.gwUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtUserFistName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserId = new DevExpress.XtraEditors.TextEdit();
            this.btnUserYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserFistName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUserList
            // 
            this.gcUserList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcUserList.Location = new System.Drawing.Point(0, 292);
            this.gcUserList.MainView = this.gwUser;
            this.gcUserList.Name = "gcUserList";
            this.gcUserList.Size = new System.Drawing.Size(694, 253);
            this.gcUserList.TabIndex = 12;
            this.gcUserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwUser});
            // 
            // gwUser
            // 
            this.gwUser.GridControl = this.gcUserList;
            this.gwUser.Name = "gwUser";
            // 
            // txtUserFistName
            // 
            this.txtUserFistName.Location = new System.Drawing.Point(106, 61);
            this.txtUserFistName.Name = "txtUserFistName";
            this.txtUserFistName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserFistName.Properties.Appearance.Options.UseFont = true;
            this.txtUserFistName.Properties.BeepOnError = false;
            this.txtUserFistName.Size = new System.Drawing.Size(181, 26);
            this.txtUserFistName.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 19);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Firt Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 19);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(106, 21);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserId.Properties.Appearance.Options.UseFont = true;
            this.txtUserId.Properties.BeepOnError = false;
            this.txtUserId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtUserId.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtUserId.Properties.MaskSettings.Set("mask", "99999");
            this.txtUserId.Size = new System.Drawing.Size(100, 26);
            this.txtUserId.TabIndex = 13;
            // 
            // btnUserYenile
            // 
            this.btnUserYenile.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserYenile.Appearance.Options.UseFont = true;
            this.btnUserYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserYenile.ImageOptions.Image")));
            this.btnUserYenile.Location = new System.Drawing.Point(374, 194);
            this.btnUserYenile.Name = "btnUserYenile";
            this.btnUserYenile.Size = new System.Drawing.Size(131, 44);
            this.btnUserYenile.TabIndex = 16;
            this.btnUserYenile.Text = "Yenile";
            // 
            // btnUserSil
            // 
            this.btnUserSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserSil.Appearance.Options.UseFont = true;
            this.btnUserSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSil.ImageOptions.Image")));
            this.btnUserSil.Location = new System.Drawing.Point(374, 134);
            this.btnUserSil.Name = "btnUserSil";
            this.btnUserSil.Size = new System.Drawing.Size(131, 44);
            this.btnUserSil.TabIndex = 17;
            this.btnUserSil.Text = "Sil";
            // 
            // btnUserGuncelle
            // 
            this.btnUserGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserGuncelle.Appearance.Options.UseFont = true;
            this.btnUserGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserGuncelle.ImageOptions.Image")));
            this.btnUserGuncelle.Location = new System.Drawing.Point(374, 84);
            this.btnUserGuncelle.Name = "btnUserGuncelle";
            this.btnUserGuncelle.Size = new System.Drawing.Size(131, 44);
            this.btnUserGuncelle.TabIndex = 18;
            this.btnUserGuncelle.Text = "Güncelle";
            // 
            // btnUserKaydet
            // 
            this.btnUserKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserKaydet.Appearance.Options.UseFont = true;
            this.btnUserKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserKaydet.ImageOptions.Image")));
            this.btnUserKaydet.Location = new System.Drawing.Point(374, 24);
            this.btnUserKaydet.Name = "btnUserKaydet";
            this.btnUserKaydet.Size = new System.Drawing.Size(131, 44);
            this.btnUserKaydet.TabIndex = 19;
            this.btnUserKaydet.Text = "Kaydet";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 19);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Last Name";
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(106, 102);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserLastName.Properties.Appearance.Options.UseFont = true;
            this.txtUserLastName.Properties.BeepOnError = false;
            this.txtUserLastName.Size = new System.Drawing.Size(181, 26);
            this.txtUserLastName.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 19);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Email";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(106, 152);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserEmail.Properties.Appearance.Options.UseFont = true;
            this.txtUserEmail.Properties.BeepOnError = false;
            this.txtUserEmail.Size = new System.Drawing.Size(181, 26);
            this.txtUserEmail.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 211);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 19);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Password";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(106, 204);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPassword.Properties.Appearance.Options.UseFont = true;
            this.txtUserPassword.Properties.BeepOnError = false;
            this.txtUserPassword.Size = new System.Drawing.Size(181, 26);
            this.txtUserPassword.TabIndex = 20;
            // 
            // UserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 545);
            this.Controls.Add(this.gcUserList);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtUserLastName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUserFistName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnUserYenile);
            this.Controls.Add(this.btnUserSil);
            this.Controls.Add(this.btnUserGuncelle);
            this.Controls.Add(this.btnUserKaydet);
            this.Name = "UserFrm";
            this.Text = "UserFrm";
            this.Load += new System.EventHandler(this.UserFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserFistName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gwUser;
        private DevExpress.XtraEditors.TextEdit txtUserFistName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUserId;
        private DevExpress.XtraEditors.SimpleButton btnUserYenile;
        private DevExpress.XtraEditors.SimpleButton btnUserSil;
        private DevExpress.XtraEditors.SimpleButton btnUserGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnUserKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUserLastName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUserEmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUserPassword;
    }
}