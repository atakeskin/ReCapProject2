
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
            this.ColorGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorGridControl
            // 
            this.ColorGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorGridControl.Location = new System.Drawing.Point(0, 268);
            this.ColorGridControl.MainView = this.gridView1;
            this.ColorGridControl.Name = "ColorGridControl";
            this.ColorGridControl.Size = new System.Drawing.Size(774, 253);
            this.ColorGridControl.TabIndex = 2;
            this.ColorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ColorGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 521);
            this.Controls.Add(this.ColorGridControl);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ColorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}