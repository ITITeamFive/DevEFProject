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
    public partial class ucWorkers : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucWorkers _instance;

        public static ucWorkers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWorkers();
                return _instance;
            }
        }

        public ucWorkers()
        {
            InitializeComponent();
        }
    }
}
