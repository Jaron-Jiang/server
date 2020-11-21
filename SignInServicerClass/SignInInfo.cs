using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace cn.swu_acm.projects.sia.libs
{
    // todo remove
    public class UserSet
    {
        
    }
    public class SignInfo : Info
    {
        private string sign_in_start_time;
        private string sign_in_end_time;
        private string sign_in_type;
        private string sign_in_publisher;
        private string sign_in_description;
        private string sign_in_is_looped;
        private string sign_in_loop_start_date;
        private string sign_in_loop_end_date;
        private string sign_in_is_force;
        private string sign_in_form_id;
        private string sign_in_question;
        private LinkedList<UserSet> need_to_sign_in;

        public SignInfo()
        {
            SignInStartime = "19700101000000";
            SignInEndtime = "19700101000000";
            SignInType = "0";
            SignInPublisher = "";
            SignInDescription = "";
            SignInIsLooped = "0";
            SignInLoopStartdate = "19700101000000";
            SignInLoopEnddate = "19700101000000";
            SignInIsForce = "0";
            SignInFormId = "";
            SignInQuestion = "";
            NeedToSignIn = new LinkedList<UserSet>();
        }
        public string SignInStartime
        {
            get => sign_in_start_time;
            set
            {
                sign_in_start_time = value;
            }
            
        }

        public string SignInEndtime
        {
            get => sign_in_end_time;
            set
            {
                sign_in_end_time = value;
            }
        }

        public string SignInType
        {
            get => sign_in_type;
            set
            {
                sign_in_type = value;
            }
        }

        public string SignInPublisher
        {
            get => sign_in_publisher;
            set
            {
                sign_in_publisher = value;
            }
        }

        public string SignInDescription
        {
            get => sign_in_description;
            set
            {
                sign_in_description = value;
            }
        }

        public string SignInIsLooped
        {
            get => sign_in_is_looped;
            set
            {
                sign_in_is_looped = value;
            }
        }

        public string SignInLoopStartdate
        {
            get => sign_in_loop_start_date;
            set
            {
                sign_in_loop_start_date = value;
            }
        }

        public string SignInLoopEnddate
        {
            get => sign_in_loop_end_date;
            set
            {
                sign_in_loop_end_date = value;
            }
        }
        
        public string SignInIsForce
        {
            get => sign_in_is_force;
            set
            {
                sign_in_is_force = value;
            }
        }

        public string SignInFormId
        {
            get => sign_in_form_id;
            set
            {
                sign_in_form_id = value;
            }
        }

        public string SignInQuestion
        {
            get => sign_in_question;
            set
            {
                sign_in_question = value;
            }
        }

        public LinkedList<UserSet> NeedToSignIn
        {
            get => need_to_sign_in;
            set
            {
                need_to_sign_in = value;
            }
        }

    }
}
