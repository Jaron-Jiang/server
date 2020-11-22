using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class ListList
    {
        private string leave_history_starttime;
        private string leave_history_endtime;
        private LinkedList<ListInfo> list_list_data;

        public string ListHistoryStarttime
        {
            get => leave_history_starttime;
            set
            {
                leave_history_starttime = value;
            }
        }

        public string ListHistoryEndtime
        {
            get => leave_history_endtime;
            set
            {
                leave_history_endtime = value;
            }
        }

        public LinkedList<ListInfo> ListListData
        {
            get => list_list_data;
            set
            {
                list_list_data = value;
            }
        }

        public ListList()
        {
            ListHistoryStarttime = "19700101000000";
            ListHistoryEndtime = "19700101000000";
            ListListData = new LinkedList<ListInfo>();
        }

        public void AddListInfo(ListInfo listInfo)
        {
            ListListData.AddLast(listInfo);
        }
    }
}
