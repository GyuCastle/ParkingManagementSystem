﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace dbex4_2139
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST =localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            string commstr = "select * from emp";
            Console.WriteLine("1. Connenction 생성과 Open");
            OracleConnection conn = new OracleConnection(conStr);
            conn.Open();
            Console.WriteLine("2. OracleDataAdapter 생성");
            OracleDataAdapter DBAdapter = new OracleDataAdapter(commstr, conn);
            // OracleDataAdapter DBAdapter = new OracleDataAdapter(commstr, conStr); //가능
            Console.WriteLine("3. CommandBuilder 생성");
            OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
            Console.WriteLine("4. DataSet 생성");
            DataSet ds = new DataSet();
            Console.WriteLine("5. Adapter를 통해서 DataSet 채우기");
            DBAdapter.Fill(ds);
            Console.WriteLine("6. Connection 닫기");
            conn.Close();
        }
    }
}
