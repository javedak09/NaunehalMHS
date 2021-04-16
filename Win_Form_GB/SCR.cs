using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Win_Form_GB
{
    public partial class SCR : Form
    {
        private bool IsSearch = false;
        private bool IsUpdate = false;
        private string comp_name = "";
        private string user_name = "";
        private string error_fldName = "";
        private bool IsError = false;

        public SCR()
        {
            InitializeComponent();
        }

        private void frmSCR_Load(object sender, EventArgs e)
        {

        }





        private void FORM_ID_Leave(object sender, EventArgs e)
        {
            if (FORM_ID.Text.IndexOf(" ") == -1)
            {
                if (FORM_ID.Text != "0000000")
                {
                    CDBOperations obj_op = new CDBOperations();

                    try
                    {
                        if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'FORM_ID'", FORM_ID.Text) == true)
                        {
                            FORM_ID.Focus();
                        }
                        else
                        {
                            COMP_ID.Text = Convert.ToString(Convert.ToInt32(FORM_ID.Text) * 100);
                            ClearFields();
                            SearchRecord();
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
                else
                {
                    ClearFields();
                    cmdSave.Visible = false;
                    cmdDelete.Visible = false;
                }
            }
            else
            {
                ClearFields();
                MessageBox.Show("Form ID does not any space or any other character except numeric digits ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                FORM_ID.Focus();
            }

            FORM_ID.BackColor = Color.White;
            ChangeColorLabel(0, lbl_FORM_ID);
        }


        private void cs01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs01'", cs01.Text) == true)
                {
                    cs01.Focus();
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

            cs01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs01);
        }


        private void cs02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs02'", cs02.Text) == true)
                {
                    cs02.Focus();
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

            cs02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs02);
        }


        private void cs03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs03'", cs03.Text) == true)
                {
                    cs03.Focus();
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

            cs03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs03);
        }


        private void cs04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs04'", cs04.Text) == true)
                {
                    cs04.Focus();
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

            cs04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs04);
        }


        private void cs05_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs05'", cs05.Text) == true)
                {
                    cs05.Focus();
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

            cs05.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs05);
        }


        private void cs06_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs06'", cs06.Text) == true)
                {
                    cs06.Focus();
                }
                else
                {
                    if (cs06.Text == "96")
                    {
                        obj_op.EnableControls(cs06a);
                        obj_op.EnableControls(cs06b);
                        obj_op.EnableControls(cs06c);
                        obj_op.EnableControls(cs06d);
                        obj_op.EnableControls(cs06e);

                        cs06a.Focus();

                    }
                    else
                    {
                        obj_op.DisableControls(cs06a);
                        obj_op.DisableControls(cs06b);
                        obj_op.DisableControls(cs06c);
                        obj_op.DisableControls(cs06d);
                        obj_op.DisableControls(cs06e);

                        tabControl1.SelectedIndex = 1;

                        cs07.Focus();

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

            cs06.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs06);
        }


        private void cs06a_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs06a'", cs06a.Text) == true)
                {
                    cs06a.Focus();
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

            cs06a.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs06a);
        }


        private void cs06b_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs06b.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs06b'", cs06b.Text) == true)
                    {
                        cs06b.Focus();
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

            cs06b.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs06b);
        }


        private void cs06c_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs06c.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs06c'", cs06c.Text) == true)
                    {
                        cs06c.Focus();
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

            cs06c.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs06c);
        }


        private void cs06d_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs06d.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs06d'", cs06d.Text) == true)
                    {
                        cs06d.Focus();
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

            cs06d.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs06d);
        }


        private void cs06e_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs06e.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs06e'", cs06e.Text) == true)
                    {
                        cs06e.Focus();
                    }
                    else
                    {
                        tabControl1.SelectedIndex = 1;
                    }
                }
                else
                {
                    tabControl1.SelectedIndex = 1;
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

            cs06e.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs06e);
        }


        private void cs07_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(cs07.Text))
                {
                    MessageBox.Show("Assessor Name cannnot be blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs07.Focus();
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

            cs07.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs07);
        }


        private void cs08_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            if (cs08.Text.IndexOf(" ") == -1)
            {
                if (cs08.Text.Length == 10)
                {
                    try
                    {
                        if (cs08.Text != "  /  /")
                        {

                            DateTime dt_a111 = new DateTime();
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            dt_a111 = Convert.ToDateTime(cs08.Text);


                            DateTime dt_study = new DateTime();
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            dt_study = Convert.ToDateTime("01/11/2020");


                            if (dt_a111 > DateTime.Now.Date)
                            {
                                MessageBox.Show("Date of screening cannot be greater than todays's date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tabControl1.SelectedIndex = 1;
                                cs08.Focus();
                            }
                            else
                            {
                                if (dt_a111 < dt_study)
                                {
                                    MessageBox.Show("Date of screening cannot be less than study's starting date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tabControl1.SelectedIndex = 1;
                                    cs08.Focus();
                                }
                                else
                                {
                                    cs08.BackColor = Color.White;
                                    ChangeColorLabel(0, lbl_cs08);
                                }
                            }
                        }
                        else if (cs08.Text == "  /  /")
                        {
                            MessageBox.Show("Date of screening cannot be blank ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabControl1.SelectedIndex = 1;
                            cs08.Focus();
                        }
                    }

                    catch (Exception ex)
                    {
                        if (ex.Message == "String was not recognized as a valid DateTime.")
                        {
                            MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cs08.Focus();
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cs08.Focus();
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
                    cs08.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter complete date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs08.Focus();
            }

            cs08.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs08);
        }


        private void cs09_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs09'", cs09.Text) == true)
                {
                    cs09.Focus();
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

            cs09.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs09);
        }


        private void cs10_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs10'", cs10.Text) == true)
                {
                    cs10.Focus();
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

            cs10.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs10);
        }


        private void cs11_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(cs11.Text))
                {
                    MessageBox.Show("Name cannnot be blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs11.Focus();
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

            cs11.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs11);
        }


        private void cs12_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(cs12.Text))
                {
                    MessageBox.Show("Father Name cannnot be blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs12.Focus();
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

            cs12.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs12);
        }


        private void cs13_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs13'", cs13.Text) == true)
                {
                    cs13.Focus();
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

            cs13.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs13);
        }


        private void cs14_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();


            if (cs14.Text.IndexOf(" ") == -1)
            {
                if (cs14.Text.Length == 10)
                {
                    try
                    {
                        if (cs14.Text != "  /  /")
                        {

                            DateTime dt_a111 = new DateTime();
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            dt_a111 = Convert.ToDateTime(cs14.Text);


                            DateTime dt_study = new DateTime();
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            dt_study = Convert.ToDateTime("01/11/2020");


                            if (dt_a111 > DateTime.Now.Date)
                            {
                                MessageBox.Show("Child Date of birth cannot be greater than todays's date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tabControl1.SelectedIndex = 1;
                                cs14.Focus();
                            }
                            else
                            {
                                if (dt_a111 < dt_study)
                                {
                                    MessageBox.Show("Child Date of birth cannot be less than study's starting date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tabControl1.SelectedIndex = 1;
                                    cs14.Focus();
                                }
                                else
                                {
                                    cs14.BackColor = Color.White;
                                    ChangeColorLabel(0, lbl_cs14);
                                }
                            }
                        }
                        else if (cs14.Text == "  /  /")
                        {
                            MessageBox.Show("Child Date of birth cannot be blank ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabControl1.SelectedIndex = 1;
                            cs14.Focus();
                        }
                    }

                    catch (Exception ex)
                    {
                        if (ex.Message == "String was not recognized as a valid DateTime.")
                        {
                            MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cs14.Focus();
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cs14.Focus();
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
                    cs14.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter complete date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cs14.Focus();
            }

            cs14.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs14);
        }


        private void cs15_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs15'", cs15.Text) == true)
                {
                    cs15.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 2;
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

            cs15.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs15);
        }


        private void cs16_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs16'", cs16.Text) == true)
                {
                    cs16.Focus();
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

            cs16.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs16);
        }


        private void cs17_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (cs17.Text.IndexOf(' ') != -1)
                {
                    MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs17.Focus();
                }
                else
                {
                    if (cs17.Text.Length != 5)
                    {
                        MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs17.Focus();
                    }
                    else
                    {
                        if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs17'", cs17.Text) == true)
                        {
                            cs17.Focus();
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

            cs17.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs17);
        }


        private void cs18_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs18'", cs18.Text) == true)
                {
                    cs18.Focus();
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

            cs18.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs18);
        }


        private void cs19_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs19'", cs19.Text) == true)
                {
                    cs19.Focus();
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

            cs19.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs19);
        }


        private void cs20_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs20'", cs20.Text) == true)
                {
                    cs20.Focus();
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

            cs20.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs20);
        }


        private void cs21_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs21'", cs21.Text) == true)
                {
                    cs21.Focus();
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

            cs21.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs21);
        }


        private void cs22_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (cs22.Text.IndexOf(' ') != -1)
                {
                    MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs22.Focus();
                }
                else
                {
                    if (cs22.Text.Length != 5)
                    {
                        MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs22.Focus();
                    }
                    else
                    {
                        if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs22'", cs22.Text) == true)
                        {
                            cs22.Focus();
                        }
                        else
                        {
                            Calc_ZScore();
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

            cs22.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs22);
        }


        private void cs23_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (cs23.Text.IndexOf(' ') != -1)
                {
                    MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs23.Focus();
                }
                else
                {
                    if (cs23.Text.Length != 5)
                    {
                        MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs23.Focus();
                    }
                    else
                    {
                        if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs23'", cs23.Text) == true)
                        {
                            cs23.Focus();
                        }
                        else
                        {
                            tabControl1.SelectedIndex = 3;
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

            cs23.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs23);
        }


        private void cs24_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (cs24.Text.IndexOf(' ') != -1)
                {
                    MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs24.Focus();
                }
                else
                {
                    if (cs24.Text.Length != 4)
                    {
                        MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cs24.Focus();
                    }
                    else
                    {
                        if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs24'", cs24.Text) == true)
                        {
                            cs24.Focus();
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

            cs24.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs24);
        }


        private void cs25_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs25'", cs25.Text) == true)
                {
                    cs25.Focus();
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

            cs25.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs25);
        }


        private void cs26_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs26'", cs26.Text) == true)
                {
                    cs26.Focus();
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

            cs26.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs26);
        }


        private void cs27_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs27'", cs27.Text) == true)
                {
                    cs27.Focus();
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

            cs27.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs27);
        }


        private void cs28a_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs28a'", cs28a.Text) == true)
                {
                    cs28a.Focus();
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

            cs28a.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs28a);
        }


        private void cs28b_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs28b'", cs28b.Text) == true)
                {
                    cs28b.Focus();
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

            cs28b.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs28b);
        }


        private void cs28c_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs28c'", cs28c.Text) == true)
                {
                    cs28c.Focus();
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

            cs28c.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs28c);
        }


        private void cs29a_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29a'", cs29a.Text) == true)
                {
                    cs29a.Focus();
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

            cs29a.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29a);
        }


        private void cs29b_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29b'", cs29b.Text) == true)
                {
                    cs29b.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 4;
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

            cs29b.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29b);
        }


        private void cs29c_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29c'", cs29c.Text) == true)
                {
                    cs29c.Focus();
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

            cs29c.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29c);
        }


        private void cs29d_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29d'", cs29d.Text) == true)
                {
                    cs29d.Focus();
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

            cs29d.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29d);
        }


        private void cs29e_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29e'", cs29e.Text) == true)
                {
                    cs29e.Focus();
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

            cs29e.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29e);
        }


        private void cs29f_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29f'", cs29f.Text) == true)
                {
                    cs29f.Focus();
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

            cs29f.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29f);
        }


        private void cs29g_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29g'", cs29g.Text) == true)
                {
                    cs29g.Focus();
                }
                else
                {
                    if (cs29g.Text == "1")
                    {
                        obj_op.EnableControls(cs29g1);
                        obj_op.EnableControls(cs29g2);
                        obj_op.EnableControls(cs29g3);
                        obj_op.EnableControls(cs29g4);

                        cs29g1.Focus();

                    }
                    else
                    {
                        obj_op.DisableControls(cs29g1);
                        obj_op.DisableControls(cs29g2);
                        obj_op.DisableControls(cs29g3);
                        obj_op.DisableControls(cs29g4);

                        cmdSave.Focus();

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

            cs29g.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29g);
        }


        private void cs29g1_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29g1'", cs29g1.Text) == true)
                {
                    cs29g1.Focus();
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

            cs29g1.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29g1);
        }


        private void cs29g2_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs29g2.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29g2'", cs29g2.Text) == true)
                    {
                        cs29g2.Focus();
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

            cs29g2.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29g2);
        }


        private void cs29g3_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs29g3.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29g3'", cs29g3.Text) == true)
                    {
                        cs29g3.Focus();
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

            cs29g3.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29g3);
        }


        private void cs29g4_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (!string.IsNullOrEmpty(cs29g4.Text))
                {
                    if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'SCR' and var_id = 'cs29g4'", cs29g4.Text) == true)
                    {
                        cs29g4.Focus();
                    }
                    else
                    {
                        cmdSave.Focus();
                    }
                }
                else;
                {
                    cmdSave.Focus();
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

            cs29g4.BackColor = Color.White;
            ChangeColorLabel(0, lbl_cs29g4);
        }
        private void ChangeColorLabel(int a, Label lbl)
        {
            if (a == 1)
            {
                lbl.BackColor = Color.FromName("Aqua");
                //lbl.Width = 350;            
                //lbl.Height = 75;            
            }
            else
            {
                lbl.BackColor = Color.FromName("Control");
                //lbl.Width = 200;            
                //lbl.Height = 75;            
            }

        }
        private void FORM_ID_Enter(object sender, EventArgs e)
        {
            FORM_ID.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_FORM_ID);
            FORM_ID.SelectAll();
        }

        private void cs01_Enter(object sender, EventArgs e)
        {
            cs01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs01);
            cs01.SelectAll();
        }

        private void cs02_Enter(object sender, EventArgs e)
        {
            cs02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs02);
            cs02.SelectAll();
        }

        private void cs03_Enter(object sender, EventArgs e)
        {
            cs03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs03);
            cs03.SelectAll();
        }

        private void cs04_Enter(object sender, EventArgs e)
        {
            cs04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs04);
            cs04.SelectAll();
        }

        private void cs05_Enter(object sender, EventArgs e)
        {
            cs05.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs05);
            cs05.SelectAll();
        }

        private void cs06_Enter(object sender, EventArgs e)
        {
            cs06.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs06);
            cs06.SelectAll();
        }

        private void cs06a_Enter(object sender, EventArgs e)
        {
            cs06a.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs06a);
            cs06a.SelectAll();
        }

        private void cs06b_Enter(object sender, EventArgs e)
        {
            cs06b.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs06b);
            cs06b.SelectAll();
        }

        private void cs06c_Enter(object sender, EventArgs e)
        {
            cs06c.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs06c);
            cs06c.SelectAll();
        }

        private void cs06d_Enter(object sender, EventArgs e)
        {
            cs06d.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs06d);
            cs06d.SelectAll();
        }

        private void cs06e_Enter(object sender, EventArgs e)
        {
            cs06e.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs06e);
            cs06e.SelectAll();
        }

        private void cs07_Enter(object sender, EventArgs e)
        {
            cs07.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs07);
            cs07.SelectAll();
        }

        private void cs08_Enter(object sender, EventArgs e)
        {
            cs08.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs08);
            cs08.SelectAll();
        }

        private void cs09_Enter(object sender, EventArgs e)
        {
            cs09.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs09);
            cs09.SelectAll();
        }

        private void cs10_Enter(object sender, EventArgs e)
        {
            cs10.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs10);
            cs10.SelectAll();
        }

        private void cs11_Enter(object sender, EventArgs e)
        {
            cs11.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs11);
            cs11.SelectAll();
        }

        private void cs12_Enter(object sender, EventArgs e)
        {
            cs12.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs12);
            cs12.SelectAll();
        }

        private void cs13_Enter(object sender, EventArgs e)
        {
            cs13.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs13);
            cs13.SelectAll();
        }

        private void cs14_Enter(object sender, EventArgs e)
        {
            cs14.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs14);
            cs14.SelectAll();
        }

        private void cs15_Enter(object sender, EventArgs e)
        {
            cs15.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs15);
            cs15.SelectAll();
        }

        private void cs16_Enter(object sender, EventArgs e)
        {
            cs16.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs16);
            cs16.SelectAll();
        }

        private void cs17_Enter(object sender, EventArgs e)
        {
            cs17.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs17);
            cs17.SelectAll();
        }

        private void cs18_Enter(object sender, EventArgs e)
        {
            cs18.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs18);
            cs18.SelectAll();
        }

        private void cs19_Enter(object sender, EventArgs e)
        {
            cs19.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs19);
            cs19.SelectAll();
        }

        private void cs20_Enter(object sender, EventArgs e)
        {
            cs20.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs20);
            cs20.SelectAll();
        }

        private void cs21_Enter(object sender, EventArgs e)
        {
            cs21.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs21);
            cs21.SelectAll();
        }

        private void cs22_Enter(object sender, EventArgs e)
        {
            cs22.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs22);
            cs22.SelectAll();
        }

        private void cs23_Enter(object sender, EventArgs e)
        {
            cs23.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs23);
            cs23.SelectAll();
        }

        private void cs24_Enter(object sender, EventArgs e)
        {
            cs24.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs24);
            cs24.SelectAll();
        }

        private void cs25_Enter(object sender, EventArgs e)
        {
            cs25.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs25);
            cs25.SelectAll();
        }

        private void cs26_Enter(object sender, EventArgs e)
        {
            cs26.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs26);
            cs26.SelectAll();
        }

        private void cs27_Enter(object sender, EventArgs e)
        {
            cs27.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs27);
            cs27.SelectAll();
        }

        private void cs28a_Enter(object sender, EventArgs e)
        {
            cs28a.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs28a);
            cs28a.SelectAll();
        }

        private void cs28b_Enter(object sender, EventArgs e)
        {
            cs28b.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs28b);
            cs28b.SelectAll();
        }

        private void cs28c_Enter(object sender, EventArgs e)
        {
            cs28c.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs28c);
            cs28c.SelectAll();
        }

        private void cs29a_Enter(object sender, EventArgs e)
        {
            cs29a.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29a);
            cs29a.SelectAll();
        }

        private void cs29b_Enter(object sender, EventArgs e)
        {
            cs29b.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29b);
            cs29b.SelectAll();
        }

        private void cs29c_Enter(object sender, EventArgs e)
        {
            cs29c.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29c);
            cs29c.SelectAll();
        }

        private void cs29d_Enter(object sender, EventArgs e)
        {
            cs29d.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29d);
            cs29d.SelectAll();
        }

        private void cs29e_Enter(object sender, EventArgs e)
        {
            cs29e.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29e);
            cs29e.SelectAll();
        }

        private void cs29f_Enter(object sender, EventArgs e)
        {
            cs29f.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29f);
            cs29f.SelectAll();
        }

        private void cs29g_Enter(object sender, EventArgs e)
        {
            cs29g.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29g);
            cs29g.SelectAll();
        }

        private void cs29g1_Enter(object sender, EventArgs e)
        {
            cs29g1.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29g1);
            cs29g1.SelectAll();
        }

        private void cs29g2_Enter(object sender, EventArgs e)
        {
            cs29g2.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29g2);
            cs29g2.SelectAll();
        }

        private void cs29g3_Enter(object sender, EventArgs e)
        {
            cs29g3.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29g3);
            cs29g3.SelectAll();
        }

        private void cs29g4_Enter(object sender, EventArgs e)
        {
            cs29g4.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_cs29g4);
            cs29g4.SelectAll();
        }

        private void SearchRecord()
        {
            DataSet ds = null;
            CDBOperations obj_op = null;

            try
            {
                ds = new DataSet();


                string qry = "select FORM_ID ," +
                "cs01    ," +
                "cs02    ," +
                "cs03    ," +
                "cs04    ," +
                "cs05    ," +
                "cs06    ," +
                "cs07    ," +
                "cs08    ," +
                "cs09    ," +
                "cs10    ," +
                "cs11    ," +
                "cs12    ," +
                "cs13    ," +
                "cs14    ," +
                "cs15    ," +
                "cs16    ," +
                "cs17    ," +
                "cs18    ," +
                "cs19    ," +
                "cs20    ," +
                "cs21    ," +
                "cs22    ," +
                "cs23    ," +
                "cs24    ," +
                "cs25    ," +
                "cs26    ," +
                "cs27    ," +
                "cs28a   ," +
                "cs28b   ," +
                "cs28c   ," +
                "cs29a   ," +
                "cs29b   ," +
                "cs29c   ," +
                "cs29d   ," +
                "cs29e   ," +
                "cs29f   ," +
                "cs29g   ," +
                "cs29g1  ," +
                "cs29g2  ," +
                "cs29g3  ," +
                "cs29g4  ," +
                "cs06a   ," +
                "cs06b   ," +
                "cs06c   ," +
                "cs06d   ," +
                "cs06e from scr where FORM_ID = '" + FORM_ID.Text + "'";



                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    obj_op = new CDBOperations();
                    ds = obj_op.GetFormData_VisitID(qry, "0", FORM_ID.Text, "");
                }
                else if (CVariables.IsUserFirstOrSecond == "User2")
                {
                    obj_op = new CDBOperations();
                    ds = obj_op.GetFormData_VisitID(qry, "1", FORM_ID.Text, "");
                }


                maskedTextBox1.Text = "";
                cmdDelete.Visible = false;


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            IsSearch = true;
                            IsUpdate = true;


                            if (CVariables.IsAdmin == false)
                            {
                                cmdDelete.Visible = false;
                            }
                            else
                            {
                                cmdDelete.Visible = true;
                            }


                            if (ds.Tables[0].Rows[0]["FORM_ID"].ToString() == null)
                            {
                                maskedTextBox1.Text = "";
                            }
                            else
                            {
                                maskedTextBox1.Text = ds.Tables[0].Rows[0]["FORM_ID"].ToString();
                            }


                            if (ds.Tables[0].Rows[0]["cs01"].ToString() == null)
                            {
                                cs01.Text = "";
                            }
                            else
                            {
                                cs01.Text = ds.Tables[0].Rows[0]["cs01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs02"].ToString() == null)
                            {
                                cs02.Text = "";
                            }
                            else
                            {
                                cs02.Text = ds.Tables[0].Rows[0]["cs02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs03"].ToString() == null)
                            {
                                cs03.Text = "";
                            }
                            else
                            {
                                cs03.Text = ds.Tables[0].Rows[0]["cs03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs04"].ToString() == null)
                            {
                                cs04.Text = "";
                            }
                            else
                            {
                                cs04.Text = ds.Tables[0].Rows[0]["cs04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs05"].ToString() == null)
                            {
                                cs05.Text = "";
                            }
                            else
                            {
                                cs05.Text = ds.Tables[0].Rows[0]["cs05"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs06"].ToString() == null)
                            {
                                cs06.Text = "";
                            }
                            else
                            {
                                cs06.Text = ds.Tables[0].Rows[0]["cs06"].ToString();

                                if (cs06.Text == "96")
                                {
                                    obj_op.EnableControls(cs06a);
                                    obj_op.EnableControls(cs06b);
                                    obj_op.EnableControls(cs06c);
                                    obj_op.EnableControls(cs06d);
                                    obj_op.EnableControls(cs06e);

                                }
                                else
                                {
                                    obj_op.DisableControls(cs06a);
                                    obj_op.DisableControls(cs06b);
                                    obj_op.DisableControls(cs06c);
                                    obj_op.DisableControls(cs06d);
                                    obj_op.DisableControls(cs06e);

                                }

                            }

                            if (ds.Tables[0].Rows[0]["cs06a"].ToString() == null)
                            {
                                cs06a.Text = "";
                            }
                            else
                            {
                                cs06a.Text = ds.Tables[0].Rows[0]["cs06a"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs06b"].ToString() == null)
                            {
                                cs06b.Text = "";
                            }
                            else
                            {
                                cs06b.Text = ds.Tables[0].Rows[0]["cs06b"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs06c"].ToString() == null)
                            {
                                cs06c.Text = "";
                            }
                            else
                            {
                                cs06c.Text = ds.Tables[0].Rows[0]["cs06c"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs06d"].ToString() == null)
                            {
                                cs06d.Text = "";
                            }
                            else
                            {
                                cs06d.Text = ds.Tables[0].Rows[0]["cs06d"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs06e"].ToString() == null)
                            {
                                cs06e.Text = "";
                            }
                            else
                            {
                                cs06e.Text = ds.Tables[0].Rows[0]["cs06e"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs07"].ToString() == null)
                            {
                                cs07.Text = "";
                            }
                            else
                            {
                                cs07.Text = ds.Tables[0].Rows[0]["cs07"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs08"].ToString() == null)
                            {
                                cs08.Text = "";
                            }
                            else
                            {
                                cs08.Text = ds.Tables[0].Rows[0]["cs08"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs09"].ToString() == null)
                            {
                                cs09.Text = "";
                            }
                            else
                            {
                                cs09.Text = ds.Tables[0].Rows[0]["cs09"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs10"].ToString() == null)
                            {
                                cs10.Text = "";
                            }
                            else
                            {
                                cs10.Text = ds.Tables[0].Rows[0]["cs10"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs11"].ToString() == null)
                            {
                                cs11.Text = "";
                            }
                            else
                            {
                                cs11.Text = ds.Tables[0].Rows[0]["cs11"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs12"].ToString() == null)
                            {
                                cs12.Text = "";
                            }
                            else
                            {
                                cs12.Text = ds.Tables[0].Rows[0]["cs12"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs13"].ToString() == null)
                            {
                                cs13.Text = "";
                            }
                            else
                            {
                                cs13.Text = ds.Tables[0].Rows[0]["cs13"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs14"].ToString() == null)
                            {
                                cs14.Text = "";
                            }
                            else
                            {
                                cs14.Text = ds.Tables[0].Rows[0]["cs14"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs15"].ToString() == null)
                            {
                                cs15.Text = "";
                            }
                            else
                            {
                                cs15.Text = ds.Tables[0].Rows[0]["cs15"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs16"].ToString() == null)
                            {
                                cs16.Text = "";
                            }
                            else
                            {
                                cs16.Text = ds.Tables[0].Rows[0]["cs16"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs17"].ToString() == null)
                            {
                                cs17.Text = "";
                            }
                            else
                            {
                                cs17.Text = ds.Tables[0].Rows[0]["cs17"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs18"].ToString() == null)
                            {
                                cs18.Text = "";
                            }
                            else
                            {
                                cs18.Text = ds.Tables[0].Rows[0]["cs18"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs19"].ToString() == null)
                            {
                                cs19.Text = "";
                            }
                            else
                            {
                                cs19.Text = ds.Tables[0].Rows[0]["cs19"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs20"].ToString() == null)
                            {
                                cs20.Text = "";
                            }
                            else
                            {
                                cs20.Text = ds.Tables[0].Rows[0]["cs20"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs21"].ToString() == null)
                            {
                                cs21.Text = "";
                            }
                            else
                            {
                                cs21.Text = ds.Tables[0].Rows[0]["cs21"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs22"].ToString() == null)
                            {
                                cs22.Text = "";
                            }
                            else
                            {
                                cs22.Text = ds.Tables[0].Rows[0]["cs22"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs23"].ToString() == null)
                            {
                                cs23.Text = "";
                            }
                            else
                            {
                                cs23.Text = ds.Tables[0].Rows[0]["cs23"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs24"].ToString() == null)
                            {
                                cs24.Text = "";
                            }
                            else
                            {
                                cs24.Text = ds.Tables[0].Rows[0]["cs24"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs25"].ToString() == null)
                            {
                                cs25.Text = "";
                            }
                            else
                            {
                                cs25.Text = ds.Tables[0].Rows[0]["cs25"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs26"].ToString() == null)
                            {
                                cs26.Text = "";
                            }
                            else
                            {
                                cs26.Text = ds.Tables[0].Rows[0]["cs26"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs27"].ToString() == null)
                            {
                                cs27.Text = "";
                            }
                            else
                            {
                                cs27.Text = ds.Tables[0].Rows[0]["cs27"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs28a"].ToString() == null)
                            {
                                cs28a.Text = "";
                            }
                            else
                            {
                                cs28a.Text = ds.Tables[0].Rows[0]["cs28a"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs28b"].ToString() == null)
                            {
                                cs28b.Text = "";
                            }
                            else
                            {
                                cs28b.Text = ds.Tables[0].Rows[0]["cs28b"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs28c"].ToString() == null)
                            {
                                cs28c.Text = "";
                            }
                            else
                            {
                                cs28c.Text = ds.Tables[0].Rows[0]["cs28c"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29a"].ToString() == null)
                            {
                                cs29a.Text = "";
                            }
                            else
                            {
                                cs29a.Text = ds.Tables[0].Rows[0]["cs29a"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29b"].ToString() == null)
                            {
                                cs29b.Text = "";
                            }
                            else
                            {
                                cs29b.Text = ds.Tables[0].Rows[0]["cs29b"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29c"].ToString() == null)
                            {
                                cs29c.Text = "";
                            }
                            else
                            {
                                cs29c.Text = ds.Tables[0].Rows[0]["cs29c"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29d"].ToString() == null)
                            {
                                cs29d.Text = "";
                            }
                            else
                            {
                                cs29d.Text = ds.Tables[0].Rows[0]["cs29d"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29e"].ToString() == null)
                            {
                                cs29e.Text = "";
                            }
                            else
                            {
                                cs29e.Text = ds.Tables[0].Rows[0]["cs29e"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29f"].ToString() == null)
                            {
                                cs29f.Text = "";
                            }
                            else
                            {
                                cs29f.Text = ds.Tables[0].Rows[0]["cs29f"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29g"].ToString() == null)
                            {
                                cs29g.Text = "";
                            }
                            else
                            {
                                cs29g.Text = ds.Tables[0].Rows[0]["cs29g"].ToString();


                                if (cs29g.Text == "1")
                                {
                                    obj_op.EnableControls(cs29g1);
                                    obj_op.EnableControls(cs29g2);
                                    obj_op.EnableControls(cs29g3);
                                    obj_op.EnableControls(cs29g4);

                                }
                                else
                                {
                                    obj_op.DisableControls(cs29g1);
                                    obj_op.DisableControls(cs29g2);
                                    obj_op.DisableControls(cs29g3);
                                    obj_op.DisableControls(cs29g4);
                                }

                            }

                            if (ds.Tables[0].Rows[0]["cs29g1"].ToString() == null)
                            {
                                cs29g1.Text = "";
                            }
                            else
                            {
                                cs29g1.Text = ds.Tables[0].Rows[0]["cs29g1"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29g2"].ToString() == null)
                            {
                                cs29g2.Text = "";
                            }
                            else
                            {
                                cs29g2.Text = ds.Tables[0].Rows[0]["cs29g2"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29g3"].ToString() == null)
                            {
                                cs29g3.Text = "";
                            }
                            else
                            {
                                cs29g3.Text = ds.Tables[0].Rows[0]["cs29g3"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["cs29g4"].ToString() == null)
                            {
                                cs29g4.Text = "";
                            }
                            else
                            {
                                cs29g4.Text = ds.Tables[0].Rows[0]["cs29g4"].ToString();
                            }

                            IsSearch = false;
                        }
                        else
                        {
                            IsSearch = false;
                        }
                    }
                    else
                    {
                        IsSearch = false;
                    }
                }
                else
                {
                    IsSearch = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Form No is numeric field ", "Data Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ds = null;
                obj_op = null;
            }
        }

        private void IsValidate(string value1, Control txtbox1, Control txtbox2, Control txtbox3)
        {
            if (value1 == "")
            {
                //txtbox1.Focus();	 
            }
            else
            {
                if (value1 != "1" && value1 != "2")
                {
                    MessageBox.Show("Invalid digit entered. Please enter any digit 1-2", "Invalid Digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox1.Focus();
                }
                else
                {
                    if (value1 == "1")
                    {
                        txtbox2.Enabled = false;
                        txtbox3.Focus();
                    }
                    else
                    {
                        txtbox2.Enabled = true;
                        txtbox2.Focus();
                    }
                }
            }

            txtbox1 = null;
            txtbox2 = null;
            txtbox3 = null;
        }

        private void IsValidate(string value1, Control txtbox1, Control txtbox2)
        {
            if (value1 == "")
            {
                //txtbox1.Focus();	 
            }
            else
            {
                if (value1 != "1" && value1 != "2")
                {
                    MessageBox.Show("Invalid digit entered. Please enter any digit 1-2", "Invalid Digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox1.Focus();
                }
                else
                {

                }
            }

            txtbox1 = null;
            txtbox2 = null;
        }

        private bool IsRecordExists(string fieldValue, string id)
        {
            bool IsExists = false;
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FORM_ID", "fldvalue" };
                string[] fldvalue = { fieldValue.ToString(), id.ToString() };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_GetRecords");

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            IsExists = true;
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

            return IsExists;
        }



        private bool DeleteForm1(string spName, string id)
        {
            bool IsSuccess = false;

            CDBOperations obj_op = null;

            try
            {
                if (FORM_ID.Text != "")
                {
                    obj_op = new CDBOperations();
                    DataSet ds = obj_op.DeleteForm1(FORM_ID.Text, spName, id, "");
                    IsSuccess = true;
                }
                else
                {
                    MessageBox.Show("Form No is missing", "Missing Form No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FORM_ID.Focus();
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

            return IsSuccess;
        }

        private void EnableDisableForms(bool IsEnable)
        {
            if (IsEnable == true)
            {
                CVariables.EnableDisableEnrollment.Visible = true;
                CVariables.EnableDisableFollowup.Visible = true;
                CVariables.EnableDisableLabForm.Visible = true;
                CVariables.EnableDisableRandomisation.Visible = true;
                CVariables.EnableDisableReconfirmEligibility.Visible = true;
                CVariables.EnableDisableArms.Visible = true;
            }
            else
            {
                CVariables.EnableDisableEnrollment.Visible = false;
                CVariables.EnableDisableFollowup.Visible = false;
                CVariables.EnableDisableLabForm.Visible = false;
                CVariables.EnableDisableRandomisation.Visible = false;
                CVariables.EnableDisableReconfirmEligibility.Visible = false;
                CVariables.EnableDisableArms.Visible = false;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to cancel this entry ?", "Cancel Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to delete this entry ?", "Delete Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    DeleteForm1("sp_GetRecords", "4");
                    this.Close();
                }
                else if (CVariables.IsUserFirstOrSecond == "User2")
                {
                    DeleteForm1("sp_GetRecords", "6");
                    this.Close();
                }
            }
        }

        private void ClearFields()
        {
            cs01.Text = "";
            cs02.Text = "";
            cs03.Text = "";
            cs04.Text = "";
            cs05.Text = "";
            cs06.Text = "";
            cs06a.Text = "";
            cs06b.Text = "";
            cs06c.Text = "";
            cs06d.Text = "";
            cs06e.Text = "";
            cs07.Text = "";
            cs08.Text = "";
            cs09.Text = "";
            cs10.Text = "";
            cs11.Text = "";
            cs12.Text = "";
            cs13.Text = "";
            cs14.Text = "";
            cs15.Text = "";
            cs16.Text = "";
            cs17.Text = "";
            cs18.Text = "";
            cs19.Text = "";
            cs20.Text = "";
            cs21.Text = "";
            cs22.Text = "";
            cs23.Text = "";
            cs24.Text = "";
            cs25.Text = "";
            cs26.Text = "";
            cs27.Text = "";
            cs28a.Text = "";
            cs28b.Text = "";
            cs28c.Text = "";
            cs29a.Text = "";
            cs29b.Text = "";
            cs29c.Text = "";
            cs29d.Text = "";
            cs29e.Text = "";
            cs29f.Text = "";
            cs29g.Text = "";
            cs29g1.Text = "";
            cs29g2.Text = "";
            cs29g3.Text = "";
            cs29g4.Text = "";
        }
        private void AddUpdatePage(string spName)
        {
            CDBOperations obj_op = null;
            string[] my_dt;

            try
            {

                my_dt = DateTime.Now.Date.ToString().Split('/');

                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                DateTime dt_cs08 = new DateTime();

                if (cs08.Text != "  /  /")
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                    dt_cs08 = Convert.ToDateTime(cs08.Text);
                }







                string[] fldname = { "FORM_ID", "cs01", "cs02", "cs03", "cs04", "cs05", "cs06", "cs06a", "cs06b", "cs06c", "cs06d", "cs06e", "cs07", "cs08", "cs09", "cs10", "cs11", "cs12", "cs13", "cs14", "cs15", "cs16", "cs17", "cs18", "cs19", "cs20", "cs21", "cs22", "cs23", "cs24", "cs25", "cs26", "cs27", "cs28a", "cs28b", "cs28c", "cs29a", "cs29b", "cs29c", "cs29d", "cs29e", "cs29f", "cs29g", "cs29g1", "cs29g2", "cs29g3", "cs29g4" };
                string[] fldvalue = { FORM_ID.Text, cs01.Text, cs02.Text, cs03.Text, cs04.Text, cs05.Text, cs06.Text, cs06a.Text, cs06b.Text, cs06c.Text, cs06d.Text, cs06e.Text, cs07.Text, dt_cs08.ToShortDateString(), cs09.Text, cs10.Text, cs11.Text, cs12.Text, cs13.Text, cs14.Text, cs15.Text, cs16.Text, cs17.Text, cs18.Text, cs19.Text, cs20.Text, cs21.Text, cs22.Text, cs23.Text, cs24.Text, cs25.Text, cs26.Text, cs27.Text, cs28a.Text, cs28b.Text, cs28c.Text, cs29a.Text, cs29b.Text, cs29c.Text, cs29d.Text, cs29e.Text, cs29f.Text, cs29g.Text, cs29g1.Text, cs29g2.Text, cs29g3.Text, cs29g4.Text };


                string qry = "INSERT INTO scr (" + fldname + ") values ('" + fldvalue + "')";



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

        private void SCR_Load(object sender, EventArgs e)
        {
            GetTotalForms();
        }


        private void GetTotalForms()
        {
            CDBOperations obj_op = null;

            try
            {
                obj_op = new CDBOperations();


                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    //label51.Text = obj_op.GetDataFieldWise_VisitID("1", "select count(*) count_rec from scr", "count_rec", "", "");

                    DataSet ds = obj_op.GetFormData_Casi("select count(*) count_rec from scr");

                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                label51.Text = ds.Tables[0].Rows[0]["count_rec"].ToString();
                            }
                        }
                    }

                }
                else
                {
                    DataSet ds = obj_op.GetFormData_Casi("select count(*) count_rec from scr");

                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                label51.Text = ds.Tables[0].Rows[0]["count_rec"].ToString();
                            }
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


        private void Calc_ZScore()
        {
            try
            {
                int var_studyid;
                double var_l;

                double var_m;
                double var_s;

                double zwhzhl;
                double zwhzhh;


                double dsd3p;
                double dsd23p;

                double dsd3n;
                double dsd23n;

                double esd3p;
                double esd23p;

                double esd3n;
                double esd23n;

                double var_weight1;

                string var_weight2;

                string var_weight3;


                string var_len1;

                string var_len2;

                string var_len3;


                double height2;
                int interph;
                double temp2;

                double hgtlow;
                double hgthigh;


                string var_hg1;
                string var_hg2;
                string var_hg3;

                int mylen;
                int myage;



                CConnection cn = new CConnection();

                //SQLiteDataAdapter da_del = new SQLiteDataAdapter("drop table tbl_zwfl", cn.cn);
                //DataSet ds_del = new DataSet();
                //da_del.Fill(ds_del);



                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from scr where form_id = '" + FORM_ID.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["cs16"].ToString()) >= 0 || Convert.ToInt32(ds.Tables[0].Rows[0]["cs16"].ToString()) <= 700)
                            {

                                SQLiteDataAdapter da1 = new SQLiteDataAdapter("select a.form_id form_id, a.cs13 cs13, a.cs16 cs16, a.cs23 cs23, b.m m, b.l l, b.s s from scr a inner join wflanthro b on a.cs13 = b.__000001 and a.cs18 = round(b.__000002, 1)", cn.cn);
                                DataSet ds1 = new DataSet();
                                da1.Fill(ds1);


                                var_weight1 = Convert.ToDouble(ds1.Tables[0].Rows[0]["cs23"].ToString());
                                var_m = Convert.ToDouble(ds1.Tables[0].Rows[0]["m"].ToString());
                                var_l = Convert.ToDouble(ds1.Tables[0].Rows[0]["l"].ToString());
                                var_s = Convert.ToDouble(ds1.Tables[0].Rows[0]["s"].ToString());


                                if (ds1 != null)
                                {
                                    if (ds1.Tables.Count > 0)
                                    {
                                        if (ds1.Tables[0].Rows.Count > 0)
                                        {

                                            //zwhzhl = (POWER((@var_weight1 / @var_m), @var_l) - 1) / (@var_s * @var_l)

                                            zwhzhl = (Math.Pow((var_weight1 / var_m), var_l) - 1) / (var_s * var_l);

                                            dsd3p = var_m * (Math.Pow((1 + (var_l * var_s * 3)), (1 / var_l)));

                                            dsd23p = dsd3p - (var_m * (Math.Pow((1 + (var_l * var_s * 2)), (1 / var_l))));


                                            if (zwhzhl > 3)
                                            {
                                                zwhzhl = 3 + ((var_weight1 - dsd3p) / dsd23p);
                                            }


                                            dsd3n = var_m * (Math.Pow((1 + (var_l * var_s * (-3))), (1 / var_l)));

                                            dsd23n = var_m * (Math.Pow((1 + (var_l * var_s * (-2))), (1 / var_l))) - dsd3n;

                                            if (zwhzhl < -3)
                                            {
                                                zwhzhl = (-3) - ((dsd3n - var_weight1) / dsd23n);
                                            }


                                            CVariables.setZscore = zwhzhl;

                                            lblzscore.Text = Convert.ToString(zwhzhl);


                                        }
                                    }
                                }


                            }
                            else
                            {


                                SQLiteDataAdapter da1 = new SQLiteDataAdapter("select a.form_id form_id, a.cs13 cs13, a.cs16 cs16, a.cs23 cs23, b.m m, b.l l, b.s s from scr a inner join wflanthro b on a.cs13 = b.__000001 and a.cs18 = round(b.__000002, 1)", cn.cn);
                                DataSet ds1 = new DataSet();
                                da1.Fill(ds1);


                                var_weight1 = Convert.ToDouble(ds.Tables[0].Rows[0]["cs23"].ToString());
                                var_m = Convert.ToDouble(ds.Tables[0].Rows[0]["m"].ToString());
                                var_l = Convert.ToDouble(ds.Tables[0].Rows[0]["l"].ToString());
                                var_s = Convert.ToDouble(ds.Tables[0].Rows[0]["s"].ToString());


                                if (ds1 != null)
                                {
                                    if (ds1.Tables.Count > 0)
                                    {
                                        if (ds1.Tables[0].Rows.Count > 0)
                                        {

                                            zwhzhl = (Math.Pow((var_weight1 / var_m), var_l) - 1) / (var_s * var_l);

                                            dsd3p = var_m * (Math.Pow((1 + (var_l * var_s * 3)), (1 / var_l)));

                                            dsd23p = dsd3p - (var_m * (Math.Pow((1 + (var_l * var_s * 2)), (1 / var_l))));


                                            if (zwhzhl > 3)
                                            {
                                                zwhzhl = 3 + ((var_weight1 - dsd3p) / dsd23p);
                                            }


                                            dsd3n = var_m * (Math.Pow((1 + (var_l * var_s * (-3))), (1 / var_l)));


                                            dsd23n = var_m * (Math.Pow((1 + (var_l * var_s * (-2))), (1 / var_l))) - dsd3n;


                                            if (zwhzhl < -3)
                                            {
                                                zwhzhl = (-3) - ((dsd3n - var_weight1) / dsd23n);
                                            }

                                            CVariables.setZscore = zwhzhl;

                                            lblzscore.Text = Convert.ToString(zwhzhl);

                                        }
                                    }
                                }


                            }

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

            }

        }

        private void SCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void SCR_Shown(object sender, EventArgs e)
        {
            FORM_ID.Focus();
        }
    }
}