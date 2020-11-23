using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.swu_acm.projects.sia.libs
{
    /// <summary>
    /// 登录信息的类
    /// </summary>
    public abstract class LoginData : ClientData
    {
        private string user_id;

        public string UserId
        {
            get => user_id;
            set => user_id = value;
        }
    }
}
