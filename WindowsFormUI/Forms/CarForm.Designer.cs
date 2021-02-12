
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.CarGridControl = new DevExpress.XtraGrid.GridControl();
            this.CarGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AnaFrmPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtSearchByPlate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lUEBrandName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ColorIdTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ModelYearTextEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.BranIdTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CarIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.PlakaNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CarNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.DailyPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RefreceCarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteCarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateCarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AddCarBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaFrmPanelControl)).BeginInit();
            this.AnaFrmPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchByPlate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearTextEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlakaNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CarGridControl
            // 
            this.CarGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CarGridControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gridLevelNode1.RelationName = "Level1";
            this.CarGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.CarGridControl.Location = new System.Drawing.Point(0, 281);
            this.CarGridControl.MainView = this.CarGridView;
            this.CarGridControl.Name = "CarGridControl";
            this.CarGridControl.Size = new System.Drawing.Size(1243, 207);
            this.CarGridControl.TabIndex = 0;
            this.CarGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CarGridView});
            this.CarGridControl.Click += new System.EventHandler(this.CarGridControl_Click);
            // 
            // CarGridView
            // 
            this.CarGridView.GridControl = this.CarGridControl;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.CarGridView_SelectionChanged);
            this.CarGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.CarGridView_FocusedRowChanged);
            // 
            // AnaFrmPanelControl
            // 
            this.AnaFrmPanelControl.Controls.Add(this.groupControl2);
            this.AnaFrmPanelControl.Controls.Add(this.groupControl1);
            this.AnaFrmPanelControl.Controls.Add(this.RefreceCarBtn);
            this.AnaFrmPanelControl.Controls.Add(this.DeleteCarBtn);
            this.AnaFrmPanelControl.Controls.Add(this.UpdateCarBtn);
            this.AnaFrmPanelControl.Controls.Add(this.AddCarBtn);
            this.AnaFrmPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaFrmPanelControl.Location = new System.Drawing.Point(0, 0);
            this.AnaFrmPanelControl.Name = "AnaFrmPanelControl";
            this.AnaFrmPanelControl.Size = new System.Drawing.Size(1243, 281);
            this.AnaFrmPanelControl.TabIndex = 1;
            this.AnaFrmPanelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.AnaFrmPanelControl_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtSearchByPlate);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.lUEBrandName);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Location = new System.Drawing.Point(774, 7);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(419, 261);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Arama";
            // 
            // txtSearchByPlate
            // 
            this.txtSearchByPlate.Location = new System.Drawing.Point(222, 97);
            this.txtSearchByPlate.Name = "txtSearchByPlate";
            this.txtSearchByPlate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchByPlate.Properties.Appearance.Options.UseFont = true;
            this.txtSearchByPlate.Properties.BeepOnError = false;
            this.txtSearchByPlate.Size = new System.Drawing.Size(181, 26);
            this.txtSearchByPlate.TabIndex = 4;
            this.txtSearchByPlate.EditValueChanged += new System.EventHandler(this.txtSearchByPlate_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(100, 100);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(108, 19);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "Search by Plate";
            // 
            // lUEBrandName
            // 
            this.lUEBrandName.Location = new System.Drawing.Point(222, 47);
            this.lUEBrandName.Name = "lUEBrandName";
            this.lUEBrandName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUEBrandName.Properties.Appearance.Options.UseFont = true;
            this.lUEBrandName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUEBrandName.Properties.NullText = "";
            this.lUEBrandName.Properties.PopupSizeable = false;
            this.lUEBrandName.Size = new System.Drawing.Size(181, 26);
            this.lUEBrandName.TabIndex = 2;
            this.lUEBrandName.EditValueChanged += new System.EventHandler(this.lUEBrandName_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(20, 50);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(188, 19);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Search by Category Name ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ColorIdTextEdit);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.ModelYearTextEdit);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.BranIdTextEdit);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.CarIdTextEdit);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.PlakaNoTextEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.CarNameTextEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.DailyPriceTextEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.DescriptionTextEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(574, 263);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Bilgiler";
            // 
            // ColorIdTextEdit
            // 
            this.ColorIdTextEdit.Location = new System.Drawing.Point(99, 122);
            this.ColorIdTextEdit.Name = "ColorIdTextEdit";
            this.ColorIdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorIdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ColorIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColorIdTextEdit.Properties.NullText = "";
            this.ColorIdTextEdit.Size = new System.Drawing.Size(181, 26);
            this.ColorIdTextEdit.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(14, 222);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 19);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Description";
            // 
            // ModelYearTextEdit
            // 
            this.ModelYearTextEdit.EditValue = "8.02.2021 00:04:16";
            this.ModelYearTextEdit.Location = new System.Drawing.Point(382, 76);
            this.ModelYearTextEdit.Name = "ModelYearTextEdit";
            this.ModelYearTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModelYearTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ModelYearTextEdit.Properties.BeepOnError = false;
            this.ModelYearTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModelYearTextEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModelYearTextEdit.Properties.DisplayFormat.FormatString = "";
            this.ModelYearTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ModelYearTextEdit.Properties.EditFormat.FormatString = "";
            this.ModelYearTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ModelYearTextEdit.Properties.MaskSettings.Set("mask", "d");
            this.ModelYearTextEdit.Size = new System.Drawing.Size(181, 26);
            this.ModelYearTextEdit.TabIndex = 0;
            this.ModelYearTextEdit.EditValueChanged += new System.EventHandler(this.ModelYearTextEdit_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(302, 173);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 19);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Daily Price";
            // 
            // BranIdTextEdit
            // 
            this.BranIdTextEdit.Location = new System.Drawing.Point(99, 76);
            this.BranIdTextEdit.Name = "BranIdTextEdit";
            this.BranIdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BranIdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.BranIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranIdTextEdit.Properties.NullText = "";
            this.BranIdTextEdit.Properties.PopupSizeable = false;
            this.BranIdTextEdit.Size = new System.Drawing.Size(181, 26);
            this.BranIdTextEdit.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(297, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 19);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Model Year";
            // 
            // CarIdTextEdit
            // 
            this.CarIdTextEdit.Enabled = false;
            this.CarIdTextEdit.Location = new System.Drawing.Point(99, 32);
            this.CarIdTextEdit.Name = "CarIdTextEdit";
            this.CarIdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CarIdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CarIdTextEdit.Properties.BeepOnError = false;
            this.CarIdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.CarIdTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.CarIdTextEdit.Properties.MaskSettings.Set("mask", "99999");
            this.CarIdTextEdit.Size = new System.Drawing.Size(100, 26);
            this.CarIdTextEdit.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(306, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 19);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Car Name";
            // 
            // PlakaNoTextEdit
            // 
            this.PlakaNoTextEdit.Location = new System.Drawing.Point(99, 170);
            this.PlakaNoTextEdit.Name = "PlakaNoTextEdit";
            this.PlakaNoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlakaNoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.PlakaNoTextEdit.Properties.BeepOnError = false;
            this.PlakaNoTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.PlakaNoTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.PlakaNoTextEdit.Properties.MaskSettings.Set("mask", "99AA999");
            this.PlakaNoTextEdit.Size = new System.Drawing.Size(181, 26);
            this.PlakaNoTextEdit.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(31, 173);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Plaka No";
            // 
            // CarNameTextEdit
            // 
            this.CarNameTextEdit.Location = new System.Drawing.Point(382, 32);
            this.CarNameTextEdit.Name = "CarNameTextEdit";
            this.CarNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CarNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CarNameTextEdit.Properties.BeepOnError = false;
            this.CarNameTextEdit.Size = new System.Drawing.Size(181, 26);
            this.CarNameTextEdit.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Color Name";
            // 
            // DailyPriceTextEdit
            // 
            this.DailyPriceTextEdit.Location = new System.Drawing.Point(382, 170);
            this.DailyPriceTextEdit.Name = "DailyPriceTextEdit";
            this.DailyPriceTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyPriceTextEdit.Properties.Appearance.Options.UseFont = true;
            this.DailyPriceTextEdit.Properties.BeepOnError = false;
            this.DailyPriceTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.DailyPriceTextEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.DailyPriceTextEdit.Properties.MaskSettings.Set("mask", "c");
            this.DailyPriceTextEdit.Size = new System.Drawing.Size(181, 26);
            this.DailyPriceTextEdit.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Brand Name";
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.Location = new System.Drawing.Point(99, 219);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DescriptionTextEdit.Properties.Appearance.Options.UseFont = true;
            this.DescriptionTextEdit.Size = new System.Drawing.Size(464, 26);
            this.DescriptionTextEdit.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Id";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // RefreceCarBtn
            // 
            this.RefreceCarBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RefreceCarBtn.Appearance.Options.UseFont = true;
            this.RefreceCarBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreceCarBtn.ImageOptions.Image")));
            this.RefreceCarBtn.Location = new System.Drawing.Point(616, 194);
            this.RefreceCarBtn.Name = "RefreceCarBtn";
            this.RefreceCarBtn.Size = new System.Drawing.Size(131, 44);
            this.RefreceCarBtn.TabIndex = 2;
            this.RefreceCarBtn.Text = "Yenile";
            // 
            // DeleteCarBtn
            // 
            this.DeleteCarBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteCarBtn.Appearance.Options.UseFont = true;
            this.DeleteCarBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCarBtn.ImageOptions.Image")));
            this.DeleteCarBtn.Location = new System.Drawing.Point(616, 144);
            this.DeleteCarBtn.Name = "DeleteCarBtn";
            this.DeleteCarBtn.Size = new System.Drawing.Size(131, 44);
            this.DeleteCarBtn.TabIndex = 2;
            this.DeleteCarBtn.Text = "Sil";
            this.DeleteCarBtn.Click += new System.EventHandler(this.DeleteCarBtn_Click);
            // 
            // UpdateCarBtn
            // 
            this.UpdateCarBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateCarBtn.Appearance.Options.UseFont = true;
            this.UpdateCarBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateCarBtn.ImageOptions.Image")));
            this.UpdateCarBtn.Location = new System.Drawing.Point(616, 94);
            this.UpdateCarBtn.Name = "UpdateCarBtn";
            this.UpdateCarBtn.Size = new System.Drawing.Size(131, 44);
            this.UpdateCarBtn.TabIndex = 2;
            this.UpdateCarBtn.Text = "Güncelle";
            this.UpdateCarBtn.Click += new System.EventHandler(this.UpdateCarBtn_Click);
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCarBtn.Appearance.Options.UseFont = true;
            this.AddCarBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddCarBtn.ImageOptions.Image")));
            this.AddCarBtn.Location = new System.Drawing.Point(616, 44);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(131, 44);
            this.AddCarBtn.TabIndex = 2;
            this.AddCarBtn.Text = "Kaydet";
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 488);
            this.Controls.Add(this.AnaFrmPanelControl);
            this.Controls.Add(this.CarGridControl);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarForm_FormClosed);
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaFrmPanelControl)).EndInit();
            this.AnaFrmPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchByPlate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearTextEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelYearTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlakaNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl CarGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CarGridView;
        private DevExpress.XtraEditors.PanelControl AnaFrmPanelControl;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit DailyPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit PlakaNoTextEdit;
        private DevExpress.XtraEditors.TextEdit CarIdTextEdit;
        private DevExpress.XtraEditors.LookUpEdit BranIdTextEdit;
        private DevExpress.XtraEditors.LookUpEdit ColorIdTextEdit;
        private DevExpress.XtraEditors.DateEdit ModelYearTextEdit;
        private DevExpress.XtraEditors.SimpleButton RefreceCarBtn;
        private DevExpress.XtraEditors.SimpleButton DeleteCarBtn;
        private DevExpress.XtraEditors.SimpleButton UpdateCarBtn;
        private DevExpress.XtraEditors.SimpleButton AddCarBtn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit CarNameTextEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lUEBrandName;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSearchByPlate;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}