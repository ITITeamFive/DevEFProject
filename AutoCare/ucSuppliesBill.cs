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
using AutoCare.models;
using System.Collections.ObjectModel;

namespace AutoCare
{
    public partial class ucSuppliesBill : DevExpress.XtraEditors.XtraUserControl
    {
        ObservableCollection<Item> billItems = new ObservableCollection<Item>();

        private static ucSuppliesBill _instance;

        public static ucSuppliesBill Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSuppliesBill();
                return _instance;
            }
        }

        public ucSuppliesBill()
        {
            InitializeComponent();

            gcBillItems.DataSource = billItems;
        }
    }
}
