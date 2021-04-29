using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    class ClassReminder : Reminder
    {

        public string linkMeet
        {
            get; set;
        }

        public ClassReminder(string link , string mes = "Jangan lupa belajar kamu masih bodoh" ) : base(mes)
        {
            this.finalMsg = Pesan + "\n" + linkMeet;
        }

        public override void ShowMes()
        {
            finalMsg = "[CLASS REMINDER]";
            MessageBox.Show(finalMsg);
        }
    }
}
