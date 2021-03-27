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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void ucWorkers_Load(object sender, EventArgs e)
        {
            CenterContext context = new CenterContext();
            workerBindingSource.DataSource = context.Workers.ToList();
            workerBindingSource.DataSource = context.Workers.ToList();
        }
    }
}
