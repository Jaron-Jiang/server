using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class MessageInfo:Info
    {
        private string message_info_id;
        private string message_info_publisher;
        private string message_info_type;
        private string message_info_title;
        private string message_info_descripiton;
        private string message_info_starttime;
        private LinkedList<UserSet> accepter;

        public string MessageInfoId
        {
            get => message_info_id;
            set
            {
                message_info_id = value;
            }
        }
        public string MessageInfoPublisher
        {
            get => message_info_publisher;
            set
            {
                message_info_publisher = value;
            }
        }
        public string MessageInfoType
        {
            get => message_info_type;
            set
            {
                message_info_type = value;
            }
        }
        public string MessageInfoTitle
        {
            get => message_info_title;
            set
            {
                message_info_title = value;
            }
        }
        public  string MessageInfoDescripiton
        {
            get => message_info_descripiton;
            set
            {
                message_info_descripiton = value;
            }
        }
        public string MessageInfoStarttime
        {
            get => message_info_starttime;
            set
            {
                message_info_starttime = value;
            }
        }
        public LinkedList<UserSet> Accepter
        {
            get => accepter;
            set
            {
                accepter = value;
            }
        }
        public MessageInfo()
        {
            MessageInfoId = "";
            MessageInfoPublisher = "";
            MessageInfoType = "";
            MessageInfoTitle = "";
            MessageInfoDescripiton = "";
            MessageInfoStarttime = "19700101000000";
            Accepter = new LinkedList<UserSet>();
        }
    }
}
