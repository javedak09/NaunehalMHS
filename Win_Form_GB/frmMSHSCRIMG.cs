using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_GB
{
    public partial class frmMSHSCRIMG : Form
    {
        public frmMSHSCRIMG()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

        }

        private void frmMSH_Load(object sender, EventArgs e)
        {
            this.Text = CVariables.AppName1 + " (Mobile Health Service Form)";
            GetTotalForms();
        }


        private void GetTotalForms()
        {
            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select count(*) count1 from camp_patient", cn.cn);
                DataSet ds = new DataSet();

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["count1"].ToString() == "0")
                        {
                            label51.Text = "1";
                        }
                        else
                        {
                            label51.Text = ds.Tables[0].Rows[0]["count1"].ToString();
                        }

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }


        private void CheckMHSNo()
        {

            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_patient where mh02='" + mh02.Text + "'", cn.cn);
                DataSet ds = new DataSet();

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        mh01.Text = ds.Tables[0].Rows[0]["mh01"].ToString();
                        mh02.Text = ds.Tables[0].Rows[0]["mh02"].ToString();
                        mh03.Text = ds.Tables[0].Rows[0]["mh03"].ToString();
                        mh04.Text = ds.Tables[0].Rows[0]["mh04"].ToString();
                        mh05.Text = ds.Tables[0].Rows[0]["mh05"].ToString();

                        mh06.SelectedValue = ds.Tables[0].Rows[0]["mh06"].ToString();

                        mh07.Text = ds.Tables[0].Rows[0]["mh07"].ToString();
                        mh08.Text = ds.Tables[0].Rows[0]["mh08"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("MHS Id does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mh02.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("MHS Id does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mh02.Focus();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }

        private void mh02_Leave(object sender, EventArgs e)
        {
            CheckMHSNo();
        }
    }
}