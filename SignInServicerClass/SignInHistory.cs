using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class SignInHistory : Info
    {
        private string sign_in_history_starttime;
        private string sign_in_history_endtime;
        private LinkedList<SignInHistoryRecord> sign_in_history_data;
        
        public string SignInHistoryStarttime
        {
            get => sign_in_history_starttime;
            set
            {
                sign_in_history_starttime = value;
            }
        }
        public string SignInHistoryEndtime
        {
            get => sign_in_history_endtime;
            set
            {
                sign_in_history_endtime = value;
            }
        }
        public LinkedList<SignInHistoryRecord> SignHistoryData
        {
            get => sign_in_history_data;
            set
            {
                sign_in_history_data = value;
            }
        }
        public void AddHistoryRecord(SignInHistoryRecord record)
        {
            SignHistoryData.AddLast(record);
        }
        public SignInHistory()
        {
            SignInHistoryStarttime = "19700101000000";
            SignInHistoryEndtime = "19700101000000";
            SignHistoryData = new LinkedList<SignInHistoryRecord>();
        }
    }
}
