using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
namespace cn.swu_acm.projects.sia.libs
{
    class User
    {
        /// <summary>
        /// 更改个人信息
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="keys">需要更新哪些值</param>
        /// <param name="values">需要更新那些值的值</param>
        /// <returns></returns>
        public static bool UserUpdata(string id,string [] keys , string [] values)
        {
            if (id[0] == '1')//老师端
            {
                string talbename = "teacher_profile";
                string [] conditionkey = { "id" };
                string[] conditionval = { id};
                return SQL.Update(keys,values,talbename,conditionkey,conditionval);
            }else if(id[0] == '2')//学生端
            {
                string talbename = "student_profile";
                string[] conditionkey = { "id" };
                string[] conditionval = { id };
                return SQL.Update(keys, values, talbename, conditionkey, conditionval);
            }
            return false;
        }
        /// <summary>
        /// 导出所有学生表
        /// </summary>
        /// <returns></returns>
        public static UserInfoList UserSelectAll()
        {
            UserInfoList userInfoList = new UserInfoList();

            return userInfoList;
        }
        /// <summary>
        /// 选择指定学生或者老师的信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public static UserInfo UserSelect(string id)
        {
            UserInfo userInfo = new UserInfo();
            

            if(id[0] == '1')//老师端
            {
                string[] cols = global.TeacherPorfile;
                string tablename = "teacher_profile";
                string[] conditionkey = { "teacher_id" };
                string[] conditionval = { id };
                string re = SQL.Select(cols,tablename,conditionkey,conditionval);
                JObject jObject = JObject.Parse(re);
                userInfo.UserInfoId = jObject["studen_id"].ToString();
                userInfo.UserInfoAddress = jObject["teacher_address"].ToString();
                userInfo.UserInfoBirthday = jObject["teacher_birthday"].ToString();
                userInfo.UserInfoDepartment = jObject["teacher_college"].ToString();
                userInfo.UserInfoEmail = jObject["teacher_email"].ToString();
                userInfo.UserInfoName = jObject["teacher_name"].ToString();
                userInfo.UserInfoQQ = jObject["teacher_qq"].ToString();
                userInfo.UserInfoSex = jObject["teacher_sex"].ToString();
                userInfo.UserInfoWechat = jObject["teacher_wechat"].ToString();
            }
            else if (id[0] == '2')//学生端
            {
                string[] cols = global.TeacherPorfile;
                string tablename = "student_profile";
                string[] conditionkey = { "student_id" };
                string[] conditionval = { id };
                string re = SQL.Select(cols, tablename, conditionkey, conditionval);
                JObject jObject = JObject.Parse(re);
                userInfo.UserInfoId = jObject["student_id"].ToString();
                userInfo.UserInfoAddress = jObject["student_address"].ToString();
                userInfo.UserInfoBirthday = jObject["tstudent_birthday"].ToString();
                userInfo.UserInfoDepartment = jObject["student_college"].ToString();
                userInfo.UserInfoEmail = jObject["student_email"].ToString();
                userInfo.UserInfoName = jObject["student_name"].ToString();
                userInfo.UserInfoQQ = jObject["student_qq"].ToString();
                userInfo.UserInfoSex = jObject["student_sex"].ToString();
                userInfo.UserInfoWechat = jObject["student_wechat"].ToString();
            }
                return userInfo;
        }
        /// <summary>
        /// 插入学生信息（可能会有老师）
        /// </summary>
        /// <param name="user">学生</param>
        /// <returns></returns>
        public static bool UserInsert(JObject user)
        {

            //if (user[""])//老师端
            //{
            //    string tablename = "teacher_profile";
            //    string [] conditionkey = global.TeacherPorfile;
            //    string [] conditionval = { };
            //    return SQL.Insert(tablename,);
            //}
            //else if(id[0] == '2')//学生端
            //{

            //}
            string tablename = "student_profile";
            string[] conditionkey = global.StudentProfile;
            string [] conditionval = { user["student_id"].ToString(), user["student_name"].ToString(), user["student_sex"].ToString(), user["student_birthday"].ToString(), user["student_dormitory"].ToString(), user["student_email"].ToString(), user["student_wechat"].ToString(), user["student_qq"].ToString(), user["student_identifynumber"].ToString(), user["student_college"].ToString(),user[ "student_major"].ToString(), user["student_grade"].ToString(), user["student_class"].ToString(), user["student_password_hash"].ToString(), user["student_isenable"].ToString(), user["student_face_id"].ToString(), user["student_courses"].ToString() };
            return SQL.Insert(tablename,conditionkey,conditionval);
        }
    }
}
