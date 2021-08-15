namespace PWC_SDK
{
    partial class FormPWCSDK
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
          this.tabControl_SDK = new System.Windows.Forms.TabControl();
          this.tabPage_Cockpits = new System.Windows.Forms.TabPage();
          this.textBox_CurrentCockpit = new System.Windows.Forms.TextBox();
          this.textBox_CockpitNumber = new System.Windows.Forms.TextBox();
          this.button_SwitchCockpit = new System.Windows.Forms.Button();
          this.button_CurrentCockpit = new System.Windows.Forms.Button();
          this.button_GetWidget = new System.Windows.Forms.Button();
          this.button_RegWidget = new System.Windows.Forms.Button();
          this.button_Cockpits = new System.Windows.Forms.Button();
          this.tabPage_Cockpit = new System.Windows.Forms.TabPage();
          this.comboBox_WidgetTypeID = new System.Windows.Forms.ComboBox();
          this.textBox_CockpitTypeID = new System.Windows.Forms.TextBox();
          this.label_Column = new System.Windows.Forms.Label();
          this.label_Row = new System.Windows.Forms.Label();
          this.textBox_Column = new System.Windows.Forms.TextBox();
          this.textBox_Row = new System.Windows.Forms.TextBox();
          this.textBox_WidgetNumber = new System.Windows.Forms.TextBox();
          this.button_CreateInstance = new System.Windows.Forms.Button();
          this.button_MoveWidget = new System.Windows.Forms.Button();
          this.button_GetWidgets = new System.Windows.Forms.Button();
          this.button_CockpitTypeID = new System.Windows.Forms.Button();
          this.tabPage_Widgets = new System.Windows.Forms.TabPage();
          this.button_Widgets = new System.Windows.Forms.Button();
          this.tabPage_Widget = new System.Windows.Forms.TabPage();
          this.label_Value = new System.Windows.Forms.Label();
          this.label_Key = new System.Windows.Forms.Label();
          this.textBox_Value = new System.Windows.Forms.TextBox();
          this.textBox_Key = new System.Windows.Forms.TextBox();
          this.textBox_WidgetUID = new System.Windows.Forms.TextBox();
          this.button_SetValue = new System.Windows.Forms.Button();
          this.button_GetValue = new System.Windows.Forms.Button();
          this.button_Close = new System.Windows.Forms.Button();
          this.button_Restore = new System.Windows.Forms.Button();
          this.button_Minimize = new System.Windows.Forms.Button();
          this.button_WidgetUID = new System.Windows.Forms.Button();
          this.button_Application = new System.Windows.Forms.Button();
          this.button_Refresh = new System.Windows.Forms.Button();
          this.button_Save = new System.Windows.Forms.Button();
          this.tabControl_SDK.SuspendLayout();
          this.tabPage_Cockpits.SuspendLayout();
          this.tabPage_Cockpit.SuspendLayout();
          this.tabPage_Widgets.SuspendLayout();
          this.tabPage_Widget.SuspendLayout();
          this.SuspendLayout();
          // 
          // tabControl_SDK
          // 
          this.tabControl_SDK.Controls.Add(this.tabPage_Cockpits);
          this.tabControl_SDK.Controls.Add(this.tabPage_Cockpit);
          this.tabControl_SDK.Controls.Add(this.tabPage_Widgets);
          this.tabControl_SDK.Controls.Add(this.tabPage_Widget);
          this.tabControl_SDK.Location = new System.Drawing.Point(13, 13);
          this.tabControl_SDK.Margin = new System.Windows.Forms.Padding(4);
          this.tabControl_SDK.Name = "tabControl_SDK";
          this.tabControl_SDK.SelectedIndex = 0;
          this.tabControl_SDK.Size = new System.Drawing.Size(383, 292);
          this.tabControl_SDK.TabIndex = 0;
          this.tabControl_SDK.Tag = "";
          // 
          // tabPage_Cockpits
          // 
          this.tabPage_Cockpits.Controls.Add(this.button_Refresh);
          this.tabPage_Cockpits.Controls.Add(this.textBox_CurrentCockpit);
          this.tabPage_Cockpits.Controls.Add(this.textBox_CockpitNumber);
          this.tabPage_Cockpits.Controls.Add(this.button_SwitchCockpit);
          this.tabPage_Cockpits.Controls.Add(this.button_CurrentCockpit);
          this.tabPage_Cockpits.Controls.Add(this.button_GetWidget);
          this.tabPage_Cockpits.Controls.Add(this.button_RegWidget);
          this.tabPage_Cockpits.Controls.Add(this.button_Cockpits);
          this.tabPage_Cockpits.Location = new System.Drawing.Point(4, 25);
          this.tabPage_Cockpits.Margin = new System.Windows.Forms.Padding(4);
          this.tabPage_Cockpits.Name = "tabPage_Cockpits";
          this.tabPage_Cockpits.Padding = new System.Windows.Forms.Padding(4);
          this.tabPage_Cockpits.Size = new System.Drawing.Size(375, 263);
          this.tabPage_Cockpits.TabIndex = 0;
          this.tabPage_Cockpits.Text = "Cockpits";
          this.tabPage_Cockpits.UseVisualStyleBackColor = true;
          // 
          // textBox_CurrentCockpit
          // 
          this.textBox_CurrentCockpit.Location = new System.Drawing.Point(258, 65);
          this.textBox_CurrentCockpit.Name = "textBox_CurrentCockpit";
          this.textBox_CurrentCockpit.Size = new System.Drawing.Size(100, 22);
          this.textBox_CurrentCockpit.TabIndex = 6;
          // 
          // textBox_CockpitNumber
          // 
          this.textBox_CockpitNumber.Location = new System.Drawing.Point(258, 16);
          this.textBox_CockpitNumber.Name = "textBox_CockpitNumber";
          this.textBox_CockpitNumber.Size = new System.Drawing.Size(100, 22);
          this.textBox_CockpitNumber.TabIndex = 5;
          // 
          // button_SwitchCockpit
          // 
          this.button_SwitchCockpit.Location = new System.Drawing.Point(23, 210);
          this.button_SwitchCockpit.Name = "button_SwitchCockpit";
          this.button_SwitchCockpit.Size = new System.Drawing.Size(214, 35);
          this.button_SwitchCockpit.TabIndex = 4;
          this.button_SwitchCockpit.Text = "SwitchCockpit";
          this.button_SwitchCockpit.UseVisualStyleBackColor = true;
          this.button_SwitchCockpit.Click += new System.EventHandler(this.button_SwitchCockpit_Click);
          // 
          // button_CurrentCockpit
          // 
          this.button_CurrentCockpit.Location = new System.Drawing.Point(23, 60);
          this.button_CurrentCockpit.Name = "button_CurrentCockpit";
          this.button_CurrentCockpit.Size = new System.Drawing.Size(214, 32);
          this.button_CurrentCockpit.TabIndex = 3;
          this.button_CurrentCockpit.Text = "get_CurrentCockpit";
          this.button_CurrentCockpit.UseVisualStyleBackColor = true;
          this.button_CurrentCockpit.Click += new System.EventHandler(this.button_CurrentCockpit_Click);
          // 
          // button_GetWidget
          // 
          this.button_GetWidget.Location = new System.Drawing.Point(23, 161);
          this.button_GetWidget.Name = "button_GetWidget";
          this.button_GetWidget.Size = new System.Drawing.Size(214, 32);
          this.button_GetWidget.TabIndex = 2;
          this.button_GetWidget.Text = "GetWidget";
          this.button_GetWidget.UseVisualStyleBackColor = true;
          this.button_GetWidget.Click += new System.EventHandler(this.button_GetWidget_Click);
          // 
          // button_RegWidget
          // 
          this.button_RegWidget.Location = new System.Drawing.Point(23, 110);
          this.button_RegWidget.Name = "button_RegWidget";
          this.button_RegWidget.Size = new System.Drawing.Size(214, 32);
          this.button_RegWidget.TabIndex = 1;
          this.button_RegWidget.Text = "RegisterWidget";
          this.button_RegWidget.UseVisualStyleBackColor = true;
          this.button_RegWidget.Click += new System.EventHandler(this.button_RegWidget_Click);
          // 
          // button_Cockpits
          // 
          this.button_Cockpits.Location = new System.Drawing.Point(23, 11);
          this.button_Cockpits.Name = "button_Cockpits";
          this.button_Cockpits.Size = new System.Drawing.Size(214, 32);
          this.button_Cockpits.TabIndex = 0;
          this.button_Cockpits.Text = "get_Cockpits";
          this.button_Cockpits.UseVisualStyleBackColor = true;
          this.button_Cockpits.Click += new System.EventHandler(this.button_Cockpits_Click);
          // 
          // tabPage_Cockpit
          // 
          this.tabPage_Cockpit.Controls.Add(this.button_Save);
          this.tabPage_Cockpit.Controls.Add(this.comboBox_WidgetTypeID);
          this.tabPage_Cockpit.Controls.Add(this.textBox_CockpitTypeID);
          this.tabPage_Cockpit.Controls.Add(this.label_Column);
          this.tabPage_Cockpit.Controls.Add(this.label_Row);
          this.tabPage_Cockpit.Controls.Add(this.textBox_Column);
          this.tabPage_Cockpit.Controls.Add(this.textBox_Row);
          this.tabPage_Cockpit.Controls.Add(this.textBox_WidgetNumber);
          this.tabPage_Cockpit.Controls.Add(this.button_CreateInstance);
          this.tabPage_Cockpit.Controls.Add(this.button_MoveWidget);
          this.tabPage_Cockpit.Controls.Add(this.button_GetWidgets);
          this.tabPage_Cockpit.Controls.Add(this.button_CockpitTypeID);
          this.tabPage_Cockpit.Location = new System.Drawing.Point(4, 25);
          this.tabPage_Cockpit.Margin = new System.Windows.Forms.Padding(4);
          this.tabPage_Cockpit.Name = "tabPage_Cockpit";
          this.tabPage_Cockpit.Padding = new System.Windows.Forms.Padding(4);
          this.tabPage_Cockpit.Size = new System.Drawing.Size(375, 263);
          this.tabPage_Cockpit.TabIndex = 1;
          this.tabPage_Cockpit.Text = "Cockpit";
          this.tabPage_Cockpit.UseVisualStyleBackColor = true;
          // 
          // comboBox_WidgetTypeID
          // 
          this.comboBox_WidgetTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.comboBox_WidgetTypeID.FormattingEnabled = true;
          this.comboBox_WidgetTypeID.Location = new System.Drawing.Point(232, 208);
          this.comboBox_WidgetTypeID.Name = "comboBox_WidgetTypeID";
          this.comboBox_WidgetTypeID.Size = new System.Drawing.Size(122, 24);
          this.comboBox_WidgetTypeID.TabIndex = 10;
          // 
          // textBox_CockpitTypeID
          // 
          this.textBox_CockpitTypeID.Location = new System.Drawing.Point(232, 21);
          this.textBox_CockpitTypeID.Name = "textBox_CockpitTypeID";
          this.textBox_CockpitTypeID.Size = new System.Drawing.Size(122, 22);
          this.textBox_CockpitTypeID.TabIndex = 9;
          // 
          // label_Column
          // 
          this.label_Column.AutoSize = true;
          this.label_Column.Location = new System.Drawing.Point(229, 141);
          this.label_Column.Name = "label_Column";
          this.label_Column.Size = new System.Drawing.Size(53, 16);
          this.label_Column.TabIndex = 8;
          this.label_Column.Text = "Column";
          // 
          // label_Row
          // 
          this.label_Row.AutoSize = true;
          this.label_Row.Location = new System.Drawing.Point(229, 97);
          this.label_Row.Name = "label_Row";
          this.label_Row.Size = new System.Drawing.Size(35, 16);
          this.label_Row.TabIndex = 7;
          this.label_Row.Text = "Row";
          // 
          // textBox_Column
          // 
          this.textBox_Column.Location = new System.Drawing.Point(232, 160);
          this.textBox_Column.Name = "textBox_Column";
          this.textBox_Column.Size = new System.Drawing.Size(122, 22);
          this.textBox_Column.TabIndex = 6;
          this.textBox_Column.Text = "0";
          this.textBox_Column.TextChanged += new System.EventHandler(this.textBox_Column_TextChanged);
          // 
          // textBox_Row
          // 
          this.textBox_Row.Location = new System.Drawing.Point(232, 116);
          this.textBox_Row.Name = "textBox_Row";
          this.textBox_Row.Size = new System.Drawing.Size(122, 22);
          this.textBox_Row.TabIndex = 5;
          this.textBox_Row.Text = "0";
          this.textBox_Row.TextChanged += new System.EventHandler(this.textBox_Row_TextChanged);
          // 
          // textBox_WidgetNumber
          // 
          this.textBox_WidgetNumber.Location = new System.Drawing.Point(232, 59);
          this.textBox_WidgetNumber.Name = "textBox_WidgetNumber";
          this.textBox_WidgetNumber.Size = new System.Drawing.Size(122, 22);
          this.textBox_WidgetNumber.TabIndex = 4;
          // 
          // button_CreateInstance
          // 
          this.button_CreateInstance.Location = new System.Drawing.Point(21, 196);
          this.button_CreateInstance.Name = "button_CreateInstance";
          this.button_CreateInstance.Size = new System.Drawing.Size(150, 36);
          this.button_CreateInstance.TabIndex = 3;
          this.button_CreateInstance.Text = "CreateWidgetInstance";
          this.button_CreateInstance.UseVisualStyleBackColor = true;
          this.button_CreateInstance.Click += new System.EventHandler(this.button_CreateInstance_Click);
          // 
          // button_MoveWidget
          // 
          this.button_MoveWidget.Location = new System.Drawing.Point(21, 110);
          this.button_MoveWidget.Name = "button_MoveWidget";
          this.button_MoveWidget.Size = new System.Drawing.Size(142, 35);
          this.button_MoveWidget.TabIndex = 2;
          this.button_MoveWidget.Text = "MoveWidget";
          this.button_MoveWidget.UseVisualStyleBackColor = true;
          this.button_MoveWidget.Click += new System.EventHandler(this.button_MoveWidget_Click);
          // 
          // button_GetWidgets
          // 
          this.button_GetWidgets.Location = new System.Drawing.Point(21, 54);
          this.button_GetWidgets.Name = "button_GetWidgets";
          this.button_GetWidgets.Size = new System.Drawing.Size(142, 32);
          this.button_GetWidgets.TabIndex = 1;
          this.button_GetWidgets.Text = "get_Widgets";
          this.button_GetWidgets.UseVisualStyleBackColor = true;
          this.button_GetWidgets.Click += new System.EventHandler(this.button_GetWidgets_Click);
          // 
          // button_CockpitTypeID
          // 
          this.button_CockpitTypeID.Location = new System.Drawing.Point(21, 17);
          this.button_CockpitTypeID.Name = "button_CockpitTypeID";
          this.button_CockpitTypeID.Size = new System.Drawing.Size(142, 31);
          this.button_CockpitTypeID.TabIndex = 0;
          this.button_CockpitTypeID.Text = "get_CockpitTypeID";
          this.button_CockpitTypeID.UseVisualStyleBackColor = true;
          this.button_CockpitTypeID.Click += new System.EventHandler(this.button_CockpitTypeID_Click);
          // 
          // tabPage_Widgets
          // 
          this.tabPage_Widgets.Controls.Add(this.button_Widgets);
          this.tabPage_Widgets.Location = new System.Drawing.Point(4, 25);
          this.tabPage_Widgets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
          this.tabPage_Widgets.Name = "tabPage_Widgets";
          this.tabPage_Widgets.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
          this.tabPage_Widgets.Size = new System.Drawing.Size(375, 263);
          this.tabPage_Widgets.TabIndex = 2;
          this.tabPage_Widgets.Text = "Widgets";
          this.tabPage_Widgets.UseVisualStyleBackColor = true;
          // 
          // button_Widgets
          // 
          this.button_Widgets.Location = new System.Drawing.Point(20, 14);
          this.button_Widgets.Name = "button_Widgets";
          this.button_Widgets.Size = new System.Drawing.Size(215, 48);
          this.button_Widgets.TabIndex = 0;
          this.button_Widgets.Text = "Count_Item";
          this.button_Widgets.UseVisualStyleBackColor = true;
          this.button_Widgets.Click += new System.EventHandler(this.button_Widgets_Click);
          // 
          // tabPage_Widget
          // 
          this.tabPage_Widget.Controls.Add(this.label_Value);
          this.tabPage_Widget.Controls.Add(this.label_Key);
          this.tabPage_Widget.Controls.Add(this.textBox_Value);
          this.tabPage_Widget.Controls.Add(this.textBox_Key);
          this.tabPage_Widget.Controls.Add(this.textBox_WidgetUID);
          this.tabPage_Widget.Controls.Add(this.button_SetValue);
          this.tabPage_Widget.Controls.Add(this.button_GetValue);
          this.tabPage_Widget.Controls.Add(this.button_Close);
          this.tabPage_Widget.Controls.Add(this.button_Restore);
          this.tabPage_Widget.Controls.Add(this.button_Minimize);
          this.tabPage_Widget.Controls.Add(this.button_WidgetUID);
          this.tabPage_Widget.Location = new System.Drawing.Point(4, 25);
          this.tabPage_Widget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
          this.tabPage_Widget.Name = "tabPage_Widget";
          this.tabPage_Widget.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
          this.tabPage_Widget.Size = new System.Drawing.Size(375, 263);
          this.tabPage_Widget.TabIndex = 3;
          this.tabPage_Widget.Text = "Widget";
          this.tabPage_Widget.UseVisualStyleBackColor = true;
          // 
          // label_Value
          // 
          this.label_Value.AutoSize = true;
          this.label_Value.Location = new System.Drawing.Point(207, 226);
          this.label_Value.Name = "label_Value";
          this.label_Value.Size = new System.Drawing.Size(43, 16);
          this.label_Value.TabIndex = 10;
          this.label_Value.Text = "Value";
          // 
          // label_Key
          // 
          this.label_Key.AutoSize = true;
          this.label_Key.Location = new System.Drawing.Point(207, 178);
          this.label_Key.Name = "label_Key";
          this.label_Key.Size = new System.Drawing.Size(31, 16);
          this.label_Key.TabIndex = 9;
          this.label_Key.Text = "Key";
          // 
          // textBox_Value
          // 
          this.textBox_Value.Location = new System.Drawing.Point(268, 223);
          this.textBox_Value.Name = "textBox_Value";
          this.textBox_Value.Size = new System.Drawing.Size(100, 22);
          this.textBox_Value.TabIndex = 8;
          this.textBox_Value.TextChanged += new System.EventHandler(this.textBox_Value_TextChanged);
          // 
          // textBox_Key
          // 
          this.textBox_Key.Location = new System.Drawing.Point(268, 175);
          this.textBox_Key.Name = "textBox_Key";
          this.textBox_Key.Size = new System.Drawing.Size(100, 22);
          this.textBox_Key.TabIndex = 7;
          this.textBox_Key.TextChanged += new System.EventHandler(this.textBox_Key_TextChanged);
          // 
          // textBox_WidgetUID
          // 
          this.textBox_WidgetUID.Location = new System.Drawing.Point(150, 19);
          this.textBox_WidgetUID.Name = "textBox_WidgetUID";
          this.textBox_WidgetUID.Size = new System.Drawing.Size(218, 22);
          this.textBox_WidgetUID.TabIndex = 6;
          // 
          // button_SetValue
          // 
          this.button_SetValue.Location = new System.Drawing.Point(33, 220);
          this.button_SetValue.Name = "button_SetValue";
          this.button_SetValue.Size = new System.Drawing.Size(111, 28);
          this.button_SetValue.TabIndex = 5;
          this.button_SetValue.Text = "SetValue";
          this.button_SetValue.UseVisualStyleBackColor = true;
          this.button_SetValue.Click += new System.EventHandler(this.button_SetValue_Click);
          // 
          // button_GetValue
          // 
          this.button_GetValue.Location = new System.Drawing.Point(33, 172);
          this.button_GetValue.Name = "button_GetValue";
          this.button_GetValue.Size = new System.Drawing.Size(111, 28);
          this.button_GetValue.TabIndex = 4;
          this.button_GetValue.Text = "GetValue";
          this.button_GetValue.UseVisualStyleBackColor = true;
          this.button_GetValue.Click += new System.EventHandler(this.button_GetValue_Click);
          // 
          // button_Close
          // 
          this.button_Close.Location = new System.Drawing.Point(33, 118);
          this.button_Close.Name = "button_Close";
          this.button_Close.Size = new System.Drawing.Size(111, 28);
          this.button_Close.TabIndex = 3;
          this.button_Close.Text = "Close";
          this.button_Close.UseVisualStyleBackColor = true;
          this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
          // 
          // button_Restore
          // 
          this.button_Restore.Location = new System.Drawing.Point(33, 85);
          this.button_Restore.Name = "button_Restore";
          this.button_Restore.Size = new System.Drawing.Size(111, 27);
          this.button_Restore.TabIndex = 2;
          this.button_Restore.Text = "Restore";
          this.button_Restore.UseVisualStyleBackColor = true;
          this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
          // 
          // button_Minimize
          // 
          this.button_Minimize.Location = new System.Drawing.Point(33, 51);
          this.button_Minimize.Name = "button_Minimize";
          this.button_Minimize.Size = new System.Drawing.Size(111, 28);
          this.button_Minimize.TabIndex = 1;
          this.button_Minimize.Text = "Minimize";
          this.button_Minimize.UseVisualStyleBackColor = true;
          this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
          // 
          // button_WidgetUID
          // 
          this.button_WidgetUID.Location = new System.Drawing.Point(33, 16);
          this.button_WidgetUID.Name = "button_WidgetUID";
          this.button_WidgetUID.Size = new System.Drawing.Size(111, 29);
          this.button_WidgetUID.TabIndex = 0;
          this.button_WidgetUID.Text = "get_WidgetUID";
          this.button_WidgetUID.UseVisualStyleBackColor = true;
          this.button_WidgetUID.Click += new System.EventHandler(this.button_WidgetUID_Click);
          // 
          // button_Application
          // 
          this.button_Application.BackColor = System.Drawing.Color.NavajoWhite;
          this.button_Application.Location = new System.Drawing.Point(12, 318);
          this.button_Application.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
          this.button_Application.Name = "button_Application";
          this.button_Application.Size = new System.Drawing.Size(384, 38);
          this.button_Application.TabIndex = 1;
          this.button_Application.Text = "Re_Set Application";
          this.button_Application.UseVisualStyleBackColor = false;
          this.button_Application.Click += new System.EventHandler(this.button_Application_Click);
          // 
          // button_Refresh
          // 
          this.button_Refresh.Location = new System.Drawing.Point(266, 210);
          this.button_Refresh.Name = "button_Refresh";
          this.button_Refresh.Size = new System.Drawing.Size(92, 35);
          this.button_Refresh.TabIndex = 7;
          this.button_Refresh.Text = "Refresh";
          this.button_Refresh.UseVisualStyleBackColor = true;
          this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
          // 
          // button_Save
          // 
          this.button_Save.Location = new System.Drawing.Point(21, 154);
          this.button_Save.Name = "button_Save";
          this.button_Save.Size = new System.Drawing.Size(142, 35);
          this.button_Save.TabIndex = 11;
          this.button_Save.Text = "Save";
          this.button_Save.UseVisualStyleBackColor = true;
          this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
          // 
          // FormPWCSDK
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(409, 367);
          this.Controls.Add(this.button_Application);
          this.Controls.Add(this.tabControl_SDK);
          this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.Margin = new System.Windows.Forms.Padding(4);
          this.Name = "FormPWCSDK";
          this.Text = "PWC_SDK";
          this.Load += new System.EventHandler(this.FormPWCSDK_Load);
          this.tabControl_SDK.ResumeLayout(false);
          this.tabPage_Cockpits.ResumeLayout(false);
          this.tabPage_Cockpits.PerformLayout();
          this.tabPage_Cockpit.ResumeLayout(false);
          this.tabPage_Cockpit.PerformLayout();
          this.tabPage_Widgets.ResumeLayout(false);
          this.tabPage_Widget.ResumeLayout(false);
          this.tabPage_Widget.PerformLayout();
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_SDK;
        private System.Windows.Forms.TabPage tabPage_Cockpits;
        private System.Windows.Forms.TabPage tabPage_Cockpit;
        private System.Windows.Forms.TabPage tabPage_Widgets;
        private System.Windows.Forms.TabPage tabPage_Widget;
        private System.Windows.Forms.Button button_Application;
        private System.Windows.Forms.Button button_Cockpits;
        private System.Windows.Forms.Button button_RegWidget;
        private System.Windows.Forms.Button button_GetWidget;
        private System.Windows.Forms.Button button_CreateInstance;
        private System.Windows.Forms.Button button_MoveWidget;
        private System.Windows.Forms.Button button_GetWidgets;
        private System.Windows.Forms.Button button_CockpitTypeID;
        private System.Windows.Forms.Button button_SwitchCockpit;
        private System.Windows.Forms.Button button_CurrentCockpit;
        private System.Windows.Forms.Button button_Widgets;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_WidgetUID;
        private System.Windows.Forms.TextBox textBox_CurrentCockpit;
        private System.Windows.Forms.TextBox textBox_CockpitNumber;
        private System.Windows.Forms.Label label_Row;
        private System.Windows.Forms.TextBox textBox_Column;
        private System.Windows.Forms.TextBox textBox_Row;
        private System.Windows.Forms.TextBox textBox_WidgetNumber;
        private System.Windows.Forms.Label label_Column;
        private System.Windows.Forms.TextBox textBox_CockpitTypeID;
        private System.Windows.Forms.Label label_Value;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_WidgetUID;
        private System.Windows.Forms.Button button_SetValue;
        private System.Windows.Forms.Button button_GetValue;
        private System.Windows.Forms.ComboBox comboBox_WidgetTypeID;
      private System.Windows.Forms.Button button_Refresh;
      private System.Windows.Forms.Button button_Save;
    }
}

