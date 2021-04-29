using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuliah_Manager
{
    class Class
    {
        private string className;
        private string day;
        private DateTime time;
        private string meetingLink;
        private string attendanceLink;
        private bool validation;
        public string ClassName
        {
            get;
            private set;
        }
        public string Day
        {
            get;
            private set;
        }
        public DateTime Time
        {
            get;
            private set;
        }
        public string MeetingLink
        {
            get;
            private set;
        }
        public string AttendanceLink
        {
            get;
            private set;
        }
        public bool Validation
        {
            get;
            private set;
        }
        public void IsValid(bool validation)
        {
            if(validation == true)
            {
                //execute database ADD fuction
            }
            else
            {
                //Show MessageBox
            }
        }
        public Class(string ClassName, string Day, DateTime Time, string MeetingLink, string AttendanceLink)
        {
            this.ClassName = ClassName;
            this.Day = Day;
            this.Time = Time;
            this.MeetingLink = MeetingLink;
            this.AttendanceLink = AttendanceLink;
        }
        public void DeleteClass(bool delClass)
        {
            if (delClass == true)
            {
                //Delete data in the database
                //Sementara, memakai dummy codes berikut
                ClassName = "";
                Day = "";
                MeetingLink = "";
                AttendanceLink = "";

            }
        }

    }
}
