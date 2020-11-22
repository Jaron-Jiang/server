using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class UserInfo:Info
    {
        private string user_info_id;
        private string user_info_name;
        private string user_info_sex;
        private string user_info_brithday;
        private string user_info_email;
        private string user_info_wechat;
        private string user_info_qq;
        private string user_info_department;
        private string user_info_address;
        public string UserInfoId
        {
            get => user_info_id;
            set
            {
                user_info_id = value;
            }
        }
        public string UserInfoName
        {
            get => user_info_name;
            set
            {
                user_info_name = value;
            }
        }
        public string UserInfoSex
        {
            get => user_info_sex;
            set
            {
                user_info_sex = value;
            }
        }
        public string UserInfoBirthday
        {
            get => user_info_brithday;
            set
            {
                user_info_brithday = value;
            }
        }
        public string UserInfoEmail
        {
            get => user_info_email;
            set
            {
                user_info_email = value;
            }
        }

        public string UserInfoWechat
        {
            get => user_info_wechat;
            set
            {
                user_info_wechat = value;
            }
        }
        public string UserInfoQQ
        {
            get => user_info_qq;
            set
            {
                user_info_qq = value;
            }
        }
        public string UserInfoDepartment
        {
            get => user_info_department;
            set
            {
                user_info_department = value;
            }
        }
        public string UserInfoAddress
        {
            get => user_info_address;
            set
            {
                user_info_address = value;
            }
        }
        public UserInfo()
        {
            UserInfoId = "000000000000000";
            UserInfoName = "EMPTY";
            UserInfoSex = "Unknown";
            UserInfoBirthday = "19700101";
            UserInfoEmail = "empty@swu-acm.cn";
            UserInfoWechat = "Unknown";
            UserInfoQQ = "Unknown";
            UserInfoDepartment = "Unknown";
            UserInfoAddress = "Uknown";
        }
    }
}
