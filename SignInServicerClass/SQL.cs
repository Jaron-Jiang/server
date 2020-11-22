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
            SqlIp = "";
            SqlPort = "";
            SqlUser = "";
            SqlPassword = "";
            SqlDb = "";
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
        /// 初始化连接数据库
        /// </summary>
        /// <param name="ip">数据库IP</param>
        /// <param name="port">数据库端口</param>
        /// <param name="user">使用者</param>
        /// <param name="password">密码</param>
        /// <param name="db">数据库名</param>
        public static void init(string ip,string port ,string user,string password,string db)
        {
            SqlIp = ip;
            SqlPort = port;
            SqlUser = user;
            SqlPassword = password;
            SqlDb = db;
            string constr = "server=" + SqlIp + ";port=" + SqlPort + ";user=" + SqlUser + ";password=" + SqlPassword + "; database=" + SqlDb + ";";
            conn = new MySqlConnection(constr);
        }

        public static string Select(string[] values,string tableName,string[] conditionKeys,string[] conditionValues)
        {
            string sql = "select " + MergeKeys(values) + " from " + tableName + " where " + Merge(conditionKeys,conditionValues," and ");
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

        public static bool IsSelect(string tableName, string[] conditionKeys, string[] conditionValues)
        {
            string sql = "select count(*) from " + tableName + " where " + Merge(conditionKeys, conditionValues," and ");
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            bool flag = (cmd.ExecuteScalar() != null);
            return flag;
        }

        public static bool Update(string[] SetKeys,string[] SetValues,string tableName,string[] conditionKeys,string[] conditionValues)
        {
            string sql = "update set " + Merge(SetKeys,SetValues,",") + " from " + tableName + " where" + Merge(conditionKeys,conditionValues," and ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            bool flag = (cmd.ExecuteScalar() != null);
            return flag;
        }

        public static bool Insert(string tableName, string[] conditionKeys, string[] conditionValues)
        {
            string sql = "insert into " + tableName + " (" + MergeKeys(conditionKeys) +") values (" + MergeValues(conditionValues) +")";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            bool flag = (cmd.ExecuteScalar() != null);
            return flag;
        }
    }
}
