
namespace AutoCare
{
    partial class ucRepository
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labEditItem = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labCost = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labQuantity = new System.Windows.Forms.Label();
            this.labModel = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1037, 435);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labEditItem);
            this.panelControl2.Controls.Add(this.labId);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.txtPrice);
            this.panelControl2.Controls.Add(this.labCost);
            this.panelControl2.Controls.Add(this.labPrice);
            this.panelControl2.Controls.Add(this.labQuantity);
            this.panelControl2.Controls.Add(this.labModel);
            this.panelControl2.Controls.Add(this.labName);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Controls.Add(this.txtModel);
            this.panelControl2.Controls.Add(this.txtQuantity);
            this.panelControl2.Controls.Add(this.txtCost);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 285);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1033, 148);
            this.panelControl2.TabIndex = 3;
            // 
            // labEditItem
            // 
            this.labEditItem.AutoSize = true;
            this.labEditItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEditItem.Location = new System.Drawing.Point(829, 2);
            this.labEditItem.Name = "labEditItem";
            this.labEditItem.Size = new System.Drawing.Size(78, 14);
            this.labEditItem.TabIndex = 39;
            this.labEditItem.Text = "تعديل المنتج";
            this.labEditItem.Visible = false;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(204, 113);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 13);
            this.labId.TabIndex = 31;
            this.labId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(5, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "تعديل";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(458, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(195, 18);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Visible = false;
            // 
            // labCost
            // 
            this.labCost.AutoSize = true;
            this.labCost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCost.Location = new System.Drawing.Point(337, 24);
            this.labCost.Name = "labCost";
            this.labCost.Size = new System.Drawing.Size(74, 13);
            this.labCost.TabIndex = 26;
            this.labCost.Text = "تكلفت المنتج";
            this.labCost.Visible = false;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.Location = new System.Drawing.Point(720, 93);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(66, 13);
            this.labPrice.TabIndex = 25;
            this.labPrice.Text = "سعر المنتج";
            this.labPrice.Visible = false;
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuantity.Location = new System.Drawing.Point(720, 53);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(66, 13);
            this.labQuantity.TabIndex = 24;
            this.labQuantity.Text = "كمية المنتج";
            this.labQuantity.Visible = false;
            // 
            // labModel
            // 
            this.labModel.AutoSize = true;
            this.labModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labModel.Location = new System.Drawing.Point(337, 93);
            this.labModel.Name = "labModel";
            this.labModel.Size = new System.Drawing.Size(71, 13);
            this.labModel.TabIndex = 23;
            this.labModel.Text = "اصدار المنتج";
            this.labModel.Visible = false;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(720, 19);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(66, 13);
            this.labName.TabIndex = 22;
            this.labName.Text = "اسم المنتج";
            this.labName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(458, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 18);
            this.txtName.TabIndex = 21;
            this.txtName.Visible = false;
            this.txtName.TextChanged += new System.EventHandler(this.itemName_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(99, 87);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(195, 18);
            this.txtModel.TabIndex = 20;
            this.txtModel.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(458, 52);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(195, 18);
            this.txtQuantity.TabIndex = 19;
            this.txtQuantity.Visible = false;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(99, 23);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(195, 18);
            this.txtCost.TabIndex = 38;
            this.txtCost.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.itemBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1033, 274);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(AutoCare.models.Item);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemID,
            this.colitemName,
            this.colitemQuantity,
            this.colitemPrice,
            this.colitemCost,
            this.colitemModel});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colitemID
            // 
            this.colitemID.Caption = "رقم القطعة";
            this.colitemID.FieldName = "itemID";
            this.colitemID.Name = "colitemID";
            this.colitemID.Visible = true;
            this.colitemID.VisibleIndex = 0;
            // 
            // colitemName
            // 
            this.colitemName.Caption = "اسم القطعة";
            this.colitemName.FieldName = "itemName";
            this.colitemName.Name = "colitemName";
            this.colitemName.Visible = true;
            this.colitemName.VisibleIndex = 1;
            // 
            // colitemQuantity
            // 
            this.colitemQuantity.Caption = "كميه القطع";
            this.colitemQuantity.FieldName = "itemQuantity";
            this.colitemQuantity.Name = "colitemQuantity";
            this.colitemQuantity.Visible = true;
            this.colitemQuantity.VisibleIndex = 2;
            // 
            // colitemPrice
            // 
            this.colitemPrice.Caption = "سعر القطعة";
            this.colitemPrice.FieldName = "itemPrice";
            this.colitemPrice.Name = "colitemPrice";
            this.colitemPrice.Visible = true;
            this.colitemPrice.VisibleIndex = 3;
            // 
            // colitemCost
            // 
            this.colitemCost.Caption = "تكلفت القطعة ";
            this.colitemCost.FieldName = "itemCost";
            this.colitemCost.Name = "colitemCost";
            this.colitemCost.Visible = true;
            this.colitemCost.VisibleIndex = 4;
            // 
            // colitemModel
            // 
            this.colitemModel.Caption = "اصدار القطعة";
            this.colitemModel.FieldName = "itemModel";
            this.colitemModel.Name = "colitemModel";
            this.colitemModel.Visible = true;
            this.colitemModel.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "itemName";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView2;
            this.repositoryItemGridLookUpEdit1.ValueMember = "itemID";
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ucRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucRepository";
            this.Size = new System.Drawing.Size(1037, 435);
            this.Load += new System.EventHandler(this.ucRepository_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labCost;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.Label labModel;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCost;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemID;
        private DevExpress.XtraGrid.Columns.GridColumn colitemName;
        private DevExpress.XtraGrid.Columns.GridColumn colitemQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colitemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colitemCost;
        private DevExpress.XtraGrid.Columns.GridColumn colitemModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labEditItem;
    }
}
