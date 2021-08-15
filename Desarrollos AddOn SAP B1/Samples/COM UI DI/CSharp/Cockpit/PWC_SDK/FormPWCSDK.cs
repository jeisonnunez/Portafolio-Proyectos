using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//****************************************************************************
//  SAP UI API 8.8 SDK Sample
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

namespace PWC_SDK
{
    public partial class FormPWCSDK : Form
    {
        private SAPbouiCOM.Application sbo_Application;
        private bool bAppSet = false;

        private string strCurrentCockpitTypeID;
        private string strCurrentWidgetUID;

        private string strCurrentKey;
        private string strCurrentValue;

        private static int currentRow = 0;
        private static int currentColumn = 0;


        private static int iFormCount = 1;
        //////////////////////////////////////////////////////////////////////////
        public FormPWCSDK()
        {
            InitializeComponent();

            //WidgetTypeID, for built-in widget types.
            comboBox_WidgetTypeID.Items.Add("IE");
            comboBox_WidgetTypeID.Items.Add("Common Functions");
            comboBox_WidgetTypeID.Items.Add("Open Items");
            comboBox_WidgetTypeID.Items.Add("Alert Widget");
            comboBox_WidgetTypeID.SelectedIndex = 0;

            //Hide tab page "WidgetS"
            tabPage_Widgets.Dispose();


            try
            {
                SetApplication();
            }
            catch(Exception e)
            {
                string strErrMsg = "Failed to connect to SAP Business One, please start the program first.\n";
                strErrMsg += "Details:\n";
                strErrMsg += e.Message;

                MessageBox.Show(strErrMsg);
            }
        }

        private void SetApplication()
        {
            SAPbouiCOM.SboGuiApi SboGuiApi = null;
            string sConnectionString = null;
            SboGuiApi = new SAPbouiCOM.SboGuiApi();

            //0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
            sConnectionString = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";
            //sConnectionString = System.Convert.ToString(Environment.GetCommandLineArgs().GetValue(1));
            SboGuiApi.Connect(sConnectionString);
            sbo_Application = SboGuiApi.GetApplication(-1);

            if(bAppSet)
            {
                //Get current cockpit
                GetCurrentCockpit();
                //Get first widget in current cockpit.
                GetFirstWidgetInCurrentCockpit();
            }
            bAppSet = true;
        }
        private void button_Application_Click(object sender, EventArgs e)
        {
            if(bAppSet == false)
            {
                SetApplication();
                RegisterEnventHandlers();
            }
        }

        private void RegisterEnventHandlers()
        {
            sbo_Application.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler(SBO_Application_ItemEvent);
            sbo_Application.MenuEvent += new SAPbouiCOM._IApplicationEvents_MenuEventEventHandler(SBO_Application_MenuEvent); 
            sbo_Application.WidgetEvent += new SAPbouiCOM._IApplicationEvents_WidgetEventEventHandler(SBO_Application_WidgetEvent);
        }


        private void FormPWCSDK_Load(object sender, EventArgs e)
        {
            if(bAppSet)
            {
                RegisterEnventHandlers();
            }
        }

        private void ShowAboutDialog()
        {
            try
            {
                //sbo_Application.Forms.Add("About_Addon_Widget", SAPbouiCOM.BoFormTypes.ft_Fixed, 0);

                SAPbouiCOM.FormCreationParams oFormParams;
                oFormParams = (SAPbouiCOM.FormCreationParams)sbo_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams);
                oFormParams.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Sizable;

                oFormParams.FormType = "WDT_ABOUT_FORM";
                oFormParams.UniqueID = "WDT_ABOUT_FORM_" + iFormCount.ToString();
                ++iFormCount;

                SAPbouiCOM.Form tmpform = sbo_Application.Forms.AddEx(oFormParams);
                tmpform.ClientHeight = 200;
                tmpform.ClientWidth = 100;

                //Use different titles for testing every time.
                tmpform.Title = "Addon_Widget_About_" + Guid.NewGuid();
                tmpform.Visible = true;

                //Add a button to the form now.
                SAPbouiCOM.Item oItem = tmpform.Items.Add("OK", SAPbouiCOM.BoFormItemTypes.it_BUTTON);
                oItem.Top = 100;
                SAPbouiCOM.Button obutton = (SAPbouiCOM.Button)oItem.Specific;
                obutton.Caption = "Okay";
            }
            catch(Exception ex)
            {

            }
        }
        private void SBO_Application_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
                        
