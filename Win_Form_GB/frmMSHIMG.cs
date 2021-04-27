using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Win_Form_GB
{


    public partial class frmMSHIMG : Form
    {

        public frmMSHIMG()
        {
            InitializeComponent();
        }


        private bool ValidateForm_new()
        {

            if (string.IsNullOrEmpty(FORM_ID.Text))
            {
                MessageBox.Show("Form ID is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FORM_ID.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(mh09y.Text))
            {
                MessageBox.Show("Age in years is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh09y.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(mh09m.Text))
            {
                MessageBox.Show("Age in months is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh09m.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(mh09d.Text))
            {
                MessageBox.Show("Age in days is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh09d.Focus();
                return false;
            }


            if (mh010.SelectedValue == "0")
            {
                MessageBox.Show("Gender is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh010.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(mh01101.Text))
            {
                MessageBox.Show("Presenting complaints is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh01101.Focus();
                return false;
            }
            else if (mh012.Text == "   ." && mh012.Enabled == true)
            {
                MessageBox.Show("Weight is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh012.Focus();
                return false;
            }
            else if (mh013.SelectedValue == "0" && mh013.Enabled == true)
            {
                MessageBox.Show("Pallor is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh013.Focus();
                return false;
            }
            else if (mh014.SelectedValue == "0" && mh014.Enabled == true)
            {
                MessageBox.Show("Hydration is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh014.Focus();
                return false;
            }
            else if (mh015.Text == "   ." && mh015.Enabled == true)
            {
                MessageBox.Show("Height/Length is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh015.Focus();
                return false;
            }
            else if (mh016.Text == "  ." && mh016.Enabled == true)
            {
                MessageBox.Show("MUAC is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh016.Focus();
                return false;
            }
            else if (!mh01701.Checked && mh01701.Enabled == true &&
                !mh01702.Checked && mh01702.Enabled == true &&
                !mh01703.Checked && mh01703.Enabled == true &&
                !mh017077.Checked && mh017077.Enabled == true)
            {
                MessageBox.Show("Diagnosis in pregnant women / mothers ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mh017077.Checked && string.IsNullOrEmpty(mh017077x.Text))
            {
                MessageBox.Show("Others is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh017077x.Focus();
                return false;
            }
            else if (!mh01801.Checked && mh01801.Enabled == true && !chkNoneDiag.Checked
                && !mh01802.Checked && mh01802.Enabled == true && !chkNoneDiag.Checked
                && !mh01803.Checked && mh01803.Enabled == true && !chkNoneDiag.Checked
                && !mh01804.Checked && mh01804.Enabled == true && !chkNoneDiag.Checked
                && !mh01805.Checked && mh01805.Enabled == true && !chkNoneDiag.Checked
                && !mh01806.Checked && mh01806.Enabled == true && !chkNoneDiag.Checked
                && !mh01807.Checked && mh01807.Enabled == true && !chkNoneDiag.Checked
                && !mh01808.Checked && mh01808.Enabled == true && !chkNoneDiag.Checked
                && !mh01809.Checked && mh01809.Enabled == true && !chkNoneDiag.Checked
                && !mh018010.Checked && mh018010.Enabled == true && !chkNoneDiag.Checked
                && !mh018011.Checked && mh018011.Enabled == true && !chkNoneDiag.Checked
                && !mh018012.Checked && mh018012.Enabled == true && !chkNoneDiag.Checked
                && !mh018013.Checked && mh018013.Enabled == true && !chkNoneDiag.Checked
                && !mh018014.Checked && mh018014.Enabled == true && !chkNoneDiag.Checked
                && !mh018015.Checked && mh018015.Enabled == true && !chkNoneDiag.Checked
                && !mh018016.Checked && mh018016.Enabled == true && !chkNoneDiag.Checked
                && !mh018077.Checked && mh018077.Enabled == true && !chkNoneDiag.Checked)
            {
                MessageBox.Show("Diagnosis in children is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mh018077.Checked && string.IsNullOrEmpty(mh018077x.Text))
            {
                MessageBox.Show("Others is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh018077x.Focus();
                return false;
            }
            else if (!mh01901.Checked && mh01901.Enabled == true && !chkNone.Checked
                && !mh01902.Checked && mh01902.Enabled == true && !chkNone.Checked
                && !mh01903.Checked && mh01903.Enabled == true && !chkNone.Checked
                && !mh01904.Checked && mh01904.Enabled == true && !chkNone.Checked
                && !mh01905.Checked && mh01905.Enabled == true && !chkNone.Checked
                && !mh01906.Checked && mh01906.Enabled == true && !chkNone.Checked
                && !mh01907.Checked && mh01907.Enabled == true && !chkNone.Checked
                && !mh01908.Checked && mh01908.Enabled == true && !chkNone.Checked
                && !mh01909.Checked && mh01909.Enabled == true && !chkNone.Checked
                && !mh019010.Checked && mh019010.Enabled == true && !chkNone.Checked
                && !mh019011.Checked && mh019011.Enabled == true && !chkNone.Checked
                && !mh019012.Checked && mh019012.Enabled == true && !chkNone.Checked
                && !mh019013.Checked && mh019013.Enabled == true && !chkNone.Checked
                && !mh019014.Checked && mh019014.Enabled == true && !chkNone.Checked
                && !mh019015.Checked && mh019015.Enabled == true && !chkNone.Checked
                && !mh019077.Checked && mh019077.Enabled == true && !chkNone.Checked
                )
            {
                MessageBox.Show("Medicines prescribed is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mh019077.Checked && string.IsNullOrEmpty(mh019077x.Text))
            {
                MessageBox.Show("Others is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh019077x.Focus();
                return false;
            }
            else if (!mh02001.Checked && mh02001.Enabled == true
                && !mh02002.Checked && mh02002.Enabled == true)
            {
                MessageBox.Show("Antenental care is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02101.Checked && mh02101.Enabled == true
                && !mh02102.Checked && mh02102.Enabled == true)
            {
                MessageBox.Show("Tetanus Vaccine administer is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02201.Checked && mh02201.Enabled == true
                && !mh02202.Checked && mh02202.Enabled == true)
            {
                MessageBox.Show("Ever received OPV is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02301.Checked && mh02301.Enabled == true
                && !mh02302.Checked && mh02302.Enabled == true)
            {
                MessageBox.Show("Ever received routine immunization is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02401.Checked && mh02401.Enabled == true
                && !mh02402.Checked && mh02402.Enabled == true)
            {
                MessageBox.Show("Vaccine card available is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02501.Checked && mh02501.Enabled == true
                && !mh02502.Checked && mh02502.Enabled == true)
            {
                MessageBox.Show("Received OPV in last campaign is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02601.Checked && mh02601.Enabled == true
                && !mh02602.Checked && mh02602.Enabled == true
                && !mh02603.Checked && mh02603.Enabled == true
                && !mh02604.Checked && mh02604.Enabled == true
                && !mh02605.Checked && mh02605.Enabled == true
                && !mh02606.Checked && mh02606.Enabled == true
                //&& !mh02607.Checked && mh02607.Enabled == true
                && !mh02608.Checked && mh02608.Enabled == true
                && !mh02609.Checked && mh02609.Enabled == true
                && !mh026010.Checked && mh026010.Enabled == true
                && !mh026011.Checked && mh026011.Enabled == true
                && !mh027b.Checked && mh027b.Enabled == true
                //&& !mh026013.Checked && mh026013.Enabled == true
                && !mh026014.Checked && mh026014.Enabled == true
                && !mh026015.Checked && mh026015.Enabled == true
                && !mh026016.Checked && mh026016.Enabled == true
                && !mh026017.Checked && mh026017.Enabled == true
                && !mh026018.Checked && mh026018.Enabled == true
                && !mh026019.Checked && mh026019.Enabled == true
                && !mh027a1.Checked && mh027a1.Enabled == true
                && !mh027a2.Checked && mh027a2.Enabled == true
                )
            {
                MessageBox.Show("Vaccination is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //else if (!mh027a1.Checked && mh027a1.Enabled == true
            //    && !mh027a2.Checked && mh027a2.Enabled == true)
            //{
            //    MessageBox.Show("OPV or Refused for OPV Vaccination is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            else if (!mh02701.Checked && mh02701.Enabled == true
                && !mh02702.Checked && mh02702.Enabled == true)
            {
                MessageBox.Show("Vaccination card issued is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02801.Checked && mh02801.Enabled == true
                && !mh02802.Checked && mh02802.Enabled == true)
            {
                MessageBox.Show("Referred is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02901.Checked && mh02901.Enabled == true
                && !mh02902.Checked && mh02902.Enabled == true)
            {
                MessageBox.Show("Signature / Consent is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }



            if (mh012.Text.Length != 5 && mh012.Enabled == true)
            {
                MessageBox.Show("Please enter complete weight in KG ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh012.Focus();
                return false;
            }


            if (mh015.Text.Length != 5 && mh015.Enabled == true)
            {
                MessageBox.Show("Please enter complete height ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh015.Focus();
                return false;
            }



            if (mh016.Text.Length != 5 && mh016.Enabled == true)
            {
                MessageBox.Show("Please enter complete MUAC ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh016.Focus();
                return false;
            }


            return true;
        }




        private bool ValidateForm()
        {

            if (string.IsNullOrEmpty(FORM_ID.Text))
            {
                MessageBox.Show("Form ID is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FORM_ID.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(mh07.Text))
            {
                MessageBox.Show("Patient's name is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh07.Focus();
                return false;
            }



            if (string.IsNullOrEmpty(mh08.Text))
            {
                MessageBox.Show("Father / Husband's name is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh08.Focus();
                return false;
            }



            if (string.IsNullOrEmpty(mh06.Text))
            {
                MessageBox.Show("Doctor's name is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh06.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(mh09y.Text))
            {
                MessageBox.Show("Age in years is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh09y.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(mh09m.Text))
            {
                MessageBox.Show("Age in months is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh09m.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(mh09d.Text))
            {
                MessageBox.Show("Age in days is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh09d.Focus();
                return false;
            }


            if (mh010.SelectedValue == "0")
            {
                MessageBox.Show("Gender is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh010.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(mh01101.Text))
            {
                MessageBox.Show("Presenting complaints is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh01101.Focus();
                return false;
            }
            else if (mh012.Text == "   ." && mh012.Enabled == true)
            {
                MessageBox.Show("Weight is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh012.Focus();
                return false;
            }
            else if (mh013.SelectedValue == "0" && mh013.Enabled == true)
            {
                MessageBox.Show("Pallor is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh013.Focus();
                return false;
            }
            else if (mh014.SelectedValue == "0" && mh014.Enabled == true)
            {
                MessageBox.Show("Hydration is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh014.Focus();
                return false;
            }
            else if (mh015.Text == "   ." && mh015.Enabled == true)
            {
                MessageBox.Show("Height/Length is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh015.Focus();
                return false;
            }
            else if (mh016.Text == "  ." && mh016.Enabled == true)
            {
                MessageBox.Show("MUAC is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh016.Focus();
                return false;
            }
            else if (!mh01701.Checked && mh01701.Enabled == true &&
                !mh01702.Checked && mh01702.Enabled == true &&
                !mh01703.Checked && mh01703.Enabled == true &&
                !mh01704.Checked && mh01704.Enabled == true &&
                !mh017077.Checked && mh017077.Enabled == true)
            {
                MessageBox.Show("Diagnosis in pregnant women / mothers ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mh017077.Checked && string.IsNullOrEmpty(mh017077x.Text))
            {
                MessageBox.Show("Others is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh017077x.Focus();
                return false;
            }
            else if (!mh01801.Checked && mh01801.Enabled == true && !chkNoneDiag.Checked
                && !mh01802.Checked && mh01802.Enabled == true && !chkNoneDiag.Checked
                && !mh01803.Checked && mh01803.Enabled == true && !chkNoneDiag.Checked
                && !mh01804.Checked && mh01804.Enabled == true && !chkNoneDiag.Checked
                && !mh01805.Checked && mh01805.Enabled == true && !chkNoneDiag.Checked
                && !mh01806.Checked && mh01806.Enabled == true && !chkNoneDiag.Checked
                && !mh01807.Checked && mh01807.Enabled == true && !chkNoneDiag.Checked
                && !mh01808.Checked && mh01808.Enabled == true && !chkNoneDiag.Checked
                && !mh01809.Checked && mh01809.Enabled == true && !chkNoneDiag.Checked
                && !mh018010.Checked && mh018010.Enabled == true && !chkNoneDiag.Checked
                && !mh018011.Checked && mh018011.Enabled == true && !chkNoneDiag.Checked
                && !mh018012.Checked && mh018012.Enabled == true && !chkNoneDiag.Checked
                && !mh018013.Checked && mh018013.Enabled == true && !chkNoneDiag.Checked
                && !mh018014.Checked && mh018014.Enabled == true && !chkNoneDiag.Checked
                && !mh018015.Checked && mh018015.Enabled == true && !chkNoneDiag.Checked
                && !mh018016.Checked && mh018016.Enabled == true && !chkNoneDiag.Checked
                && !mh018077.Checked && mh018077.Enabled == true && !chkNoneDiag.Checked)
            {
                MessageBox.Show("Diagnosis in children is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mh018077.Checked && string.IsNullOrEmpty(mh018077x.Text))
            {
                MessageBox.Show("Others is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh018077x.Focus();
                return false;
            }
            else if (!mh01901.Checked && mh01901.Enabled == true && !chkNone.Checked
                && !mh01902.Checked && mh01902.Enabled == true && !chkNone.Checked
                && !mh01903.Checked && mh01903.Enabled == true && !chkNone.Checked
                && !mh01904.Checked && mh01904.Enabled == true && !chkNone.Checked
                && !mh01905.Checked && mh01905.Enabled == true && !chkNone.Checked
                && !mh01906.Checked && mh01906.Enabled == true && !chkNone.Checked
                && !mh01907.Checked && mh01907.Enabled == true && !chkNone.Checked
                && !mh01908.Checked && mh01908.Enabled == true && !chkNone.Checked
                && !mh01909.Checked && mh01909.Enabled == true && !chkNone.Checked
                && !mh019010.Checked && mh019010.Enabled == true && !chkNone.Checked
                && !mh019011.Checked && mh019011.Enabled == true && !chkNone.Checked
                && !mh019012.Checked && mh019012.Enabled == true && !chkNone.Checked
                && !mh019013.Checked && mh019013.Enabled == true && !chkNone.Checked
                && !mh019014.Checked && mh019014.Enabled == true && !chkNone.Checked
                && !mh019015.Checked && mh019015.Enabled == true && !chkNone.Checked
                && !mh019077.Checked && mh019077.Enabled == true && !chkNone.Checked
                )
            {
                MessageBox.Show("Medicines prescribed is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mh019077.Checked && string.IsNullOrEmpty(mh019077x.Text))
            {
                MessageBox.Show("Others is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mh019077x.Focus();
                return false;
            }
            else if (!mh02001.Checked && mh02001.Enabled == true
                && !mh02002.Checked && mh02002.Enabled == true)
            {
                MessageBox.Show("Antenental care is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02101.Checked && mh02101.Enabled == true
                && !mh02102.Checked && mh02102.Enabled == true)
            {
                MessageBox.Show("Tetanus Vaccine administer is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02201.Checked && mh02201.Enabled == true
                && !mh02202.Checked && mh02202.Enabled == true)
            {
                MessageBox.Show("Ever received OPV is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02301.Checked && mh02301.Enabled == true
                && !mh02302.Checked && mh02302.Enabled == true)
            {
                MessageBox.Show("Ever received routine immunization is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02401.Checked && mh02401.Enabled == true
                && !mh02402.Checked && mh02402.Enabled == true)
            {
                MessageBox.Show("Vaccine card available is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02501.Checked && mh02501.Enabled == true
                && !mh02502.Checked && mh02502.Enabled == true)
            {
                MessageBox.Show("Received OPV in last campaign is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02601.Checked && mh02601.Enabled == true
                && !mh02602.Checked && mh02602.Enabled == true
                && !mh02603.Checked && mh02603.Enabled == true
                && !mh02604.Checked && mh02604.Enabled == true
                && !mh02605.Checked && mh02605.Enabled == true
                && !mh02606.Checked && mh02606.Enabled == true
                //&& !mh02607.Checked && mh02607.Enabled == true
                && !mh02608.Checked && mh02608.Enabled == true
                && !mh02609.Checked && mh02609.Enabled == true
                && !mh026010.Checked && mh026010.Enabled == true
                && !mh026011.Checked && mh026011.Enabled == true
                && !mh027b.Checked && mh027b.Enabled == true
                //&& !mh026013.Checked && mh026013.Enabled == true
                && !mh026014.Checked && mh026014.Enabled == true
                && !mh026015.Checked && mh026015.Enabled == true
                && !mh026016.Checked && mh026016.Enabled == true
                && !mh026017.Checked && mh026017.Enabled == true
                && !mh026018.Checked && mh026018.Enabled == true
                && !mh026019.Checked && mh026019.Enabled == true
                && !mh027a1.Checked && mh027a1.Enabled == true
                && !mh027a2.Checked && mh027a2.Enabled == true
                && !chkVaccination.Checked && chkVaccination.Enabled == true
                )
            {
                MessageBox.Show("Vaccination is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //else if (!mh027a1.Checked && mh027a1.Enabled == true
            //    && !mh027a2.Checked && mh027a2.Enabled == true)
            //{
            //    MessageBox.Show("OPV or Refused for OPV Vaccination is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            else if (!mh02701.Checked && mh02701.Enabled == true
                && !mh02702.Checked && mh02702.Enabled == true)
            {
                MessageBox.Show("Vaccination card issued is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02801.Checked && mh02801.Enabled == true
                && !mh02802.Checked && mh02802.Enabled == true)
            {
                MessageBox.Show("Referred is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!mh02901.Checked && mh02901.Enabled == true
                && !mh02902.Checked && mh02902.Enabled == true)
            {
                MessageBox.Show("Signature / Consent is required ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }



            if (mh012.Text.Length != 5 && mh012.Enabled == true)
            {
                MessageBox.Show("Please enter complete weight in KG ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh012.Focus();
                return false;
            }


            if (mh015.Text.Length != 5 && mh015.Enabled == true)
            {
                MessageBox.Show("Please enter complete height ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh015.Focus();
                return false;
            }



            if (mh016.Text.Length != 5 && mh016.Enabled == true)
            {
                MessageBox.Show("Please enter complete MUAC ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh016.Focus();
                return false;
            }


            return true;
        }



        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (SaveData_Detail() == true)
            {
                ClearForm();
                GetTotalForms();

                FORM_ID.Focus();

                mh02.Enabled = false;

                cmdSave.Location = new System.Drawing.Point(751, 74);
                cmdNewID.Location = new System.Drawing.Point(751, 118);
            }

        }




        private void SaveData_Master()
        {

            CDBOperations obj_op = null;
            string[] my_dt;

            try
            {

                my_dt = DateTime.Now.Date.ToString().Split('/');

                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                DateTime dt_mh01 = new DateTime();

                if (mh01.Text != "  /  /")
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                    dt_mh01 = Convert.ToDateTime(mh01.Text);
                }


                string[] fldname = { "" };
                string[] fldvalue = { "" };


                //string[] fldname = { };
                //string[] fldvalue = { FORM_ID.Text, dt_mh01.ToShortDateString(), mh02.Text, mh03.Text, mh04.Text, mh05.Text };


                string qry = "INSERT INTO camp_patient (form_id, mh01, mh02, mh03, mh04, mh05, dist_id, uccode, userid, entrydate) values " +
                    "('" + FORM_ID.Text + "', '" + dt_mh01.ToShortDateString() + "', '" + mh02.Text + "', '" + mh03.Text + "', '" + mh04.Text + "', '" + mh05.Text + "', '" + CVariables.dist_id + "', '" + CVariables.uc_code + "', '" + CVariables.UserName + "', '" + EntryDate.ToShortDateString() + "')";


                obj_op = new CDBOperations();
                obj_op.ExecuteNonQuery_Casi(fldname, fldvalue, qry);

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




        private bool SaveData_Detail()
        {

            bool IsSaved = false;

            string var_chkWeight = "";
            string var_chkHeight = "";
            string var_chkMUAC = "";


            string var_mh01701 = "";
            string var_mh01702 = "";
            string var_mh01703 = "";
            string var_mh017077 = "";
            string var_mh01704 = "";



            string var_mh01801 = "";
            string var_mh01802 = "";
            string var_mh01803 = "";
            string var_mh01804 = "";
            string var_mh01805 = "";
            string var_mh01806 = "";
            string var_mh01807 = "";
            string var_mh01808 = "";
            string var_mh01809 = "";
            string var_mh018010 = "";
            string var_mh018011 = "";
            string var_mh018012 = "";
            string var_mh018013 = "";
            string var_mh018014 = "";
            string var_mh018015 = "";
            string var_mh018016 = "";
            string var_mh018077 = "";




            string var_mh01901 = "";
            string var_mh01902 = "";
            string var_mh01903 = "";
            string var_mh01904 = "";
            string var_mh01905 = "";
            string var_mh01906 = "";
            string var_mh01907 = "";
            string var_mh01908 = "";
            string var_mh01909 = "";
            string var_mh019010 = "";
            string var_mh019011 = "";
            string var_mh019012 = "";
            string var_mh019013 = "";
            string var_mh019014 = "";
            string var_mh019015 = "";
            string var_mh019077 = "";



            string var_mh020 = "";
            string var_mh021 = "";
            string var_mh022 = "";
            string var_mh023 = "";
            string var_mh024 = "";
            string var_mh025 = "";
            string var_mh027 = "";
            string var_mh028 = "";
            string var_mh029 = "";



            string var_mh02601 = "";
            string var_mh02602 = "";
            string var_mh02603 = "";
            string var_mh02604 = "";
            string var_mh02605 = "";
            string var_mh02606 = "";
            string var_mh02607 = "";
            string var_mh02608 = "";
            string var_mh02609 = "";
            string var_mh026010 = "";
            string var_mh026011 = "";
            string var_mh026012 = "";
            string var_mh026013 = "";
            string var_mh026014 = "";
            string var_mh026015 = "";
            string var_mh026016 = "";
            string var_mh026017 = "";
            string var_mh026018 = "";
            string var_mh026019 = "";


            string val_chkWeight = "";
            string val_chkHeight = "";
            string val_chkMUAC = "";



            if (ValidateForm() == false)
            {
                return false;
            }


            if (chkWeight.Checked)
            {
                var_chkWeight = "1";
            }
            else
            {
                var_chkWeight = "0";
            }



            if (mh012.Text == "   .")
            {
                val_chkWeight = DBNull.Value.ToString();
            }
            else
            {
                val_chkWeight = mh012.Text;
            }



            if (chkHeight.Checked)
            {
                var_chkHeight = "1";
            }
            else
            {
                var_chkHeight = "0";
            }



            if (mh015.Text == "   .")
            {
                val_chkHeight = DBNull.Value.ToString();
            }
            else
            {
                val_chkHeight = mh015.Text;
            }



            if (chkMUAC.Checked)
            {
                var_chkMUAC = "1";
            }
            else
            {
                var_chkMUAC = "0";
            }



            if (mh016.Text == "  .")
            {
                val_chkMUAC = DBNull.Value.ToString();
            }
            else
            {
                val_chkMUAC = mh016.Text;
            }



            if (mh01701.Checked == true && mh01701.Enabled == true)
            {
                var_mh01701 = "1";
            }


            if (mh01702.Checked == true && mh01702.Enabled == true)
            {
                var_mh01702 = "2";
            }


            if (mh01703.Checked == true && mh01703.Enabled == true)
            {
                var_mh01703 = "3";
            }


            if (mh01704.Checked == true && mh01704.Enabled == true)
            {
                var_mh01704 = "4";
            }


            if (mh017077.Checked == true && mh017077.Enabled == true)
            {
                var_mh017077 = "77";
            }






            if (mh01801.Checked == true && mh01801.Enabled == true)
            {
                var_mh01801 = "1";
            }

            if (mh01802.Checked == true && mh01802.Enabled == true)
            {
                var_mh01802 = "2";
            }

            if (mh01803.Checked == true && mh01803.Enabled == true)
            {
                var_mh01803 = "3";
            }

            if (mh01804.Checked == true && mh01804.Enabled == true)
            {
                var_mh01804 = "4";
            }

            if (mh01805.Checked == true && mh01805.Enabled == true)
            {
                var_mh01805 = "5";
            }

            if (mh01806.Checked == true && mh01806.Enabled == true)
            {
                var_mh01806 = "6";
            }

            if (mh01807.Checked == true && mh01807.Enabled == true)
            {
                var_mh01807 = "7";
            }

            if (mh01808.Checked == true && mh01808.Enabled == true)
            {
                var_mh01808 = "8";
            }

            if (mh01809.Checked == true && mh01809.Enabled == true)
            {
                var_mh01809 = "9";
            }


            if (mh018010.Checked == true && mh018010.Enabled == true)
            {
                var_mh018010 = "10";
            }


            if (mh018011.Checked == true && mh018011.Enabled == true)
            {
                var_mh018011 = "11";
            }


            if (mh018012.Checked == true && mh018012.Enabled == true)
            {
                var_mh018012 = "12";
            }


            if (mh018013.Checked == true && mh018013.Enabled == true)
            {
                var_mh018013 = "13";
            }


            if (mh018014.Checked == true && mh018014.Enabled == true)
            {
                var_mh018014 = "14";
            }


            if (mh018015.Checked == true && mh018015.Enabled == true)
            {
                var_mh018015 = "15";
            }


            if (mh018016.Checked == true && mh018016.Enabled == true)
            {
                var_mh018016 = "16";
            }


            if (mh018077.Checked == true && mh018077.Enabled == true)
            {
                var_mh018077 = "77";
            }





            if (mh01901.Checked == true && mh01901.Enabled == true)
            {
                var_mh01901 = "1";
            }

            if (mh01902.Checked == true && mh01902.Enabled == true)
            {
                var_mh01902 = "2";
            }

            if (mh01903.Checked == true && mh01903.Enabled == true)
            {
                var_mh01903 = "3";
            }

            if (mh01904.Checked == true && mh01904.Enabled == true)
            {
                var_mh01904 = "4";
            }

            if (mh01905.Checked == true && mh01905.Enabled == true)
            {
                var_mh01905 = "5";
            }

            if (mh01906.Checked == true && mh01906.Enabled == true)
            {
                var_mh01906 = "6";
            }

            if (mh01907.Checked == true && mh01907.Enabled == true)
            {
                var_mh01907 = "7";
            }

            if (mh01908.Checked == true && mh01908.Enabled == true)
            {
                var_mh01908 = "8";
            }

            if (mh01909.Checked == true && mh01909.Enabled == true)
            {
                var_mh01909 = "9";
            }


            if (mh019010.Checked == true && mh019010.Enabled == true)
            {
                var_mh019010 = "10";
            }


            if (mh019011.Checked == true && mh019011.Enabled == true)
            {
                var_mh019011 = "11";
            }


            if (mh019012.Checked == true && mh019012.Enabled == true)
            {
                var_mh019012 = "12";
            }


            if (mh019013.Checked == true && mh019013.Enabled == true)
            {
                var_mh019013 = "13";
            }


            if (mh019014.Checked == true && mh019014.Enabled == true)
            {
                var_mh019014 = "14";
            }


            if (mh019015.Checked == true && mh019015.Enabled == true)
            {
                var_mh019015 = "15";
            }


            if (mh019077.Checked == true && mh019077.Enabled == true)
            {
                var_mh019077 = "77";
            }





            if (mh02001.Checked == true && mh02001.Enabled == true)
            {
                var_mh020 = "1";
            }

            if (mh02002.Checked == true && mh02002.Enabled == true)
            {
                var_mh020 = "2";
            }



            if (mh02101.Checked == true && mh02101.Enabled == true)
            {
                var_mh021 = "1";
            }


            if (mh02102.Checked == true && mh02102.Enabled == true)
            {
                var_mh021 = "2";
            }



            if (mh02201.Checked == true && mh02201.Enabled == true)
            {
                var_mh022 = "1";
            }


            if (mh02202.Checked == true && mh02202.Enabled == true)
            {
                var_mh022 = "2";
            }




            if (mh02301.Checked == true && mh02301.Enabled == true)
            {
                var_mh023 = "1";
            }


            if (mh02302.Checked == true && mh02302.Enabled == true)
            {
                var_mh023 = "2";
            }




            if (mh02401.Checked == true && mh02401.Enabled == true)
            {
                var_mh024 = "1";
            }


            if (mh02402.Checked == true && mh02402.Enabled == true)
            {
                var_mh024 = "2";
            }



            if (mh02501.Checked == true && mh02501.Enabled == true)
            {
                var_mh025 = "1";
            }



            if (mh02502.Checked == true && mh02502.Enabled == true)
            {
                var_mh025 = "2";
            }



            if (mh02701.Checked == true && mh02701.Enabled == true)
            {
                var_mh027 = "1";
            }



            if (mh02702.Checked == true && mh02702.Enabled == true)
            {
                var_mh027 = "2";
            }



            if (mh02801.Checked == true && mh02801.Enabled == true)
            {
                var_mh028 = "1";
            }


            if (mh02802.Checked == true && mh02802.Enabled == true)
            {
                var_mh028 = "2";
            }




            if (mh02901.Checked == true && mh02901.Enabled == true)
            {
                var_mh029 = "1";
            }



            if (mh02902.Checked == true && mh02902.Enabled == true)
            {
                var_mh029 = "2";
            }




            if (mh027b.Checked == false)
            {

                if (mh02601.Checked == true)
                {
                    var_mh02601 = "1";
                }

                if (mh02602.Checked == true)
                {
                    var_mh02602 = "2";
                }

                if (mh02603.Checked == true)
                {
                    var_mh02603 = "3";
                }

                if (mh02604.Checked == true)
                {
                    var_mh02604 = "4";
                }

                if (mh02605.Checked == true)
                {
                    var_mh02605 = "5";
                }

                if (mh02606.Checked == true)
                {
                    var_mh02606 = "6";
                }




                if (mh02608.Checked == true)
                {
                    var_mh02608 = "8";
                }

                if (mh02609.Checked == true)
                {
                    var_mh02609 = "9";
                }


                if (mh026010.Checked == true)
                {
                    var_mh026010 = "10";
                }


                if (mh026011.Checked == true)
                {
                    var_mh026011 = "11";
                }






                if (mh026014.Checked == true)
                {
                    var_mh026014 = "14";
                }


                if (mh026015.Checked == true)
                {
                    var_mh026015 = "15";
                }


                if (mh026016.Checked == true)
                {
                    var_mh026016 = "16";
                }


                if (mh026017.Checked == true)
                {
                    var_mh026017 = "17";
                }


                if (mh026018.Checked == true)
                {
                    var_mh026018 = "18";
                }


                if (mh026019.Checked == true)
                {
                    var_mh026019 = "19";
                }


            }


            string var_chknone = "";

            if (chkNone.Checked == true)
            {
                var_chknone = "1";
            }



            string var_chkNoneDiag = "";

            if (chkNoneDiag.Checked == true)
            {
                var_chkNoneDiag = "1";
            }



            string var_mh027b = "";


            if (mh027b.Checked == true)
            {
                var_mh027b = "1";
            }


            string var_mh027a1 = "";


            if (mh027a1.Checked == true)
            {
                var_mh027a1 = "1";
            }
            else if (mh027a2.Checked == true)
            {
                var_mh027a1 = "2";
            }


            string var_chkVaccination = "";


            if (chkVaccination.Checked)
            {
                var_chkVaccination = "1";
            }



            CDBOperations obj_op = null;
            string[] my_dt;

            try
            {

                string masterid = IsMHSID_FormID_Exists_InMaster();


                if (masterid == "")
                {
                    SaveData_Master();
                }


                masterid = IsMHSID_FormID_Exists_InMaster();


                //GetMasterID();


                my_dt = DateTime.Now.Date.ToString().Split('/');

                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                DateTime dt_mh01 = new DateTime();

                if (mh01.Text != "  /  /")
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                    dt_mh01 = Convert.ToDateTime(mh01.Text);
                }


                string[] fldname = { "" };
                string[] fldvalue = { "" };


                //string[] fldname = { "mh01", "mh02", "mh03", "mh04", "mh05", "mh06", "mh07", "mh08", "mh09y", "mh09m", "mh09d", "mh010", "mh011", "mh012", "chkWeight", "mh013", "mh014", "mh015", "chkHeight", "mh016", "chkMUAC", "mh01701", "mh01702", "mh01703", "mh017077", "mh017077x", "mh01801", "mh01802", "mh01803", "mh01804", "mh01805", "mh01806", "mh01807", "mh01808", "mh01809", "mh018010", "mh018011", "mh018012", "mh018013", "mh018014", "mh018015", "mh018016", "mh018077", "mh018077x", "mh01901", "mh01902", "mh01903", "mh01904", "mh01905", "mh01906", "mh01907", "mh01908", "mh01909", "mh019010", "mh019011", "mh019012", "mh019013", "mh019014", "mh019015", "mh019077", "mh019077x", "mh020", "mh021", "mh022", "mh023", "mh024", "mh025", "mh02601", "mh02602", "mh02603", "mh02604", "mh02605", "mh02606", "mh02607", "mh02608", "mh02609", "mh026010", "mh026011", "mh026012", "mh026013", "mh026014", "mh026015", "mh026016", "mh026017", "mh026018", "mh026019", "mh027", "mh028", "mh029" };
                //string[] fldvalue = { dt_mh01.ToShortDateString(), mh02.Text, mh03.Text, mh04.Text, mh05.Text, mh06.SelectedValue.ToString(), mh07.Text, mh08.Text, mh09y.Text, mh09m.Text, mh09d.Text, mh010.SelectedValue.ToString(), mh011.Text, mh012.Text, var_chkWeight, mh013.SelectedValue.ToString(), mh014.SelectedValue.ToString(), mh015.Text, var_chkHeight, mh016.Text, var_chkMUAC, var_mh01701, var_mh01702, var_mh01703, var_mh017077, mh017077x.Text, var_mh01801, var_mh01802, var_mh01803, var_mh01804, var_mh01805, var_mh01806, var_mh01807, var_mh01808, var_mh01809, var_mh018010, var_mh018011, var_mh018012, var_mh018013, var_mh018014, var_mh018015, var_mh018016, var_mh018077, mh018077x.Text, var_mh01901, var_mh01902, var_mh01903, var_mh01904, var_mh01905, var_mh01906, var_mh01907, var_mh01908, var_mh01909, var_mh019010, var_mh019011, var_mh019012, var_mh019013, var_mh019014, var_mh019015, var_mh019077, mh019077x.Text, var_mh020, var_mh021, var_mh022, var_mh023, var_mh024, var_mh025, var_mh02601, var_mh02602, var_mh02603, var_mh02604, var_mh02605, var_mh02606, var_mh02607, var_mh02608, var_mh02609, var_mh026010, var_mh026011, var_mh026012, var_mh026013, var_mh026014, var_mh026015, var_mh026016, var_mh026017, var_mh026018, var_mh026019, var_mh027, var_mh028, var_mh029 };



                //string[] fldname = { "mh01", "mh02", "mh06", "mh07", "mh08", "mh09y", "mh09m", "mh09d", "mh010", "mh011", "mh012", "chkWeight", "mh013", "mh014", "mh015", "chkHeight", "mh016", "chkMUAC", "mh01701", "mh01702", "mh01703", "mh017077", "mh017077x", "mh01801", "mh01802", "mh01803", "mh01804", "mh01805", "mh01806", "mh01807", "mh01808", "mh01809", "mh018010", "mh018011", "mh018012", "mh018013", "mh018014", "mh018015", "mh018016", "mh018077", "mh018077x", "mh01901", "mh01902", "mh01903", "mh01904", "mh01905", "mh01906", "mh01907", "mh01908", "mh01909", "mh019010", "mh019011", "mh019012", "mh019013", "mh019014", "mh019015", "mh019077", "mh019077x", "mh020", "mh021", "mh022", "mh023", "mh024", "mh025", "mh02601", "mh02602", "mh02603", "mh02604", "mh02605", "mh02606", "mh02607", "mh02608", "mh02609", "mh026010", "mh026011", "mh026012", "mh026013", "mh026014", "mh026015", "mh026016", "mh026017", "mh026018", "mh026019", "mh027", "mh028", "mh029" };
                //string[] fldvalue = { dt_mh01.ToShortDateString(), mh02.Text, mh06.SelectedValue.ToString(), mh07.Text, mh08.Text, mh09y.Text, mh09m.Text, mh09d.Text, mh010.SelectedValue.ToString(), mh011.Text.Replace('\n', ' '), mh012.Text, var_chkWeight, mh013.SelectedValue.ToString(), mh014.SelectedValue.ToString(), mh015.Text, var_chkHeight, mh016.Text, var_chkMUAC, var_mh01701, var_mh01702, var_mh01703, var_mh017077, mh017077x.Text, var_mh01801, var_mh01802, var_mh01803, var_mh01804, var_mh01805, var_mh01806, var_mh01807, var_mh01808, var_mh01809, var_mh018010, var_mh018011, var_mh018012, var_mh018013, var_mh018014, var_mh018015, var_mh018016, var_mh018077, mh018077x.Text, var_mh01901, var_mh01902, var_mh01903, var_mh01904, var_mh01905, var_mh01906, var_mh01907, var_mh01908, var_mh01909, var_mh019010, var_mh019011, var_mh019012, var_mh019013, var_mh019014, var_mh019015, var_mh019077, mh019077x.Text, var_mh020, var_mh021, var_mh022, var_mh023, var_mh024, var_mh025, var_mh02601, var_mh02602, var_mh02603, var_mh02604, var_mh02605, var_mh02606, var_mh02607, var_mh02608, var_mh02609, var_mh026010, var_mh026011, var_mh026012, var_mh026013, var_mh026014, var_mh026015, var_mh026016, var_mh026017, var_mh026018, var_mh026019, var_mh027, var_mh028, var_mh029 };


                //string qry = "INSERT INTO camp_patient_dtl (" + fldname + ") values ('" + fldvalue + "')";


                //string qry = "INSERT INTO camp_patient_dtl (mh01, mh02, mh06, mh07, mh08, mh09y, mh09m, mh09d, mh010, mh011, mh012, chkWeight, mh013, mh014, mh015, chkHeight, mh016, chkMUAC, mh01701, mh01702, mh01703, mh017077, mh017077x, mh01801, mh01802, mh01803, mh01804, mh01805, mh01806, mh01807, mh01808, mh01809, mh018010, mh018011, mh018012, mh018013, mh018014, mh018015, mh018016, mh018077, mh018077x, mh01901, mh01902, mh01903, mh01904, mh01905, mh01906, mh01907, mh01908, mh01909, mh019010, mh019011, mh019012, mh019013, mh019014, mh019015, mh019077, mh019077x, mh020, mh021, mh022, mh023, mh024, mh025, mh02601, mh02602, mh02603, mh02604, mh02605, mh02606, mh02607, mh02608, mh02609, mh026010, mh026011, mh026012, mh026013, mh026014, mh026015, mh026016, mh026017, mh026018, mh026019, mh027, mh028, mh029, dist_id, uccode) values ('" + dt_mh01.ToShortDateString() + "', '" + mh02.Text + "', '" + mh06.SelectedValue.ToString() + "', '" + mh07.Text + "', '" + mh08.Text + "', '" + mh09y.Text + "', '" + mh09m.Text + "', '" + mh09d.Text + "', '" + mh010.SelectedValue.ToString() + "', '" + mh01101.Text.Replace('\n', ' ') + "', '" + val_chkWeight + "', '" + var_chkWeight + "', '" + mh013.SelectedValue.ToString() + "', '" + mh014.SelectedValue.ToString() + "', '" + val_chkHeight + "', '" + var_chkHeight + "', '" + val_chkMUAC + "', '" + var_chkMUAC + "', '" + var_mh01701 + "', '" + var_mh01702 + "', '" + var_mh01703 + "', '" + var_mh017077 + "', '" + mh017077x.Text + "', '" + var_mh01801 + "', '" + var_mh01802 + "', '" + var_mh01803 + "', '" + var_mh01804 + "', '" + var_mh01805 + "', '" + var_mh01806 + "', '" + var_mh01807 + "', '" + var_mh01808 + "', '" + var_mh01809 + "', '" + var_mh018010 + "', '" + var_mh018011 + "', '" + var_mh018012 + "', '" + var_mh018013 + "', '" + var_mh018014 + "', '" + var_mh018015 + "', '" + var_mh018016 + "', '" + var_mh018077 + "', '" + mh018077x.Text + "', '" + var_mh01901 + "', '" + var_mh01902 + "', '" + var_mh01903 + "', '" + var_mh01904 + "', '" + var_mh01905 + "', '" + var_mh01906 + "', '" + var_mh01907 + "', '" + var_mh01908 + "', '" + var_mh01909 + "', '" + var_mh019010 + "', '" + var_mh019011 + "', '" + var_mh019012 + "', '" + var_mh019013 + "', '" + var_mh019014 + "', '" + var_mh019015 + "', '" + var_mh019077 + "', '" + mh019077x.Text + "', '" + var_mh020 + "', '" + var_mh021 + "', '" + var_mh022 + "', '" + var_mh023 + "', '" + var_mh024 + "', '" + var_mh025 + "', '" + var_mh02601 + "', '" + var_mh02602 + "', '" + var_mh02603 + "', '" + var_mh02604 + "', '" + var_mh02605 + "', '" + var_mh02606 + "', '" + var_mh02607 + "', '" + var_mh02608 + "', '" + var_mh02609 + "', '" + var_mh026010 + "', '" + var_mh026011 + "', '" + var_mh026012 + "', '" + var_mh026013 + "', '" + var_mh026014 + "', '" + var_mh026015 + "', '" + var_mh026016 + "', '" + var_mh026017 + "', '" + var_mh026018 + "', '" + var_mh026019 + "', '" + var_mh027 + "', '" + var_mh028 + "', '" + var_mh029 + "', '" + CVariables.dist_id + "', '" + CVariables.uc_code + "')";


                string qry = "INSERT INTO camp_patient_dtl (master_id, FORM_ID, mh01, mh02, mh06, mh07, mh08, mh09y, mh09m, mh09d, mh010, mh01101, mh01102, mh01103, mh012, chkWeight, mh013, mh014, mh015, chkHeight, mh016, chkMUAC, mh01701, mh01702, mh01703, mh01704, mh017077, mh017077x, mh01801, mh01802, mh01803, mh01804, mh01805, mh01806, mh01807, mh01808, mh01809, mh018010, mh018011, mh018012, mh018013, mh018014, mh018015, mh018016, mh018077, mh018077x, mh01901, mh01902, mh01903, mh01904, mh01905, mh01906, mh01907, mh01908, mh01909, mh019010, mh019011, mh019012, mh019013, mh019014, mh019015, mh019077, mh019077x, mh020, mh021, mh022, mh023, mh024, mh025, mh02601, mh02602, mh02603, mh02604, mh02605, mh02606, mh02607, mh02608, mh02609, mh026010, mh026011, mh026012, mh026013, mh026014, mh026015, mh026016, mh026017, mh026018, mh026019, mh027, mh028, mh029, dist_id, uccode, mh027a, mh027b, chknone, entrydate, userid, chkNoneDiag, chkVaccination) values " +
                    "('" + masterid + "', '" + FORM_ID.Text + "', '" + dt_mh01.ToShortDateString() + "', '" + mh02.Text + "', '" + mh06.SelectedValue.ToString() + "', '" + mh07.Text + "', '" + mh08.Text + "', '" + mh09y.Text + "', '" + mh09m.Text + "', '" + mh09d.Text + "', '" + mh010.SelectedValue.ToString() + "', '" + mh01101.Text.Replace('\n', ' ') + "', '" + mh01102.Text.Replace('\n', ' ') + "', '" + mh01103.Text.Replace('\n', ' ') + "', '" + val_chkWeight + "', '" + var_chkWeight + "', '" + mh013.SelectedValue.ToString() + "', '" + mh014.SelectedValue.ToString() + "', '" + val_chkHeight + "', '" + var_chkHeight + "', '" + val_chkMUAC + "', '" + var_chkMUAC + "', '" + var_mh01701 + "', '" + var_mh01702 + "', '" + var_mh01703 + "', '" + var_mh01704 + "', '" + var_mh017077 + "', '" + mh017077x.Text + "', '" + var_mh01801 + "', '" + var_mh01802 + "', '" + var_mh01803 + "', '" + var_mh01804 + "', '" + var_mh01805 + "', '" + var_mh01806 + "', '" + var_mh01807 + "', '" + var_mh01808 + "', '" + var_mh01809 + "', '" + var_mh018010 + "', '" + var_mh018011 + "', '" + var_mh018012 + "', '" + var_mh018013 + "', '" + var_mh018014 + "', '" + var_mh018015 + "', '" + var_mh018016 + "', '" + var_mh018077 + "', '" + mh018077x.Text + "', '" + var_mh01901 + "', '" + var_mh01902 + "', '" + var_mh01903 + "', '" + var_mh01904 + "', '" + var_mh01905 + "', '" + var_mh01906 + "', '" + var_mh01907 + "', '" + var_mh01908 + "', '" + var_mh01909 + "', '" + var_mh019010 + "', '" + var_mh019011 + "', '" + var_mh019012 + "', '" + var_mh019013 + "', '" + var_mh019014 + "', '" + var_mh019015 + "', '" + var_mh019077 + "', '" + mh019077x.Text + "', '" + var_mh020 + "', '" + var_mh021 + "', '" + var_mh022 + "', '" + var_mh023 + "', '" + var_mh024 + "', '" + var_mh025 + "', '" + var_mh02601 + "', '" + var_mh02602 + "', '" + var_mh02603 + "', '" + var_mh02604 + "', '" + var_mh02605 + "', '" + var_mh02606 + "', '" + var_mh02607 + "', '" + var_mh02608 + "', '" + var_mh02609 + "', '" + var_mh026010 + "', '" + var_mh026011 + "', '" + var_mh026012 + "', '" + var_mh026013 + "', '" + var_mh026014 + "', '" + var_mh026015 + "', '" + var_mh026016 + "', '" + var_mh026017 + "', '" + var_mh026018 + "', '" + var_mh026019 + "', '" + var_mh027 + "', '" + var_mh028 + "', '" + var_mh029 + "', '" + CVariables.dist_id + "', '" + CVariables.uc_code + "', '" + var_mh027a1 + "', '" + var_mh027b + "', '" + var_chknone + "', '" + EntryDate.ToShortDateString() + "', '" + CVariables.UserName + "', '" + var_chkNoneDiag + "', '" + var_chkVaccination + "')";



                obj_op = new CDBOperations();
                obj_op.ExecuteNonQuery_Casi(fldname, fldvalue, qry);

                IsSaved = true;

                //vScrollBar1.Value = 0;

                MessageBox.Show("Record saved successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return IsSaved;

        }


        private void frmMSH_Load(object sender, EventArgs e)
        {
            this.Text = CVariables.AppName1 + " (Mobile Health Service Form)";

            GetTotalForms();

            //getTown();
            //getUC();
            getGender();
            getPallor();
            getHydration();
        }


        private void GetTotalForms()
        {
            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select count(*) count1 from camp_patient_dtl", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


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



        private void GetMasterID()
        {
            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select seq from sqlite_sequence where name=\"\"camp_patient_dtl\"", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["seq"].ToString() == "0")
                        {
                            CVariables.seq_master_id = "0";
                        }
                        else
                        {
                            CVariables.seq_master_id = ds.Tables[0].Rows[0]["count1"].ToString();
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



        //private void getTown()
        //{
        //    Dictionary<string, string> comboSource = new Dictionary<string, string>();
        //    comboSource.Add("0", "Select Town");
        //    comboSource.Add("1", "Town 1");

        //    mh03.DataSource = new BindingSource(comboSource, null);
        //    mh03.DisplayMember = "Value";
        //    mh03.ValueMember = "Key";

        //}


        private void getPallor()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Select Pallor");
            comboSource.Add("1", "Positive");
            comboSource.Add("2", "Negative");

            mh013.DataSource = new BindingSource(comboSource, null);
            mh013.DisplayMember = "Value";
            mh013.ValueMember = "Key";

        }


        private void getHydration()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Select Hydration");
            comboSource.Add("1", "Adequate");
            comboSource.Add("2", "Inadequate");

            mh014.DataSource = new BindingSource(comboSource, null);
            mh014.DisplayMember = "Value";
            mh014.ValueMember = "Key";

        }



        //private void getUC()
        //{
        //    Dictionary<string, string> comboSource = new Dictionary<string, string>();
        //    comboSource.Add("0", "Select UC");
        //    comboSource.Add("1", "UC 1");

        //    mh04.DataSource = new BindingSource(comboSource, null);
        //    mh04.DisplayMember = "Value";
        //    mh04.ValueMember = "Key";

        //}



        private void getGender()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("0", "Select Gender");
            comboSource.Add("1", "Male");
            comboSource.Add("2", "Female");

            mh010.DataSource = new BindingSource(comboSource, null);
            mh010.DisplayMember = "Value";
            mh010.ValueMember = "Key";

        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //if (vScrollBar1.Value > 0)
            //{
            //    vScrollBar1.Value = 0;
            //}
            //else
            //{
            //    vScrollBar1.Value = 400;
            //}
        }

        private void frmMSHIMG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmMSHIMG_Shown(object sender, EventArgs e)
        {
            mh02.Focus();
        }

        private void mh017077_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (mh017077.Checked == true)
            {
                obj_op.EnableControls(mh017077x);
                mh017077x.Focus();
            }
            else
            {
                obj_op.DisableControls(mh017077x);
            }
        }

        private void mh018077_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (mh018077.Checked == true)
            {
                obj_op.EnableControls(mh018077x);
                mh018077x.Focus();
            }
            else
            {
                obj_op.DisableControls(mh018077x);
            }
        }

        private void mh019077_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (mh019077.Checked == true)
            {
                mycheck(mh019015);

                obj_op.EnableControls(mh019077x);
                mh019077x.Focus();
            }
            else
            {
                obj_op.DisableControls(mh019077x);
            }
        }

        private void chkPW_CheckedChanged(object sender, EventArgs e)
        {

            //CDBOperations obj_op = new CDBOperations();


            //if (!string.IsNullOrEmpty(mh09y.Text) && chkPW.Checked == true)
            //{
            //    if (chkPW.Checked == true && mh010.SelectedValue.ToString() == "2" && Convert.ToInt32(mh09y.Text) >= 14 && Convert.ToInt32(mh09y.Text) <= 49)
            //    {
            //        obj_op.EnableControls(mh01703);
            //        obj_op.EnableControls(mh017077);
            //    }
            //    else
            //    {
            //        MessageBox.Show("This checkbox only be checked if the woman age is between 14 - 49 and her gender is female ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        chkPW.Checked = false;

            //        obj_op.DisableControls_Checkbox(mh01703);
            //        obj_op.DisableControls_Checkbox(mh017077);
            //        obj_op.DisableControls(mh017077x);

            //    }
            //}

            //obj_op = null;
        }

        private void mh09y_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (mh09y.Text == "0" && mh09m.Text == "0" && mh09d.Text == "0")
            {
                MessageBox.Show("Age in years, months and days all cannot contain zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09y.Focus();
                return;
            }


            if (string.IsNullOrEmpty(mh09y.Text))
            {
                MessageBox.Show("Please enter age in years ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09y.Focus();
            }
            else
            {
                if (mh010.SelectedValue.ToString() == "2" && Convert.ToInt32(mh09y.Text) >= 14 && Convert.ToInt32(mh09y.Text) <= 49)
                {
                    obj_op.EnableControls(mh01701);
                    obj_op.EnableControls(mh01702);
                    obj_op.EnableControls(mh01703);
                    obj_op.EnableControls_Checkbox(mh01704);
                    obj_op.EnableControls(mh017077);

                    obj_op.DisableControls(mh015);
                    obj_op.DisableControls(mh016);


                    chkHeight.Enabled = false;
                    chkHeight.Checked = false;
                    chkMUAC.Enabled = false;
                    chkMUAC.Checked = false;



                    obj_op.DisableControls_Checkbox(mh01801);
                    obj_op.DisableControls_Checkbox(mh01802);
                    obj_op.DisableControls_Checkbox(mh01803);
                    obj_op.DisableControls_Checkbox(mh01804);
                    obj_op.DisableControls_Checkbox(mh01805);
                    obj_op.DisableControls_Checkbox(mh01806);
                    obj_op.DisableControls_Checkbox(mh01807);
                    obj_op.DisableControls_Checkbox(mh01808);
                    obj_op.DisableControls_Checkbox(mh01809);
                    obj_op.DisableControls_Checkbox(mh018010);
                    obj_op.DisableControls_Checkbox(mh018011);
                    obj_op.DisableControls_Checkbox(mh018012);
                    obj_op.DisableControls_Checkbox(mh018013);
                    obj_op.DisableControls_Checkbox(mh018014);
                    obj_op.DisableControls_Checkbox(mh018015);
                    obj_op.DisableControls_Checkbox(mh018016);
                    obj_op.DisableControls_Checkbox(mh018077);
                    obj_op.DisableControls(mh018077x);


                    obj_op.DisableControls_Checkbox2(chkNoneDiag);

                    obj_op.DisableControls_Checkbox(mh02601);
                    obj_op.DisableControls_Checkbox(mh02602);
                    obj_op.DisableControls_Checkbox(mh02603);
                    obj_op.DisableControls_Checkbox(mh02604);
                    obj_op.DisableControls_Checkbox(mh02605);
                    obj_op.DisableControls_Checkbox(mh02606);
                    obj_op.DisableControls_Checkbox(mh027a1);
                    obj_op.DisableControls_Checkbox(mh02608);
                    obj_op.DisableControls_Checkbox(mh02609);
                    obj_op.DisableControls_Checkbox(mh026010);
                    obj_op.DisableControls_Checkbox(mh026011);
                    obj_op.DisableControls_Checkbox(mh027b);
                    obj_op.DisableControls_Checkbox(mh027a2);
                    obj_op.DisableControls_Checkbox(mh026014);
                    obj_op.DisableControls_Checkbox(mh026015);
                    obj_op.DisableControls_Checkbox(mh026016);
                    obj_op.DisableControls_Checkbox(mh026017);
                    obj_op.DisableControls_Checkbox(mh026018);
                    obj_op.DisableControls_Checkbox(mh026019);
                    obj_op.DisableControls_Checkbox2(chkVaccination);


                    panel1.Enabled = true;
                    obj_op.EnableControls(mh02001);
                    obj_op.EnableControls(mh02002);

                    panel4.Enabled = true;
                    obj_op.EnableControls(mh02101);
                    obj_op.EnableControls(mh02102);


                    obj_op.DisableControls_RadioButton(mh02201);
                    obj_op.DisableControls_RadioButton(mh02202);

                    obj_op.DisableControls_RadioButton(mh02301);
                    obj_op.DisableControls_RadioButton(mh02302);

                    obj_op.DisableControls_RadioButton(mh02401);
                    obj_op.DisableControls_RadioButton(mh02402);

                    obj_op.DisableControls_RadioButton(mh02501);
                    obj_op.DisableControls_RadioButton(mh02502);

                    panel2.Enabled = false;
                    panel5.Enabled = false;
                    panel3.Enabled = false;
                    panel6.Enabled = false;


                    panel8.Enabled = false;

                    obj_op.DisableControls_RadioButton(mh02701);
                    obj_op.DisableControls_RadioButton(mh02702);


                }
                else if (Convert.ToInt32(mh09y.Text) <= 5)
                {


                    obj_op.DisableControls_Checkbox(mh01701);
                    obj_op.DisableControls_Checkbox(mh01702);
                    obj_op.DisableControls_Checkbox(mh01703);
                    obj_op.DisableControls_Checkbox2(mh01704);
                    obj_op.DisableControls_Checkbox(mh017077);
                    obj_op.DisableControls(mh017077x);


                    obj_op.EnableControls(mh015);
                    chkHeight.Enabled = true;

                    obj_op.EnableControls(mh016);
                    chkMUAC.Enabled = true;


                    obj_op.EnableControls(mh01801);
                    obj_op.EnableControls(mh01802);
                    obj_op.EnableControls(mh01803);
                    obj_op.EnableControls(mh01804);
                    obj_op.EnableControls(mh01805);
                    obj_op.EnableControls(mh01806);
                    obj_op.EnableControls(mh01807);
                    obj_op.EnableControls(mh01808);
                    obj_op.EnableControls(mh01809);
                    obj_op.EnableControls(mh018010);
                    obj_op.EnableControls(mh018011);
                    obj_op.EnableControls(mh018012);
                    obj_op.EnableControls(mh018013);
                    obj_op.EnableControls(mh018014);
                    obj_op.EnableControls(mh018015);
                    obj_op.EnableControls(mh018016);
                    obj_op.EnableControls(mh018077);

                    obj_op.EnableControls_Checkbox(chkNoneDiag);


                    obj_op.EnableControls(mh02601);
                    obj_op.EnableControls(mh02602);
                    obj_op.EnableControls(mh02603);
                    obj_op.EnableControls(mh02604);
                    obj_op.EnableControls(mh02605);
                    obj_op.EnableControls(mh02606);
                    obj_op.EnableControls(mh027a1);
                    obj_op.EnableControls(mh02608);
                    obj_op.EnableControls(mh02609);
                    obj_op.EnableControls(mh026010);
                    obj_op.EnableControls(mh026011);
                    obj_op.EnableControls(mh027b);
                    obj_op.EnableControls(mh027a2);
                    obj_op.EnableControls(mh026014);
                    obj_op.EnableControls(mh026015);
                    obj_op.EnableControls(mh026016);
                    obj_op.EnableControls(mh026017);
                    obj_op.EnableControls(mh026018);
                    obj_op.EnableControls(mh026019);
                    obj_op.EnableControls_Checkbox(chkVaccination);


                    panel1.Enabled = false;
                    obj_op.DisableControls_RadioButton(mh02001);
                    obj_op.DisableControls_RadioButton(mh02002);

                    panel4.Enabled = false;
                    obj_op.DisableControls_RadioButton(mh02101);
                    obj_op.DisableControls_RadioButton(mh02102);



                    panel2.Enabled = true;
                    panel5.Enabled = true;
                    panel3.Enabled = true;
                    panel6.Enabled = true;


                    obj_op.EnableControls(mh02201);
                    obj_op.EnableControls(mh02202);

                    obj_op.EnableControls(mh02301);
                    obj_op.EnableControls(mh02302);

                    obj_op.EnableControls(mh02401);
                    obj_op.EnableControls(mh02402);

                    obj_op.EnableControls(mh02501);
                    obj_op.EnableControls(mh02502);


                    panel8.Enabled = true;

                    obj_op.EnableControls(mh02701);
                    obj_op.EnableControls(mh02702);

                }
                else if (Convert.ToInt32(mh09y.Text) > 5)
                {

                    obj_op.DisableControls_Checkbox(mh01701);
                    obj_op.DisableControls_Checkbox(mh01702);
                    obj_op.DisableControls_Checkbox(mh01703);
                    obj_op.DisableControls_Checkbox2(mh01704);
                    obj_op.DisableControls_Checkbox(mh017077);
                    obj_op.DisableControls(mh017077x);


                    obj_op.DisableControls(mh015);
                    chkHeight.Enabled = false;


                    obj_op.DisableControls(mh016);
                    chkMUAC.Enabled = false;



                    obj_op.DisableControls_Checkbox(mh01801);
                    obj_op.DisableControls_Checkbox(mh01802);
                    obj_op.DisableControls_Checkbox(mh01803);
                    obj_op.DisableControls_Checkbox(mh01804);
                    obj_op.DisableControls_Checkbox(mh01805);
                    obj_op.DisableControls_Checkbox(mh01806);
                    obj_op.DisableControls_Checkbox(mh01807);
                    obj_op.DisableControls_Checkbox(mh01808);
                    obj_op.DisableControls_Checkbox(mh01809);
                    obj_op.DisableControls_Checkbox(mh018010);
                    obj_op.DisableControls_Checkbox(mh018011);
                    obj_op.DisableControls_Checkbox(mh018012);
                    obj_op.DisableControls_Checkbox(mh018013);
                    obj_op.DisableControls_Checkbox(mh018014);
                    obj_op.DisableControls_Checkbox(mh018015);
                    obj_op.DisableControls_Checkbox(mh018016);
                    obj_op.DisableControls_Checkbox(mh018077);
                    obj_op.DisableControls(mh018077x);

                    obj_op.DisableControls_Checkbox2(chkNoneDiag);


                    obj_op.DisableControls_Checkbox(mh02601);
                    obj_op.DisableControls_Checkbox(mh02602);
                    obj_op.DisableControls_Checkbox(mh02603);
                    obj_op.DisableControls_Checkbox(mh02604);
                    obj_op.DisableControls_Checkbox(mh02605);
                    obj_op.DisableControls_Checkbox(mh02606);
                    obj_op.DisableControls_Checkbox(mh027a1);
                    obj_op.DisableControls_Checkbox(mh02608);
                    obj_op.DisableControls_Checkbox(mh02609);
                    obj_op.DisableControls_Checkbox(mh026010);
                    obj_op.DisableControls_Checkbox(mh026011);
                    obj_op.DisableControls_Checkbox(mh027b);
                    obj_op.DisableControls_Checkbox(mh027a2);
                    obj_op.DisableControls_Checkbox(mh026014);
                    obj_op.DisableControls_Checkbox(mh026015);
                    obj_op.DisableControls_Checkbox(mh026016);
                    obj_op.DisableControls_Checkbox(mh026017);
                    obj_op.DisableControls_Checkbox(mh026018);
                    obj_op.DisableControls_Checkbox(mh026019);
                    obj_op.DisableControls_Checkbox2(chkVaccination);



                    panel1.Enabled = false;
                    obj_op.DisableControls_RadioButton(mh02001);
                    obj_op.DisableControls_RadioButton(mh02002);

                    panel4.Enabled = false;
                    obj_op.DisableControls_RadioButton(mh02101);
                    obj_op.DisableControls_RadioButton(mh02102);


                    obj_op.DisableControls_RadioButton(mh02201);
                    obj_op.DisableControls_RadioButton(mh02202);

                    obj_op.DisableControls_RadioButton(mh02301);
                    obj_op.DisableControls_RadioButton(mh02302);

                    obj_op.DisableControls_RadioButton(mh02401);
                    obj_op.DisableControls_RadioButton(mh02402);

                    obj_op.DisableControls_RadioButton(mh02501);
                    obj_op.DisableControls_RadioButton(mh02502);

                    panel2.Enabled = false;
                    panel5.Enabled = false;
                    panel3.Enabled = false;
                    panel6.Enabled = false;


                    panel8.Enabled = false;

                    obj_op.DisableControls_RadioButton(mh02701);
                    obj_op.DisableControls_RadioButton(mh02702);


                }
                else
                {

                    obj_op.EnableControls(mh01701);
                    obj_op.EnableControls(mh01702);
                    obj_op.EnableControls(mh01703);
                    obj_op.EnableControls_Checkbox(mh01704);
                    obj_op.EnableControls(mh017077);



                    obj_op.DisableControls_RadioButton(mh02201);
                    obj_op.DisableControls_RadioButton(mh02202);

                    obj_op.DisableControls_RadioButton(mh02301);
                    obj_op.DisableControls_RadioButton(mh02302);

                    obj_op.DisableControls_RadioButton(mh02401);
                    obj_op.DisableControls_RadioButton(mh02402);

                    obj_op.DisableControls_RadioButton(mh02501);
                    obj_op.DisableControls_RadioButton(mh02502);

                    panel2.Enabled = false;
                    panel5.Enabled = false;
                    panel3.Enabled = false;
                    panel6.Enabled = false;


                    panel8.Enabled = false;

                    obj_op.DisableControls_RadioButton(mh02701);
                    obj_op.DisableControls_RadioButton(mh02702);

                }
            }
        }

        private void mh09m_Leave(object sender, EventArgs e)
        {

            if (mh09y.Text == "0" && mh09m.Text == "0" && mh09d.Text == "0")
            {
                MessageBox.Show("Age in years, months and days all cannot contain zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09m.Focus();
                return;
            }


            if (string.IsNullOrEmpty(mh09m.Text))
            {
                MessageBox.Show("Please enter age in months ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09m.Focus();
            }
            else
            {
                if (Convert.ToInt32(mh09m.Text) > 11)
                {
                    MessageBox.Show("Age in months cannot be greater than 11 months ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mh09m.Focus();
                }
            }
        }

        private void mh09d_Leave(object sender, EventArgs e)
        {

            if (mh09y.Text == "0" && mh09m.Text == "0" && mh09d.Text == "0")
            {
                MessageBox.Show("Age in years, months and days all cannot contain zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09d.Focus();
                return;
            }
            else if (mh09y.Text == "00" && mh09m.Text == "00" && mh09d.Text == "00")
            {
                MessageBox.Show("Age in years, months and days all cannot contain zero ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09d.Focus();
                return;
            }



            if (string.IsNullOrEmpty(mh09d.Text))
            {
                MessageBox.Show("Please enter age in days ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh09d.Focus();
            }
            else
            {
                if (Convert.ToInt32(mh09d.Text) < 0 || Convert.ToInt32(mh09d.Text) > 29)
                {
                    MessageBox.Show("Age in days must be between 0 - 29 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mh09d.Focus();
                }
            }
        }

        private void chkNone_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            if ((mh01901.Checked ||
              mh01902.Checked ||
              mh01903.Checked ||
              mh01904.Checked ||
              mh01905.Checked ||
              mh01906.Checked ||
              mh01907.Checked ||
              mh01908.Checked ||
              mh01909.Checked ||
              mh019010.Checked ||
              mh019011.Checked ||
              mh019012.Checked ||
              mh019013.Checked ||
              mh019014.Checked ||
              mh019015.Checked ||
              mh019077.Checked) && chkNone.Checked)
            {
                MessageBox.Show("You have already selected an option in Medicines Prescribed. Please clear it first  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkNone.Checked = false;
                return;
            }



            if (chkNone.Checked == true)
            {
                obj_op.DisableControls_Checkbox1(mh01901);
                obj_op.DisableControls_Checkbox1(mh01902);
                obj_op.DisableControls_Checkbox1(mh01903);
                obj_op.DisableControls_Checkbox1(mh01904);
                obj_op.DisableControls_Checkbox1(mh01905);
                obj_op.DisableControls_Checkbox1(mh01906);
                obj_op.DisableControls_Checkbox1(mh01907);
                obj_op.DisableControls_Checkbox1(mh01908);
                obj_op.DisableControls_Checkbox1(mh01909);
                obj_op.DisableControls_Checkbox1(mh019010);
                obj_op.DisableControls_Checkbox1(mh019011);
                obj_op.DisableControls_Checkbox1(mh019012);
                obj_op.DisableControls_Checkbox1(mh019013);
                obj_op.DisableControls_Checkbox1(mh019014);
                obj_op.DisableControls_Checkbox1(mh019015);
                obj_op.DisableControls_Checkbox1(mh019077);
                obj_op.DisableControls(mh019077x);
            }

            obj_op = null;
        }

        private void mh010_SelectedIndexChanged(object sender, EventArgs e)
        {

            CDBOperations obj_op = new CDBOperations();


            if (!string.IsNullOrEmpty(mh09y.Text))
            {
                if (mh010.SelectedValue.ToString() == "2" && Convert.ToInt32(mh09y.Text) >= 14 && Convert.ToInt32(mh09y.Text) <= 49)
                {
                    obj_op.EnableControls(mh01701);
                    obj_op.EnableControls(mh01702);
                    obj_op.EnableControls(mh01703);
                    obj_op.EnableControls_Checkbox(mh01704);
                    obj_op.EnableControls(mh017077);

                    obj_op.EnableControls(mh02001);
                    obj_op.EnableControls(mh02002);

                    obj_op.EnableControls(mh02101);
                    obj_op.EnableControls(mh02102);

                    panel1.Enabled = true;
                    panel4.Enabled = true;


                    obj_op.DisableControls_RadioButton(mh02201);
                    obj_op.DisableControls_RadioButton(mh02202);

                    obj_op.DisableControls_RadioButton(mh02301);
                    obj_op.DisableControls_RadioButton(mh02302);

                    obj_op.DisableControls_RadioButton(mh02401);
                    obj_op.DisableControls_RadioButton(mh02402);

                    obj_op.DisableControls_RadioButton(mh02501);
                    obj_op.DisableControls_RadioButton(mh02502);

                    panel2.Enabled = false;
                    panel5.Enabled = false;
                    panel3.Enabled = false;
                    panel6.Enabled = false;


                }
                else if (Convert.ToInt32(mh09y.Text) <= 5)
                {

                    obj_op.EnableControls(mh015);
                    chkHeight.Enabled = true;

                    obj_op.EnableControls(mh016);
                    chkMUAC.Enabled = true;


                    obj_op.DisableControls_RadioButton(mh02001);
                    obj_op.DisableControls_RadioButton(mh02002);

                    obj_op.DisableControls_RadioButton(mh02101);
                    obj_op.DisableControls_RadioButton(mh02102);

                    panel1.Enabled = false;
                    panel4.Enabled = false;



                    obj_op.EnableControls(mh02601);
                    obj_op.EnableControls(mh02602);
                    obj_op.EnableControls(mh02603);
                    obj_op.EnableControls(mh02604);
                    obj_op.EnableControls(mh02605);
                    obj_op.EnableControls(mh02606);
                    obj_op.EnableControls(mh027a1);
                    obj_op.EnableControls(mh02608);
                    obj_op.EnableControls(mh02609);
                    obj_op.EnableControls(mh026010);
                    obj_op.EnableControls(mh026011);
                    obj_op.EnableControls(mh027b);
                    obj_op.EnableControls(mh027a2);
                    obj_op.EnableControls(mh026014);
                    obj_op.EnableControls(mh026015);
                    obj_op.EnableControls(mh026016);
                    obj_op.EnableControls(mh026017);
                    obj_op.EnableControls(mh026018);
                    obj_op.EnableControls(mh026019);
                    obj_op.EnableControls_Checkbox(chkVaccination);


                    panel2.Enabled = true;
                    panel5.Enabled = true;
                    panel3.Enabled = true;
                    panel6.Enabled = true;


                    obj_op.EnableControls(mh02201);
                    obj_op.EnableControls(mh02202);

                    obj_op.EnableControls(mh02301);
                    obj_op.EnableControls(mh02302);

                    obj_op.EnableControls(mh02401);
                    obj_op.EnableControls(mh02402);

                    obj_op.EnableControls(mh02501);
                    obj_op.EnableControls(mh02502);

                }
                else if (Convert.ToInt32(mh09y.Text) > 5)
                {

                    obj_op.DisableControls(mh015);
                    chkHeight.Enabled = false;
                    chkHeight.Checked = false;


                    obj_op.DisableControls(mh016);
                    chkMUAC.Enabled = false;
                    chkMUAC.Checked = false;


                    obj_op.DisableControls_Checkbox(mh01701);
                    obj_op.DisableControls_Checkbox(mh01702);
                    obj_op.DisableControls_Checkbox(mh01703);
                    obj_op.DisableControls_Checkbox2(mh01704);
                    obj_op.DisableControls_Checkbox(mh017077);

                    obj_op.DisableControls(mh017077x);


                    obj_op.DisableControls_RadioButton(mh02001);
                    obj_op.DisableControls_RadioButton(mh02002);

                    obj_op.DisableControls_RadioButton(mh02101);
                    obj_op.DisableControls_RadioButton(mh02102);

                    panel1.Enabled = false;
                    panel4.Enabled = false;



                    obj_op.DisableControls_Checkbox(mh02601);
                    obj_op.DisableControls_Checkbox(mh02602);
                    obj_op.DisableControls_Checkbox(mh02603);
                    obj_op.DisableControls_Checkbox(mh02604);
                    obj_op.DisableControls_Checkbox(mh02605);
                    obj_op.DisableControls_Checkbox(mh02606);
                    obj_op.DisableControls_Checkbox(mh027a1);
                    obj_op.DisableControls_Checkbox(mh02608);
                    obj_op.DisableControls_Checkbox(mh02609);
                    obj_op.DisableControls_Checkbox(mh026010);
                    obj_op.DisableControls_Checkbox(mh026011);
                    obj_op.DisableControls_Checkbox(mh027b);
                    obj_op.DisableControls_Checkbox(mh027a2);
                    obj_op.DisableControls_Checkbox(mh026014);
                    obj_op.DisableControls_Checkbox(mh026015);
                    obj_op.DisableControls_Checkbox(mh026016);
                    obj_op.DisableControls_Checkbox(mh026017);
                    obj_op.DisableControls_Checkbox(mh026018);
                    obj_op.DisableControls_Checkbox(mh026019);
                    obj_op.DisableControls_Checkbox2(chkVaccination);


                    obj_op.DisableControls_RadioButton(mh02201);
                    obj_op.DisableControls_RadioButton(mh02202);

                    obj_op.DisableControls_RadioButton(mh02301);
                    obj_op.DisableControls_RadioButton(mh02302);

                    obj_op.DisableControls_RadioButton(mh02401);
                    obj_op.DisableControls_RadioButton(mh02402);

                    obj_op.DisableControls_RadioButton(mh02501);
                    obj_op.DisableControls_RadioButton(mh02502);

                    panel2.Enabled = false;
                    panel5.Enabled = false;
                    panel3.Enabled = false;
                    panel6.Enabled = false;


                }
                else
                {

                    obj_op.DisableControls_Checkbox(mh01701);
                    obj_op.DisableControls_Checkbox(mh01702);
                    obj_op.DisableControls_Checkbox(mh01703);
                    obj_op.DisableControls_Checkbox2(mh01704);
                    obj_op.DisableControls_Checkbox(mh017077);

                    obj_op.DisableControls(mh017077x);


                    obj_op.DisableControls_RadioButton(mh02001);
                    obj_op.DisableControls_RadioButton(mh02002);

                    obj_op.DisableControls_RadioButton(mh02101);
                    obj_op.DisableControls_RadioButton(mh02102);




                }
            }
            else
            {
                if (mh010.SelectedValue.ToString() == "2")
                {
                    obj_op.EnableControls(mh01701);
                    obj_op.EnableControls(mh01702);
                    obj_op.EnableControls(mh01703);
                    obj_op.EnableControls_Checkbox(mh01704);
                    obj_op.EnableControls(mh017077);

                    panel1.Enabled = true;
                    panel4.Enabled = true;
                }
                else
                {
                    obj_op.DisableControls_Checkbox(mh01701);
                    obj_op.DisableControls_Checkbox(mh01702);
                    obj_op.DisableControls_Checkbox(mh01703);
                    obj_op.DisableControls_Checkbox2(mh01704);
                    obj_op.DisableControls_Checkbox(mh017077);
                    obj_op.DisableControls(mh017077x);


                    obj_op.DisableControls_RadioButton(mh02001);
                    obj_op.DisableControls_RadioButton(mh02002);


                    obj_op.DisableControls_RadioButton(mh02101);
                    obj_op.DisableControls_RadioButton(mh02102);


                    panel1.Enabled = false;
                    panel4.Enabled = false;
                }
            }


            obj_op = null;

        }

        private void mh06_Leave(object sender, EventArgs e)
        {
            if (mh06.SelectedValue == "0")
            {
                MessageBox.Show("Please select doctor name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh06.Focus();
            }
        }

        private void mh010_Leave(object sender, EventArgs e)
        {

            if (mh010.SelectedValue == "0")
            {
                MessageBox.Show("Please select gender ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh010.Focus();
            }
            else
            {
                CDBOperations obj_op = new CDBOperations();


                if (!string.IsNullOrEmpty(mh09y.Text))
                {
                    if (mh010.SelectedValue.ToString() == "2" && Convert.ToInt32(mh09y.Text) >= 14 && Convert.ToInt32(mh09y.Text) <= 49)
                    {
                        obj_op.EnableControls(mh01701);
                        obj_op.EnableControls(mh01702);
                        obj_op.EnableControls(mh01703);
                        obj_op.EnableControls_Checkbox(mh01704);
                        obj_op.EnableControls(mh017077);


                        obj_op.DisableControls(mh015);
                        chkHeight.Enabled = false;

                        obj_op.DisableControls(mh016);
                        chkMUAC.Enabled = false;


                        obj_op.DisableControls_Checkbox(mh01801);
                        obj_op.DisableControls_Checkbox(mh01802);
                        obj_op.DisableControls_Checkbox(mh01803);
                        obj_op.DisableControls_Checkbox(mh01804);
                        obj_op.DisableControls_Checkbox(mh01805);
                        obj_op.DisableControls_Checkbox(mh01806);
                        obj_op.DisableControls_Checkbox(mh01807);
                        obj_op.DisableControls_Checkbox(mh01808);
                        obj_op.DisableControls_Checkbox(mh01809);
                        obj_op.DisableControls_Checkbox(mh018010);
                        obj_op.DisableControls_Checkbox(mh018011);
                        obj_op.DisableControls_Checkbox(mh018012);
                        obj_op.DisableControls_Checkbox(mh018013);
                        obj_op.DisableControls_Checkbox(mh018014);
                        obj_op.DisableControls_Checkbox(mh018015);
                        obj_op.DisableControls_Checkbox(mh018016);
                        obj_op.DisableControls_Checkbox(mh018077);
                        obj_op.DisableControls(mh018077x);

                        obj_op.DisableControls_Checkbox2(chkNoneDiag);


                        obj_op.DisableControls_Checkbox(mh02601);
                        obj_op.DisableControls_Checkbox(mh02602);
                        obj_op.DisableControls_Checkbox(mh02603);
                        obj_op.DisableControls_Checkbox(mh02604);
                        obj_op.DisableControls_Checkbox(mh02605);
                        obj_op.DisableControls_Checkbox(mh02606);
                        obj_op.DisableControls_Checkbox(mh027a1);
                        obj_op.DisableControls_Checkbox(mh02608);
                        obj_op.DisableControls_Checkbox(mh02609);
                        obj_op.DisableControls_Checkbox(mh026010);
                        obj_op.DisableControls_Checkbox(mh026011);
                        obj_op.DisableControls_Checkbox(mh027b);
                        obj_op.DisableControls_Checkbox(mh027a2);
                        obj_op.DisableControls_Checkbox(mh026014);
                        obj_op.DisableControls_Checkbox(mh026015);
                        obj_op.DisableControls_Checkbox(mh026016);
                        obj_op.DisableControls_Checkbox(mh026017);
                        obj_op.DisableControls_Checkbox(mh026018);
                        obj_op.DisableControls_Checkbox(mh026019);
                        obj_op.DisableControls_Checkbox2(chkVaccination);


                        obj_op.EnableControls(mh02001);
                        obj_op.EnableControls(mh02002);

                        obj_op.EnableControls(mh02101);
                        obj_op.EnableControls(mh02102);

                        panel1.Enabled = true;
                        panel4.Enabled = true;


                        obj_op.DisableControls_RadioButton(mh02201);
                        obj_op.DisableControls_RadioButton(mh02202);

                        obj_op.DisableControls_RadioButton(mh02301);
                        obj_op.DisableControls_RadioButton(mh02302);

                        obj_op.DisableControls_RadioButton(mh02401);
                        obj_op.DisableControls_RadioButton(mh02402);

                        obj_op.DisableControls_RadioButton(mh02501);
                        obj_op.DisableControls_RadioButton(mh02502);

                        panel2.Enabled = false;
                        panel5.Enabled = false;
                        panel3.Enabled = false;
                        panel6.Enabled = false;


                        panel8.Enabled = false;

                        obj_op.DisableControls_RadioButton(mh02701);
                        obj_op.DisableControls_RadioButton(mh02702);


                    }
                    else if (Convert.ToInt32(mh09y.Text) <= 5)
                    {

                        obj_op.DisableControls_Checkbox(mh01701);
                        obj_op.DisableControls_Checkbox(mh01702);
                        obj_op.DisableControls_Checkbox(mh01703);
                        obj_op.DisableControls_Checkbox2(mh01704);
                        obj_op.DisableControls_Checkbox(mh017077);
                        obj_op.DisableControls(mh017077x);



                        obj_op.EnableControls(mh015);
                        chkHeight.Enabled = true;

                        obj_op.EnableControls(mh016);
                        chkMUAC.Enabled = true;



                        obj_op.DisableControls_RadioButton(mh02001);
                        obj_op.DisableControls_RadioButton(mh02002);

                        obj_op.DisableControls_RadioButton(mh02101);
                        obj_op.DisableControls_RadioButton(mh02102);

                        panel1.Enabled = false;
                        panel4.Enabled = false;



                        obj_op.EnableControls(mh01801);
                        obj_op.EnableControls(mh01802);
                        obj_op.EnableControls(mh01803);
                        obj_op.EnableControls(mh01804);
                        obj_op.EnableControls(mh01805);
                        obj_op.EnableControls(mh01806);
                        obj_op.EnableControls(mh01807);
                        obj_op.EnableControls(mh01808);
                        obj_op.EnableControls(mh01809);
                        obj_op.EnableControls(mh018010);
                        obj_op.EnableControls(mh018011);
                        obj_op.EnableControls(mh018012);
                        obj_op.EnableControls(mh018013);
                        obj_op.EnableControls(mh018014);
                        obj_op.EnableControls(mh018015);
                        obj_op.EnableControls(mh018016);
                        obj_op.EnableControls(mh018077);

                        obj_op.EnableControls_Checkbox(chkNoneDiag);


                        obj_op.EnableControls(mh02601);
                        obj_op.EnableControls(mh02602);
                        obj_op.EnableControls(mh02603);
                        obj_op.EnableControls(mh02604);
                        obj_op.EnableControls(mh02605);
                        obj_op.EnableControls(mh02606);
                        obj_op.EnableControls(mh027a1);
                        obj_op.EnableControls(mh02608);
                        obj_op.EnableControls(mh02609);
                        obj_op.EnableControls(mh026010);
                        obj_op.EnableControls(mh026011);
                        obj_op.EnableControls(mh027b);
                        obj_op.EnableControls(mh027a2);
                        obj_op.EnableControls(mh026014);
                        obj_op.EnableControls(mh026015);
                        obj_op.EnableControls(mh026016);
                        obj_op.EnableControls(mh026017);
                        obj_op.EnableControls(mh026018);
                        obj_op.EnableControls(mh026019);
                        obj_op.EnableControls_Checkbox(chkVaccination);


                        panel2.Enabled = true;
                        panel5.Enabled = true;
                        panel3.Enabled = true;
                        panel6.Enabled = true;


                        obj_op.EnableControls(mh02201);
                        obj_op.EnableControls(mh02202);

                        obj_op.EnableControls(mh02301);
                        obj_op.EnableControls(mh02302);

                        obj_op.EnableControls(mh02401);
                        obj_op.EnableControls(mh02402);

                        obj_op.EnableControls(mh02501);
                        obj_op.EnableControls(mh02502);



                        panel8.Enabled = true;

                        obj_op.EnableControls(mh02701);
                        obj_op.EnableControls(mh02702);


                    }
                    else if (Convert.ToInt32(mh09y.Text) > 5)
                    {

                        obj_op.DisableControls(mh015);
                        chkHeight.Enabled = false;


                        obj_op.DisableControls(mh016);
                        chkMUAC.Enabled = false;


                        obj_op.DisableControls_Checkbox(mh01701);
                        obj_op.DisableControls_Checkbox(mh01702);
                        obj_op.DisableControls_Checkbox(mh01703);
                        obj_op.DisableControls_Checkbox2(mh01704);
                        obj_op.DisableControls_Checkbox(mh017077);
                        obj_op.DisableControls(mh017077x);



                        obj_op.DisableControls_Checkbox(mh01801);
                        obj_op.DisableControls_Checkbox(mh01802);
                        obj_op.DisableControls_Checkbox(mh01803);
                        obj_op.DisableControls_Checkbox(mh01804);
                        obj_op.DisableControls_Checkbox(mh01805);
                        obj_op.DisableControls_Checkbox(mh01806);
                        obj_op.DisableControls_Checkbox(mh01807);
                        obj_op.DisableControls_Checkbox(mh01808);
                        obj_op.DisableControls_Checkbox(mh01809);
                        obj_op.DisableControls_Checkbox(mh018010);
                        obj_op.DisableControls_Checkbox(mh018011);
                        obj_op.DisableControls_Checkbox(mh018012);
                        obj_op.DisableControls_Checkbox(mh018013);
                        obj_op.DisableControls_Checkbox(mh018014);
                        obj_op.DisableControls_Checkbox(mh018015);
                        obj_op.DisableControls_Checkbox(mh018016);
                        obj_op.DisableControls_Checkbox(mh018077);
                        obj_op.DisableControls(mh018077x);

                        obj_op.DisableControls_Checkbox2(chkNoneDiag);



                        obj_op.DisableControls_RadioButton(mh02001);
                        obj_op.DisableControls_RadioButton(mh02002);

                        obj_op.DisableControls_RadioButton(mh02101);
                        obj_op.DisableControls_RadioButton(mh02102);

                        panel1.Enabled = false;
                        panel4.Enabled = false;


                        obj_op.DisableControls_Checkbox(mh02601);
                        obj_op.DisableControls_Checkbox(mh02602);
                        obj_op.DisableControls_Checkbox(mh02603);
                        obj_op.DisableControls_Checkbox(mh02604);
                        obj_op.DisableControls_Checkbox(mh02605);
                        obj_op.DisableControls_Checkbox(mh02606);
                        obj_op.DisableControls_Checkbox(mh027a1);
                        obj_op.DisableControls_Checkbox(mh02608);
                        obj_op.DisableControls_Checkbox(mh02609);
                        obj_op.DisableControls_Checkbox(mh026010);
                        obj_op.DisableControls_Checkbox(mh026011);
                        obj_op.DisableControls_Checkbox(mh027b);
                        obj_op.DisableControls_Checkbox(mh027a2);
                        obj_op.DisableControls_Checkbox(mh026014);
                        obj_op.DisableControls_Checkbox(mh026015);
                        obj_op.DisableControls_Checkbox(mh026016);
                        obj_op.DisableControls_Checkbox(mh026017);
                        obj_op.DisableControls_Checkbox(mh026018);
                        obj_op.DisableControls_Checkbox(mh026019);
                        obj_op.DisableControls_Checkbox2(chkVaccination);


                        obj_op.DisableControls_RadioButton(mh02201);
                        obj_op.DisableControls_RadioButton(mh02202);

                        obj_op.DisableControls_RadioButton(mh02301);
                        obj_op.DisableControls_RadioButton(mh02302);

                        obj_op.DisableControls_RadioButton(mh02401);
                        obj_op.DisableControls_RadioButton(mh02402);

                        obj_op.DisableControls_RadioButton(mh02501);
                        obj_op.DisableControls_RadioButton(mh02502);

                        panel2.Enabled = false;
                        panel5.Enabled = false;
                        panel3.Enabled = false;
                        panel6.Enabled = false;


                        panel8.Enabled = false;

                        obj_op.DisableControls_RadioButton(mh02701);
                        obj_op.DisableControls_RadioButton(mh02702);


                    }
                    else
                    {

                        obj_op.DisableControls_Checkbox(mh01701);
                        obj_op.DisableControls_Checkbox(mh01702);
                        obj_op.DisableControls_Checkbox(mh01703);
                        obj_op.DisableControls_Checkbox2(mh01704);
                        obj_op.DisableControls_Checkbox(mh017077);

                        obj_op.DisableControls(mh017077x);


                        obj_op.DisableControls_RadioButton(mh02001);
                        obj_op.DisableControls_RadioButton(mh02002);

                        obj_op.DisableControls_RadioButton(mh02101);
                        obj_op.DisableControls_RadioButton(mh02102);

                    }
                }
                else
                {
                    if (mh010.SelectedValue.ToString() == "2")
                    {
                        obj_op.EnableControls(mh01701);
                        obj_op.EnableControls(mh01702);
                        obj_op.EnableControls(mh01703);
                        obj_op.EnableControls_Checkbox(mh01704);
                        obj_op.EnableControls(mh017077);

                        panel1.Enabled = true;
                        panel4.Enabled = true;
                    }
                    else
                    {
                        obj_op.DisableControls_Checkbox(mh01701);
                        obj_op.DisableControls_Checkbox(mh01702);
                        obj_op.DisableControls_Checkbox(mh01703);
                        obj_op.DisableControls_Checkbox2(mh01704);
                        obj_op.DisableControls_Checkbox(mh017077);
                        obj_op.DisableControls(mh017077x);


                        obj_op.DisableControls_RadioButton(mh02001);
                        obj_op.DisableControls_RadioButton(mh02002);


                        obj_op.DisableControls_RadioButton(mh02101);
                        obj_op.DisableControls_RadioButton(mh02102);


                        panel1.Enabled = false;
                        panel4.Enabled = false;


                    }
                }

                obj_op = null;
            }
        }

        private void mh011_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mh01101.Text))
            {
                MessageBox.Show("Please select presenting complaints ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh01101.Focus();
            }
        }

        private void mh012_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(mh012.Text))
            //{
            //    MessageBox.Show("Please enter weight in KG ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    mh012.Focus();
            //}
            //else
            //{
            //    if (mh012.Text.Length != 5)
            //    {
            //        MessageBox.Show("Please enter complete weight in KG ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        mh012.Focus();
            //    }
            //}

        }

        private void chkWht_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mh026012_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            /*mh02601.Checked == true && mh027b.Checked == true ||
                mh02602.Checked == true && mh027b.Checked == true ||
                mh02603.Checked == true && mh027b.Checked == true ||
                mh02604.Checked == true && mh027b.Checked == true ||
                mh02605.Checked == true && mh027b.Checked == true ||
                mh02606.Checked == true && mh027b.Checked == true ||
                mh027a1.Checked == true && mh027b.Checked == true ||
                mh02608.Checked == true && mh027b.Checked == true ||
                mh02609.Checked == true && mh027b.Checked == true ||
                mh026010.Checked == true && mh027b.Checked == true ||
                mh026011.Checked == true && mh027b.Checked == true ||
                mh027b.Checked == true && mh027b.Checked == true ||
                mh026014.Checked == true && mh027b.Checked == true ||
                mh026015.Checked == true && mh027b.Checked == true ||
                mh026016.Checked == true && mh027b.Checked == true ||
                mh026017.Checked == true && mh027b.Checked == true ||
                mh026018.Checked == true && mh027b.Checked == true ||
                mh026019.Checked == true && mh027b.Checked == true*/


            if ((mh02601.Checked ||
                mh02602.Checked ||
                mh02603.Checked ||
                mh02604.Checked ||
                mh02605.Checked ||
                mh02606.Checked ||
                mh02608.Checked ||
                mh02609.Checked ||
                mh026010.Checked ||
                mh026011.Checked ||
                mh026014.Checked ||
                mh026015.Checked ||
                mh026016.Checked ||
                mh026017.Checked ||
                mh026018.Checked ||
                mh026019.Checked) && mh027b.Checked
                )
            {
                MessageBox.Show("Vaccinations have been reported first remove the vaccination ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh027b.Checked = false;
            }



            //if (mh027b.Checked)
            //{
            //    obj_op.DisableControls_Checkbox(mh02601);
            //    obj_op.DisableControls_Checkbox(mh02602);
            //    obj_op.DisableControls_Checkbox(mh02603);
            //    obj_op.DisableControls_Checkbox(mh02604);
            //    obj_op.DisableControls_Checkbox(mh02605);
            //    obj_op.DisableControls_Checkbox(mh02606);
            //    //obj_op.DisableControls_Checkbox(mh02607);
            //    obj_op.DisableControls_Checkbox(mh02608);
            //    obj_op.DisableControls_Checkbox(mh02609);
            //    obj_op.DisableControls_Checkbox(mh026010);
            //    obj_op.DisableControls_Checkbox(mh026011);

            //    //obj_op.DisableControls_Checkbox(mh026013);

            //    obj_op.DisableControls_Checkbox(mh026014);
            //    obj_op.DisableControls_Checkbox(mh026015);
            //    obj_op.DisableControls_Checkbox(mh026016);
            //    obj_op.DisableControls_Checkbox(mh026017);
            //    obj_op.DisableControls_Checkbox(mh026018);
            //    obj_op.DisableControls_Checkbox(mh026019);
            //}
            //else
            //{
            //    obj_op.EnableControls(mh02601);
            //    obj_op.EnableControls(mh02602);
            //    obj_op.EnableControls(mh02603);
            //    obj_op.EnableControls(mh02604);
            //    obj_op.EnableControls(mh02605);
            //    obj_op.EnableControls(mh02606);
            //    //obj_op.EnableControls(mh02607);
            //    obj_op.EnableControls(mh02608);
            //    obj_op.EnableControls(mh02609);
            //    obj_op.EnableControls(mh026010);
            //    obj_op.EnableControls(mh026011);

            //    //obj_op.EnableControls(mh026013);

            //    obj_op.EnableControls(mh026014);
            //    obj_op.EnableControls(mh026015);
            //    obj_op.EnableControls(mh026016);
            //    obj_op.EnableControls(mh026017);
            //    obj_op.EnableControls(mh026018);
            //    obj_op.EnableControls(mh026019);
            //}

            obj_op = null;
        }

        private void mh026013_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            //if (
            //    (mh027a1.Checked == true ||
            //    mh02608.Checked == true ||
            //    mh02609.Checked == true ||
            //    mh026010.Checked == true ||
            //    mh026011.Checked == true) && mh027a2.Checked == true)
            //{
            //    MessageBox.Show("Receipt of OPV is exist in camp please recheck ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    mh027a2.Checked = false;
            //}


            if (mh027a1.Checked == true && mh027a2.Checked)
            {
                MessageBox.Show("OPV is selected please unchecked ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh027a2.Checked = false;
            }



            //if (mh027a2.Checked)
            //{
            //    mh027a1.Checked = false;

            //    //obj_op.DisableControls_Checkbox(mh02608);
            //    //obj_op.DisableControls_Checkbox(mh02609);
            //    //obj_op.DisableControls_Checkbox(mh026010);
            //    //obj_op.DisableControls_Checkbox(mh026011);
            //}
            //else
            //{
            //    //obj_op.EnableControls(mh02608);
            //    //obj_op.EnableControls(mh02609);
            //    //obj_op.EnableControls(mh026010);
            //    //obj_op.EnableControls(mh026011);
            //}

            obj_op = null;
        }

        private void mh02_Leave(object sender, EventArgs e)
        {
            if (mh02.Text == "000-0000-0")
            {
                cmdSave.Enabled = false;
                cmdMainMenu.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(mh02.Text))
                {
                    MessageBox.Show("Please enter MHS No. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mh02.Focus();
                }
                else
                {
                    CheckMHSNo();
                }
            }
        }



        private void CheckMHSNo()
        {

            CDBOperations obj_op = null;
            CConnection cn = null;


            try
            {
                obj_op = new CDBOperations();
                cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select district, ucName, area_name, ucCode, strftime('%d/%m/%Y', execution_date) execution_date from campdatadown where camp_no='" + mh02.Text + "' and dist_id='" + CVariables.dist_id + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        mh03.Text = ds.Tables[0].Rows[0]["district"].ToString();
                        mh04.Text = ds.Tables[0].Rows[0]["ucName"].ToString();
                        mh05.Text = ds.Tables[0].Rows[0]["area_name"].ToString();
                        mh01.Text = ds.Tables[0].Rows[0]["execution_date"].ToString();

                        CVariables.uc_code = ds.Tables[0].Rows[0]["ucCode"].ToString();

                        GetDoctorsHMSNo();
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



        private void GetDoctorsHMSNo()
        {

            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_doctors a inner join campdatadown b on a.idCamp = b.idCamp where b.camp_no='" + mh02.Text + "'", cn.cn);


                //SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_doctors where idCamp='" + mh02.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Dictionary<string, string> comboSource = new Dictionary<string, string>();


                if (ds.Tables.Count > 0)
                {

                    for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                    {
                        comboSource.Add(ds.Tables[0].Rows[a]["iddoctor"].ToString(), ds.Tables[0].Rows[a]["staff_name"].ToString());
                    }


                    if (ds.Tables.Count > 0)
                    {
                        mh06.DataSource = new BindingSource(comboSource, null);
                        mh06.DisplayMember = "Value";
                        mh06.ValueMember = "Key";
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

        private void chkWeight_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (chkWeight.Checked)
            {
                obj_op.DisableControls(mh012);
            }
            else
            {
                obj_op.EnableControls(mh012);
                mh012.Focus();
            }

            obj_op = null;
        }

        private void chkHeight_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (chkHeight.Checked)
            {
                obj_op.DisableControls(mh015);
            }
            else
            {
                obj_op.EnableControls(mh015);
                mh015.Focus();
            }

            obj_op = null;
        }

        private void chkMUAC_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (chkMUAC.Checked)
            {
                obj_op.DisableControls(mh016);
            }
            else
            {
                obj_op.EnableControls(mh016);
                mh016.Focus();
            }

            obj_op = null;
        }

        private void mh016_Leave(object sender, EventArgs e)
        {
            //vScrollBar1.Value = 400;
            cmdSave.Location = new System.Drawing.Point(750, 500);
            cmdNewID.Location = new System.Drawing.Point(750, 550);
        }

        private void mh08_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mh08.Text))
            {
                MessageBox.Show("Please enter father / husband name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh08.Focus();
            }
        }

        private void mh07_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mh07.Text))
            {
                MessageBox.Show("Please enter patient name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh07.Focus();
            }
        }

        private void mh01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (mh01.Text.IndexOf(" ") == -1)
            {
                if (mh01.Text.Length == 10)
                {
                    try
                    {
                        string[] dt1;
                        string[] dob;
                        string[] study_dt1;
                        int dayno = 0;


                        if (mh01.Text != "  /  /")
                        {
                            dt1 = mh01.Text.ToString().Split('/');

                            DateTime dt = new DateTime();
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            dt = Convert.ToDateTime(mh01.Text);

                            string vdt = getExecutionDateMHSNo();

                            if (vdt == "")
                            {
                                MessageBox.Show("Execution Date not found. This form cannot be processed without execution date. ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                mh01.Focus();
                            }
                            else
                            {
                                study_dt1 = vdt.Split('-');
                                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                                DateTime study_dt = Convert.ToDateTime(study_dt1[0] + "-" + study_dt1[1] + "-" + study_dt1[2]);


                                if (dt > DateTime.Now.Date)
                                {
                                    MessageBox.Show("Date cannot be greater than todays's date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    mh01.Focus();
                                }
                                else
                                {
                                    if (dt < study_dt)
                                    {
                                        MessageBox.Show("Date cannot be less than execution date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        mh01.Focus();
                                    }
                                    else
                                    {
                                        mh06.Focus();
                                    }
                                }
                            }

                        }
                        else if (mh01.Text == "  /  /")
                        {
                            MessageBox.Show("Date of form filling cannot be blank ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mh01.Focus();
                        }
                    }

                    catch (Exception ex)
                    {
                        if (ex.Message == "String was not recognized as a valid DateTime.")
                        {
                            MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mh01.Focus();
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mh01.Focus();
                        }
                    }

                    finally
                    {
                        obj_op = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter complete date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mh01.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter complete date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh01.Focus();
            }
        }


        private string getExecutionDateMHSNo()
        {

            CDBOperations obj_op = null;
            CConnection cn = new CConnection();

            string vdt = "";

            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from campdatadown where camp_no='" + mh02.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        vdt = ds.Tables[0].Rows[0]["execution_date"].ToString();
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

            return vdt;
        }




        private void ClearForm()
        {
            CDBOperations obj_op = new CDBOperations();

            //mh01.Text = "";
            //mh02.Text = "";
            //mh03.Text = "";
            //mh04.Text = "";
            //mh05.Text = "";

            FORM_ID.Text = "";
            mh06.SelectedValue = "0";

            mh07.Text = "";
            mh08.Text = "";
            mh09y.Text = "";
            mh09m.Text = "";
            mh09d.Text = "";

            mh010.SelectedValue = "0";

            mh01101.Text = "";
            mh01102.Text = "";
            mh01103.Text = "";

            mh012.Text = "";
            chkWeight.Checked = false;

            mh013.SelectedValue = "0";
            mh014.SelectedValue = "0";

            mh015.Text = "";
            chkHeight.Checked = false;

            mh016.Text = "";
            chkMUAC.Checked = false;



            mh01701.Checked = false;
            mh01702.Checked = false;
            mh01703.Checked = false;
            mh01704.Checked = false;
            mh017077.Checked = false;


            obj_op.DisableControls(mh017077x);

            mh01801.Checked = false;
            mh01802.Checked = false;
            mh01803.Checked = false;
            mh01804.Checked = false;
            mh01805.Checked = false;
            mh01806.Checked = false;
            mh01807.Checked = false;
            mh01808.Checked = false;
            mh01809.Checked = false;
            mh018010.Checked = false;
            mh018011.Checked = false;
            mh018012.Checked = false;
            mh018013.Checked = false;
            mh018014.Checked = false;
            mh018015.Checked = false;
            mh018016.Checked = false;
            mh018077.Checked = false;

            chkNoneDiag.Checked = false;

            obj_op.DisableControls(mh018077x);



            mh01901.Checked = false;
            mh01902.Checked = false;
            mh01903.Checked = false;
            mh01904.Checked = false;
            mh01905.Checked = false;
            mh01906.Checked = false;
            mh01907.Checked = false;
            mh01908.Checked = false;
            mh01909.Checked = false;
            mh019010.Checked = false;
            mh019011.Checked = false;
            mh019012.Checked = false;
            mh019013.Checked = false;
            mh019014.Checked = false;
            mh019015.Checked = false;
            mh019077.Checked = false;

            obj_op.DisableControls(mh019077x);

            chkNone.Checked = false;

            mh02001.Checked = false;
            mh02002.Checked = false;

            mh02101.Checked = false;
            mh02102.Checked = false;

            mh02201.Checked = false;
            mh02202.Checked = false;

            mh02301.Checked = false;
            mh02302.Checked = false;

            mh02401.Checked = false;
            mh02402.Checked = false;

            mh02501.Checked = false;
            mh02502.Checked = false;


            mh02601.Checked = false;
            mh02602.Checked = false;
            mh02603.Checked = false;
            mh02604.Checked = false;
            mh02605.Checked = false;
            mh02606.Checked = false;
            mh027a1.Checked = false;
            mh02608.Checked = false;
            mh02609.Checked = false;
            mh026010.Checked = false;
            mh026011.Checked = false;
            mh027b.Checked = false;
            mh027a2.Checked = false;
            mh026014.Checked = false;
            mh026015.Checked = false;
            mh026016.Checked = false;
            mh026017.Checked = false;
            mh026018.Checked = false;
            mh026019.Checked = false;

            chkVaccination.Checked = false;

            mh02701.Checked = false;
            mh02702.Checked = false;

            mh02801.Checked = false;
            mh02802.Checked = false;

            mh02901.Checked = false;
            mh02902.Checked = false;

            obj_op = null;
        }


        private void mh01901_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01901);
        }


        private void mycheck(CheckBox chk1)
        {
            if (chk1.Checked)
            {
                chkNone.Checked = false;
            }
        }

        private void mh01902_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01902);
        }

        private void mh01903_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01903);
        }

        private void mh01904_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01904);
        }

        private void mh01905_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01905);
        }

        private void mh01906_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01906);
        }

        private void mh01907_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01907);
        }

        private void mh01908_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01908);
        }

        private void mh01909_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh01909);
        }

        private void mh019010_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh019010);
        }

        private void mh019011_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh019011);
        }

        private void mh019012_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh019012);
        }

        private void mh019013_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh019013);
        }

        private void mh019014_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh019014);
        }

        private void mh019015_CheckedChanged(object sender, EventArgs e)
        {
            mycheck(mh019015);
        }

        private void mh02_Enter(object sender, EventArgs e)
        {

        }

        private void cmdNewID_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            mh02.Enabled = true;

            FORM_ID.Text = "";
            mh01.Text = "";
            mh02.Text = "";
            mh03.Text = "";
            mh04.Text = "";
            mh05.Text = "";

            ClearForm();
            mh02.Focus();
            //vScrollBar1.Value = 0;
        }

        private void cmdMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mh013_Leave(object sender, EventArgs e)
        {
            if (mh013.SelectedValue == "0")
            {
                MessageBox.Show("Please select Pallor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh013.Focus();
            }
        }

        private void mh014_Leave(object sender, EventArgs e)
        {
            if (mh014.SelectedValue == "0")
            {
                MessageBox.Show("Please select Hydration ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh014.Focus();
            }
        }


        private void mh02602_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02602.Checked == true)
            {
                mh02603.Checked = false;
                mh02604.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh02603_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02603.Checked == true)
            {
                mh02602.Checked = false;
                mh02604.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh02604_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02604.Checked == true)
            {
                mh02602.Checked = false;
                mh02603.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh02605_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02605.Checked == true)
            {
                mh02606.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh02606_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02606.Checked == true)
            {
                mh02605.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh02608_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            //if (mh02608.Checked == true)
            //{
            //    mh02609.Checked = false;
            //    mh026010.Checked = false;
            //    mh026011.Checked = false;
            //    mh027a1.Checked = false;
            //}

            if (mh02608.Checked == true)
            {
                mh02609.Checked = false;
                mh026010.Checked = false;
                mh026011.Checked = false;
                mh027b.Checked = false;
                //mh027a1.Checked = false;

                obj_op.DisableControls_Checkbox2(mh027a1);
                obj_op.DisableControls_Checkbox2(mh027a2);
            }
            else
            {
                obj_op.EnableControls_Checkbox(mh027a1);
                obj_op.EnableControls_Checkbox(mh027a2);
            }

            obj_op = null;
        }

        private void mh02609_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            //if (mh02609.Checked == true)
            //{
            //    mh02608.Checked = false;
            //    mh026010.Checked = false;
            //    mh026011.Checked = false;
            //    mh027a1.Checked = false;
            //}

            if (mh02609.Checked == true)
            {
                mh02608.Checked = false;
                mh026010.Checked = false;
                mh026011.Checked = false;
                mh027b.Checked = false;
                //mh027a1.Checked = false;

                obj_op.DisableControls_Checkbox2(mh027a1);
                obj_op.DisableControls_Checkbox2(mh027a2);
            }
            else
            {
                obj_op.EnableControls_Checkbox(mh027a1);
                obj_op.EnableControls_Checkbox(mh027a2);
            }

            obj_op = null;
        }

        private void mh026010_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            //if (mh026010.Checked == true)
            //{
            //    mh02608.Checked = false;
            //    mh02609.Checked = false;
            //    mh026011.Checked = false;
            //    mh027a1.Checked = false;
            //}


            if (mh026010.Checked == true)
            {
                mh02608.Checked = false;
                mh02609.Checked = false;
                mh026011.Checked = false;
                mh027b.Checked = false;
                //mh027a1.Checked = false;

                obj_op.DisableControls_Checkbox2(mh027a1);
                obj_op.DisableControls_Checkbox2(mh027a2);
            }
            else
            {
                obj_op.EnableControls_Checkbox(mh027a1);
                obj_op.EnableControls_Checkbox(mh027a2);
            }

            obj_op = null;
        }

        private void mh026011_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            //if (mh026011.Checked == true)
            //{
            //    mh02608.Checked = false;
            //    mh02609.Checked = false;
            //    mh026010.Checked = false;
            //    mh027a1.Checked = false;
            //}

            if (mh026011.Checked == true)
            {
                mh02608.Checked = false;
                mh02609.Checked = false;
                mh026010.Checked = false;
                mh027b.Checked = false;
                //mh027a1.Checked = false;

                obj_op.DisableControls_Checkbox2(mh027a1);
                obj_op.DisableControls_Checkbox2(mh027a2);
            }
            else
            {
                obj_op.EnableControls_Checkbox(mh027a1);
                obj_op.EnableControls_Checkbox(mh027a2);
            }

            obj_op = null;
        }

        private void mh026014_CheckedChanged(object sender, EventArgs e)
        {
            if (mh026014.Checked == true)
            {
                mh026015.Checked = false;
                mh026016.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh026015_CheckedChanged(object sender, EventArgs e)
        {
            if (mh026015.Checked == true)
            {
                mh026014.Checked = false;
                mh026016.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh026016_CheckedChanged(object sender, EventArgs e)
        {
            if (mh026016.Checked == true)
            {
                mh026014.Checked = false;
                mh026015.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh026017_CheckedChanged(object sender, EventArgs e)
        {
            if (mh026017.Checked == true)
            {
                mh026018.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh026018_CheckedChanged(object sender, EventArgs e)
        {
            if (mh026018.Checked == true)
            {
                mh026017.Checked = false;
                mh027b.Checked = false;
            }
        }

        private void mh02601_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02601.Checked == true)
            {
                mh027b.Checked = false;
            }
        }

        private void mh027a1_CheckedChanged(object sender, EventArgs e)
        {
            if (mh027a1.Checked == true)
            {
                mh02608.Checked = false;
                mh02609.Checked = false;
                mh026010.Checked = false;
                mh026011.Checked = false;
            }


            if (mh027a1.Checked == true && mh027a2.Checked)
            {
                MessageBox.Show("Refused for OPV is selected please unchecked ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh027a1.Checked = false;
            }


        }

        private void mh026019_CheckedChanged(object sender, EventArgs e)
        {
            if (mh026019.Checked == true)
            {
                mh027b.Checked = false;
            }
        }

        private void mh01101_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mh01101.Text))
            {
                MessageBox.Show("Please select presenting complaints ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh01101.Focus();
            }
        }

        private void FORM_ID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FORM_ID.Text))
            {
                MessageBox.Show("Please enter form id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FORM_ID.Focus();
            }
            else
            {
                CheckedFormID();
            }
        }



        private string IsMHSID_FormID_Exists_InMaster()
        {

            CDBOperations obj_op = null;
            CConnection cn = null;

            string dbid = "";


            try
            {
                obj_op = new CDBOperations();
                cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_patient where form_id='" + FORM_ID.Text + "' and mh02='" + mh02.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbid = ds.Tables[0].Rows[0]["id"].ToString();
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

            return dbid;
        }



        private void CheckedFormID()
        {

            CDBOperations obj_op = null;
            CConnection cn = null;


            try
            {
                obj_op = new CDBOperations();
                cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_patient where form_id='" + FORM_ID.Text + "' and mh02='" + mh02.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Form ID already exist against this MHS Id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FORM_ID.Focus();
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

        private void chkNoneDiag_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            if ((mh01801.Checked ||
               mh01802.Checked ||
               mh01803.Checked ||
               mh01804.Checked ||
               mh01805.Checked ||
               mh01806.Checked ||
               mh01807.Checked ||
               mh01808.Checked ||
               mh01809.Checked ||
               mh018010.Checked ||
               mh018011.Checked ||
               mh018012.Checked ||
               mh018013.Checked ||
               mh018014.Checked ||
               mh018015.Checked ||
               mh018016.Checked ||
               mh018077.Checked) && chkNoneDiag.Checked)
            {
                MessageBox.Show("You have already selected an option in Diagnosis in children. Please clear it first  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkNoneDiag.Checked = false;
                return;
            }



            if (chkNoneDiag.Checked == true)
            {
                obj_op.DisableControls_Checkbox(mh01801);
                obj_op.DisableControls_Checkbox(mh01802);
                obj_op.DisableControls_Checkbox(mh01803);
                obj_op.DisableControls_Checkbox(mh01804);
                obj_op.DisableControls_Checkbox(mh01805);
                obj_op.DisableControls_Checkbox(mh01806);
                obj_op.DisableControls_Checkbox(mh01807);
                obj_op.DisableControls_Checkbox(mh01808);
                obj_op.DisableControls_Checkbox(mh01809);
                obj_op.DisableControls_Checkbox(mh018010);
                obj_op.DisableControls_Checkbox(mh018011);
                obj_op.DisableControls_Checkbox(mh018012);
                obj_op.DisableControls_Checkbox(mh018013);
                obj_op.DisableControls_Checkbox(mh018014);
                obj_op.DisableControls_Checkbox(mh018015);
                obj_op.DisableControls_Checkbox(mh018016);
                obj_op.DisableControls_Checkbox(mh018077);
                obj_op.DisableControls(mh018077x);
            }
            else
            {
                obj_op.EnableControls(mh01801);
                obj_op.EnableControls(mh01802);
                obj_op.EnableControls(mh01803);
                obj_op.EnableControls(mh01804);
                obj_op.EnableControls(mh01805);
                obj_op.EnableControls(mh01806);
                obj_op.EnableControls(mh01807);
                obj_op.EnableControls(mh01808);
                obj_op.EnableControls(mh01809);
                obj_op.EnableControls(mh018010);
                obj_op.EnableControls(mh018011);
                obj_op.EnableControls(mh018012);
                obj_op.EnableControls(mh018013);
                obj_op.EnableControls(mh018014);
                obj_op.EnableControls(mh018015);
                obj_op.EnableControls(mh018016);
                obj_op.EnableControls(mh018077);
            }

            obj_op = null;
        }

        private void mh02202_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02202.Checked && mh02501.Checked)
            {
                MessageBox.Show("if Ever received OPV is [2 - No] then Received OPV in last campaign cannot be [1 - Yes] ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh02202.Checked = false;
            }
        }

        private void mh02501_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02202.Checked && mh02501.Checked)
            {
                MessageBox.Show("if Ever received OPV is [2 - No] then Received OPV in last campaign cannot be [1 - Yes] ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh02501.Checked = false;
            }
        }

        private void mh02302_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02302.Checked && mh02401.Checked)
            {
                MessageBox.Show("if Ever received routine immunization is [2 - No] then Vaccination Card available cannot be [1 - Yes] ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh02302.Checked = false;
            }
        }

        private void mh02401_CheckedChanged(object sender, EventArgs e)
        {
            if (mh02302.Checked && mh02401.Checked)
            {
                MessageBox.Show("if Ever received routine immunization is [2 - No] then Vaccination Card available cannot be [1 - Yes] ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh02401.Checked = false;
            }
        }

        private void mh01704_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            if ((mh01701.Checked ||
               mh01702.Checked ||
               mh01703.Checked ||
               mh017077.Checked) && mh01704.Checked)
            {
                MessageBox.Show("You have already selected an option in Diagnosis in pregnant women / mother. Please clear it first  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mh01704.Checked = false;
                return;
            }


            if (mh01704.Checked)
            {
                obj_op.DisableControls_Checkbox2(mh01701);
                obj_op.DisableControls_Checkbox2(mh01702);
                obj_op.DisableControls_Checkbox2(mh01703);
                obj_op.DisableControls_Checkbox2(mh017077);
                obj_op.DisableControls(mh017077x);
            }
            else
            {
                obj_op.EnableControls_Checkbox(mh01701);
                obj_op.EnableControls_Checkbox(mh01702);
                obj_op.EnableControls_Checkbox(mh01703);
                obj_op.EnableControls_Checkbox(mh017077);
            }

            obj_op = null;
        }

        private void chkVaccination_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if ((mh02601.Checked ||
               mh02602.Checked ||
               mh02603.Checked ||
               mh02604.Checked ||
               mh02605.Checked ||
               mh02606.Checked ||
               mh02608.Checked ||
               mh02609.Checked ||
               mh026010.Checked ||
               mh026011.Checked ||
               mh026014.Checked ||
               mh026015.Checked ||
               mh026016.Checked ||
               mh026017.Checked ||
               mh026018.Checked ||
               mh02701.Checked ||
               mh02702.Checked ||
               mh027a1.Checked ||
               mh027a2.Checked ||
               mh026019.Checked) && chkVaccination.Checked
               )
            {
                MessageBox.Show("Vaccinations have been reported first clear the vaccination ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkVaccination.Checked = false;
                mh02701.Checked = false;
                mh02702.Checked = false;
                return;
            }



            if (chkVaccination.Checked)
            {
                obj_op.DisableControls_Checkbox(mh02601);
                obj_op.DisableControls_Checkbox(mh02602);
                obj_op.DisableControls_Checkbox(mh02603);
                obj_op.DisableControls_Checkbox(mh02604);
                obj_op.DisableControls_Checkbox(mh02605);
                obj_op.DisableControls_Checkbox(mh02606);
                //obj_op.DisableControls_Checkbox(mh02607);
                obj_op.DisableControls_Checkbox(mh02608);
                obj_op.DisableControls_Checkbox(mh02609);
                obj_op.DisableControls_Checkbox(mh026010);
                obj_op.DisableControls_Checkbox(mh026011);

                //obj_op.DisableControls_Checkbox(mh026013);

                obj_op.DisableControls_Checkbox(mh026014);
                obj_op.DisableControls_Checkbox(mh026015);
                obj_op.DisableControls_Checkbox(mh026016);
                obj_op.DisableControls_Checkbox(mh026017);
                obj_op.DisableControls_Checkbox(mh026018);
                obj_op.DisableControls_Checkbox(mh026019);
                obj_op.DisableControls_Checkbox(mh027b);

                panel8.Enabled = false;

                obj_op.DisableControls_Checkbox(mh027a1);
                obj_op.DisableControls_Checkbox(mh027a2);
                obj_op.DisableControls_RadioButton(mh02701);
                obj_op.DisableControls_RadioButton(mh02702);
            }
            else
            {
                obj_op.EnableControls(mh02601);
                obj_op.EnableControls(mh02602);
                obj_op.EnableControls(mh02603);
                obj_op.EnableControls(mh02604);
                obj_op.EnableControls(mh02605);
                obj_op.EnableControls(mh02606);
                //obj_op.EnableControls(mh02607);
                obj_op.EnableControls(mh02608);
                obj_op.EnableControls(mh02609);
                obj_op.EnableControls(mh026010);
                obj_op.EnableControls(mh026011);

                //obj_op.EnableControls(mh026013);

                obj_op.EnableControls(mh026014);
                obj_op.EnableControls(mh026015);
                obj_op.EnableControls(mh026016);
                obj_op.EnableControls(mh026017);
                obj_op.EnableControls(mh026018);
                obj_op.EnableControls(mh026019);

                obj_op.EnableControls(mh027b);
                obj_op.EnableControls(mh027a1);
                obj_op.EnableControls(mh027a2);
                obj_op.EnableControls(mh02701);
                obj_op.EnableControls(mh02702);

                panel8.Enabled = true;
            }

            obj_op = null;


        }

    }
}