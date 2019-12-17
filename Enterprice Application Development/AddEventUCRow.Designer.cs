namespace Enterprice_Application_Development
{
    partial class AddEventUCRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxEventName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxStartTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxEndTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxRecurrency = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBoxEventType = new System.Windows.Forms.ComboBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.toolTipEventName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStartTime = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEndTime = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipContact = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLocation = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRepeat = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEventType = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddRow = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date :";
            // 
            // txtBxEventName
            // 
            this.txtBxEventName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxEventName.Location = new System.Drawing.Point(81, 10);
            this.txtBxEventName.Name = "txtBxEventName";
            this.txtBxEventName.Size = new System.Drawing.Size(79, 20);
            this.txtBxEventName.TabIndex = 20;
            this.toolTipEventName.SetToolTip(this.txtBxEventName, "Insert event name");
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(208, 10);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.TabStop = false;
            this.toolTipDate.SetToolTip(this.dateTimePicker, "Pick date");
            this.dateTimePicker.Value = new System.DateTime(2019, 11, 19, 18, 38, 44, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Time :";
            // 
            // txtBxStartTime
            // 
            this.txtBxStartTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxStartTime.Location = new System.Drawing.Point(481, 10);
            this.txtBxStartTime.Name = "txtBxStartTime";
            this.txtBxStartTime.Size = new System.Drawing.Size(79, 20);
            this.txtBxStartTime.TabIndex = 23;
            this.toolTipStartTime.SetToolTip(this.txtBxStartTime, "Insert event starting time in 24 Hour format");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "End Time :";
            // 
            // txtBxEndTime
            // 
            this.txtBxEndTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxEndTime.Location = new System.Drawing.Point(630, 10);
            this.txtBxEndTime.Name = "txtBxEndTime";
            this.txtBxEndTime.Size = new System.Drawing.Size(79, 20);
            this.txtBxEndTime.TabIndex = 25;
            this.toolTipEndTime.SetToolTip(this.txtBxEndTime, "Start event end time in 24 Hour format");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contact :";
            // 
            // txtBxContact
            // 
            this.txtBxContact.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxContact.Location = new System.Drawing.Point(771, 10);
            this.txtBxContact.Name = "txtBxContact";
            this.txtBxContact.Size = new System.Drawing.Size(79, 20);
            this.txtBxContact.TabIndex = 27;
            this.toolTipContact.SetToolTip(this.txtBxContact, "Insert contact details");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Location :";
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBxLocation.Location = new System.Drawing.Point(916, 10);
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(79, 20);
            this.txtBxLocation.TabIndex = 29;
            this.toolTipLocation.SetToolTip(this.txtBxLocation, "Insert location data");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1001, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Repeating :";
            // 
            // cmbBoxRecurrency
            // 
            this.cmbBoxRecurrency.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbBoxRecurrency.FormattingEnabled = true;
            this.cmbBoxRecurrency.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbBoxRecurrency.Location = new System.Drawing.Point(1060, 10);
            this.cmbBoxRecurrency.Name = "cmbBoxRecurrency";
            this.cmbBoxRecurrency.Size = new System.Drawing.Size(75, 21);
            this.cmbBoxRecurrency.TabIndex = 31;
            this.cmbBoxRecurrency.SelectedIndex = 0;
            this.toolTipRepeat.SetToolTip(this.cmbBoxRecurrency, "Is event repeating?");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1141, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Event type :";
            // 
            // cmbBoxEventType
            // 
            this.cmbBoxEventType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbBoxEventType.FormattingEnabled = true;
            this.cmbBoxEventType.Items.AddRange(new object[] {
            "Event",
            "Appointment"});
            this.cmbBoxEventType.Location = new System.Drawing.Point(1202, 10);
            this.cmbBoxEventType.Name = "cmbBoxEventType";
            this.cmbBoxEventType.Size = new System.Drawing.Size(81, 21);
            this.cmbBoxEventType.TabIndex = 33;
            this.cmbBoxEventType.SelectedIndex = 0;
            this.toolTipEventType.SetToolTip(this.cmbBoxEventType, "Pick event type.");
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRow.Location = new System.Drawing.Point(1289, 9);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(77, 21);
            this.btnAddRow.TabIndex = 35;
            this.btnAddRow.Text = "Add Event";
            this.toolTipAddRow.SetToolTip(this.btnAddRow, "Add event to the data base.");
            this.btnAddRow.UseVisualStyleBackColor = false;
            // 
            // AddEventUCRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.cmbBoxEventType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBoxRecurrency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxEndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBxEventName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "AddEventUCRow";
            this.Size = new System.Drawing.Size(1378, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxEventName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxEndTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxRecurrency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBoxEventType;
        public System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.ToolTip toolTipEventName;
        private System.Windows.Forms.ToolTip toolTipDate;
        private System.Windows.Forms.ToolTip toolTipStartTime;
        private System.Windows.Forms.ToolTip toolTipEndTime;
        private System.Windows.Forms.ToolTip toolTipContact;
        private System.Windows.Forms.ToolTip toolTipLocation;
        private System.Windows.Forms.ToolTip toolTipRepeat;
        private System.Windows.Forms.ToolTip toolTipEventType;
        private System.Windows.Forms.ToolTip toolTipAddRow;
    }
}