            //About.
            if (pVal.FormTypeEx == "WDT_FORM" && pVal.ItemUID == "PWC_SYS_ABOUT_ITM")
            {
                if (pVal.EventType == SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED && pVal.BeforeAction == false)
                {
                    ShowAboutDialog();
                }
            }

            if (pVal.EventType == SAPbouiCOM.BoEventTypes.et_Drag)
            {
                SAPbouiCOM.ItemDragEvent itemDragEvt = (SAPbouiCOM.ItemDragEvent)pVal;

                if (itemDragEvt.TargetFormUID.CompareTo("") != 0)
                {
                    string strFormType = itemDragEvt.TargetFormType;
                    string strFormUID = itemDragEvt.TargetFormUID;
                    int iTop = itemDragEvt.Top;
                    int iLeft = itemDragEvt.Left;

                    SAPbouiCOM.Form sForm = sbo_Application.Forms.Item(pVal.FormUID);
                    SAPbouiCOM.Item sItem = sForm.Items.Item(pVal.ItemUID);


                    SAPbouiCOM.Form oForm = sbo_Application.Forms.Item(strFormUID);
                    //Copy the item now, we need to freeze the from in advance.
                    oForm.Freeze(true);

                    SAPbouiCOM.Item oItem = oForm.Items.Add("test" + iFormCount.ToString(), sItem.Type);
                    oItem.Visible = true;
                    ++iFormCount;

                    oItem.Left = iLeft;
                    oItem.Top = iTop;
                    oItem.Height = sItem.Height;
                    oItem.Width = sItem.Width;

                    switch(oItem.Type)
                    {
                        case SAPbouiCOM.BoFormItemTypes.it_BUTTON:
                            {
                                SAPbouiCOM.Button sButton = (SAPbouiCOM.Button)sItem.Specific;
                                SAPbouiCOM.Button oButton = (SAPbouiCOM.Button)oItem.Specific;
                                oButton.Caption = sButton.Caption;
                            }
                            break;

                        case SAPbouiCOM.BoFormItemTypes.it_COMBO_BOX:
                            {
                                SAPbouiCOM.ComboBox sCombo = (SAPbouiCOM.ComboBox)sItem.Specific;
                                SAPbouiCOM.ComboBox oCombo = (SAPbouiCOM.ComboBox)oItem.Specific;

                                for(int i=0; i<sCombo.ValidValues.Count; ++i)
                                {
                                    oCombo.ValidValues.Add(sCombo.ValidValues.Item(i).Value, sCombo.ValidValues.Item(i).Description);
                                }
                            }
                            break;

                        case SAPbouiCOM.BoFormItemTypes.it_EDIT:
                            {
                                SAPbouiCOM.EditText sEditText = (SAPbouiCOM.EditText)sItem.Specific;
                                SAPbouiCOM.EditText oEditText = (SAPbouiCOM.EditText)oItem.Specific;
                                oEditText.String = sEditText.String;
                                oEditText.Value = sEditText.Value;
                            }
                            break;
                            
                        //All other types, you can do similar operations as you like.
                        case SAPbouiCOM.BoFormItemTypes.it_BUTTON_COMBO:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_CHECK_BOX:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_EXTEDIT:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_FOLDER:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_GRID:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_LINKED_BUTTON:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_MATRIX:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_OPTION_BUTTON:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_PANE_COMBO_BOX:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_PICTURE:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_RECTANGLE:
                            break;
                        case SAPbouiCOM.BoFormItemTypes.it_STATIC:
                            break;
                        default:
                            break;
                    }

                    //Remeber to un-freeze the form after adjustment.
                    oForm.Freeze(false);
                }
            }
        }

        private void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
        }

        private void SBO_Application_WidgetEvent(ref SAPbouiCOM.WidgetData pWidgetData, out bool BubbleEvent)
        {
            BubbleEvent = true;

            if (pWidgetData.EventType == SAPbouiCOM.BoWidgetEventTypes.wet_created && pWidgetData.WidgetType == "AddonWidget")
            {
                //Catch widget event "wet_created" from Infra/App level and assign a form for it.
                SAPbouiCOM.FormCreationParams oFormParams;
                oFormParams = (SAPbouiCOM.FormCreationParams)sbo_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams);
                oFormParams.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Sizable;
                //oFormParams.FormType = "WDT_FORM_" + Guid.NewGuid();
                //oFormParams.UniqueID = "WDT_FORM_" + Guid.NewGuid();
                oFormParams.FormType = "WDT_FORM";
                oFormParams.UniqueID = "WDT_FORM_" + iFormCount.ToString();
                ++iFormCount;

                SAPbouiCOM.Form tmpform = sbo_Application.Forms.AddEx(oFormParams);
                tmpform.ClientHeight = 600;
                tmpform.ClientWidth = 600;
                tmpform.Left = pWidgetData.Left;
                tmpform.Top = pWidgetData.Top;
                tmpform.Width = pWidgetData.Right - pWidgetData.Left;
                tmpform.Height = pWidgetData.Bottom - pWidgetData.Top;
                //User differnt titles for testing every time.
                tmpform.Title = "Addon_Widget_" + Guid.NewGuid();
                tmpform.Visible = true;

                //Add a button to the form now.
                SAPbouiCOM.Item oItem = tmpform.Items.Add("EditText", SAPbouiCOM.BoFormItemTypes.it_EDIT);
                oItem.Top = 100;
                oItem.Left = 100;
                SAPbouiCOM.EditText oText = (SAPbouiCOM.EditText)oItem.Specific;
                //oText.Caption = "TestButton";

                //Assign the form to the add-on widget
                pWidgetData.Form = tmpform;
            }

            if (pWidgetData.EventType == SAPbouiCOM.BoWidgetEventTypes.wet_content_save && pWidgetData.WidgetType == "AddonWidget")
            {
                SAPbouiCOM.Widget oWidget = sbo_Application.Cockpits.GetWidget(pWidgetData.WidgetUID);
                oWidget.SetValue("save", "saveAddonWidget");
            }
        }

        private void button_Cockpits_Click(object sender, EventArgs e)
        {
            //Get all cockpits.
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            int iCkptsCount = ckpts.Count;

            if(iCkptsCount > 0)
            {
                //Zero based.
                for(int iLoop=0; iLoop<iCkptsCount; ++iLoop)
                {
                    SAPbouiCOM.Cockpit ckpt = ckpts.Item(iLoop);
                    string strCkptTypeID = ckpt.CockpitTypeID;

                    //Whatever operation as you like...
                }
            }

            textBox_CockpitNumber.Text = iCkptsCount.ToString();
        }

        private void button_RegWidget_Click(object sender, EventArgs e)
        {
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //Widget Registration Parameters.
            SAPbouiCOM.WidgetRegParams wrp = (SAPbouiCOM.WidgetRegParams)sbo_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_WidgetRegParams);
            string sPath;

            sPath = System.IO.Directory.GetCurrentDirectory();
            sPath = System.IO.Directory.GetParent(sPath).ToString();
            sPath = System.IO.Directory.GetParent(sPath).ToString();

            wrp.WidgetType = "AddonWidget";
            wrp.WidgetName = "Addon_Menu";
            wrp.ImagePath = sPath + "\\Smile.png";
            wrp.Width = 50;
            wrp.Height = 40;
            wrp.CategoryUID = "User Widgets";

            //Register Add-on widget.
            ckpts.RegisterWidget(wrp);

            comboBox_WidgetTypeID.Items.Add("AddonWidget");     //For add-on users...
        }

        private void button_GetWidget_Click(object sender, EventArgs e)
        {
            //Get widget with WidgetUID.
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //For example, if there is more than 1 cockpit in B1.
            //And every cockpit has more than 1 widget on it.
            //Get the first widget in the first cockpit.
            SAPbouiCOM.Cockpit ckpt = ckpts.Item(0);
            SAPbouiCOM.Widgets wdts = ckpt.Widgets;
            SAPbouiCOM.Widget wdt = wdts.Item(0);

            //Store the widgetUID for the further steps...
            string strWidgetUID = wdt.WidgetUID;

            //Any operations as you like....
            //.........

            //You can retrieve the first one now....
            SAPbouiCOM.Widget wdtGet = ckpts.GetWidget(strWidgetUID);

            string strWidgetUniqueID = wdtGet.WidgetUID;

            //Test for invalid input when GetWidget.
            strWidgetUniqueID = "xxxx";
            SAPbouiCOM.Widget wdtInvalid = ckpts.GetWidget(strWidgetUniqueID);
        }

        private void button_CockpitTypeID_Click(object sender, EventArgs e)
        {
            ////Get type ID of a specified cockpit.
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //if(ckpts.Count > 0)
            //{
            //    //For example, get CockpitTypeID of the first cockpit.
            //    string strCockpitTypeID = ckpts.Item(0).CockpitTypeID;
            //}

            //Get current cockpit's type id
            textBox_CockpitTypeID.Text = ckpts.CurrentCockpit.CockpitTypeID;
        }

        private void button_GetWidgets_Click(object sender, EventArgs e)
        {
            //Get widgets from a specific cockpit object.
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //if (ckpts.Count > 0)
            //{
            //    //For example, get CockpitTypeID of the first cockpit.
            //    //You can put some widgets into this cockpit in advance.
            //    SAPbouiCOM.Widgets wdts = ckpts.CurrentCockpit.Widgets;

            //    //Now you can check the widget number in this cockpit.
            //    textBox_WidgetNumber.Text = wdts.Count.ToString();

            //    //Any other operations as you like...
            //}

            //Get widgets number of current cockpit.
            textBox_WidgetNumber.Text = ckpts.CurrentCockpit.Widgets.Count.ToString();
        }

        private void button_MoveWidget_Click(object sender, EventArgs e)
        {
            //Move a specific widget in the current cockpit.
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //Move the first widget in the current cockpit...Just for example.
            if(ckpts.Count > 0)
            {
                //Get current cockpit
                SAPbouiCOM.Cockpit ckpt = (SAPbouiCOM.Cockpit)ckpts.CurrentCockpit;
                SAPbouiCOM.Widgets wdts = ckpt.Widgets;
                if(wdts.Count > 0)
                {
                    //Move the widget now.
                    string strWidgetUID = wdts.Item(0).WidgetUID;

                    int row = Convert.ToInt32(currentRow);
                    int col = Convert.ToInt32(currentColumn);
                    //Try to move the widget to (row, col)
                    ckpt.MoveWidget(strWidgetUID, row, col);
                }
            }
        }

        private void button_CreateInstance_Click(object sender, EventArgs e)
        {
            //Move a specific widget in the current cockpit.
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //Put a IE Browser widget into the current cockpit...Just for example.
            SAPbouiCOM.Cockpit ckpt = (SAPbouiCOM.Cockpit)ckpts.CurrentCockpit;

            string strWidgetTypeID = comboBox_WidgetTypeID.Text;

            //Try to put the browser widget into current cockpit, and placing it at (row, col)
            SAPbouiCOM.Widget wdt_instance = ckpt.CreateWidgetInstance(strWidgetTypeID, currentRow, currentColumn);

            if (wdt_instance == null)
            {
              MessageBox.Show("Error while trying to create a widget instance: " +
                "the widget is a registered widget and there is not other widget at that location?");
            }
        }


        private void GetCurrentCockpit()
        {
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //Get the current cockpit...
            SAPbouiCOM.Cockpit ckpt = (SAPbouiCOM.Cockpit)ckpts.CurrentCockpit;

            //Store the cockpit type id for "SwitchCockpit" later.
            strCurrentCockpitTypeID = ckpt.CockpitTypeID;
            //Any other operations as you like...


            textBox_CurrentCockpit.Text = ckpt.CockpitTypeID;
        }

        private void GetFirstWidgetInCurrentCockpit()
        {
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //Get the current cockpit...
            SAPbouiCOM.Cockpit ckpt = (SAPbouiCOM.Cockpit)ckpts.CurrentCockpit;

            if(ckpt.Widgets != null && ckpt.Widgets.Count>0)
            {
                strCurrentWidgetUID = ckpt.Widgets.Item(0).WidgetUID;
                textBox_WidgetUID.Text = strCurrentWidgetUID;
            }
        }

        private void button_CurrentCockpit_Click(object sender, EventArgs e)
        {
            GetCurrentCockpit();
        }

        private void button_SwitchCockpit_Click(object sender, EventArgs e)
        {
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //Get the current cockpit...
            SAPbouiCOM.Cockpit ckpt = (SAPbouiCOM.Cockpit)ckpts.CurrentCockpit;

            //Then change the "current" cockpit, you can do this by shifting to other cockpit.....

            //Then re-set the former one as the "Current" cockpit.
            ckpts.SwitchCockpit(strCurrentCockpitTypeID);
        }

        private void button_Widgets_Click(object sender, EventArgs e)
        {
            //Get all widgets in a cockpit.

            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //2 way to test item count in cockpits...
            if (ckpts.Count > 0)
            {
                SAPbouiCOM.Cockpit ckpt_Number = ckpts.Item(0);
                SAPbouiCOM.Cockpit ckpt_Code = ckpts.Item(strCurrentCockpitTypeID);

                //2 ways to test item count in widgets
                SAPbouiCOM.Widgets wdts = ckpt_Code.Widgets;
                if (wdts.Count > 0)
                {
                    SAPbouiCOM.Widget wdt_number = wdts.Item(0);
                    SAPbouiCOM.Widget wdt_Code = wdts.Item(wdt_number.WidgetUID);
                }
            }

            //For example, get all widgets in current cockpit.
            //SAPbouiCOM.Widgets wdts = (SAPbouiCOM.Widgets)ckpts.CurrentCockpit.Widgets;

            ////We can check the number of widgets at first...
            //int iCount = wdts.Count;

            //Any other operations as you like...
        }

        private void button_WidgetUID_Click(object sender, EventArgs e)
        {
            //Get WidgetUID of a widget, in a cockpit.

            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //For example, get all widgets in current cockpit.
            SAPbouiCOM.Widgets wdts = (SAPbouiCOM.Widgets)ckpts.CurrentCockpit.Widgets;

            //For example, get the first widget's UID.
            textBox_WidgetUID.Text = wdts.Item(0).WidgetUID;

            strCurrentWidgetUID = wdts.Item(0).WidgetUID;
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            //Minimize a widget, in a cockpit.

            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //For example, get all widgets in current cockpit.
            SAPbouiCOM.Widgets wdts = (SAPbouiCOM.Widgets)ckpts.CurrentCockpit.Widgets;

            if(wdts.Count > 0)
            {
                //For example, Minimize the first widget in current cockpit.
                SAPbouiCOM.Widget wdt = (SAPbouiCOM.Widget)wdts.Item(0);

                wdt.Minimize();
            }
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            //Restore a widget, in a cockpit.

            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //For example, get all widgets in current cockpit.
            SAPbouiCOM.Widgets wdts = (SAPbouiCOM.Widgets)ckpts.CurrentCockpit.Widgets;

            //For example, Resotre the first widget in current cockpit.
            //You can minimize it manually in B1, in advance.
            if(wdts.Count > 0)
            {
                SAPbouiCOM.Widget wdt = (SAPbouiCOM.Widget)wdts.Item(0);

                wdt.Restore();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            //Close a widget, in a cockpit.

            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;

            //For example, get all widgets in current cockpit.
            SAPbouiCOM.Widgets wdts = (SAPbouiCOM.Widgets)ckpts.CurrentCockpit.Widgets;

            //For example, Close the first widget in current cockpit.
            //You can minimize it manually in B1, in advance.
            if(wdts.Count > 0)
            {
                SAPbouiCOM.Widget wdt = (SAPbouiCOM.Widget)wdts.Item(0);

                wdt.Close();
            }
        }

        private void textBox_Row_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Row.Text.Length == 0)
            {
                currentRow = -1;
            }
            else
            {
                currentRow = Convert.ToInt32(textBox_Row.Text);
            }
        }

        private void textBox_Column_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Column.Text.Length == 0)
            {
                currentColumn = -1;
            }
            else
            {
                currentColumn = Convert.ToInt32(textBox_Column.Text);
            }
        }

        private void button_GetValue_Click(object sender, EventArgs e)
        {
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;
            SAPbouiCOM.Widget wdt = ckpts.GetWidget(strCurrentWidgetUID);
            string strValue = wdt.GetValue(strCurrentKey);

            textBox_Value.Text = strValue;
        }

        private void button_SetValue_Click(object sender, EventArgs e)
        {
            SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;
            SAPbouiCOM.Widget wdt = ckpts.GetWidget(strCurrentWidgetUID);
            wdt.SetValue(strCurrentKey, strCurrentValue);
        }

        private void textBox_Key_TextChanged(object sender, EventArgs e)
        {
            strCurrentKey = textBox_Key.Text;
        }

        private void textBox_Value_TextChanged(object sender, EventArgs e)
        {
            strCurrentValue = textBox_Value.Text;
        }

      private void button_Refresh_Click(object sender, EventArgs e)
      {
        sbo_Application.Cockpits.Refresh();
      }

      private void button_Save_Click(object sender, EventArgs e)
      {
        //Save current cockpit configuration.
        SAPbouiCOM.Cockpits ckpts = sbo_Application.Cockpits;
        SAPbouiCOM.Cockpit ckpt = (SAPbouiCOM.Cockpit)ckpts.CurrentCockpit;

        ckpt.Save();
      }
    }
}