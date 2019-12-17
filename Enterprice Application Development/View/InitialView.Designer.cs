namespace Enterprice_Application_Development.View
{
    partial class InitialView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialView));
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvEventCalendar = new System.Windows.Forms.DataGridView();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventCalendarDS = new Enterprice_Application_Development.EventCalendarDS();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eventCalendarDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.CloseButton = new System.Windows.Forms.ToolTip(this.components);
            this.GenerateReportButton = new System.Windows.Forms.ToolTip(this.components);
            this.AddEventButton = new System.Windows.Forms.ToolTip(this.components);
            this.calendarWidget = new System.Windows.Forms.ToolTip(this.components);
            this.DataGrid = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEvent.Location = new System.Drawing.Point(1092, 28);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(289, 23);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.AddEventButton.SetToolTip(this.btnAddEvent, "Add new events");
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(1092, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 22);
            this.button4.TabIndex = 4;
            this.button4.Text = "Close";
            this.CloseButton.SetToolTip(this.button4, "Close Calendar");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnClose);
            // 
            // dgvEventCalendar
            // 
            this.dgvEventCalendar.AllowUserToOrderColumns = true;
            this.dgvEventCalendar.AutoGenerateColumns = false;
            this.dgvEventCalendar.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvEventCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.locationDataDataGridViewTextBoxColumn,
            this.recurrencyDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.EventIDColumn});
            this.dgvEventCalendar.DataSource = this.calendarBindingSource;
            this.dgvEventCalendar.Location = new System.Drawing.Point(252, 28);
            this.dgvEventCalendar.Name = "dgvEventCalendar";
            this.dgvEventCalendar.Size = new System.Drawing.Size(834, 162);
            this.dgvEventCalendar.TabIndex = 5;
            this.DataGrid.SetToolTip(this.dgvEventCalendar, "Click on event rows to edit and delete events");
            this.dgvEventCalendar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCellMouseClick);
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // locationDataDataGridViewTextBoxColumn
            // 
            this.locationDataDataGridViewTextBoxColumn.DataPropertyName = "LocationData";
            this.locationDataDataGridViewTextBoxColumn.HeaderText = "LocationData";
            this.locationDataDataGridViewTextBoxColumn.Name = "locationDataDataGridViewTextBoxColumn";
            // 
            // recurrencyDataGridViewTextBoxColumn
            // 
            this.recurrencyDataGridViewTextBoxColumn.DataPropertyName = "Recurrency";
            this.recurrencyDataGridViewTextBoxColumn.HeaderText = "Recurrency";
            this.recurrencyDataGridViewTextBoxColumn.Name = "recurrencyDataGridViewTextBoxColumn";
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            // 
            // EventIDColumn
            // 
            this.EventIDColumn.DataPropertyName = "EventID";
            this.EventIDColumn.HeaderText = "EventID";
            this.EventIDColumn.Name = "EventIDColumn";
            this.EventIDColumn.Visible = false;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "Calendar";
            this.calendarBindingSource.DataSource = this.eventCalendarDS;
            // 
            // eventCalendarDS
            // 
            this.eventCalendarDS.DataSetName = "EventCalendarDS";
            this.eventCalendarDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(1092, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(289, 22);
            this.button5.TabIndex = 6;
            this.button5.Text = "Generate Report";
            this.GenerateReportButton.SetToolTip(this.button5, "Write a file showing event details.");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnClickGenerateReport);
            // 
            // eventCalendarDSBindingSource
            // 
            this.eventCalendarDSBindingSource.DataSource = this.eventCalendarDS;
            this.eventCalendarDSBindingSource.Position = 0;
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Teal;
            this.calendar.Location = new System.Drawing.Point(13, 27);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 7;
            this.calendar.TitleBackColor = System.Drawing.Color.Teal;
            this.calendarWidget.SetToolTip(this.calendar, "Month calendar view");
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.onSelectedDateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1092, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter Events";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onClick_FileEvents);
            // 
            // InitialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1393, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvEventCalendar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitialView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dula\'s Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCalendarDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvEventCalendar;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private EventCalendarDS eventCalendarDS;
        //private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventCalendarDSBindingSource;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventIDColumn;
        private System.Windows.Forms.ToolTip CloseButton;
        private System.Windows.Forms.ToolTip GenerateReportButton;
        private System.Windows.Forms.ToolTip AddEventButton;
        private System.Windows.Forms.ToolTip DataGrid;
        private System.Windows.Forms.ToolTip calendarWidget;
        private System.Windows.Forms.Button button1;
    }
}