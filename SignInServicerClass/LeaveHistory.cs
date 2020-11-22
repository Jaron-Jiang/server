using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class LeaveHistory
    {
        private string leave_history_starttime;
        private string leave_history_endtime;
        private LinkedList<LeaveRecord> leave_history_data;

        public string LeaveHistoryStarttime
        {
            get => leave_history_starttime;
            set
            {
                leave_history_starttime = value;
            }
        }

        public string LeaveHistoryEndtime
        {
            get => leave_history_endtime;
            set
            {
                leave_history_endtime = value;
            }
        }

        public LinkedList<LeaveRecord> LeaveHistoryData
        {
            get => leave_history_data;
            set
            {
                leave_history_data = value;
            }
        }

        public void AddLeaveRecord(LeaveRecord leaveRecord)
        {
            LeaveHistoryData.AddLast(leaveRecord);
        }
    }
}
