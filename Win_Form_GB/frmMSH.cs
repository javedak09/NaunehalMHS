using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_GB
{
    public partial class frmMSH : Form
    {
        public frmMSH()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

        }

        private void frmMSH_Load(object sender, EventArgs e)
        {
            getTown();
            getUC();
            getGender();
        }


        private void getTown()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Select Town");
            comboSource.Add("1", "Town 1");

            town.DataSource = new BindingSource(comboSource, null);
            town.DisplayMember = "Value";
            town.ValueMember = "Key";

        }



        private void getUC()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Select UC");
            comboSource.Add("1", "UC 1");

            uc.DataSource = new BindingSource(comboSource, null);
            uc.DisplayMember = "Value";
            uc.ValueMember = "Key";

        }



        private void getGender()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Select Gender");
            comboSource.Add("1", "Male");
            comboSource.Add("2", "Female");

            gender.DataSource = new BindingSource(comboSource, null);
            gender.DisplayMember = "Value";
            gender.ValueMember = "Key";

        }


    }    
}