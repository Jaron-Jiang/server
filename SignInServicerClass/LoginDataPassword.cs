using System;

namespace cn.swu_acm.projects.sia.libs
{
    /// <summary>
    /// LoginDataPassword类是SignInApp的密码登录请求信息类
    /// 密码登录的类
    /// </summary>
    public class LoginDataPassword : LoginData
    {       
        private string password;

        public string Password
        {
            get => password;
            set => password = cn.swu_acm.projects.sia.libs.Converter.EncodingTo32L(value);
        }
        
        public LoginDataPassword()
        {
            ServerAddr = DefaultConfig.ServerAddr;
            ServerPort = DefaultConfig.ServerPort;
            UserId = "000000000000000";
            Password = "123456";
            RequestFunc =
                cn.swu_acm.projects.sia.libs.Converter.EncodingTo32L(FunctionSetServer.LoginWithPassword.ToString());
            CallBack = cn.swu_acm.projects.sia.libs.Converter.EncodingTo32L(
                FunctionSetClient.LoginPasswordExpress.ToString());
        }
    }
}