using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SAPbobsCOM;

//****************************************************************************
//  SAP DI API 8.8 SDK Sample
//****************************************************************************
//
//  Copyright (c) SAP 
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************

///////////////////////////////////////////////////////////////////////

namespace CockpitsService
{
    public partial class FormCkptService : Form
    {
        SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
        SAPbobsCOM.CockpitsService ckptService = null;


        public FormCkptService()
        {
            InitializeComponent();

            ////SQL Type.
            comboBox_SQLType.Items.Add("SQL Server 2005");
            comboBox_SQLType.Items.Add("SQL Server 2008");
            comboBox_SQLType.SelectedIndex = 0;

            ////Languages.
            comboBox_Language.Items.Add("English");
            comboBox_Language.SelectedIndex = 0;
        }

        ~FormCkptService()
        {
            if(null != oCompany)
            {
                oCompany.Disconnect();
            }
        }

        private void ConnectWithCurrentSettings()
        {
            //Use the default values
            oCompany.Server = comboBox_ServerName.Text;
            oCompany.LicenseServer = comboBox_LicServerName.Text + ":" + textBox_LicServerPort.Text;
            oCompany.UseTrusted = checkBox_UserTrusted.Checked;
            
            if (string.Compare("SQL Server 2008", comboBox_SQLType.Text) == 0)
            {
                oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2008;
            }
            else
            {
                oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2005;
            }

            oCompany.DbUserName = textBox_SQLUserName.Text;
            oCompany.DbPassword = textBox_SQLPassword.Text;

            oCompany.CompanyDB = comboBox_CompanyDB.Text;
            oCompany.UserName = textBox_CompanyUser.Text;
            oCompany.Password = textBox_CompanyPassword.Text;

            oCompany.language = BoSuppLangs.ln_English;

            int lRetCode = oCompany.Connect();
            if (0 != lRetCode)
            {
                int lErrCode = lRetCode;
                string strErr;
                oCompany.GetLastError(out lErrCode, out strErr);
                label_ResultContent.Text = strErr;
            }
            else
            {
                label_ResultContent.Text = "Connected to Company: " + oCompany.CompanyDB;
                label_ResultContent.BackColor = Color.LightGreen;

                //Get cockpitsService.
                ckptService = GetCockpitService();
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            ConnectWithCurrentSettings();

            if(ckptService != null)
            {
                //Connection succeeded.
                button_Connect.Enabled = false;
            }
        }

        private SAPbobsCOM.CockpitsService GetCockpitService()
        {
            //Get all list from OCPT.
            if (null == oCompany)
            {
                MessageBox.Show("Connect to a company db at first!");
                return null;
            }
            //Get company service.
            SAPbobsCOM.CompanyService comService = oCompany.GetCompanyService();
            if (null == comService)
            {
                MessageBox.Show("Failed to create company service!");
                return null;
            }

            //Get cockpitsService.
            SAPbobsCOM.CockpitsService oService = (SAPbobsCOM.CockpitsService)comService.GetBusinessService(ServiceTypes.CockpitsService);
            if (null == oService)
            {
                MessageBox.Show("Failed to create CockpitsService!");
                return null;
            }
            else
            {
                return oService;
            }
        }

        private void button_GetList_Click(object sender, EventArgs e)
        {
            if (null == ckptService)
                return;

            SAPbobsCOM.CockpitsParams ckptsParams = (SAPbobsCOM.CockpitsParams)ckptService.GetCockpitList();
            if (null == ckptsParams)
                return;

            DataTable showTable = new DataTable();
            DataColumn dc = null;
            
            dc = showTable.Columns.Add("AbsEntry", Type.GetType("System.Int32"));

            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dc.AutoIncrementStep = 1;
            dc.AllowDBNull = true;

            DataColumn dcCode = showTable.Columns.Add("Code", Type.GetType("System.Int32"));
            DataColumn dcName = showTable.Columns.Add("Name", Type.GetType("System.String"));
            DataColumn dcDesc = showTable.Columns.Add("Description", Type.GetType("System.String"));
            DataColumn dcManu = showTable.Columns.Add("Manufacturer", Type.GetType("System.String"));

            if(ckptsParams.Count > 0)
            {
                foreach (SAPbobsCOM.CockpitParams ckptParams in ckptsParams)
                {
                    SAPbobsCOM.Cockpit ckpt = ckptService.GetCockpit(ckptParams);
                    //Get all properties now.
                    DataRow rowNew = showTable.NewRow();
                    rowNew["AbsEntry"] = ckpt.AbsEntry;
                    rowNew["Code"] = ckpt.Code;
                    rowNew["Name"] = ckpt.Name;
                    rowNew["Description"] = ckpt.Description;
                    rowNew["Manufacturer"] = ckpt.Manufacturer;

                    showTable.Rows.Add(rowNew);
                }
            }
            
            //Update the dataGrid control.
            dataGridView_Cockpits.DataSource = showTable;
            
            GC.Collect();
        }

        private void button_AddObj_Click(object sender, EventArgs e)
        {
            if (null == ckptService)
                return;

            SAPbobsCOM.Cockpit ckptAdd = (SAPbobsCOM.Cockpit)ckptService.GetDataInterface(CockpitsServiceDataInterfaces.csCockpit);
            ckptAdd.Name = textBox_CkptName.Text;
            ckptAdd.Description = textBox_CkptDesc.Text;
            ckptAdd.Manufacturer = textBox_CkptManu.Text;

            ckptService.AddCockpit(ckptAdd);

            //Update the control
            button_GetUserCockpitList_Click(sender, e);

            GC.Collect();
        }

        private void button_UpdateObj_Click(object sender, EventArgs e)
        {
            if (null == ckptService)
                return;

            SAPbobsCOM.CockpitParams ckptUpdateParams = (SAPbobsCOM.CockpitParams)ckptService.GetDataInterface(CockpitsServiceDataInterfaces.csCockpitParams);
            ckptUpdateParams.AbsEntry = Convert.ToInt32(textBox_ParamsName.Text);

            try
            {
                SAPbobsCOM.Cockpit ckptUpdate = (SAPbobsCOM.Cockpit)ckptService.GetCockpit(ckptUpdateParams);
                ckptUpdate.Name = textBox_CkptName.Text;
                ckptUpdate.Description = textBox_CkptDesc.Text;
                ckptUpdate.Manufacturer = textBox_CkptManu.Text;

                ckptService.UpdateCockpit(ckptUpdate);

                //Update the control now.
                button_GetUserCockpitList_Click(sender, e);
            }
            catch(Exception ex)
            {
                string strErrMsg = ex.ToString();
                string strErrShow = "Failed to Update Cockpit, Invalid inputs...\n\n";
                MessageBox.Show(strErrShow + strErrMsg);
                return;
            }
        }

        private void button_RemoveObj_Click(object sender, EventArgs e)
        {
            if (null == ckptService)
                return;

            SAPbobsCOM.CockpitParams ckptDeleteParams = (SAPbobsCOM.CockpitParams)ckptService.GetDataInterface(CockpitsServiceDataInterfaces.csCockpitParams);
            ckptDeleteParams.AbsEntry = Convert.ToInt32(textBox_ParamsName.Text);
            

            try
            {
                ckptService.DeleteCockpit(ckptDeleteParams);

                //Update the control.
                button_GetUserCockpitList_Click(sender, e);
            }
            catch (Exception ex)
            {
                string strErrMsg = ex.ToString();
                string strErrShow = "Failed to Update Cockpit, Invalid inputs...\n\n";
                MessageBox.Show(strErrShow + strErrMsg);
                return;
            }
        }

        private void button_GetObj_Click(object sender, EventArgs e)
        {
           if (null == ckptService)
                return;

            SAPbobsCOM.CockpitParams ckptParams = (SAPbobsCOM.CockpitParams)ckptService.GetDataInterface(CockpitsServiceDataInterfaces.csCockpitParams);
            ckptParams.AbsEntry = Convert.ToInt32(textBox_ParamsName.Text);
          
            try
            {
                SAPbobsCOM.Cockpit ckptGet = (SAPbobsCOM.Cockpit)ckptService.GetCockpit(ckptParams);

                DataTable showTable = new DataTable();
                DataColumn dc = null;

                dc = showTable.Columns.Add("AbsEntry", Type.GetType("System.Int32"));

                dc.AutoIncrement = true;
                dc.AutoIncrementSeed = 1;
                dc.AutoIncrementStep = 1;
                dc.AllowDBNull = true;

                DataColumn dcCode = showTable.Columns.Add("Code", Type.GetType("System.Int32"));
                DataColumn dcName = showTable.Columns.Add("Name", Type.GetType("System.String"));
                DataColumn dcDesc = showTable.Columns.Add("Description", Type.GetType("System.String"));
                DataColumn dcManu = showTable.Columns.Add("Manufacturer", Type.GetType("System.String"));

                //Get all properties now.
                DataRow rowNew = showTable.NewRow();
                rowNew["AbsEntry"] = ckptGet.AbsEntry;
                rowNew["Code"] = ckptGet.Code;
                rowNew["Name"] = ckptGet.Name;
                rowNew["Description"] = ckptGet.Description;
                rowNew["Manufacturer"] = ckptGet.Manufacturer;

                showTable.Rows.Add(rowNew);

                dataGridView_Cockpits.DataSource = showTable;
            }
            catch (Exception ex)
            {
                string strErrMsg = ex.ToString();
                string strErrShow = "Failed to Update Cockpit, Invalid inputs...\n\n";
                MessageBox.Show(strErrShow + strErrMsg);
                return;
            }

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dataGridView_Cockpits.DataSource = null;
        }

      private void button_GetCockpitsList_Click(object sender, EventArgs e)
      {
        if (null == ckptService)
          return;


        SAPbobsCOM.CockpitsParams ckptsParams = (SAPbobsCOM.CockpitsParams)ckptService.GetCockpitList();
        if (null == ckptsParams)
          return;

        FillDataTable(ckptsParams);

        GC.Collect();

      }

      private void button_GetUserCockpitList_Click(object sender, EventArgs e)
      {
        if (null == ckptService)
          return;

        SAPbobsCOM.CockpitsParams ckptsParams = (SAPbobsCOM.CockpitsParams)ckptService.GetUserCockpitList();
        if (null == ckptsParams)
          return;

        FillDataTable(ckptsParams);

        GC.Collect();
      }

      private void button_GetTemplateCockpitList_Click(object sender, EventArgs e)
      {
        if (null == ckptService)
          return;

        SAPbobsCOM.CockpitsParams ckptsParams = (SAPbobsCOM.CockpitsParams)ckptService.GetTemplateCockpitList();
        if (null == ckptsParams)
          return;

        FillDataTable(ckptsParams);

        GC.Collect();
      }

      public void FillDataTable(CockpitsParams ckptsParams)
      {
        DataTable showTable = new DataTable();
        DataColumn dc = null;

        dc = showTable.Columns.Add("AbsEntry", Type.GetType("System.Int32"));

        dc.AutoIncrement = true;
        dc.AutoIncrementSeed = 1;
        dc.AutoIncrementStep = 1;
        dc.AllowDBNull = true;

        DataColumn dcCode = showTable.Columns.Add("Code", Type.GetType("System.Int32"));
        DataColumn dcType = showTable.Columns.Add("CockpitType", Type.GetType("System.String"));
        DataColumn dcName = showTable.Columns.Add("Name", Type.GetType("System.String"));
        DataColumn dcDesc = showTable.Columns.Add("Description", Type.GetType("System.String"));
        DataColumn dcManu = showTable.Columns.Add("Manufacturer", Type.GetType("System.String"));
        DataColumn dcPublisher = showTable.Columns.Add("Publisher", Type.GetType("System.String"));
        DataColumn dcDate = showTable.Columns.Add("Date", Type.GetType("System.String"));
        DataColumn dcTime = showTable.Columns.Add("Time", Type.GetType("System.String"));

        if (ckptsParams.Count > 0)
        {
          foreach (SAPbobsCOM.CockpitParams ckptParams in ckptsParams)
          {
            SAPbobsCOM.Cockpit ckpt = ckptService.GetCockpit(ckptParams);
            //Get all properties now.
            DataRow rowNew = showTable.NewRow();
            rowNew["AbsEntry"] = ckpt.AbsEntry;
            rowNew["Code"] = ckpt.Code;
            rowNew["CockpitType"] = ckpt.CockpitType;
            rowNew["Name"] = ckpt.Name;
            rowNew["Description"] = ckpt.Description;
            rowNew["Manufacturer"] = ckpt.Manufacturer;
            rowNew["Publisher"] = ckpt.Publisher;
            rowNew["Date"] = ckpt.Date.ToShortDateString();
            rowNew["Time"] = ckpt.Time.ToShortTimeString();

            showTable.Rows.Add(rowNew);
          }
        }

        //Update the dataGrid control.
        dataGridView_Cockpits.DataSource = showTable;
      }

      private void button_Publish_Click(object sender, EventArgs e)
      {
        if (null == ckptService)
          return;

        SAPbobsCOM.CockpitParams ckptPublishParams = (SAPbobsCOM.CockpitParams)ckptService.GetDataInterface(CockpitsServiceDataInterfaces.csCockpitParams);
        ckptPublishParams.AbsEntry = Convert.ToInt32(textBox_ParamsName.Text);

        try
        {
          SAPbobsCOM.Cockpit ckptPublish = (SAPbobsCOM.Cockpit)ckptService.GetCockpit(ckptPublishParams);

          ckptService.PublishCockpit(ckptPublish);

          //Update the control now.
          button_GetTemplateCockpitList_Click(sender, e);
        }
        catch (Exception ex)
        {
          string strErrMsg = ex.ToString();
          string strErrShow = "Failed to Update Cockpit, Invalid inputs...\n\n";
          MessageBox.Show(strErrShow + strErrMsg);
          return;
        }
      }

     }
}