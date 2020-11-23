using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace cn.swu_acm.projects.sia.libs
{
    class Calendar

    {
        /// <summary>
        /// 插入课表信息
        /// </summary>
        /// <param name="calendar">课表的json文件</param>
        /// <returns></returns>
        public static bool CalendarInsert(JObject calendar)
        {
            string tablename = "Calendar";
            string[] conditionkey = global.Calendar;
            string[] conditionval = {calendar["user_id"].ToString(),calendar["calendar_title"].ToString(),calendar["calendar_starttime"].ToString(),calendar["calendar_endtime"].ToString(),calendar["calendar_address"].ToString(),calendar["calendar_description"].ToString() };
            return SQL.Insert(tablename,conditionkey,conditionval);
        }
        /// <summary>
        /// 查询该用户的课程
        /// </summary>
        /// <param name="user_id">用户id</param>
        /// <returns></returns>
        public static CalendarInfo CalendarSelect(string user_id,string starttime,string endtime)
        {
            CalendarInfo calendarInfo = new CalendarInfo();
            string tablename = "Calendar";
            string[] values = global.Calendar;
            string[] conditionkey = { "user_id","calendar_starttime","calendar_endtime"};
            string[] conditionval = { user_id,starttime,endtime};
            string res = SQL.Select(values,tablename,conditionkey,conditionval);
            JObject jObject = JObject.Parse(res);
            calendarInfo.UserId = user_id;
            calendarInfo.CalendarAddress = jObject["calendar_address"].ToString();
            calendarInfo.CalendarDescription = jObject["calendar_description"].ToString();
            calendarInfo.CalendarEndtime = jObject["calendar_endtime"].ToString();
            calendarInfo.CalendarStarttime = jObject["calendar_starttime"].ToString();
            calendarInfo.CalendarTitle = jObject["calendar_title"].ToString();
            return calendarInfo;
        }
    }
}
