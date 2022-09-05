using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace REST.FORMS
{
    public partial class frmStoreGateway : DevExpress.XtraEditors.XtraForm
    {
        public frmStoreGateway()
        {
            InitializeComponent();
        }

        private void gatewayBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         

        }

        private void frmStoreGateway_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Gateway' table. You can move, or remove it, as needed.
         

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            REST.BUSINESS.REST.StoreGateway(uniqueSerialNumTextEdit.Text, humanReadableTextEdit.Text, iPv4TextEdit.Text);

        }
    }
}