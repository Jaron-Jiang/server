using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class SignInList
    {
        private string sign_in_list_starttime;
        private string sign_in_list_endtime;
        private LinkedList<SignInInfo> sign_in_list_data;

        public string SignInListStarttime
        {
            get => sign_in_list_starttime;
            set
            {
                sign_in_list_starttime = value;
            }
        }

        public string SignInListEndtime
        {
            get => sign_in_list_endtime;
            set
            {
                sign_in_list_endtime = value;
            }
        }
        
        public LinkedList<SignInInfo> SignInListData
        {
            get => sign_in_list_data;
            set
            {
                sign_in_list_data = value;
            }
        }
        public void AddSignInfo(SignInInfo signInInfo)
        {
            SignInListData.AddLast(signInInfo);
        }
    }
}
