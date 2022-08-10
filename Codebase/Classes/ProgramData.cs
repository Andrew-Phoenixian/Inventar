using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar_2._0.Classes
{
    public static class ProgramData
    {
        // SETTINGS SECTION //
        public static bool RememberMe = false;
        public static bool AutoLogin = false;
        public static String SELECTED_PRINTER = new PrinterSettings().PrinterName;

        // USERDATA //
        public static String Username = "";
        public static String Password = "";
        public static String FullName = "";
        public static String LocationName = "";
        public static String ApiKey = "";
    }
}
