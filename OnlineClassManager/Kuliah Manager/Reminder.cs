using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    abstract class Reminder
    {
        public string finalMsg;
        protected string className;
        protected string day;       
        protected bool validation;
        public string Pesan { get; protected set; }
        public string ClassName { get; private set; }
        public bool Validation { get; set; }
        public Reminder (string mes)
        {
            this.Pesan = mes;
        }

        public virtual void ShowMes()
        {
            MessageBox.Show(finalMsg);
        }
    }
}
