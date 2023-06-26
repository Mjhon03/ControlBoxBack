
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ControlBoxWCF.Models
{
    public class BaseData
    {
        public SqlConnection connection = new SqlConnection("data source = DESKTOP-DNU6QDA\\SQLEXPRESS; initial catalog = dbcontrolbox; user id = root ; password = 1108");
    }
    


}