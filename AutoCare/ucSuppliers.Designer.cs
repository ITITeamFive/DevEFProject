
namespace AutoCare
{
    partial class ucSuppliers
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelte2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblAddressEdit = new DevExpress.XtraEditors.LabelControl();
            this.txtAddressEdit = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplierID = new DevExpress.XtraEditors.LabelControl();
            this.lblEdit = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhoneNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEdit = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneNumberEdit = new DevExpress.XtraEditors.LabelControl();
            this.txtNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupplierAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupplierPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddressEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelControl1.Size = new System.Drawing.Size(1156, 635);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Controls.Add(this.btnDelte2);
            this.panelControl3.Controls.Add(this.btnEdit2);
            this.panelControl3.Controls.Add(this.lblAddressEdit);
            this.panelControl3.Controls.Add(this.txtAddressEdit);
            this.panelControl3.Controls.Add(this.lblSupplierID);
            this.panelControl3.Controls.Add(this.lblEdit);
            this.panelControl3.Controls.Add(this.btnSaveEdit);
            this.panelControl3.Controls.Add(this.txtPhoneNumberEdit);
            this.panelControl3.Controls.Add(this.lblNameEdit);
            this.panelControl3.Controls.Add(this.lblPhoneNumberEdit);
            this.panelControl3.Controls.Add(this.txtNameEdit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 454);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1152, 179);
            this.panelControl3.TabIndex = 3;
            // 
            // btnDelte2
            // 
            this.btnDelte2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelte2.Location = new System.Drawing.Point(174, 56);
            this.btnDelte2.Name = "btnDelte2";
            this.btnDelte2.Size = new System.Drawing.Size(376, 66);
            this.btnDelte2.TabIndex = 48;
            this.btnDelte2.Text = "Delete";
            this.btnDelte2.Visible = false;
            this.btnDelte2.Click += new System.EventHandler(this.btnDelte2_Click);
            // 
            // btnEdit2
            // 
            this.btnEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit2.Location = new System.Drawing.Point(602, 56);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(377, 66);
            this.btnEdit2.TabIndex = 47;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.Visible = false;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // lblAddressEdit
            // 
            this.lblAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressEdit.Location = new System.Drawing.Point(691, 68);
            this.lblAddressEdit.Name = "lblAddressEdit";
            this.lblAddressEdit.Size = new System.Drawing.Size(69, 17);
            this.lblAddressEdit.TabIndex = 46;
            this.lblAddressEdit.Text = "عنوان المورد";
            this.lblAddressEdit.Visible = false;
            // 
            // txtAddressEdit
            // 
            this.txtAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressEdit.Location = new System.Drawing.Point(411, 63);
            this.txtAddressEdit.Name = "txtAddressEdit";
            this.txtAddressEdit.Size = new System.Drawing.Size(250, 22);
            this.txtAddressEdit.TabIndex = 45;
            this.txtAddressEdit.Visible = false;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplierID.Location = new System.Drawing.Point(974, 24);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(0, 16);
            this.lblSupplierID.TabIndex = 44;
            this.lblSupplierID.Visible = false;
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.Location = new System.Drawing.Point(994, 24);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(107, 17);
            this.lblEdit.TabIndex = 43;
            this.lblEdit.Text = "تعديل بيانات المورد";
            this.lblEdit.Visible = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEdit.Location = new System.Drawing.Point(67, 125);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(151, 29);
            this.btnSaveEdit.TabIndex = 42;
            this.btnSaveEdit.Text = "حفظ التعديل";
            this.btnSaveEdit.Visible = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click_1);
            // 
            // txtPhoneNumberEdit
            // 
            this.txtPhoneNumberEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumberEdit.Location = new System.Drawing.Point(22, 65);
            this.txtPhoneNumberEdit.Name = "txtPhoneNumberEdit";
            this.txtPhoneNumberEdit.Size = new System.Drawing.Size(263, 22);
            this.txtPhoneNumberEdit.TabIndex = 39;
            this.txtPhoneNumberEdit.Visible = false;
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameEdit.Location = new System.Drawing.Point(1059, 68);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(65, 17);
            this.lblNameEdit.TabIndex = 40;
            this.lblNameEdit.Text = "اسم المورد";
            this.lblNameEdit.Visible = false;
            // 
            // lblPhoneNumberEdit
            // 
            this.lblPhoneNumberEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumberEdit.Location = new System.Drawing.Point(309, 65);
            this.lblPhoneNumberEdit.Name = "lblPhoneNumberEdit";
            this.lblPhoneNumberEdit.Size = new System.Drawing.Size(61, 17);
            this.lblPhoneNumberEdit.TabIndex = 41;
            this.lblPhoneNumberEdit.Text = "رقم الهاتف";
            this.lblPhoneNumberEdit.Visible = false;
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEdit.Location = new System.Drawing.Point(779, 63);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(250, 22);
            this.txtNameEdit.TabIndex = 38;
            this.txtNameEdit.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.supplierBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 156);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1154, 292);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(AutoCare.models.Supplier);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsupplierID,
            this.colsupplierName,
            this.colsupplierAddress,
            this.colsupplierPhoneNumber});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colsupplierID
            // 
            this.colsupplierID.Caption = "كود المورد";
            this.colsupplierID.FieldName = "supplierID";
            this.colsupplierID.MinWidth = 25;
            this.colsupplierID.Name = "colsupplierID";
            this.colsupplierID.Visible = true;
            this.colsupplierID.VisibleIndex = 0;
            this.colsupplierID.Width = 94;
            // 
            // colsupplierName
            // 
            this.colsupplierName.Caption = "اسم المورد";
            this.colsupplierName.FieldName = "supplierName";
            this.colsupplierName.MinWidth = 25;
            this.colsupplierName.Name = "colsupplierName";
            this.colsupplierName.Visible = true;
            this.colsupplierName.VisibleIndex = 1;
            this.colsupplierName.Width = 94;
            // 
            // colsupplierAddress
            // 
            this.colsupplierAddress.Caption = "عنوان المورد";
            this.colsupplierAddress.FieldName = "supplierAddress";
            this.colsupplierAddress.MinWidth = 25;
            this.colsupplierAddress.Name = "colsupplierAddress";
            this.colsupplierAddress.Visible = true;
            this.colsupplierAddress.VisibleIndex = 2;
            this.colsupplierAddress.Width = 94;
            // 
            // colsupplierPhoneNumber
            // 
            this.colsupplierPhoneNumber.Caption = "رقم الهاتف";
            this.colsupplierPhoneNumber.FieldName = "supplierPhoneNumber";
            this.colsupplierPhoneNumber.MinWidth = 25;
            this.colsupplierPhoneNumber.Name = "colsupplierPhoneNumber";
            this.colsupplierPhoneNumber.Visible = true;
            this.colsupplierPhoneNumber.VisibleIndex = 3;
            this.colsupplierPhoneNumber.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtPhoneNumber);
            this.panelControl2.Controls.Add(this.lblPhoneNumber);
            this.panelControl2.Controls.Add(this.txtAddress);
            this.panelControl2.Controls.Add(this.lblName);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.lblAddress);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1152, 148);
            this.panelControl2.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(112, 65);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(203, 22);
            this.txtPhoneNumber.TabIndex = 42;
            this.txtPhoneNumber.Visible = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(333, 68);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(61, 17);
            this.lblPhoneNumber.TabIndex = 43;
            this.lblPhoneNumber.Text = "رقم الهاتف";
            this.lblPhoneNumber.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(446, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 22);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Location = new System.Drawing.Point(949, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 17);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "الاسم";
            this.lblName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(112, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 29);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "حفظ";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.Location = new System.Drawing.Point(650, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 17);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "العنوان";
            this.lblAddress.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(921, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 29);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "اضافة مورد جديد";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(744, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 36;
            this.txtName.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(233, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 29);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSuppliers";
            this.Size = new System.Drawing.Size(1156, 635);
            this.Load += new System.EventHandler(this.ucSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddressEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplierPhoneNumber;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblAddressEdit;
        private DevExpress.XtraEditors.TextEdit txtAddressEdit;
        private DevExpress.XtraEditors.LabelControl lblSupplierID;
        private DevExpress.XtraEditors.LabelControl lblEdit;
        private DevExpress.XtraEditors.SimpleButton btnSaveEdit;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumberEdit;
        private DevExpress.XtraEditors.LabelControl lblNameEdit;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumberEdit;
        private DevExpress.XtraEditors.TextEdit txtNameEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelte2;
        private DevExpress.XtraEditors.SimpleButton btnEdit2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
