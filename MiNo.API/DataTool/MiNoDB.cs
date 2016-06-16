using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiNo.API
{
    public static class MiNoDB
    {
        public static DataSet GetData(string strSql)
        {
            return SqlHelper.ExecuteDataset(SqlHelper.GetConnection(), CommandType.Text, strSql);
        }
        public static DataSet ChangeData(string strSql)
        {
            return SqlHelper.ExecuteDataset(SqlHelper.GetConnection(), CommandType.Text, strSql);
        }
    }
}