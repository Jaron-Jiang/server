using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
namespace cn.swu_acm.projects.sia.libs
{
    class SignIn
    {
        /// <summary>
        /// 查询与该id有关的所有签到表
        /// </summary>
        /// <param name="id">学生或者老师的id</param>
        /// <returns></returns>
       public SignInList SignSelect(string id,string starttime,string endtime)
        {
            SignInList signInList = new SignInList();
            //查询语句
            
            return signInList;
        }
        /// <summary>
        /// 查询与该id有关的所有签到记录
        /// </summary>
        /// <param name="id">学生或者老师的id</param>
        /// <returns></returns>
        public SignInList SignSelectHistorys(string id,string starttime,string endtime,string startdate,string enddate)
        {
            SignInList signInList = new SignInList();
            if (id[0] == '1')//老师端
            {
                //查询语句
                string[] conditionKeys = { "id","form_startdate", "form_enddate", "form_starttime", "form_endtime" };
                string[] conditionValues = { id,startdate, enddate, starttime, endtime };
                string[] values = global.FormsColumnNames;
                string tablename = "forms";
                string json = SQL.Select(values,tablename,conditionKeys,conditionValues);
                JArray jArray = new JArray();
                jArray = JArray.Parse(json);
                for(int i = 0; i < jArray.Count; i++)
                {

                }
                SignInHistoryRecord signInHistoryRecord = new SignInHistoryRecord();
                //signInHistoryRecord = josn转对象
            }
            else if (id[0] == '2')
            {

            }
            return signInList;
        }
        /// <summary>
        /// 查询某个签到表的签到状态
        /// </summary>
        /// <param name="form_id">签到表id</param>
        /// <returns></returns>
        public bool SignStatus(string form_id)
        {
            return false;
        }
        /// <summary>
        /// 对签到表插入
        /// </summary>
        /// <param name="signInList">插入得签到表对象</param>
        /// <returns></returns>
        public bool SignInInsert(SignInList signInList)
        {
            //插入
            return false;
        }
        /// <summary>
        /// 插入签到记录
        /// </summary>
        /// <param name="signInHistory">签到表</param>
        /// <returns></returns>
        public bool SignInInsertRecord(SignInHistory signInHistory)
        {
            return false;
        }
        /// <summary>
        /// 改变签到表的状态
        /// </summary>
        /// <param name="condition">需要改变为得状态</param>
        /// <param name="form_id">签到表id</param>
        /// <returns></returns>
        public bool SignInUpdata(string condition,string form_id)
        {

            return false;
        }
        
    }
}
