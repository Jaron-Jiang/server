using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    public enum SignIn_Type
    {
        Nothing,
        Location,
        Audio,
        Face,
        List
    }
    class SignInHistoryRecord : Info
    {
        private string sign_in_complete_Datetime;
        private string sign_in_type;
        private string sign_in_starttime;
        private string sign_in_endtime;
        public string SignInCompleteDatetime
        {
            get => sign_in_complete_Datetime;
            set
            {
                sign_in_complete_Datetime = value;
            }
        }
        public string SignInType
        {
            get => sign_in_type;
            set
            {
                sign_in_type = value;
            }
        }
        public string SignInStartTime
        {
            get => sign_in_starttime;
            set
            {
                sign_in_starttime = value;
            }
        }
        public string SignInEndtime
        {
            get => sign_in_endtime;
            set
            {
                sign_in_endtime = value;
            }
        }
        public SignInHistoryRecord()
        {
            SignInCompleteDatetime = "19700101000000";
            SignInType = SignIn_Type.Nothing.ToString();
            SignInStartTime = "19700101000000";
            SignInEndtime = "19700101000000";
        }

    }
}
