using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class LeaveRecord 
    {
        private string leave_info_id;
        private string leave_info_type;
        private string leave_info_submiter;
        private string leave_info_starttime;
        private string leave_info_endtime;
        private string leave_info_destination;
        private string leave_info_approver;
        private string leave_info_is_approved;
        private string leave_info_is_finished;

        public string LeaveInfoId
        {
            get => leave_info_id;
            set
            {
                leave_info_id = value;
            }
        }

        public string LeaveInfoType
        {
            get => leave_info_type;
            set
            {
                leave_info_type = value;
            }
        }

        public string LeaveInfoSubmiter
        {
            get => leave_info_submiter;
            set
            {
                leave_info_submiter = value;
            }
        }

        public string LeaveInfoStarttime
        {
            get => leave_info_starttime;
            set
            {
                leave_info_starttime = value;
            }
        }

        public string LeaveInfoEndtime
        {
            get => leave_info_endtime;
            set
            {
                leave_info_endtime = value;
            }
        }

        public string LeaveInfoDestination
        {
            get => leave_info_destination;
            set
            {
                leave_info_destination = value;
            }
        }

        public string LeaveInfoApprover
        {
            get => leave_info_approver;
            set
            {
                leave_info_approver = value;
            }
        }

        public string LeaveInfoIsApproved
        {
            get => leave_info_is_approved;
            set
            {
                leave_info_is_approved = value;
            }
        }

        public string LeaveInfoIsFinshed
        {
            get => leave_info_is_finished;
            set
            {
                leave_info_is_finished = value;
            }
        }

        public LeaveRecord()
        {
            LeaveInfoId = "";
            LeaveInfoType = "0";
            LeaveInfoSubmiter = "";
            LeaveInfoStarttime = "19700101000000";
            LeaveInfoEndtime = "19700101000000";
            LeaveInfoDestination = "";
            LeaveInfoApprover = "";
            LeaveInfoIsApproved = "0";
            LeaveInfoIsFinshed = "0";
        }
    }
}
