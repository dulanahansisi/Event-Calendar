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
    public partial class SelectCellUC : UserControl
    {
        public SelectCellUC()
        {
            InitializeComponent();
        }

        public String EventName
        {
            set { }
            get
            {
                return this.txtBXEDEventName.Text;
            }
        }

        public Int16 StartTime
        {
            set { }
            get
            {
                return Convert.ToInt16(this.txtBXEDStartTime.Text);
            }
        }

        public Int16 EndTime
        {
            set { }
            get
            {
                return Convert.ToInt16(this.txtBXEDEndTime.Text);
            }
        }

        public String EventLocation
        {
            set { }
            get
            {
                return this.txtBXEDLocation.Text;
            }
        }

        public String Contact
        {
            set { }
            get
            {
                return this.txtBXEDContact.Text;
            }
        }

        public System.DateTime DateTime
        {
            set { }
            get
            {
                return this.eDEventNamedateTimePicker.Value;
            }
        }

        public String Reccurency
        {
            set { }
            get
            {
                return this.cmbBXEDRecurrency.Text;
            }
        }

        public String EventType
        {
            set { }
            get
            {
                return this.cmbBXEDEventType.Text;
            }
        }
    }
}

