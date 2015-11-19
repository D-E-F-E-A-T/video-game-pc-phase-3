using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

// http://blogs.u2u.be/diederik/post/2015/09/08/Using-SQLite-on-the-Universal-Windows-Platform.aspx
// http://blog.chrisbriggsy.com/Using-SQLITE-in-Windows-10-IoT-Core-Insider-Preview/
namespace LocalData
{
    public sealed class LocalData
    {
        private SQLite.Net.SQLiteConnection conn;

        public LocalData()
        {

        }
    }
}
