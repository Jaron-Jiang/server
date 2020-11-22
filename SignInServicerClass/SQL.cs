using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    static class SQL
    {
        private static string sql_ip;
        private static string sql_port;
        private static string sql_user;
        private static string sql_password;
        private static string sql_db;
        private static MySqlConnection conn;

        public static string SqlIp
        {
            get => sql_ip;
            set
            {
                sql_ip = value;
            }
        }

        public static string SqlPort
        {
            get => sql_port;
            set
            {
                sql_port = value;
            }
        }

        public static string SqlUser
        {
            get => sql_user;
            set
            {
                sql_user = value;
            }
        }

        public static string SqlPassword
        {
            get => sql_password;
            set
            {
                sql_password = value;
            }
        }

        public static string SqlDb
        {
            get => sql_db;
            set
            {
                sql_db = value;
            }
        }

        static SQL()
        {
            SqlIp = DefaultConfig.DatabaseAddr;
            SqlPort = DefaultConfig.DatabasePort;
            SqlUser = DefaultConfig.DatabaseUser;
            SqlPassword = DefaultConfig.DatabasePass;
            SqlDb = DefaultConfig.DatabaseName;
            string constr = "server=" + SqlIp + ";port=" + SqlPort + ";user=" + SqlUser + ";password=" + SqlPassword + "; database=" + SqlDb + ";";
            conn = new MySqlConnection(constr);
        }

        /// <summary>
        /// 对键和键值进行拼接
        /// </summary>
        /// <param name="Keys">要拼接的键</param>
        /// <param name="Values">要拼接的键值</param>
        /// <param name="symbol">连接符分别是" and " 和","</param>
        /// <returns></returns>
        public static string Merge(string[] Keys,string[] Values,string symbol)
        {
            string str = "";
            for(int i = 0; i < Keys.Length - 1;i++)
            {
                str += Keys[i] + " = '" + Values[i] + "'" + symbol;
            }
            str += Keys[Keys.Length - 1] + " = '" + Values[Keys.Length - 1] + "'";
            return str;
        }

        /// <summary>
        /// 对键值进行拼接
        /// </summary>
        /// <param name="Values">要拼接的键值</param>
        /// <returns></returns>
        public static string MergeValues(string[] Values)
        {
            string str = "";
            for(int i = 0;i<Values.Length - 1;i++)
            {
                str += "'" + Values[i] + "',";
            }
            str += "'" + Values[Values.Length - 1] + "'";
            return str;
        }

        /// <summary>
        /// 对键进行拼接
        /// </summary>
        /// <param name="Values">要拼接的键</param>
        /// <returns></returns>
        public static string MergeKeys(string[] Values)
        {
            string str = "";
            for(int i = 0;i < Values.Length - 1;i++)
            {
                str += Values[i] + ",";
            }
            str += Values[Values.Length - 1];
            return str;
        }

        /// <summary>
        /// 有条件的查询
        /// </summary>
        /// <param name="values">查询返回的东西</param>
        /// <param name="tableName">查询的表</param>
        /// <param name="conditionKeys">查询条件的键</param>
        /// <param name="conditionValues">查询条件的键值</param>
        /// <returns></returns>
        public static string Select(string[] values,string tableName,string[] conditionKeys,string[] conditionValues)
        {
            string sql = "select " + MergeKeys(values) + " from " + tableName + " where " + Merge(conditionKeys, conditionValues, " and ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            JArray jArray = new JArray();
            MySqlDataReader result = cmd.ExecuteReader();
            while(result.Read())
            {
                JObject jObject = new JObject();
                for(int i = 0;i < values.Length;i++)
                {
                    jObject.Add(values[i], result[i].ToString());
                }
            }
            result.Close();
            return jArray.ToString();
        }

        /// <summary>
        /// 无条件的查询
        /// </summary>
        /// <param name="values">查询返回的东西</param>
        /// <param name="tableName">查询的表</param>
        /// <returns></returns>
        public static string Select(string[] values, string tableName)
        {
            string sql = "select " + MergeKeys(values) + " from " + tableName;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            JArray jArray = new JArray();
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                JObject jObject = new JObject();
                for (int i = 0; i < values.Length; i++)
                {
                    jObject.Add(values[i], result[i].ToString());
                }
            }
            result.Close();
            return jArray.ToString();
        }

        /// <summary>
        /// 有条件的查询表中数据的条数
        /// </summary>
        /// <param name="tableName">查询的表</param>
        /// <param name="conditionKeys">查询条件的键</param>
        /// <param name="conditionValues">查询条件的键值</param>
        /// <returns></returns>
        public static int SelectCount(string tableName, string[] conditionKeys, string[] conditionValues)
        {
            string sql = "select count(*) from " + tableName + " where " + Merge(conditionKeys, conditionValues," and ");
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        /// <summary>
        /// 无条件的查询表中数据的条数
        /// </summary>
        /// <param name="tableName">查询的表</param>
        /// <returns></returns>
        public static int SelectCount(string tableName)
        {
            string sql = "select count(*) from " + tableName;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        /// <summary>
        /// 有条件更新数据库
        /// </summary>
        /// <param name="SetKeys">要更新的键键值的键</param>
        /// <param name="SetValues">要更新的键值</param>
        /// <param name="tableName">要更新的表</param>
        /// <param name="conditionKeys">更新条件的键</param>
        /// <param name="conditionValues">更新条件的键值</param>
        /// <returns></returns>
        public static bool Update(string[] SetKeys,string[] SetValues,string tableName,string[] conditionKeys,string[] conditionValues)
        {
            string sql = "update set " + Merge(SetKeys,SetValues,",") + " from " + tableName + " where" + Merge(conditionKeys,conditionValues," and ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            bool flag = (cmd.ExecuteScalar() != null);
            return flag;
        }

        /// <summary>
        /// 无条件更新数据库
        /// </summary>
        /// <param name="SetKeys">要更新的键键值的键</param>
        /// <param name="SetValues">要更新的键值</param>
        /// <param name="tableName">要更新的表</param>
        /// <returns></returns>
        public static bool Update(string[] SetKeys, string[] SetValues, string tableName)
        {
            string sql = "update set " + Merge(SetKeys, SetValues, ",") + " from " + tableName;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            bool flag = (cmd.ExecuteScalar() != null);
            return flag;
        }


        /// <summary>
        /// 向数据库中插入数据
        /// </summary>
        /// <param name="tableName">要插入的表</param>
        /// <param name="conditionKeys">要插入的键</param>
        /// <param name="conditionValues">要插入的键值</param>
        /// <returns></returns>
        public static bool Insert(string tableName, string[] conditionKeys, string[] conditionValues)
        {
            string sql = "insert into " + tableName + " (" + MergeKeys(conditionKeys) +") values (" + MergeValues(conditionValues) +")";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            bool flag = (cmd.ExecuteScalar() != null);
            return flag;
        }
    }
}
