using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprice_Application_Development
{
    public partial class AddEventUCRow : UserControl
    {
        public AddEventUCRow()
        {
            InitializeComponent();
        }

        public String EventName
        {
            get
            {
                return this.txtBxEventName.Text;
            }
        }

        public Int16 StartTime
        {
            get
            {
                return Convert.ToInt16(this.txtBxStartTime.Text);
            }
        }

        public Int16 EndTime
        {
            get
            {
                return Convert.ToInt16(this.txtBxEndTime.Text);
            }
        }

        public String EventLocation
        {
            get
            {
                return this.txtBxLocation.Text;
            }
        }

        public String Contact
        {
            get
            {
                return this.txtBxContact.Text;
            }
        }

        public System.DateTime DateTime
        {
            get
            {
                return this.dateTimePicker.Value;
            }
        }

        public String Reccurency
        {
            get {
               return this.cmbBoxRecurrency.Text;
            }
        }

        public String EventType
        {
            get
            {
                return this.cmbBoxEventType.Text;
            }
        }

        
    }
}
