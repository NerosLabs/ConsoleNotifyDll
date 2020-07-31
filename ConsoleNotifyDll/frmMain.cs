using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NerosNotify {
    public partial class frmMain : Form {
        public frmMain(String title, String message) {
            InitializeComponent();

            Notify.Visible = true;
            Notify.BalloonTipTitle = title;
            Notify.BalloonTipText = message;
            Notify.BalloonTipIcon = ToolTipIcon.Info;
            Notify.ShowBalloonTip(5000);

        }

    }
}
