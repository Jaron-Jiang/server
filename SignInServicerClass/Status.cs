using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    class Status : ServerData
    {
        private string status_type;
        private string status_result;

        public string StausType
        {
            get => status_type;
            set
            {
                status_type = value;
            }
        }


        public string StatusResult
        {
            get => status_result;
            set
            {
                status_result = value;
            }
        }
    }
}
