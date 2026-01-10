using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SQLComponent
{
    public string connection = "localhost";
    public string username = "root";
    public string password = "";
    public string database = "db_library";

    public string connectToSQL()
    {
        string sqlconnection = $"server={connection};uid={username};password={password};database={database}";
        return sqlconnection;
    }
}
