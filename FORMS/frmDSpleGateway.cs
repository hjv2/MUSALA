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
using REST.UC;

namespace REST.FORMS
{
    public partial class frmDSpleGateway : DevExpress.XtraEditors.XtraForm
    {
        private Control control;
        private DataRow row;

        public frmDSpleGateway()
        {
            InitializeComponent();
        }

        public frmDSpleGateway(DataRow row)
        {
            InitializeComponent();
            this.row = row;
            var details = row as DATA.DataSet1.GatewayRow;
            uniqueSerialNumTextEdit.Text = details.uniqueSerialNum;
            humanReadableTextEdit.Text = details.humanReadable;
            iPv4TextEdit.Text = details.IPv4;
        }

   

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}