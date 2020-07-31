using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using NerosNotify;
using System.Reflection;

namespace ConsoleNotify {
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("01A31113-9353-44cc-A1F4-C6F1210E4B30")]  
    public interface _Notify {
        void showNotify(string NotifyTitle,string NotifyMessage) ; 
    }

    [ClassInterface(ClassInterfaceType.None)]
    [Guid("E2F07CD4-CE73-4102-B35D-119362624C47")]  
    [ProgId("NerosNotify")]
    public class Notify : _Notify {
        public void showNotify(string title, string message) {
            frmMain frm = new frmMain((String)title,(String)message );
            frm.Dispose();
        }
    }
}

