using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//using DevExpress.XtraGrid.Columns;
using System.Data;
using DevExpress.XtraPivotGrid;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
//using GDOCApp.Properties;


namespace REST.UTILS
{
    static class Utils
    {

        internal static DATA.DataClasses1DataContext ConectarLinq()
        {
            var linq = new DATA.DataClasses1DataContext (RESTConnStrings());
            return linq;
        }



        internal static string RESTConnStrings()
        {
            ///-----------DataSet => RESTConnectionString -----------------/////
            return "Data Source=HAVAPP001;Initial Catalog=REST;Persist Security Info=True;User ID=sa;Password=Prima123Vera";
        }

        public static void ShowOnPanel2(UserControl uc, DevExpress.XtraEditors.SplitContainerControl splitContainerControl)
        {
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl.Panel2.Controls.Clear();
            splitContainerControl.Panel2.Controls.Add(uc);
        }

        internal static void ShowGridFilterAlways(UserControl uc)
        {
            foreach (var item in uc.Controls)
            {
                ShowGridFilterAlways(item);
            }
        }

        internal static void ShowGridFilterAlways(object item)
        {
            if (item.GetType() == typeof(DevExpress.XtraGrid.GridControl))
            {
                var gridC = item as DevExpress.XtraGrid.GridControl;
                var gridv = gridC.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

                gridv.OptionsView.ShowAutoFilterRow = true;
                gridv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
                //gridv.OptionsView.

                gridv.OptionsFind.AlwaysVisible = true;
                gridv.OptionsFind.FindNullPrompt = "Entre el texto a buscar...";
                gridv.OptionsFind.ShowClearButton = false;
                gridv.OptionsFind.ShowCloseButton = false;
                gridv.OptionsFind.ShowFindButton = false;

            }
        }




    }
}
