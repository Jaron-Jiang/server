using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class Leave
    {
        /// <summary>
        /// 查看某个人的id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="starttime">开始时间</param>
        /// <param name="endtime">结束时间</param>
        /// <returns></returns>
        public LeaveHistory LeaveSelectHistory(string id,string starttime,string endtime)
        {
            LeaveHistory leaveHistory = new LeaveHistory();
            leaveHistory.LeaveHistoryStarttime = starttime;
            leaveHistory.LeaveHistoryEndtime = endtime;
            LeaveRecord leaveRecord = new LeaveRecord();
            //查询数据库加入list
            return leaveHistory;
        }
        /// <summary>
        /// 插入请假
        /// </summary>
        /// <param name="leaveHistory">请假单</param>
        /// <returns></returns>
        public bool LeaveInsert(LeaveHistory leaveHistory)
        {
            //对数据库插入
            return false;
        }
        /// <summary>
        /// 对leave_id表更新状态
        /// </summary>
        /// <param name="condition">需要更新的状态</param>
        /// <param name="leave_id"></param>
        /// <returns></returns>
        public bool LeaveUpdata(string condition,string leave_id)
        {
            //更新
            return false;
        }
        public LeaveHistory LeaveRecordSelect(string id)
        {
            LeaveHistory leaveHistory = new LeaveHistory();
            LeaveRecord leaveRecord = new LeaveRecord(); 
            //查询
            return leaveHistory;
        }
    }
}
