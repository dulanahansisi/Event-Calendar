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
    public partial class EventFilterUC : UserControl
    {
        public EventFilterUC()
        {
            InitializeComponent();
        }

        public DateTime FromDate
        {
            get
            {
                return this.dateTimePickerFrom.Value;
            }
        }
        public DateTime ToDate
        {
            get
            {
                return this.dateTimePickerTo.Value;
            }
        }
    }
}
