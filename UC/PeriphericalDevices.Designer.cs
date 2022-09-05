namespace REST.UC
{
    partial class PeriphericalDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriphericalDevices));
            this.dataSet1 = new REST.DATA.DataSet1();
            this.periphericalDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periphericalDeviceTableAdapter = new REST.DATA.DataSet1TableAdapters.PeriphericalDeviceTableAdapter();
            this.tableAdapterManager = new REST.DATA.DataSet1TableAdapters.TableAdapterManager();
            this.periphericalDeviceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.periphericalDeviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidGateway = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gatewayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.periphericalDeviceGridControl = new DevExpress.XtraGrid.GridControl();
            this.gatewayTableAdapter = new REST.DATA.DataSet1TableAdapters.GatewayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periphericalDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periphericalDeviceBindingNavigator)).BeginInit();
            this.periphericalDeviceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periphericalDeviceGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periphericalDeviceBindingSource
            // 
            this.periphericalDeviceBindingSource.DataMember = "PeriphericalDevice";
            this.periphericalDeviceBindingSource.DataSource = this.dataSet1;
            // 
            // periphericalDeviceTableAdapter
            // 
            this.periphericalDeviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GatewayTableAdapter = null;
            this.tableAdapterManager.PeriphericalDeviceTableAdapter = this.periphericalDeviceTableAdapter;
            this.tableAdapterManager.UpdateOrder = REST.DATA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // periphericalDeviceBindingNavigator
            // 
            this.periphericalDeviceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.periphericalDeviceBindingNavigator.BindingSource = this.periphericalDeviceBindingSource;
            this.periphericalDeviceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.periphericalDeviceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.periphericalDeviceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.periphericalDeviceBindingNavigatorSaveItem,
            this.toolStripLabel1});
            this.periphericalDeviceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.periphericalDeviceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.periphericalDeviceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.periphericalDeviceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.periphericalDeviceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.periphericalDeviceBindingNavigator.Name = "periphericalDeviceBindingNavigator";
            this.periphericalDeviceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.periphericalDeviceBindingNavigator.Size = new System.Drawing.Size(1003, 40);
            this.periphericalDeviceBindingNavigator.TabIndex = 0;
            this.periphericalDeviceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 37);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // periphericalDeviceBindingNavigatorSaveItem
            // 
            this.periphericalDeviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.periphericalDeviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("periphericalDeviceBindingNavigatorSaveItem.Image")));
            this.periphericalDeviceBindingNavigatorSaveItem.Name = "periphericalDeviceBindingNavigatorSaveItem";
            this.periphericalDeviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 37);
            this.periphericalDeviceBindingNavigatorSaveItem.Text = "Save Data";
            this.periphericalDeviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.periphericalDeviceBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(198, 37);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPD,
            this.colUID,
            this.colvendor,
            this.coldateCreated,
            this.colidGateway,
            this.colstatus});
            this.gridView1.GridControl = this.periphericalDeviceGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.ViewCaption = "PERIPHERICAL DEVICES";
            // 
            // colidPD
            // 
            this.colidPD.FieldName = "idPD";
            this.colidPD.Name = "colidPD";
            // 
            // colUID
            // 
            this.colUID.FieldName = "UID";
            this.colUID.Name = "colUID";
            this.colUID.Visible = true;
            this.colUID.VisibleIndex = 1;
            // 
            // colvendor
            // 
            this.colvendor.Caption = "Vendor";
            this.colvendor.FieldName = "vendor";
            this.colvendor.Name = "colvendor";
            this.colvendor.Visible = true;
            this.colvendor.VisibleIndex = 2;
            // 
            // coldateCreated
            // 
            this.coldateCreated.Caption = "Date Created";
            this.coldateCreated.FieldName = "dateCreated";
            this.coldateCreated.Name = "coldateCreated";
            this.coldateCreated.Visible = true;
            this.coldateCreated.VisibleIndex = 3;
            // 
            // colidGateway
            // 
            this.colidGateway.Caption = "Gateway";
            this.colidGateway.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colidGateway.FieldName = "idGateway";
            this.colidGateway.Name = "colidGateway";
            this.colidGateway.Visible = true;
            this.colidGateway.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uniqueSerialNum", "Gateway")});
            this.repositoryItemLookUpEdit1.DataSource = this.gatewayBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "uniqueSerialNum";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "idGateway";
            this.repositoryItemLookUpEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEdit1_EditValueChanged);
            // 
            // gatewayBindingSource
            // 
            this.gatewayBindingSource.DataMember = "Gateway";
            this.gatewayBindingSource.DataSource = this.dataSet1;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Status";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 4;
            // 
            // periphericalDeviceGridControl
            // 
            this.periphericalDeviceGridControl.DataSource = this.periphericalDeviceBindingSource;
            this.periphericalDeviceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periphericalDeviceGridControl.Location = new System.Drawing.Point(0, 40);
            this.periphericalDeviceGridControl.MainView = this.gridView1;
            this.periphericalDeviceGridControl.Name = "periphericalDeviceGridControl";
            this.periphericalDeviceGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.periphericalDeviceGridControl.Size = new System.Drawing.Size(1003, 502);
            this.periphericalDeviceGridControl.TabIndex = 1;
            this.periphericalDeviceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gatewayTableAdapter
            // 
            this.gatewayTableAdapter.ClearBeforeFill = true;
            // 
            // PeriphericalDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.periphericalDeviceGridControl);
            this.Controls.Add(this.periphericalDeviceBindingNavigator);
            this.Name = "PeriphericalDevices";
            this.Size = new System.Drawing.Size(1003, 542);
            this.Load += new System.EventHandler(this.PeriphericalDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periphericalDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periphericalDeviceBindingNavigator)).EndInit();
            this.periphericalDeviceBindingNavigator.ResumeLayout(false);
            this.periphericalDeviceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periphericalDeviceGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DATA.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource periphericalDeviceBindingSource;
        private DATA.DataSet1TableAdapters.PeriphericalDeviceTableAdapter periphericalDeviceTableAdapter;
        private DATA.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator periphericalDeviceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton periphericalDeviceBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidPD;
        private DevExpress.XtraGrid.Columns.GridColumn colUID;
        private DevExpress.XtraGrid.Columns.GridColumn colvendor;
        private DevExpress.XtraGrid.Columns.GridColumn coldateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colidGateway;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.GridControl periphericalDeviceGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource gatewayBindingSource;
        private DATA.DataSet1TableAdapters.GatewayTableAdapter gatewayTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
