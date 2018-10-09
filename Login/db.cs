using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class db {
    public db() {
    }
    public static SqlConnection CreateConnection() {
        SqlConnection con = new SqlConnection("server=localhost\\SQL2008;database=userinfo;uid=sa;pwd=123456;");
        return con;

    }
}
