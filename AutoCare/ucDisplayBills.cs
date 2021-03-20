using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare
{
    public partial class ucDisplayBills : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDisplayBills _instance;

        public static ucDisplayBills Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDisplayBills();
                return _instance;
            }
        }

        public ucDisplayBills()
        {
            InitializeComponent();
        }
    }
}
