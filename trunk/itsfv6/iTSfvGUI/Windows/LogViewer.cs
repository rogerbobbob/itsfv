using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTSfvGUI
{
    public partial class LogViewer : Form
    {
        public HelpersLib.Logger Logger = new HelpersLib.Logger();

        public LogViewer()
        {
            InitializeComponent();
            Logger.MessageAdded += Logger_MessageAdded;
        }

        void Logger_MessageAdded(string message)
        {
            lbLogs.Items.Add(message);
        }

    }
}
