using MyApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
docker run -d --name sql-server-2019-c2009l -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Abc123456789" -p 1435:1433 mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
 
 */
namespace MyApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new StudentList());
        }
    }
}
