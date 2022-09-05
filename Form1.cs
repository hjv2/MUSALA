using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using REST.UC;

namespace REST
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           if (splitContainerControl.Panel2.Controls[0].GetType() != typeof(ucGateways))
           {
                var uc = new ucGateways(e.Link.Item.Caption.ToUpper());
                UTILS.Utils.ShowOnPanel2(uc, splitContainerControl);
               // UTILS.Utils.SetUCActual(uc);
                UTILS.Utils.ShowGridFilterAlways(uc);
           }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (splitContainerControl.Panel2.Controls[0].GetType() != typeof(UC.PeriphericalDevices))
            {
                var uc = new PeriphericalDevices(e.Link.Item.Caption.ToUpper());
                UTILS.Utils.ShowOnPanel2(uc, splitContainerControl);
                // UTILS.Utils.SetUCActual(uc);
                UTILS.Utils.ShowGridFilterAlways(uc);
            }
        }

        private void navBarItem2_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new FORMS.frmStoreGateway();
            frm.ShowDialog();
            if (splitContainerControl.Panel2.Controls[0].GetType() == typeof(ucGateways))
            {
                var uc = new ucGateways(e.Link.Item.Caption.ToUpper());
                UTILS.Utils.ShowOnPanel2(uc, splitContainerControl);
                // UTILS.Utils.SetUCActual(uc);
                UTILS.Utils.ShowGridFilterAlways(uc);
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //if (splitContainerControl.Panel2.Controls[0].GetType() == typeof(ucGateways))
            //{
            //  //  splitContainerControl.Panel2.Controls.Add(uc);
            //    var frm = new FORMS.frmDSpleGateway(splitContainerControl.Panel2.Controls[0]);
            //    frm.ShowDialog();
            //}
        }
    }
}