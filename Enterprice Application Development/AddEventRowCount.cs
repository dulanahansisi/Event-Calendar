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
    public partial class AddEventRowCount : UserControl
    {
        public AddEventRowCount()
        {
            InitializeComponent();
        }

        public Int16 rowCount
        {
            get
            {
                return Convert.ToInt16(this.txtBoxAddEventRowCount.Text);
            }
        }
    }
}
