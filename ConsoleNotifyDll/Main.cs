using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsoleNotify {
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("01A31113-9353-44cc-A1F4-C6F1210E4B30")]  //Allocate your own GUID
    public interface _Notify {
        string HelloWorld { get; }
        int showNotify { get; }
    }

    [ClassInterface(ClassInterfaceType.None)]
    [Guid("E2F07CD4-CE73-4102-B35D-119362624C47")]  //Allocate your own GUID
    [ProgId("TestDll.Test")]
    public class Notify : _Notify {
        String title { get; set; }
        String message { get; set; }
        public string HelloWorld { 
            get { 
                return "Hello, World! "; 
            } 
        }
        public int showNotify {
            get {
                return this.show();
            }
        }

        private int show() {
            NotifyIcon notify = new NotifyIcon();
            notify.ShowBalloonTip(10, "teste", "teste", ToolTipIcon.Info);
            return 1;
        }
    }
}
 
