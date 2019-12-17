using Enterprice_Application_Development.Modal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprice_Application_Development.View
{
    public partial class InitialView : Form
    {
        public static int rowId = 0;
        public InitialView()
        {
            InitializeComponent();
            try
            {
                this.eventCalendarDS.ReadXml("data.dat");
                Load += new EventHandler(AppLoad);
            }
            catch (Exception)
            {

            }      
        }

        private void AppLoad(object sender, System.EventArgs e)
        {
            this.dgvEventCalendar.Columns[2].DefaultCellStyle.Format = "D4";
            this.dgvEventCalendar.Columns[3].DefaultCellStyle.Format = "D4";
            this.Icon = Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Calendar;
            highlightCalendar();

        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            for(int ix = this.Controls.Count - 1; ix >= 0; ix--)
                {
                if (this.Controls[ix].Name.Contains("nRow") || this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect") || this.Controls[ix].Name.Contains("Filter"))
                {
                    this.Controls[ix].Dispose();
                }
            }

            //this shows user control AddEventRowCount
                AddEventRowCount myrow = new AddEventRowCount();
                myrow.Name = "nRow";
                myrow.Location = new Point(1093, 143);
                myrow.btnGenerateAddRows.Click += btnGenerateAddEventRows;
                this.Controls.Add(myrow);
        }
        private void btnGenerateAddEventRows(object sender, EventArgs e)
        {
            try
            {
                //this shows user control AddEventUCRow
                if (sender is Button)
                {
                    Button temp = (Button)sender;
                    AddEventRowCount m = (AddEventRowCount)temp.Parent;
                    Int16 numOfAddEventRows = m.rowCount;

                    for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
                    {
                        if (/*this.Controls[ix].Name.Contains("nRow") ||*/ this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect") || this.Controls[ix].Name.Contains("Filter"))
                        {
                            this.Controls[ix].Dispose();
                        }
                    }

                    if (numOfAddEventRows<=5)
                    {
                        for (int i = 0; i < numOfAddEventRows; i++)
                        {
                            AddEventUCRow myrow = new AddEventUCRow();
                            myrow.Name = "line";
                            myrow.Location = new Point(12, 201 + (i * myrow.Size.Height + 1));
                            myrow.btnAddRow.Click += BtnAddEventUC;
                            this.Controls.Add(myrow);
                        }
                    } else
                    {
                        MessageBox.Show("Maximum number of events you can add at a time is 5.");
                    }
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Inputs!");
            }                              
        }
        private void BtnAddEventUC(object sender, EventArgs e)
        {
            if (sender is Button)             
            {
                EventCalendarDS.CalendarRow row = this.eventCalendarDS.Calendar.NewCalendarRow();
                Button temp = (Button)sender;
                AddEventUCRow nEvent = (AddEventUCRow)temp.Parent;


                try
                {
                    if (!validateEventDate("hifgtbsa",nEvent.DateTime, nEvent.StartTime.ToString(), nEvent.EndTime.ToString()))
                    {
                        if (0 < Convert.ToInt32(nEvent.StartTime) && Convert.ToInt32(nEvent.StartTime) < 2400)
                        {
                            if (0 < Convert.ToInt32(nEvent.EndTime) && Convert.ToInt32(nEvent.EndTime) < 2400)
                            {
                                if (new CalendarModal().validateTime(Convert.ToInt32(nEvent.StartTime), Convert.ToInt32(nEvent.EndTime)))
                                {
                                    row.StartTime = nEvent.StartTime;
                                    row.EventName = nEvent.EventName;
                                    row.EndTime = nEvent.EndTime;
                                    row.Date = nEvent.DateTime;
                                    row.Contact = nEvent.Contact;
                                    row.LocationData = nEvent.EventLocation;
                                    row.Recurrency = nEvent.Reccurency;
                                    row.EventType = nEvent.EventType;
                                    this.eventCalendarDS.Calendar.AddCalendarRow(row);
                                    this.eventCalendarDS.Calendar.AcceptChanges();
                                    this.eventCalendarDS.WriteXml("data.dat");
                                    this.Controls.Remove(nEvent);
                                    this.calendar.AddBoldedDate(row.Date);
                                    this.calendar.UpdateBoldedDates();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid time bound.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid time bound.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have an existing event.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Inputs!");
                }                
            }
        }
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                EventCalendarDS.CalendarRow row = this.eventCalendarDS.Calendar.FindByEventID(Convert.ToInt16(this.dgvEventCalendar["EventIdColumn", rowId].Value.ToString()));
                Button temp = (Button)sender;
                SelectCellUC myrow = (SelectCellUC)temp.Parent;

                try
                {
                    if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (new CalendarModal().validateTime(Convert.ToInt32(myrow.txtBXEDStartTime.Text), Convert.ToInt32(myrow.txtBXEDEndTime.Text)))
                        {

                            if (!validateEventDate(myrow.txtBXEDEventName.Text,myrow.eDEventNamedateTimePicker.Value, myrow.txtBXEDStartTime.Text.ToString(), myrow.txtBXEDEndTime.Text.ToString()))
                            {
                                row.EventName = myrow.txtBXEDEventName.Text;
                                row.Date = myrow.eDEventNamedateTimePicker.Value;
                                row.StartTime = Convert.ToInt16(myrow.txtBXEDStartTime.Text);
                                row.EndTime = Convert.ToInt16(myrow.txtBXEDEndTime.Text);
                                row.Contact = myrow.txtBXEDContact.Text;
                                row.LocationData = myrow.txtBXEDLocation.Text;
                                row.Recurrency = myrow.cmbBXEDRecurrency.Text;
                                row.EventType = myrow.cmbBXEDEventType.Text;
                                this.eventCalendarDS.Calendar.AcceptChanges();
                                this.eventCalendarDS.WriteXml("data.dat");
                                //this.calendar.AddBoldedDate(row.Date);
                                //this.calendar.UpdateBoldedDates();
                                highlightCalendar();
                            }
                            else
                            {
                                MessageBox.Show("You already have an event");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid time.");
                        }
                    }                                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Inputs!");
                }
                              
            }
        }
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sender is Button)
                {
                    EventCalendarDS.CalendarRow row = this.eventCalendarDS.Calendar.FindByEventID(Convert.ToInt16(this.dgvEventCalendar["EventIdColumn", rowId].Value.ToString()));
                    this.eventCalendarDS.Calendar.RemoveCalendarRow(row);
                    this.eventCalendarDS.Calendar.AcceptChanges();
                    Button temp = (Button)sender;
                    SelectCellUC myrow = (SelectCellUC)temp.Parent;
                    this.Controls.Remove(myrow);
                    this.eventCalendarDS.WriteXml("data.dat");
                    highlightCalendar();
                }
            }             
        }
        private void dgvCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
                {
                    if (this.Controls[ix].Name.Contains("nRow") || this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect") || this.Controls[ix].Name.Contains("Filter"))
                    {
                        this.Controls[ix].Dispose();
                    }
                }

                SelectCellUC myrow = new SelectCellUC();
                myrow.Name = "cellSelect";
                myrow.Location = new Point(12, 201);
                myrow.btnEdit.Click += btnEditEvent_Click;
                myrow.btnDelete.Click += btnDeleteEvent_Click;
                this.Controls.Add(myrow);


                rowId = dgvEventCalendar.CurrentCell.RowIndex;
                EventCalendarDS.CalendarRow row = this.eventCalendarDS.Calendar.FindByEventID(Convert.ToInt16(this.dgvEventCalendar["EventIDColumn", e.RowIndex].Value.ToString()));

                myrow.txtBXEDEventName.Text = row.EventName;
                myrow.eDEventNamedateTimePicker.Value = row.Date;
                myrow.txtBXEDStartTime.Text = row.StartTime.ToString("D4");
                myrow.txtBXEDEndTime.Text = row.EndTime.ToString("D4");
                myrow.txtBXEDContact.Text = row.Contact;
                myrow.txtBXEDLocation.Text = row.LocationData;
                myrow.cmbBXEDRecurrency.Text = row.Recurrency;
                myrow.cmbBXEDEventType.Text = row.EventType;
            }
            catch (Exception)
            {

                for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
                {
                    if (this.Controls[ix].Name.Contains("nRow") || this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect") || this.Controls[ix].Name.Contains("Filter"))
                    {
                        this.Controls[ix].Dispose();
                    }
                }
                MessageBox.Show("Empty row");
            }

        }
        private void btnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }       
        private async void btnClickGenerateReport(object sender, EventArgs e)
        {
            Console.WriteLine("Start");
            var time = await Task.Run(()=>this.forecastTime());
            Console.WriteLine("End");
        }
        public int forecastTime()
        {

            CalendarModal calendarModal = new CalendarModal();

            StreamWriter sw;
            try
            {
                sw = new StreamWriter("Generated Report.dat", false, Encoding.UTF8);
                sw.WriteLine("Today is: " + DateTime.Now+"\n");
                sw.WriteLine("Your upcoming Events are: \n");
            }
            catch (Exception)
            {
                throw;
            }


            Int16 pastEventCount = 0;
            double pastDuration = 0;
            Int16 futureEvents = 0;
            double futureTimeDuration = 0;
            Double predictedDuration = 0.0;


            for (int i =0;i<dgvEventCalendar.RowCount-1;i++)
            {
                String cellValueDate = this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString();
                String cellValueStartTime = this.dgvEventCalendar.Rows[i].Cells[2].Value.ToString();
                String cellValueEndTime = this.dgvEventCalendar.Rows[i].Cells[3].Value.ToString();

                DateTime dateTime = Convert.ToDateTime(cellValueDate);
                DateTime date = dateTime.Date;
                int year = date.Year;
                int month = date.Month;
                int day = date.Day;

                int hourOfEvent = calendarModal.calculateHours(Int16.Parse(cellValueStartTime));
                int startHourTimeInMinutes = hourOfEvent * 60;
                int startMinuteimeInMinutes = calendarModal.calculateMinutes(Int16.Parse(cellValueStartTime)) ;
                double startTimeMinutes = startHourTimeInMinutes+ startMinuteimeInMinutes;

                int endHourTimeInMinutes = calendarModal.calculateHours(Int16.Parse(cellValueEndTime)) * 60;
                int endMinuteimeInMinutes = calendarModal.calculateMinutes(Int16.Parse(cellValueEndTime));
                double endTimeMinutes = endHourTimeInMinutes + endMinuteimeInMinutes;

                double eventTimeDuration = endTimeMinutes - startTimeMinutes;

                if (calendarModal.compareDate(date, hourOfEvent, startMinuteimeInMinutes))
                {
                    futureTimeDuration += eventTimeDuration;
                    futureEvents++;

                   
                    sw.WriteLine("Event Name: "+ this.dgvEventCalendar.Rows[i].Cells[0].Value.ToString()+".");
                    sw.WriteLine("Event Date: " + this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString() + ".");

                    int sTime = Convert.ToInt32(this.dgvEventCalendar.Rows[i].Cells[2].Value);
                    int eTime = Convert.ToInt32(this.dgvEventCalendar.Rows[i].Cells[3].Value);

                    sw.WriteLine("Event starts at: " + sTime.ToString("D4")+"h.");
                    sw.WriteLine("Event ends at: " + eTime.ToString("D4") + "h.");
                    sw.WriteLine("Event Contact detail: " + this.dgvEventCalendar.Rows[i].Cells[4].Value.ToString() + ".");
                    sw.WriteLine("Event is in: " + this.dgvEventCalendar.Rows[i].Cells[5].Value.ToString() + ".") ;
                    sw.WriteLine("Is event recurring ?: " + this.dgvEventCalendar.Rows[i].Cells[6].Value.ToString() + ".");
                    sw.WriteLine("Event is: " + this.dgvEventCalendar.Rows[i].Cells[7].Value.ToString() + ".");
                    sw.WriteLine("\n");
                }
                else
                {
                    pastEventCount++;
                    pastDuration += eventTimeDuration;
                }
            }

            double averageTimeDuration = pastDuration / pastEventCount;
            predictedDuration = averageTimeDuration * futureEvents;

            sw.WriteLine("You have participated in: " + pastEventCount + " events.");
            sw.WriteLine("You have spent: " + pastDuration/60.0 + " hours on events.");
            sw.WriteLine("You have spent: " + averageTimeDuration / 60.0 + " hours per event in average.");
            sw.WriteLine("You have to allocate average of " + predictedDuration / 60.0 + " hours for the events in future approximately (depending on past event average).");
            sw.WriteLine("You have to allocate " + futureTimeDuration/60.0 + " hours for the events in future (depending on upcoming event durations).");

            sw.Close();
            MessageBox.Show("Report successfully generated.");
            return 1;
        }
        public bool validateEventDate(String eventName, DateTime dateTime, String startTime, String endTime)
        {
            bool isOverlap = false;

            int numberStartTime = Convert.ToInt16(startTime);
            int numberEndTime = Convert.ToInt16(endTime);


            for (int i = 0; i < dgvEventCalendar.RowCount - 1; i++)
            {
                String evntName = eventName;
                String cellValueDate = this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString();
                String cellValueStartTime = this.dgvEventCalendar.Rows[i].Cells[2].Value.ToString();
                String cellValueEndTime = this.dgvEventCalendar.Rows[i].Cells[3].Value.ToString();

                int numbercellValueStartTime = Convert.ToInt16(cellValueStartTime);
                int numbercellValueEndTime = Convert.ToInt16(cellValueEndTime);

                DateTime dT = Convert.ToDateTime(cellValueDate);
                DateTime date = dT.Date;
                int year = date.Year;
                int month = date.Month;
                int day = date.Day;

                if (year == dateTime.Year && month == dateTime.Month && day == dateTime.Day && ((numbercellValueStartTime<=numberStartTime)&&(numberStartTime < numbercellValueEndTime)))
                {               
                    if (eventName.Contains(evntName))
                    {
                        isOverlap = false;
                    }
                    else
                    {
                        isOverlap = true;
                        break;
                    }

                }
                else
                {
                    isOverlap = false;
                }
            }
                return isOverlap;       
        }
        public void highlightCalendar()
        {
            this.calendar.RemoveAllBoldedDates();
            for (int i = 0; i < dgvEventCalendar.RowCount - 1; i++)
            {
                String cellValueDate = this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString();              
                DateTime dateTime = Convert.ToDateTime(cellValueDate);
                DateTime date = dateTime.Date;

                this.calendar.AddBoldedDate(date);
            }
            this.calendar.UpdateBoldedDates();
        
        }
        private void onSelectedDateChanged(object sender, DateRangeEventArgs e)
        {

            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix].Name.Contains("nRow") || this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect") || this.Controls[ix].Name.Contains("Filter"))
                {
                    this.Controls[ix].Dispose();
                }
            }

            DateTime dateTimeSelected = Convert.ToDateTime(this.calendar.SelectionRange.Start.ToShortDateString());
            DateTime dateSelected = dateTimeSelected.Date;
            String messageText = "";


            try
            {
                for (int i = 0; i < dgvEventCalendar.RowCount - 1; i++)
                {
                    String cellValueDate = this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString();
                    String cellValueStartTime = this.dgvEventCalendar.Rows[i].Cells[2].Value.ToString();
                    String cellValueEndTime = this.dgvEventCalendar.Rows[i].Cells[3].Value.ToString();

                    DateTime dateTime = Convert.ToDateTime(cellValueDate);
                    DateTime date = dateTime.Date;
                    int year = date.Year;
                    int month = date.Month;
                    int day = date.Day;

                    if (dateSelected.Equals(date))
                    {
                        int startT = Convert.ToInt32(this.dgvEventCalendar.Rows[i].Cells[2].Value);
                        messageText += " You have an event titled " + this.dgvEventCalendar.Rows[i].Cells[0].Value.ToString() + " at " + startT.ToString("D4") + " h. \n ";
                    }
                }

                if (!messageText.Equals(""))
                {
                    MessageBox.Show(messageText);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
            finally
            { 
            
            }

        }

        private void onClick_FileEvents(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix].Name.Contains("nRow") || this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect"))
                {
                    this.Controls[ix].Dispose();
                }
            }

            //this shows user control AddEventRowCount
            EventFilterUC myrow = new EventFilterUC();
            myrow.Name = "Filter";
            myrow.Location = new Point(12, 196);
            myrow.FilterButton.Click += onClick_FileButton;
            this.Controls.Add(myrow);
        }

        private async void onClick_FileButton(object sender, EventArgs e)
        {
            Console.WriteLine("Start");
            Button temp = (Button)sender;
            EventFilterUC m = (EventFilterUC)temp.Parent;

            DateTime timeFrom = m.FromDate;
            DateTime timeTo = m.ToDate;

            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix].Name.Contains("nRow") || this.Controls[ix].Name.Contains("line") || this.Controls[ix].Name.Contains("cellSelect")|| this.Controls[ix].Name.Contains("Filter"))
                {
                    this.Controls[ix].Dispose();
                }
            }           
            var filtered = await Task.Run(() => this.filterEventsByTime(timeFrom, timeTo));
            Console.WriteLine("End");
        }

        public int filterEventsByTime(DateTime timeFrom, DateTime timeTo)
        {
            CalendarModal calendarModal = new CalendarModal();

            StreamWriter sw;
            try
            {
                sw = new StreamWriter("Filtered Events.dat", false, Encoding.UTF8);
                sw.WriteLine("Today is: " + DateTime.Now + "\n");
                sw.WriteLine("Events from "+timeFrom.Year+"\\"+timeFrom.Month+"\\"+timeFrom.Day+" to "+ timeTo.Year + "\\" + timeTo.Month + "\\" + timeTo.Day+" are as below..."+ "\n");

            }
            catch (Exception)
            {
                throw;
            }

            int filteredEventCount = 0;

            for (int i = 0; i < dgvEventCalendar.RowCount - 1; i++)
                {
                    String cellValueDate = this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString();
                    DateTime dateTime = Convert.ToDateTime(cellValueDate);
                    DateTime date = dateTime.Date;
                    int year = date.Year;
                    int month = date.Month;
                    int day = date.Day;

                if ((timeFrom.Year<=year&& year<=timeTo.Year)&& (timeFrom.Month <= month && month <= timeTo.Month)&&(timeFrom.Day <= day && day <= timeTo.Day))
                {
                    filteredEventCount++;
                    sw.WriteLine("Event Name: " + this.dgvEventCalendar.Rows[i].Cells[0].Value.ToString() + ".");
                    sw.WriteLine("Event Date: " + this.dgvEventCalendar.Rows[i].Cells[1].Value.ToString() + ".");

                    int sTime = Convert.ToInt32(this.dgvEventCalendar.Rows[i].Cells[2].Value);
                    int eTime = Convert.ToInt32(this.dgvEventCalendar.Rows[i].Cells[3].Value);

                    sw.WriteLine("Event starts at: " + sTime.ToString("D4") + "h.");
                    sw.WriteLine("Event ends at: " + eTime.ToString("D4") + "h.");
                    sw.WriteLine("Event Contact detail: " + this.dgvEventCalendar.Rows[i].Cells[4].Value.ToString() + ".");
                    sw.WriteLine("Event is in: " + this.dgvEventCalendar.Rows[i].Cells[5].Value.ToString() + ".");
                    sw.WriteLine("Is event recurring ?: " + this.dgvEventCalendar.Rows[i].Cells[6].Value.ToString() + ".");
                    sw.WriteLine("Event is: " + this.dgvEventCalendar.Rows[i].Cells[7].Value.ToString() + ".");
                    sw.WriteLine("\n");
                }
            }

            sw.WriteLine("Total events between start time and end time are: " + filteredEventCount);
            sw.Close();
            
            MessageBox.Show("Report successfully generated.");
            return 0;
        }

        
    }
}
