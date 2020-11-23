using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Security.Cryptography;

namespace cn.swu_acm.projects.sia.libs
{
    public class global
    {
        public static string[] FormsColumnNames = { "form_id", "form_title", "form_type", "form_introduction", "form_publisher", "form_startdate", "form_enddate", "form_starttime", "form_endtime", "form_loop", "form_isforce", "form_users" };
        public static string[] FormsRecordsColumnNames = { "record_id", "record_form_id", "record_submiter", "record_type", "record_data", "record_time" };
        public static string[] StudentProfile = { "student_id", "student_name", "student_sex", "student_birthday", "student_dormitory", "student_email", "student_wechat", "student_qq", "student_identifynumber", "student_college", "student_major", "student_grade", "student_class", "student_password_hash", "student_isenable", "student_face_id", "student_courses" };
        public static string[] TeacherPorfile = { "teacher_id", "teacher_name", "teacher_sex", "teacher_college", "teacher_address", "teacher_birthday", "teacher_identifynumber", "teacher_email", "teacher_wechat", "teacher_qq", "teacher_password_hash", "teacher_isenable", "teacher_isapprover" };
        public static string[] messages = { "message_id", "message_publisher", "message_starttime", "message_type", "message_users", "message_data" };
        public static string[] lists = { "list_id", "list_publisher", "list_starttime", "list_endtime", "list_introduction", "list_title", "list_users", "list_isforce" };
        public static string[] list_records = { "record_id", "record_time", "record_submiter", "record_data", "record_list_id" };
        public static string[] leave_records = { "leave_id", "leave_type", "leave_student", "leave_starttime", "leave_endtime", "leave_destination", "leave_approver", "leave_isfinished" };
        public static string[] course = { "corese_id", "course_name", "course_teacher", "course_startdate", "course_enddate", "course_starttime", "course_endtime", "course_college", "course_major", "course_grade", "course_type", "course_users" };
        public static string[] Calendar = { "user_id","calendar_title", "calendar_starttime", "calendar_endtime", "calendar_address", "calendar_description" };
    };
    }

}
