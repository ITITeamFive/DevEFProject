
namespace AutoCare
{
    partial class ucDisplayBills
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clientBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillTotablPriceBefore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillTotablPriceAfter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.supplierBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbillDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillTotablPriceBefore1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillTotablPriceAfter1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillDiscount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbillCash1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sherif\'s";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clientBillBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 124);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1208, 363);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick_1);
            // 
            // clientBillBindingSource
            // 
            this.clientBillBindingSource.DataSource = typeof(AutoCare.models.ClientBill);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbillID,
            this.colbillDate,
            this.colClient,
            this.colbillTotablPriceBefore,
            this.colbillTotablPriceAfter,
            this.colbillDiscount,
            this.colbillCash});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colbillDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colbillID
            // 
            this.colbillID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbillID.AppearanceCell.Options.UseFont = true;
            this.colbillID.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbillID.AppearanceHeader.Options.UseFont = true;
            this.colbillID.Caption = "الفاتورة";
            this.colbillID.FieldName = "billID";
            this.colbillID.MinWidth = 23;
            this.colbillID.Name = "colbillID";
            this.colbillID.OptionsColumn.AllowEdit = false;
            this.colbillID.Visible = true;
            this.colbillID.VisibleIndex = 1;
            this.colbillID.Width = 87;
            // 
            // colbillDate
            // 
            this.colbillDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colbillDate.AppearanceCell.Options.UseFont = true;
            this.colbillDate.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillDate.AppearanceHeader.Options.UseFont = true;
            this.colbillDate.Caption = "التاريخ";
            this.colbillDate.FieldName = "billDate";
            this.colbillDate.MinWidth = 23;
            this.colbillDate.Name = "colbillDate";
            this.colbillDate.OptionsColumn.AllowEdit = false;
            this.colbillDate.Visible = true;
            this.colbillDate.VisibleIndex = 0;
            this.colbillDate.Width = 87;
            // 
            // colClient
            // 
            this.colClient.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colClient.AppearanceCell.Options.UseFont = true;
            this.colClient.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colClient.AppearanceHeader.Options.UseFont = true;
            this.colClient.Caption = "العميل";
            this.colClient.FieldName = "Client.clientName";
            this.colClient.MinWidth = 23;
            this.colClient.Name = "colClient";
            this.colClient.OptionsColumn.AllowEdit = false;
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 2;
            this.colClient.Width = 87;
            // 
            // colbillTotablPriceBefore
            // 
            this.colbillTotablPriceBefore.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colbillTotablPriceBefore.AppearanceCell.Options.UseFont = true;
            this.colbillTotablPriceBefore.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillTotablPriceBefore.AppearanceHeader.Options.UseFont = true;
            this.colbillTotablPriceBefore.Caption = "قبل الخصم";
            this.colbillTotablPriceBefore.FieldName = "billTotablPriceBefore";
            this.colbillTotablPriceBefore.MinWidth = 23;
            this.colbillTotablPriceBefore.Name = "colbillTotablPriceBefore";
            this.colbillTotablPriceBefore.OptionsColumn.AllowEdit = false;
            this.colbillTotablPriceBefore.Visible = true;
            this.colbillTotablPriceBefore.VisibleIndex = 4;
            this.colbillTotablPriceBefore.Width = 87;
            // 
            // colbillTotablPriceAfter
            // 
            this.colbillTotablPriceAfter.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colbillTotablPriceAfter.AppearanceCell.Options.UseFont = true;
            this.colbillTotablPriceAfter.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillTotablPriceAfter.AppearanceHeader.Options.UseFont = true;
            this.colbillTotablPriceAfter.Caption = "بعد الخصم";
            this.colbillTotablPriceAfter.FieldName = "billTotablPriceAfter";
            this.colbillTotablPriceAfter.MinWidth = 23;
            this.colbillTotablPriceAfter.Name = "colbillTotablPriceAfter";
            this.colbillTotablPriceAfter.OptionsColumn.AllowEdit = false;
            this.colbillTotablPriceAfter.Visible = true;
            this.colbillTotablPriceAfter.VisibleIndex = 5;
            this.colbillTotablPriceAfter.Width = 87;
            // 
            // colbillDiscount
            // 
            this.colbillDiscount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colbillDiscount.AppearanceCell.Options.UseFont = true;
            this.colbillDiscount.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillDiscount.AppearanceHeader.Options.UseFont = true;
            this.colbillDiscount.Caption = "الخصم";
            this.colbillDiscount.FieldName = "billDiscount";
            this.colbillDiscount.MinWidth = 23;
            this.colbillDiscount.Name = "colbillDiscount";
            this.colbillDiscount.OptionsColumn.AllowEdit = false;
            this.colbillDiscount.Visible = true;
            this.colbillDiscount.VisibleIndex = 3;
            this.colbillDiscount.Width = 87;
            // 
            // colbillCash
            // 
            this.colbillCash.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colbillCash.AppearanceCell.Options.UseFont = true;
            this.colbillCash.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillCash.AppearanceHeader.Options.UseFont = true;
            this.colbillCash.Caption = "المدفوع";
            this.colbillCash.FieldName = "billCash";
            this.colbillCash.MinWidth = 23;
            this.colbillCash.Name = "colbillCash";
            this.colbillCash.OptionsColumn.AllowEdit = false;
            this.colbillCash.Visible = true;
            this.colbillCash.VisibleIndex = 6;
            this.colbillCash.Width = 87;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "عميل";
            this.comboBoxEdit1.Location = new System.Drawing.Point(968, 39);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 2;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "عميل",
            "مورد"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(183, 36);
            this.comboBoxEdit1.TabIndex = 3;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Freestyle Script", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(469, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(187, 119);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "فواتير";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.supplierBillBindingSource;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(0, 124);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1208, 363);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // supplierBillBindingSource
            // 
            this.supplierBillBindingSource.DataSource = typeof(AutoCare.models.SupplierBill);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbillDate1,
            this.colbillID1,
            this.colbillTotablPriceBefore1,
            this.colbillTotablPriceAfter1,
            this.colbillDiscount1,
            this.colbillCash1,
            this.colSupplier});
            this.gridView2.DetailHeight = 431;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colbillDate1
            // 
            this.colbillDate1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colbillDate1.AppearanceCell.Options.UseFont = true;
            this.colbillDate1.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillDate1.AppearanceHeader.Options.UseFont = true;
            this.colbillDate1.Caption = "تاريخ";
            this.colbillDate1.FieldName = "billDate";
            this.colbillDate1.MinWidth = 23;
            this.colbillDate1.Name = "colbillDate1";
            this.colbillDate1.OptionsColumn.AllowEdit = false;
            this.colbillDate1.Visible = true;
            this.colbillDate1.VisibleIndex = 6;
            this.colbillDate1.Width = 171;
            // 
            // colbillID1
            // 
            this.colbillID1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbillID1.AppearanceCell.Options.UseFont = true;
            this.colbillID1.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbillID1.AppearanceHeader.Options.UseFont = true;
            this.colbillID1.Caption = "الفاتورة";
            this.colbillID1.FieldName = "billID";
            this.colbillID1.MinWidth = 23;
            this.colbillID1.Name = "colbillID1";
            this.colbillID1.OptionsColumn.AllowEdit = false;
            this.colbillID1.Visible = true;
            this.colbillID1.VisibleIndex = 5;
            this.colbillID1.Width = 167;
            // 
            // colbillTotablPriceBefore1
            // 
            this.colbillTotablPriceBefore1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colbillTotablPriceBefore1.AppearanceCell.Options.UseFont = true;
            this.colbillTotablPriceBefore1.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillTotablPriceBefore1.AppearanceHeader.Options.UseFont = true;
            this.colbillTotablPriceBefore1.Caption = "قبل الخصم";
            this.colbillTotablPriceBefore1.FieldName = "billTotablPriceBefore";
            this.colbillTotablPriceBefore1.MinWidth = 23;
            this.colbillTotablPriceBefore1.Name = "colbillTotablPriceBefore1";
            this.colbillTotablPriceBefore1.OptionsColumn.AllowEdit = false;
            this.colbillTotablPriceBefore1.Visible = true;
            this.colbillTotablPriceBefore1.VisibleIndex = 2;
            this.colbillTotablPriceBefore1.Width = 168;
            // 
            // colbillTotablPriceAfter1
            // 
            this.colbillTotablPriceAfter1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colbillTotablPriceAfter1.AppearanceCell.Options.UseFont = true;
            this.colbillTotablPriceAfter1.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillTotablPriceAfter1.AppearanceHeader.Options.UseFont = true;
            this.colbillTotablPriceAfter1.Caption = "بعد الخصم";
            this.colbillTotablPriceAfter1.FieldName = "billTotablPriceAfter";
            this.colbillTotablPriceAfter1.MinWidth = 23;
            this.colbillTotablPriceAfter1.Name = "colbillTotablPriceAfter1";
            this.colbillTotablPriceAfter1.OptionsColumn.AllowEdit = false;
            this.colbillTotablPriceAfter1.Visible = true;
            this.colbillTotablPriceAfter1.VisibleIndex = 1;
            this.colbillTotablPriceAfter1.Width = 168;
            // 
            // colbillDiscount1
            // 
            this.colbillDiscount1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colbillDiscount1.AppearanceCell.Options.UseFont = true;
            this.colbillDiscount1.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillDiscount1.AppearanceHeader.Options.UseFont = true;
            this.colbillDiscount1.Caption = "الخصم";
            this.colbillDiscount1.FieldName = "billDiscount";
            this.colbillDiscount1.MinWidth = 23;
            this.colbillDiscount1.Name = "colbillDiscount1";
            this.colbillDiscount1.OptionsColumn.AllowEdit = false;
            this.colbillDiscount1.Visible = true;
            this.colbillDiscount1.VisibleIndex = 3;
            this.colbillDiscount1.Width = 168;
            // 
            // colbillCash1
            // 
            this.colbillCash1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colbillCash1.AppearanceCell.Options.UseFont = true;
            this.colbillCash1.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colbillCash1.AppearanceHeader.Options.UseFont = true;
            this.colbillCash1.Caption = "المدفوع";
            this.colbillCash1.FieldName = "billCash";
            this.colbillCash1.MinWidth = 23;
            this.colbillCash1.Name = "colbillCash1";
            this.colbillCash1.OptionsColumn.AllowEdit = false;
            this.colbillCash1.Visible = true;
            this.colbillCash1.VisibleIndex = 0;
            this.colbillCash1.Width = 168;
            // 
            // colSupplier
            // 
            this.colSupplier.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colSupplier.AppearanceCell.Options.UseFont = true;
            this.colSupplier.AppearanceHeader.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold);
            this.colSupplier.AppearanceHeader.Options.UseFont = true;
            this.colSupplier.Caption = "المورد";
            this.colSupplier.FieldName = "Supplier.supplierName";
            this.colSupplier.MinWidth = 23;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowEdit = false;
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 4;
            this.colSupplier.Width = 168;
            // 
            // ucDisplayBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucDisplayBills";
            this.Size = new System.Drawing.Size(1223, 639);
            this.Load += new System.EventHandler(this.ucDisplayBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clientBillBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colbillID;
        private DevExpress.XtraGrid.Columns.GridColumn colbillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colbillTotablPriceBefore;
        private DevExpress.XtraGrid.Columns.GridColumn colbillTotablPriceAfter;
        private DevExpress.XtraGrid.Columns.GridColumn colbillDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colbillCash;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource supplierBillBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colbillID1;
        private DevExpress.XtraGrid.Columns.GridColumn colbillDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colbillTotablPriceBefore1;
        private DevExpress.XtraGrid.Columns.GridColumn colbillTotablPriceAfter1;
        private DevExpress.XtraGrid.Columns.GridColumn colbillDiscount1;
        private DevExpress.XtraGrid.Columns.GridColumn colbillCash1;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
    }
}
