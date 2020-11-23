using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.swu_acm.projects.sia.libs
{
    class Login
    {
        public static bool LoginPassword(LoginDataPassword loginDataPassword)
        {
            string tablename = "Admin";
            if(tablename == "Admin")
            {
                string[] conditionKey = { "user_id", "user_pass_hash" };
                string[] conditionVal = { loginDataPassword.UserId,loginDataPassword.Password};
                int flag = SQL.SelectCount(tablename, conditionKey, conditionVal);
                if (flag > 0)
                {
                    return true;
                }
                else
                {
                    tablename = "Staff";
                }
            }
            else
            {
                string[] conditionKey = { "user_id", "user_pass_hash" };
                string[] conditionVal = { loginDataPassword.UserId, loginDataPassword.Password };
                int flag = SQL.SelectCount(tablename, conditionKey, conditionVal);
                if (flag > 0)
                {
                    return true;
                }
            }

            //if ()
            //{
            //    return true;
            //}
            //if(id[0] == '1')//老师端
            //{
            //    string tablename= "";//to do;
            //    string[] conditionkey = { };//to do;
            //    string[] conditionval = { loginDataPassword.Password };
            //    int flag = SQL.SelectCount(tablename, conditionkey, conditionval);
            //    if (flag >0 ) return true;
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else if(id[0] == '2')//学生端
            //{
            //    string tablename = "";//to do;
            //    string[] conditionkey = { };//to do;
            //    string[] conditionval = { loginDataPassword.Password };
            //    int flag =SQL.SelectCount(tablename, conditionkey, conditionval);
            //    if (flag > 0) return true;
            //    else
            //    {
            //        return false;
            //    }
            //}
            return false;
        }
        public static bool LoginFace(LoginDataFace loginDataFace)
        {
            string id = loginDataFace.UserId;
            if(id[0] == '1')//老师端
            {
                //调库
            }
            else if(id[0]=='2')//学生端
            {
                //调库
            }
            return false;
        }
    }
}
