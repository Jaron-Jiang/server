using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class MessageList:Info
    {
        private string message_starttime;
        private string message_endtime;
        private LinkedList<MessageInfo> message_list_data;
        public string MessageStarttime
        {
            get => message_starttime;
            set
            {
                message_starttime = value;
            }
        }
        public string MessageEndtime
        {
            get => message_endtime;
            set
            {
                message_endtime = value;
            }
        }
        public LinkedList<MessageInfo> MessageListData
        {
            get => message_list_data;
            set
            {
                message_list_data = value;
            }
        }

        public void AddHistory(MessageInfo message_info)
        {
            MessageListData.AddLast(message_info);
        }
        public MessageList()
        {
            MessageStarttime = "19700101000000";
            MessageEndtime = "19700101000000";
            MessageListData = new LinkedList<MessageInfo>();
        }
    }
}
