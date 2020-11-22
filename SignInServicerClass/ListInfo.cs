using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class ListInfo
    {
        private string list_info_id;
        private string list_info_title;
        private string list_info_starttime;
        private string list_info_endtime;
        private string list_info_publisher;
        private string list_info_is_forced;
        private LinkedList<UserSet> need_to_complete;
        private LinkedList<ListDataUnit> list_info_problems;

        public string ListInfoId
        {
            get => list_info_id;
            set
            {
                list_info_id = value;
            }
        }

        public string ListInfoTitle
        {
            get => list_info_title;
            set
            {
                list_info_title = value;
            }
        }

        public string ListInfoStarttime
        {
            get => list_info_starttime;
            set
            {
                list_info_starttime = value;
            }
        }

        public string ListInfoEndtime
        {
            get => list_info_endtime;
            set
            {
                list_info_endtime = value;
            }
        }

        public string ListInfoPublisher
        {
            get => list_info_publisher;
            set
            {
                list_info_publisher = value;
            }
        }

        public string ListInfoIsForced
        {
            get => list_info_is_forced;
            set
            {
                list_info_is_forced = value;
            }
        }

        public LinkedList<UserSet> NeedToComplete
        {
            get => need_to_complete;
            set
            {
                need_to_complete = value;
            }
        }

        public LinkedList<ListDataUnit> ListInfoProblems
        {
            get => list_info_problems;
            set
            {
                list_info_problems = value;
            }
        }

        public ListInfo()
        {
            ListInfoId = "";
            ListInfoTitle = "";
            ListInfoStarttime = "19700101000000";
            ListInfoEndtime = "19700101000000";
            ListInfoPublisher = "";
            ListInfoIsForced = "0";
            NeedToComplete = new LinkedList<UserSet>();
            ListInfoProblems = new LinkedList<ListDataUnit>();
        }

        public void AddUserSet(UserSet userSet)
        {
            NeedToComplete.AddLast(userSet);
        }

        public void AddListDataUnit(ListDataUnit listDataUnit)
        {
            ListInfoProblems.AddLast(listDataUnit);
        }
    }
}
