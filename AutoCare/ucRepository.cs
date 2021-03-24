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

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void itemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            button2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void ucRepository_Load(object sender, EventArgs e)
        {
            CenterContext context = new CenterContext();
            itemBindingSource.DataSource = context.Items.ToList();

            itemBindingSource.DataSource = context.Items.ToList();
        }
    }
}
