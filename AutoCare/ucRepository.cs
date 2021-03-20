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
    public partial class ucRepository : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucRepository _instance;

        public static ucRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRepository();
                return _instance;
            }
        }

        public ucRepository()
        {
            InitializeComponent();
        }
    }
}
