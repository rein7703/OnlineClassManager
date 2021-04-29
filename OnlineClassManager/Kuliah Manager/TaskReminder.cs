﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kuliah_Manager
{
    class TaskReminder : Reminder
    {
        
        public TaskReminder(string matkul, string mes = "Ngerjain tugas aja masih dapet C apalagi ga ngerjain! Yuk Nugas!") : base(mes)
        {
            this.finalMsg = Pesan + "\n" + "Ada tugas matkul " + matkul;
        }

        public override void ShowMes()
        {
            finalMsg = "[TASK REMINDER]" + finalMsg;
            MessageBox.Show(finalMsg);
        }
    }
}
