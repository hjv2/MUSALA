using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace REST.UC
{
    public partial class ucGateways : UserControl
    {
        public ucGateways(string pHeaderText)
        {
            InitializeComponent();
            this.toolStripLabel1.Text = pHeaderText;

        }

        private void gatewayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gatewayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ucGateways_Load(object sender, EventArgs e)
        {
            gatewayTableAdapter.Fill(dataSet1.Gateway);
            periphericalDeviceTableAdapter.Fill(dataSet1.PeriphericalDevice);
        }

        private void gatewayBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gatewayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                var rowSelected = gridView1.GetFocusedRow();
                if (rowSelected == null)
                    return;
                var type = rowSelected.GetType();
                if (type == typeof(DataRowView))
                {
                    var row = ((System.Data.DataRowView)rowSelected).Row;
                    var frm = new FORMS.frmDSpleGateway(row);
                    frm.ShowDialog();

                }

            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            if (e.RowHandle<0)
            {
                return;
            }

            int moreThan2Unique = 0;
            int moreThan2IPv4 = 0;

            GridView view = sender as GridView;
            GridColumn colIPv4 = view.Columns["IPv4"];
            GridColumn coluniqueSerialNum = view.Columns["uniqueSerialNum"];
            //Get the value of the first column
            string address = (string)view.GetRowCellValue(e.RowHandle, colIPv4);
            //Get the value of the second column
            string unique = (string)view.GetRowCellValue(e.RowHandle, coluniqueSerialNum);
            //Validity criterion

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (moreThan2IPv4 == 2 )
                {
                    MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Valid = false;
                    view.SetColumnError(colIPv4, "Invalid");
                    return;
                    //break;
                }


                if (moreThan2Unique == 2)
                {
                    MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Valid = false;
                    view.SetColumnError(coluniqueSerialNum, "Invalid");
                    return;
                    //break;
                }


                var row = gridView1.GetRow(i) as DataRowView;
                if (row != null)
                {
                    var gateway = row.Row as DATA.DataSet1.GatewayRow;
                    if (gateway.uniqueSerialNum==unique)
                    {
                        moreThan2Unique = moreThan2Unique+1;
                    }

                    if (gateway.IPv4 == address)
                    {
                        moreThan2IPv4 = moreThan2IPv4+1;
                    }


                    //try
                    //{
                    //    if (device.idGateway == idgateway)
                    //    {
                    //        moreThan10ByGateway = moreThan10ByGateway + 1;
                    //    }
                    //}
                    //catch (Exception)
                    //{
                    //    continue;
                    //    //throw;
                    //}
                }
                

               
            }

         











          //      if (inSt < onOrd)
            //{
               // e.Valid = false;
                ////Set errors with specific descriptions for the columns
                //view.SetColumnError(inStockCol, "The value must be greater than Units On Order");
                //view.SetColumnError(onOrderCol, "The value must be less than Units In Stock");
           // }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
          //  e.ExceptionMode = ExceptionMode.NoAction;

        }
    }
}
