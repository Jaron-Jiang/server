using System;
using System.Collections.Generic;
using System.Text;
using cn.swu_acm.projects.sia.libs;
using Newtonsoft.Json;

namespace cn.swu_acm.projects.sia.libs
{
    public abstract class ServerData
    {
        public string DataToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
