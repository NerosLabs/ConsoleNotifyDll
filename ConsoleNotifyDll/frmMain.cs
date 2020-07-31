using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleNotifyDll {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();

            Notify.Visible = true;
            Notify.BalloonTipTitle = "teste";
            Notify.BalloonTipText = "descrição";
            Notify.BalloonTipIcon = ToolTipIcon.Info;
            Notify.ShowBalloonTip(5000);

        }

    }
}
