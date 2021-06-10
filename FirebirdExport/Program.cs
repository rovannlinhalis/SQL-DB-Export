using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSQLExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public enum BancosDeDados
    {
        FireBird = 3050,
        SQLServer = 1433,
        PostgreSQL = 5432,
        MySQL = 3306,
        //ArquivoCSV = 0,
        ODBC = 1
    }
}
