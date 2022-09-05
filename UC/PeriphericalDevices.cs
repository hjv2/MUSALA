using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static REST.DATA.DataSet1;

namespace REST.UC
{
    public partial class PeriphericalDevices : UserControl
    {
        public PeriphericalDevices(string pHeaderText)
        {
            InitializeComponent();
            this.toolStripLabel1.Text = pHeaderText;
        }

        private void periphericalDeviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.periphericalDeviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void PeriphericalDevices_Load(object sender, EventArgs e)
        {
            periphericalDeviceTableAdapter.Fill(dataSet1.PeriphericalDevice);
            gatewayTableAdapter.Fill(dataSet1.Gateway);
        }

        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int moreThan10ByGateway = 0;
            int idgateway = (int)((DevExpress.XtraEditors.LookUpEdit)sender).EditValue;
            int pos = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (moreThan10ByGateway >= 10)
                {
                    pos = i;
                    break;
                }
                var row = gridView1.GetRow(i) as DataRowView;
                if (row != null)
                {
                    var device = row.Row as PeriphericalDeviceRow;
                    try
                    {
                        if (device.idGateway == idgateway)
                        {
                            moreThan10ByGateway = moreThan10ByGateway + 1;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                        //throw;
                    }
                }
                else
                {
                }

                // var row = gridView1.GetRow(i);
            }

            if (moreThan10ByGateway >= 10)
            {
                MessageBox.Show("Cannot more than 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridView1.DeleteRow(pos);
                //gridView1.RefreshData();
                return;
            }
        }
    }
}
