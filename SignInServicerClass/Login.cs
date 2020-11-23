using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class Login
    {
        /// <summary>
        /// 密码登录
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public static bool LoginPassword(string id,string password)
        {
            string[] Key = { "id","password"}; 
            string[] value = { id,password };
            if(id[0] == '1')//老师
            {
                bool flag = false;
                string tablename = "teacher_profile";
                flag =  SQL.IsSelect(tablename,Key,value);
                return flag == true ? true : false;
            }
            else if(id[0] == '2')
            {
                bool flag = false;
                string tablename = "student_profile";
                flag = SQL.IsSelect(tablename, Key, value);
                return flag == true ? true : false;
            }
            return false;
        }
        public static string LoginFace(string id,string face)
        {
            //调库
            //读取数据库得人脸数据来与客户端发出得数据做对比。
            return "false";
        }
    }
}
