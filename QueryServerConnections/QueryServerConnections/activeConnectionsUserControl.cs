using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryServerConnections
{
    
    public partial class activeConnectionUserControl : UserControl
    {
        public activeConnectionUserControl()
        {
            InitializeComponent();
        }

        public activeConnectionUserControl(string labelText)
        {
            InitializeComponent();
            this.activeConnectionLabel.Text = labelText;
        }
    }
}
