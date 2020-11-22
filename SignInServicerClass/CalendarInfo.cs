using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class CalendarInfo:Info
    {
        private string calendar_title;
        private string calendar_starttime;
        private string calendar_endtime;
        private string calendar_address;
        private string calendar_description;
        public string CalendarTitle
        {
            get => calendar_title;
            set
            {
                calendar_title = value;
            }
        }
        public string CalendarStarttime
        {
            get => calendar_starttime;
            set
            {
                calendar_starttime = value;
            }
        }
        public string CalendarEndtime
        {
            get => calendar_endtime;
            set
            {
                calendar_endtime = value;
            }
        }
        public string CalendarAddress
        {
            get => calendar_address;
            set
            {
                calendar_address = value;
            }
        }
        public string CalendarDescription
        {
            get => calendar_description;
            set
            {
                calendar_description = value;
            }
        }
        public CalendarInfo()
        {
            CalendarTitle = "Unknown";
            CalendarStarttime = "19700101000000";
            CalendarEndtime = "19700101000000";
            CalendarAddress = "Unknown";
            CalendarDescription = "";
        }
    }
}
