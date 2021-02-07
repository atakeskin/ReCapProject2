
namespace WindowsFormUI.Forms
{
    partial class CarForm
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
            this.CarGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarGridControl
            // 
            this.CarGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CarGridControl.Location = new System.Drawing.Point(0, 235);
            this.CarGridControl.MainView = this.gridView1;
            this.CarGridControl.Name = "CarGridControl";
            this.CarGridControl.Size = new System.Drawing.Size(731, 253);
            this.CarGridControl.TabIndex = 0;
            this.CarGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.CarGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 488);
            this.Controls.Add(this.CarGridControl);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarForm_FormClosed);
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl CarGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}