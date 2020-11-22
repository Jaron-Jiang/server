using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class UserInfoList:Info
    {
        private LinkedList<UserInfo> users;
        public LinkedList<UserInfo> Users
        {
            get => users;
            set
            {
                users = value;
            }
        }
        public void Add(UserInfo user_info)
        {
            Users.AddLast(user_info);
        }
        public UserInfoList()
        {
            Users = new LinkedList<UserInfo>();
        }
    }
}
