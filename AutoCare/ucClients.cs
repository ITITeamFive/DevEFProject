﻿using DevExpress.XtraEditors;
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
    public partial class ucClients : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucClients _instance;

        public static ucClients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClients();
                return _instance;
            }
        }

        public ucClients()
        {
            InitializeComponent();
        }
    }
}
