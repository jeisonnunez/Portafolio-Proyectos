namespace CockpitsService
{
    partial class FormCkptService
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          this.tabPage_Test = new System.Windows.Forms.TabPage();
          this.button_Clear = new System.Windows.Forms.Button();
          this.button_GetCockpitsList = new System.Windows.Forms.Button();
          this.dataGridView_Cockpits = new System.Windows.Forms.DataGridView();
          this.button_GetUserCockpitList = new System.Windows.Forms.Button();
          this.groupBox_ServiceAttributes = new System.Windows.Forms.GroupBox();
          this.label_ParamName = new System.Windows.Forms.Label();
          this.textBox_ParamsName = new System.Windows.Forms.TextBox();
          this.button_AddObj = new System.Windows.Forms.Button();
          this.button_UpdateObj = new System.Windows.Forms.Button();
          this.button_RemoveObj = new System.Windows.Forms.Button();
          this.label_CkptName = new System.Windows.Forms.Label();
          this.textBox_CkptName = new System.Windows.Forms.TextBox();
          this.label_CkptDesc = new System.Windows.Forms.Label();
          this.textBox_CkptDesc = new System.Windows.Forms.TextBox();
          this.label_CkptManu = new System.Windows.Forms.Label();
          this.textBox_CkptManu = new System.Windows.Forms.TextBox();
          this.button_Publish = new System.Windows.Forms.Button();
          this.button_GetTemplateCockpitList = new System.Windows.Forms.Button();
          this.tabPage_Connect = new System.Windows.Forms.TabPage();
          this.button_Connect = new System.Windows.Forms.Button();
          this.groupBox_CompanyAttributes = new System.Windows.Forms.GroupBox();
          this.label_ServerName = new System.Windows.Forms.Label();
          this.label_LicServerName = new System.Windows.Forms.Label();
          this.comboBox_ServerName = new System.Windows.Forms.ComboBox();
          this.comboBox_LicServerName = new System.Windows.Forms.ComboBox();
          this.textBox_LicServerPort = new System.Windows.Forms.TextBox();
          this.label_SQLType = new System.Windows.Forms.Label();
          this.comboBox_SQLType = new System.Windows.Forms.ComboBox();
          this.label_SQLAdmin = new System.Windows.Forms.Label();
          this.label_SQLPass = new System.Windows.Forms.Label();
          this.textBox_SQLUserName = new System.Windows.Forms.TextBox();
          this.textBox_SQLPassword = new System.Windows.Forms.TextBox();
          this.label_CompanyDBName = new System.Windows.Forms.Label();
          this.label_CompanyUser = new System.Windows.Forms.Label();
          this.label_CompanyPassword = new System.Windows.Forms.Label();
          this.comboBox_CompanyDB = new System.Windows.Forms.ComboBox();
          this.textBox_CompanyUser = new System.Windows.Forms.TextBox();
          this.textBox_CompanyPassword = new System.Windows.Forms.TextBox();
          this.label_Language = new System.Windows.Forms.Label();
          this.checkBox_UserTrusted = new System.Windows.Forms.CheckBox();
          this.comboBox_Language = new System.Windows.Forms.ComboBox();
          this.label_Result = new System.Windows.Forms.Label();
          this.label_ResultContent = new System.Windows.Forms.Label();
          this.tabControl_Service = new System.Windows.Forms.TabControl();
          this.tabPage_Test.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cockpits)).BeginInit();
          this.groupBox_ServiceAttributes.SuspendLayout();
          this.tabPage_Connect.SuspendLayout();
          this.groupBox_CompanyAttributes.SuspendLayout();
          this.tabControl_Service.SuspendLayout();
          this.SuspendLayout();
          // 
          // tabPage_Test
          // 
          this.tabPage_Test.Controls.Add(this.button_GetTemplateCockpitList);
          this.tabPage_Test.Controls.Add(this.groupBox_ServiceAttributes);
          this.tabPage_Test.Controls.Add(this.button_GetUserCockpitList);
          this.tabPage_Test.Controls.Add(this.dataGridView_Cockpits);
          this.tabPage_Test.Controls.Add(this.button_GetCockpitsList);
          this.tabPage_Test.Controls.Add(this.button_Clear);
          this.tabPage_Test.Location = new System.Drawing.Point(4, 25);
          this.tabPage_Test.Margin = new System.Windows.Forms.Padding(4);
          this.tabPage_Test.Name = "tabPage_Test";
          this.tabPage_Test.Padding = new System.Windows.Forms.Padding(4);
          this.tabPage_Test.Size = new System.Drawing.Size(864, 441);
          this.tabPage_Test.TabIndex = 1;
          this.tabPage_Test.Text = "Service/Objects";
          this.tabPage_Test.UseVisualStyleBackColor = true;
          // 
          // button_Clear
          // 
          this.button_Clear.BackColor = System.Drawing.Color.LightCoral;
          this.button_Clear.Location = new System.Drawing.Point(670, 396);
          this.button_Clear.Name = "button_Clear";
          this.button_Clear.Size = new System.Drawing.Size(178, 35);
          this.button_Clear.TabIndex = 19;
          this.button_Clear.Text = "Clear DataGridView";
          this.button_Clear.UseVisualStyleBackColor = false;
          this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
          // 
          // button_GetCockpitsList
          // 
          this.button_GetCockpitsList.Location = new System.Drawing.Point(7, 393);
          this.button_GetCockpitsList.Name = "button_GetCockpitsList";
          this.button_GetCockpitsList.Size = new System.Drawing.Size(197, 38);
          this.button_GetCockpitsList.TabIndex = 21;
          this.button_GetCockpitsList.Text = "GetCockpitsList";
          this.button_GetCockpitsList.UseVisualStyleBackColor = true;
          this.button_GetCockpitsList.Click += new System.EventHandler(this.button_GetCockpitsList_Click);
          // 
          // dataGridView_Cockpits
          // 
          this.dataGridView_Cockpits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dataGridView_Cockpits.Location = new System.Drawing.Point(7, 7);
          this.dataGridView_Cockpits.Name = "dataGridView_Cockpits";
          this.dataGridView_Cockpits.Size = new System.Drawing.Size(644, 380);
          this.dataGridView_Cockpits.TabIndex = 0;
          // 
          // button_GetUserCockpitList
          // 
          this.button_GetUserCockpitList.Location = new System.Drawing.Point(221, 393);
          this.button_GetUserCockpitList.Name = "button_GetUserCockpitList";
          this.button_GetUserCockpitList.Size = new System.Drawing.Size(197, 38);
          this.button_GetUserCockpitList.TabIndex = 22;
          this.button_GetUserCockpitList.Text = "GetUserCockpitList";
          this.button_GetUserCockpitList.UseVisualStyleBackColor = true;
          this.button_GetUserCockpitList.Click += new System.EventHandler(this.button_GetUserCockpitList_Click);
          // 
          // groupBox_ServiceAttributes
          // 
          this.groupBox_ServiceAttributes.Controls.Add(this.button_Publish);
          this.groupBox_ServiceAttributes.Controls.Add(this.textBox_CkptManu);
          this.groupBox_ServiceAttributes.Controls.Add(this.label_CkptManu);
          this.groupBox_ServiceAttributes.Controls.Add(this.textBox_CkptDesc);
          this.groupBox_ServiceAttributes.Controls.Add(this.label_CkptDesc);
          this.groupBox_ServiceAttributes.Controls.Add(this.textBox_CkptName);
          this.groupBox_ServiceAttributes.Controls.Add(this.label_CkptName);
          this.groupBox_ServiceAttributes.Controls.Add(this.button_RemoveObj);
          this.groupBox_ServiceAttributes.Controls.Add(this.button_UpdateObj);
          this.groupBox_ServiceAttributes.Controls.Add(this.button_AddObj);
          this.groupBox_ServiceAttributes.Controls.Add(this.textBox_ParamsName);
          this.groupBox_ServiceAttributes.Controls.Add(this.label_ParamName);
          this.groupBox_ServiceAttributes.Location = new System.Drawing.Point(657, 7);
          this.groupBox_ServiceAttributes.Name = "groupBox_ServiceAttributes";
          this.groupBox_ServiceAttributes.Size = new System.Drawing.Size(200, 380);
          this.groupBox_ServiceAttributes.TabIndex = 1;
          this.groupBox_ServiceAttributes.TabStop = false;
          this.groupBox_ServiceAttributes.Text = "Service Attributes";
          // 
          // label_ParamName
          // 
          this.label_ParamName.AutoSize = true;
          this.label_ParamName.Location = new System.Drawing.Point(6, 202);
          this.label_ParamName.Name = "label_ParamName";
          this.label_ParamName.Size = new System.Drawing.Size(61, 16);
          this.label_ParamName.TabIndex = 6;
          this.label_ParamName.Text = "Params";
          // 
          // textBox_ParamsName
          // 
          this.textBox_ParamsName.Location = new System.Drawing.Point(70, 199);
          this.textBox_ParamsName.Name = "textBox_ParamsName";
          this.textBox_ParamsName.Size = new System.Drawing.Size(121, 22);
          this.textBox_ParamsName.TabIndex = 7;
          this.textBox_ParamsName.Text = "AbsEntry";
          // 
          // button_AddObj
          // 
          this.button_AddObj.Location = new System.Drawing.Point(13, 130);
          this.button_AddObj.Name = "button_AddObj";
          this.button_AddObj.Size = new System.Drawing.Size(181, 30);
          this.button_AddObj.TabIndex = 9;
          this.button_AddObj.Text = "Add";
          this.button_AddObj.UseVisualStyleBackColor = true;
          this.button_AddObj.Click += new System.EventHandler(this.button_AddObj_Click);
          // 
          // button_UpdateObj
          // 
          this.button_UpdateObj.Location = new System.Drawing.Point(13, 245);
          this.button_UpdateObj.Name = "button_UpdateObj";
          this.button_UpdateObj.Size = new System.Drawing.Size(181, 29);
          this.button_UpdateObj.TabIndex = 10;
          this.button_UpdateObj.Text = "Update";
          this.button_UpdateObj.UseVisualStyleBackColor = true;
          this.button_UpdateObj.Click += new System.EventHandler(this.button_UpdateObj_Click);
          // 
          // button_RemoveObj
          // 
          this.button_RemoveObj.Location = new System.Drawing.Point(13, 294);
          this.button_RemoveObj.Name = "button_RemoveObj";
          this.button_RemoveObj.Size = new System.Drawing.Size(181, 30);
          this.button_RemoveObj.TabIndex = 11;
          this.button_RemoveObj.Text = "Delete";
          this.button_RemoveObj.UseVisualStyleBackColor = true;
          this.button_RemoveObj.Click += new System.EventHandler(this.button_RemoveObj_Click);
          // 
          // label_CkptName
          // 
          this.label_CkptName.AutoSize = true;
          this.label_CkptName.Location = new System.Drawing.Point(10, 31);
          this.label_CkptName.Name = "label_CkptName";
          this.label_CkptName.Size = new System.Drawing.Size(49, 16);
          this.label_CkptName.TabIndex = 13;
          this.label_CkptName.Text = "Name";
          // 
          // textBox_CkptName
          // 
          this.textBox_CkptName.Location = new System.Drawing.Point(70, 28);
          this.textBox_CkptName.Name = "textBox_CkptName";
          this.textBox_CkptName.Size = new System.Drawing.Size(121, 22);
          this.textBox_CkptName.TabIndex = 14;
          // 
          // label_CkptDesc
          // 
          this.label_CkptDesc.AutoSize = true;
          this.label_CkptDesc.Location = new System.Drawing.Point(10, 60);
          this.label_CkptDesc.Name = "label_CkptDesc";
          this.label_CkptDesc.Size = new System.Drawing.Size(44, 16);
          this.label_CkptDesc.TabIndex = 15;
          this.label_CkptDesc.Text = "Desc";
          // 
          // textBox_CkptDesc
          // 
          this.textBox_CkptDesc.Location = new System.Drawing.Point(70, 60);
          this.textBox_CkptDesc.Name = "textBox_CkptDesc";
          this.textBox_CkptDesc.Size = new System.Drawing.Size(121, 22);
          this.textBox_CkptDesc.TabIndex = 16;
          // 
          // label_CkptManu
          // 
          this.label_CkptManu.AutoSize = true;
          this.label_CkptManu.Location = new System.Drawing.Point(10, 91);
          this.label_CkptManu.Name = "label_CkptManu";
          this.label_CkptManu.Size = new System.Drawing.Size(45, 16);
          this.label_CkptManu.TabIndex = 17;
          this.label_CkptManu.Text = "Manu";
          // 
          // textBox_CkptManu
          // 
          this.textBox_CkptManu.Location = new System.Drawing.Point(70, 88);
          this.textBox_CkptManu.Name = "textBox_CkptManu";
          this.textBox_CkptManu.Size = new System.Drawing.Size(121, 22);
          this.textBox_CkptManu.TabIndex = 18;
          // 
          // button_Publish
          // 
          this.button_Publish.Location = new System.Drawing.Point(13, 344);
          this.button_Publish.Name = "button_Publish";
          this.button_Publish.Size = new System.Drawing.Size(181, 30);
          this.button_Publish.TabIndex = 20;
          this.button_Publish.Text = "Publish";
          this.button_Publish.UseVisualStyleBackColor = true;
          this.button_Publish.Click += new System.EventHandler(this.button_Publish_Click);
          // 
          // button_GetTemplateCockpitList
          // 
          this.button_GetTemplateCockpitList.Location = new System.Drawing.Point(441, 393);
          this.button_GetTemplateCockpitList.Name = "button_GetTemplateCockpitList";
          this.button_GetTemplateCockpitList.Size = new System.Drawing.Size(197, 38);
          this.button_GetTemplateCockpitList.TabIndex = 23;
          this.button_GetTemplateCockpitList.Text = "GetTemplateCockpitList";
          this.button_GetTemplateCockpitList.UseVisualStyleBackColor = true;
          this.button_GetTemplateCockpitList.Click += new System.EventHandler(this.button_GetTemplateCockpitList_Click);
          // 
          // tabPage_Connect
          // 
          this.tabPage_Connect.Controls.Add(this.label_ResultContent);
          this.tabPage_Connect.Controls.Add(this.label_Result);
          this.tabPage_Connect.Controls.Add(this.groupBox_CompanyAttributes);
          this.tabPage_Connect.Controls.Add(this.button_Connect);
          this.tabPage_Connect.Location = new System.Drawing.Point(4, 25);
          this.tabPage_Connect.Margin = new System.Windows.Forms.Padding(4);
          this.tabPage_Connect.Name = "tabPage_Connect";
          this.tabPage_Connect.Padding = new System.Windows.Forms.Padding(4);
          this.tabPage_Connect.Size = new System.Drawing.Size(864, 441);
          this.tabPage_Connect.TabIndex = 0;
          this.tabPage_Connect.Text = "Connection";
          this.tabPage_Connect.UseVisualStyleBackColor = true;
          // 
          // button_Connect
          // 
          this.button_Connect.BackColor = System.Drawing.Color.MistyRose;
          this.button_Connect.Location = new System.Drawing.Point(8, 195);
          this.button_Connect.Name = "button_Connect";
          this.button_Connect.Size = new System.Drawing.Size(845, 40);
          this.button_Connect.TabIndex = 0;
          this.button_Connect.Text = "CONNECT";
          this.button_Connect.UseVisualStyleBackColor = false;
          this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
          // 
          // groupBox_CompanyAttributes
          // 
          this.groupBox_CompanyAttributes.Controls.Add(this.comboBox_Language);
          this.groupBox_CompanyAttributes.Controls.Add(this.checkBox_UserTrusted);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_Language);
          this.groupBox_CompanyAttributes.Controls.Add(this.textBox_CompanyPassword);
          this.groupBox_CompanyAttributes.Controls.Add(this.textBox_CompanyUser);
          this.groupBox_CompanyAttributes.Controls.Add(this.comboBox_CompanyDB);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_CompanyPassword);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_CompanyUser);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_CompanyDBName);
          this.groupBox_CompanyAttributes.Controls.Add(this.textBox_SQLPassword);
          this.groupBox_CompanyAttributes.Controls.Add(this.textBox_SQLUserName);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_SQLPass);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_SQLAdmin);
          this.groupBox_CompanyAttributes.Controls.Add(this.comboBox_SQLType);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_SQLType);
          this.groupBox_CompanyAttributes.Controls.Add(this.textBox_LicServerPort);
          this.groupBox_CompanyAttributes.Controls.Add(this.comboBox_LicServerName);
          this.groupBox_CompanyAttributes.Controls.Add(this.comboBox_ServerName);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_LicServerName);
          this.groupBox_CompanyAttributes.Controls.Add(this.label_ServerName);
          this.groupBox_CompanyAttributes.Location = new System.Drawing.Point(8, 8);
          this.groupBox_CompanyAttributes.Name = "groupBox_CompanyAttributes";
          this.groupBox_CompanyAttributes.Size = new System.Drawing.Size(845, 181);
          this.groupBox_CompanyAttributes.TabIndex = 1;
          this.groupBox_CompanyAttributes.TabStop = false;
          this.groupBox_CompanyAttributes.Text = "Company Attributes";
          // 
          // label_ServerName
          // 
          this.label_ServerName.AutoSize = true;
          this.label_ServerName.Location = new System.Drawing.Point(19, 22);
          this.label_ServerName.Name = "label_ServerName";
          this.label_ServerName.Size = new System.Drawing.Size(54, 16);
          this.label_ServerName.TabIndex = 0;
          this.label_ServerName.Text = "Server";
          // 
          // label_LicServerName
          // 
          this.label_LicServerName.AutoSize = true;
          this.label_LicServerName.Location = new System.Drawing.Point(304, 22);
          this.label_LicServerName.Name = "label_LicServerName";
          this.label_LicServerName.Size = new System.Drawing.Size(112, 16);
          this.label_LicServerName.TabIndex = 1;
          this.label_LicServerName.Text = "License Server";
          // 
          // comboBox_ServerName
          // 
          this.comboBox_ServerName.FormattingEnabled = true;
          this.comboBox_ServerName.Location = new System.Drawing.Point(79, 19);
          this.comboBox_ServerName.Name = "comboBox_ServerName";
          this.comboBox_ServerName.Size = new System.Drawing.Size(184, 24);
          this.comboBox_ServerName.TabIndex = 2;
          this.comboBox_ServerName.Text = "localhost";
          // 
          // comboBox_LicServerName
          // 
          this.comboBox_LicServerName.FormattingEnabled = true;
          this.comboBox_LicServerName.Location = new System.Drawing.Point(427, 19);
          this.comboBox_LicServerName.Name = "comboBox_LicServerName";
          this.comboBox_LicServerName.Size = new System.Drawing.Size(159, 24);
          this.comboBox_LicServerName.TabIndex = 3;
          this.comboBox_LicServerName.Text = "localhost";
          // 
          // textBox_LicServerPort
          // 
          this.textBox_LicServerPort.Location = new System.Drawing.Point(592, 19);
          this.textBox_LicServerPort.Name = "textBox_LicServerPort";
          this.textBox_LicServerPort.Size = new System.Drawing.Size(55, 22);
          this.textBox_LicServerPort.TabIndex = 4;
          this.textBox_LicServerPort.Text = "30000";
          // 
          // label_SQLType
          // 
          this.label_SQLType.AutoSize = true;
          this.label_SQLType.Location = new System.Drawing.Point(19, 60);
          this.label_SQLType.Name = "label_SQLType";
          this.label_SQLType.Size = new System.Drawing.Size(77, 16);
          this.label_SQLType.TabIndex = 5;
          this.label_SQLType.Text = "SQL Type";
          // 
          // comboBox_SQLType
          // 
          this.comboBox_SQLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.comboBox_SQLType.FormattingEnabled = true;
          this.comboBox_SQLType.Location = new System.Drawing.Point(102, 57);
          this.comboBox_SQLType.Name = "comboBox_SQLType";
          this.comboBox_SQLType.Size = new System.Drawing.Size(161, 24);
          this.comboBox_SQLType.TabIndex = 6;
          // 
          // label_SQLAdmin
          // 
          this.label_SQLAdmin.AutoSize = true;
          this.label_SQLAdmin.Location = new System.Drawing.Point(304, 60);
          this.label_SQLAdmin.Name = "label_SQLAdmin";
          this.label_SQLAdmin.Size = new System.Drawing.Size(74, 16);
          this.label_SQLAdmin.TabIndex = 7;
          this.label_SQLAdmin.Text = "SQL User";
          // 
          // label_SQLPass
          // 
          this.label_SQLPass.AutoSize = true;
          this.label_SQLPass.Location = new System.Drawing.Point(515, 60);
          this.label_SQLPass.Name = "label_SQLPass";
          this.label_SQLPass.Size = new System.Drawing.Size(109, 16);
          this.label_SQLPass.TabIndex = 8;
          this.label_SQLPass.Text = "SQL Password";
          // 
          // textBox_SQLUserName
          // 
          this.textBox_SQLUserName.Location = new System.Drawing.Point(384, 57);
          this.textBox_SQLUserName.Name = "textBox_SQLUserName";
          this.textBox_SQLUserName.Size = new System.Drawing.Size(100, 22);
          this.textBox_SQLUserName.TabIndex = 9;
          this.textBox_SQLUserName.Text = "sa";
          // 
          // textBox_SQLPassword
          // 
          this.textBox_SQLPassword.Location = new System.Drawing.Point(630, 57);
          this.textBox_SQLPassword.Name = "textBox_SQLPassword";
          this.textBox_SQLPassword.Size = new System.Drawing.Size(129, 22);
          this.textBox_SQLPassword.TabIndex = 10;
          this.textBox_SQLPassword.UseSystemPasswordChar = true;
          // 
          // label_CompanyDBName
          // 
          this.label_CompanyDBName.AutoSize = true;
          this.label_CompanyDBName.Location = new System.Drawing.Point(19, 102);
          this.label_CompanyDBName.Name = "label_CompanyDBName";
          this.label_CompanyDBName.Size = new System.Drawing.Size(73, 16);
          this.label_CompanyDBName.TabIndex = 11;
          this.label_CompanyDBName.Text = "Company";
          // 
          // label_CompanyUser
          // 
          this.label_CompanyUser.AutoSize = true;
          this.label_CompanyUser.Location = new System.Drawing.Point(304, 102);
          this.label_CompanyUser.Name = "label_CompanyUser";
          this.label_CompanyUser.Size = new System.Drawing.Size(63, 16);
          this.label_CompanyUser.TabIndex = 12;
          this.label_CompanyUser.Text = "B1 User";
          // 
          // label_CompanyPassword
          // 
          this.label_CompanyPassword.AutoSize = true;
          this.label_CompanyPassword.Location = new System.Drawing.Point(515, 102);
          this.label_CompanyPassword.Name = "label_CompanyPassword";
          this.label_CompanyPassword.Size = new System.Drawing.Size(98, 16);
          this.label_CompanyPassword.TabIndex = 13;
          this.label_CompanyPassword.Text = "B1 Password";
          // 
          // comboBox_CompanyDB
          // 
          this.comboBox_CompanyDB.FormattingEnabled = true;
          this.comboBox_CompanyDB.Location = new System.Drawing.Point(102, 99);
          this.comboBox_CompanyDB.Name = "comboBox_CompanyDB";
          this.comboBox_CompanyDB.Size = new System.Drawing.Size(161, 24);
          this.comboBox_CompanyDB.TabIndex = 14;
          this.comboBox_CompanyDB.Text = "SBODemoUS";
          // 
          // textBox_CompanyUser
          // 
          this.textBox_CompanyUser.Location = new System.Drawing.Point(384, 99);
          this.textBox_CompanyUser.Name = "textBox_CompanyUser";
          this.textBox_CompanyUser.Size = new System.Drawing.Size(100, 22);
          this.textBox_CompanyUser.TabIndex = 15;
          this.textBox_CompanyUser.Text = "manager";
          // 
          // textBox_CompanyPassword
          // 
          this.textBox_CompanyPassword.Location = new System.Drawing.Point(630, 99);
          this.textBox_CompanyPassword.Name = "textBox_CompanyPassword";
          this.textBox_CompanyPassword.Size = new System.Drawing.Size(200, 22);
          this.textBox_CompanyPassword.TabIndex = 16;
          this.textBox_CompanyPassword.UseSystemPasswordChar = true;
          // 
          // label_Language
          // 
          this.label_Language.AutoSize = true;
          this.label_Language.Location = new System.Drawing.Point(19, 144);
          this.label_Language.Name = "label_Language";
          this.label_Language.Size = new System.Drawing.Size(77, 16);
          this.label_Language.TabIndex = 17;
          this.label_Language.Text = "Language";
          // 
          // checkBox_UserTrusted
          // 
          this.checkBox_UserTrusted.AutoSize = true;
          this.checkBox_UserTrusted.Location = new System.Drawing.Point(713, 21);
          this.checkBox_UserTrusted.Name = "checkBox_UserTrusted";
          this.checkBox_UserTrusted.Size = new System.Drawing.Size(117, 20);
          this.checkBox_UserTrusted.TabIndex = 19;
          this.checkBox_UserTrusted.Text = "User Trusted";
          this.checkBox_UserTrusted.UseVisualStyleBackColor = true;
          // 
          // comboBox_Language
          // 
          this.comboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.comboBox_Language.FormattingEnabled = true;
          this.comboBox_Language.Location = new System.Drawing.Point(102, 141);
          this.comboBox_Language.Name = "comboBox_Language";
          this.comboBox_Language.Size = new System.Drawing.Size(161, 24);
          this.comboBox_Language.TabIndex = 22;
          // 
          // label_Result
          // 
          this.label_Result.AutoSize = true;
          this.label_Result.Location = new System.Drawing.Point(8, 242);
          this.label_Result.Name = "label_Result";
          this.label_Result.Size = new System.Drawing.Size(52, 16);
          this.label_Result.TabIndex = 2;
          this.label_Result.Text = "Result";
          // 
          // label_ResultContent
          // 
          this.label_ResultContent.AutoSize = true;
          this.label_ResultContent.Location = new System.Drawing.Point(8, 268);
          this.label_ResultContent.Name = "label_ResultContent";
          this.label_ResultContent.Size = new System.Drawing.Size(20, 16);
          this.label_ResultContent.TabIndex = 3;
          this.label_ResultContent.Text = "...";
          // 
          // tabControl_Service
          // 
          this.tabControl_Service.Controls.Add(this.tabPage_Connect);
          this.tabControl_Service.Controls.Add(this.tabPage_Test);
          this.tabControl_Service.Location = new System.Drawing.Point(14, 11);
          this.tabControl_Service.Margin = new System.Windows.Forms.Padding(4);
          this.tabControl_Service.Name = "tabControl_Service";
          this.tabControl_Service.SelectedIndex = 0;
          this.tabControl_Service.Size = new System.Drawing.Size(872, 470);
          this.tabControl_Service.TabIndex = 0;
          // 
          // FormCkptService
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(900, 487);
          this.Controls.Add(this.tabControl_Service);
          this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.Margin = new System.Windows.Forms.Padding(4);
          this.Name = "FormCkptService";
          this.Text = "Service";
          this.tabPage_Test.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cockpits)).EndInit();
          this.groupBox_ServiceAttributes.ResumeLayout(false);
          this.groupBox_ServiceAttributes.PerformLayout();
          this.tabPage_Connect.ResumeLayout(false);
          this.tabPage_Connect.PerformLayout();
          this.groupBox_CompanyAttributes.ResumeLayout(false);
          this.groupBox_CompanyAttributes.PerformLayout();
          this.tabControl_Service.ResumeLayout(false);
          this.ResumeLayout(false);

        }

        #endregion

      private System.Windows.Forms.TabPage tabPage_Test;
      private System.Windows.Forms.Button button_GetTemplateCockpitList;
      private System.Windows.Forms.GroupBox groupBox_ServiceAttributes;
      private System.Windows.Forms.Button button_Publish;
      private System.Windows.Forms.TextBox textBox_CkptManu;
      private System.Windows.Forms.Label label_CkptManu;
      private System.Windows.Forms.TextBox textBox_CkptDesc;
      private System.Windows.Forms.Label label_CkptDesc;
      private System.Windows.Forms.TextBox textBox_CkptName;
      private System.Windows.Forms.Label label_CkptName;
      private System.Windows.Forms.Button button_RemoveObj;
      private System.Windows.Forms.Button button_UpdateObj;
      private System.Windows.Forms.Button button_AddObj;
      private System.Windows.Forms.TextBox textBox_ParamsName;
      private System.Windows.Forms.Label label_ParamName;
      private System.Windows.Forms.Button button_GetUserCockpitList;
      private System.Windows.Forms.DataGridView dataGridView_Cockpits;
      private System.Windows.Forms.Button button_GetCockpitsList;
      private System.Windows.Forms.Button button_Clear;
      private System.Windows.Forms.TabPage tabPage_Connect;
      private System.Windows.Forms.Label label_ResultContent;
      private System.Windows.Forms.Label label_Result;
      private System.Windows.Forms.GroupBox groupBox_CompanyAttributes;
      private System.Windows.Forms.ComboBox comboBox_Language;
      private System.Windows.Forms.CheckBox checkBox_UserTrusted;
      private System.Windows.Forms.Label label_Language;
      private System.Windows.Forms.TextBox textBox_CompanyPassword;
      private System.Windows.Forms.TextBox textBox_CompanyUser;
      private System.Windows.Forms.ComboBox comboBox_CompanyDB;
      private System.Windows.Forms.Label label_CompanyPassword;
      private System.Windows.Forms.Label label_CompanyUser;
      private System.Windows.Forms.Label label_CompanyDBName;
      private System.Windows.Forms.TextBox textBox_SQLPassword;
      private System.Windows.Forms.TextBox textBox_SQLUserName;
      private System.Windows.Forms.Label label_SQLPass;
      private System.Windows.Forms.Label label_SQLAdmin;
      private System.Windows.Forms.ComboBox comboBox_SQLType;
      private System.Windows.Forms.Label label_SQLType;
      private System.Windows.Forms.TextBox textBox_LicServerPort;
      private System.Windows.Forms.ComboBox comboBox_LicServerName;
      private System.Windows.Forms.ComboBox comboBox_ServerName;
      private System.Windows.Forms.Label label_LicServerName;
      private System.Windows.Forms.Label label_ServerName;
      private System.Windows.Forms.Button button_Connect;
      private System.Windows.Forms.TabControl tabControl_Service;


      }
}

