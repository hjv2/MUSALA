namespace REST.UC
{
    partial class ucGateways
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGateways));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidGateway1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gatewayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new REST.DATA.DataSet1();
            this.colstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gatewayGridControl = new DevExpress.XtraGrid.GridControl();
            this.gatewayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidGateway = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluniqueSerialNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhumanReadable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPv4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gatewayTableAdapter = new REST.DATA.DataSet1TableAdapters.GatewayTableAdapter();
            this.tableAdapterManager = new REST.DATA.DataSet1TableAdapters.TableAdapterManager();
            this.periphericalDeviceTableAdapter = new REST.DATA.DataSet1TableAdapters.PeriphericalDeviceTableAdapter();
            this.gatewayBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gatewayBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fKPeriphericalDeviceGatewayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingNavigator)).BeginInit();
            this.gatewayBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPeriphericalDeviceGatewayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPD1,
            this.colUID1,
            this.colvendor1,
            this.coldateCreated1,
            this.colidGateway1,
            this.colstatus1});
            this.gridView2.GridControl = this.gatewayGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.ViewCaption = "PERIPHERICAL DEVICES";
            // 
            // colidPD1
            // 
            this.colidPD1.FieldName = "idPD";
            this.colidPD1.Name = "colidPD1";
            // 
            // colUID1
            // 
            this.colUID1.FieldName = "UID";
            this.colUID1.Name = "colUID1";
            this.colUID1.Visible = true;
            this.colUID1.VisibleIndex = 0;
            // 
            // colvendor1
            // 
            this.colvendor1.FieldName = "vendor";
            this.colvendor1.Name = "colvendor1";
            this.colvendor1.Visible = true;
            this.colvendor1.VisibleIndex = 1;
            // 
            // coldateCreated1
            // 
            this.coldateCreated1.FieldName = "dateCreated";
            this.coldateCreated1.Name = "coldateCreated1";
            this.coldateCreated1.Visible = true;
            this.coldateCreated1.VisibleIndex = 2;
            // 
            // colidGateway1
            // 
            this.colidGateway1.Caption = "Gateway";
            this.colidGateway1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colidGateway1.FieldName = "idGateway";
            this.colidGateway1.Name = "colidGateway1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uniqueSerialNum", "Gateway")});
            this.repositoryItemLookUpEdit1.DataSource = this.gatewayBindingSource1;
            this.repositoryItemLookUpEdit1.DisplayMember = "uniqueSerialNum";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "idGateway";
            // 
            // gatewayBindingSource1
            // 
            this.gatewayBindingSource1.DataMember = "Gateway";
            this.gatewayBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colstatus1
            // 
            this.colstatus1.FieldName = "status";
            this.colstatus1.Name = "colstatus1";
            this.colstatus1.Visible = true;
            this.colstatus1.VisibleIndex = 3;
            // 
            // gatewayGridControl
            // 
            this.gatewayGridControl.DataSource = this.gatewayBindingSource;
            this.gatewayGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "FK_PeriphericalDevice_Gateway";
            this.gatewayGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gatewayGridControl.Location = new System.Drawing.Point(0, 40);
            this.gatewayGridControl.MainView = this.gridView1;
            this.gatewayGridControl.Name = "gatewayGridControl";
            this.gatewayGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gatewayGridControl.Size = new System.Drawing.Size(997, 491);
            this.gatewayGridControl.TabIndex = 1;
            this.gatewayGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gatewayBindingSource
            // 
            this.gatewayBindingSource.DataMember = "Gateway";
            this.gatewayBindingSource.DataSource = this.dataSet1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidGateway,
            this.coluniqueSerialNum,
            this.colhumanReadable,
            this.colIPv4});
            this.gridView1.GridControl = this.gatewayGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.ViewCaption = "GATEWAYS";
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colidGateway
            // 
            this.colidGateway.FieldName = "idGateway";
            this.colidGateway.Name = "colidGateway";
            // 
            // coluniqueSerialNum
            // 
            this.coluniqueSerialNum.Caption = "Unique Serial Number";
            this.coluniqueSerialNum.FieldName = "uniqueSerialNum";
            this.coluniqueSerialNum.Name = "coluniqueSerialNum";
            this.coluniqueSerialNum.Visible = true;
            this.coluniqueSerialNum.VisibleIndex = 0;
            // 
            // colhumanReadable
            // 
            this.colhumanReadable.Caption = "Human Readable";
            this.colhumanReadable.FieldName = "humanReadable";
            this.colhumanReadable.Name = "colhumanReadable";
            this.colhumanReadable.Visible = true;
            this.colhumanReadable.VisibleIndex = 1;
            // 
            // colIPv4
            // 
            this.colIPv4.FieldName = "IPv4";
            this.colIPv4.Name = "colIPv4";
            this.colIPv4.Visible = true;
            this.colIPv4.VisibleIndex = 2;
            // 
            // gatewayTableAdapter
            // 
            this.gatewayTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GatewayTableAdapter = this.gatewayTableAdapter;
            this.tableAdapterManager.PeriphericalDeviceTableAdapter = this.periphericalDeviceTableAdapter;
            this.tableAdapterManager.UpdateOrder = REST.DATA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // periphericalDeviceTableAdapter
            // 
            this.periphericalDeviceTableAdapter.ClearBeforeFill = true;
            // 
            // gatewayBindingNavigator
            // 
            this.gatewayBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gatewayBindingNavigator.BindingSource = this.gatewayBindingSource;
            this.gatewayBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gatewayBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gatewayBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gatewayBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.toolStripButton1});
            this.gatewayBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gatewayBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gatewayBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gatewayBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gatewayBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gatewayBindingNavigator.Name = "gatewayBindingNavigator";
            this.gatewayBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gatewayBindingNavigator.Size = new System.Drawing.Size(997, 40);
            this.gatewayBindingNavigator.TabIndex = 0;
            this.gatewayBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // gatewayBindingNavigatorSaveItem
            // 
            this.gatewayBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gatewayBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gatewayBindingNavigatorSaveItem.Image")));
            this.gatewayBindingNavigatorSaveItem.Name = "gatewayBindingNavigatorSaveItem";
            this.gatewayBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 37);
            this.gatewayBindingNavigatorSaveItem.Text = "Save Data";
            this.gatewayBindingNavigatorSaveItem.Click += new System.EventHandler(this.gatewayBindingNavigatorSaveItem_Click_1);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton1.Text = "Display details from a Gateway";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // fKPeriphericalDeviceGatewayBindingSource
            // 
            this.fKPeriphericalDeviceGatewayBindingSource.DataMember = "FK_PeriphericalDevice_Gateway";
            this.fKPeriphericalDeviceGatewayBindingSource.DataSource = this.gatewayBindingSource;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "uniqueSerialNum";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "uniqueSerialNum";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "humanReadable";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // ucGateways
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gatewayGridControl);
            this.Controls.Add(this.gatewayBindingNavigator);
            this.Name = "ucGateways";
            this.Size = new System.Drawing.Size(997, 531);
            this.Load += new System.EventHandler(this.ucGateways_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayBindingNavigator)).EndInit();
            this.gatewayBindingNavigator.ResumeLayout(false);
            this.gatewayBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPeriphericalDeviceGatewayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DATA.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gatewayBindingSource;
        private DATA.DataSet1TableAdapters.GatewayTableAdapter gatewayTableAdapter;
        private DATA.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gatewayBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gatewayBindingNavigatorSaveItem;
        private DATA.DataSet1TableAdapters.PeriphericalDeviceTableAdapter periphericalDeviceTableAdapter;
        private DevExpress.XtraGrid.GridControl gatewayGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colidPD1;
        private DevExpress.XtraGrid.Columns.GridColumn colUID1;
        private DevExpress.XtraGrid.Columns.GridColumn colvendor1;
        private DevExpress.XtraGrid.Columns.GridColumn coldateCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colidGateway1;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidGateway;
        private DevExpress.XtraGrid.Columns.GridColumn coluniqueSerialNum;
        private DevExpress.XtraGrid.Columns.GridColumn colhumanReadable;
        private DevExpress.XtraGrid.Columns.GridColumn colIPv4;
        private System.Windows.Forms.BindingSource fKPeriphericalDeviceGatewayBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource gatewayBindingSource1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
