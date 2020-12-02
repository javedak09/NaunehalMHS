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
    public partial class frmPermissions : Form
    {
        static string var_user_id;
        static bool IsUpdate;
        static bool IsUpdatePermission;
        static string var_perm_id;

        public frmPermissions()
        {
            InitializeComponent();
        }

        private void frmPermissions_Load(object sender, EventArgs e)
        {
            GetUsersData();
            GetLocation();
            GetStatus();
        }

        private void GetLocation()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "6", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboLocation.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboLocation.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboLocation.DataSource = ds.Tables[0];

                ds = null;
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


        private void GetStatus()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "7", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboStatus.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboStatus.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboStatus.DataSource = ds.Tables[0];

                ds = null;
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


        private void GetUsersData()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "", "", "3", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                if (ds.Tables.Count > 0)
                {
                    DGUser.DataSource = ds.Tables[0];

                    DGUser.Columns[0].Visible = false;
                    DGUser.Columns[0].ReadOnly = true;
                    DGUser.Columns[1].ReadOnly = true;
                    DGUser.Columns[2].ReadOnly = true;
                    DGUser.Columns[3].ReadOnly = true;
                    DGUser.Columns[4].ReadOnly = true;
                    DGUser.Columns[5].ReadOnly = true;
                }

                ds = null;
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

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "")
                {
                    MessageBox.Show("User ID required field", "User ID Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Focus();
                }
                else if (txtPasswd.Text == "")
                {
                    MessageBox.Show("Password required field", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswd.Focus();
                }
                else if (txtPasswd.Text != txtConfirmPasswd.Text)
                {
                    MessageBox.Show("Password and confirm password are not same ", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswd.Focus();
                }
                else if (txtAkuID.Text == "")
                {
                    MessageBox.Show("Aku ID cannot be left blank ", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAkuID.Focus();
                }
                else if (txtEmpNo.Text == "")
                {
                    MessageBox.Show("Emp No cannot be left blank ", "AKU ID Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpNo.Focus();
                }
                else
                {
                    if (IsUpdate == true)
                    {
                        if (cboLocation.SelectedValue.ToString() == "0")
                        {
                            MessageBox.Show("Please select location ", "Location not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboLocation.Focus();
                        }
                        else
                        {
                            if (cboStatus.SelectedValue.ToString() == "0")
                            {
                                MessageBox.Show("Please select status ", "Status not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboStatus.Focus();
                            }
                            else
                            {
                                UpdateRecord();
                                ClearFields();
                                IsUpdate = false;
                            }
                        }
                    }
                    else
                    {
                        if (IsUserExists() == true)
                        {
                            MessageBox.Show("User already exists", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUserID.Focus();
                        }
                        else
                        {
                            if (cboLocation.SelectedValue.ToString() == "0")
                            {
                                MessageBox.Show("Please select location ", "Location not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboLocation.Focus();
                            }
                            else
                            {
                                if (cboStatus.SelectedValue.ToString() == "0")
                                {
                                    MessageBox.Show("Please select status ", "Status not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cboStatus.Focus();
                                }
                                else
                                {
                                    AddUser();
                                    ClearFields();
                                }
                            }
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }

            finally
            {

            }
        }


        private bool IsUserExists()
        {
            CDBOperations obj_op = null;
            bool IsLogin = false;

            try
            {
                string[] fldname = { "UserID", "Passwd" };
                string[] fldvalue = { txtUserID.Text, txtPasswd.Text };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Login");

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        IsLogin = true;
                    }
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                obj_op = null;
            }

            return IsLogin;
        }



        private void AddUser()
        {
            CDBOperations obj_op = null;
            DataSet ds = null;

            try
            {
                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                ds = new DataSet();
                obj_op = new CDBOperations();


                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", txtUserID.Text, txtPasswd.Text, cboStatus.SelectedValue.ToString(), "0", "0", cboLocation.SelectedValue.ToString(), txtAkuID.Text, txtEmpNo.Text, EntryDate.ToShortDateString() };

                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");


                if (ds.Tables.Count > 0)
                {
                    DGUser.DataSource = ds.Tables[0];
                }

                IsUpdate = false;
                var_user_id = "";
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }

        private void UpdateRecord()
        {
            CDBOperations obj_op = null;
            DataSet ds = null;

            try
            {
                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                ds = new DataSet();
                obj_op = new CDBOperations();

                if (var_user_id != "")
                {
                    if (cboStatus.SelectedValue.ToString() == "3")
                    {
                        string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                        string[] fldvalue = { var_user_id, txtUserID.Text, txtPasswd.Text, "False", "", "1", cboLocation.SelectedValue.ToString(), txtAkuID.Text, txtEmpNo.Text, EntryDate.ToShortDateString() };

                        ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");
                    }
                    else
                    {
                        string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                        string[] fldvalue = { var_user_id, txtUserID.Text, txtPasswd.Text, "True", "", "1", cboLocation.SelectedValue.ToString(), txtAkuID.Text, txtEmpNo.Text, EntryDate.ToShortDateString() };

                        ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");
                    }
                }
                else
                {
                    MessageBox.Show("Please select any record from User Management Grid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (ds.Tables.Count > 0)
                {
                    DGUser.DataSource = ds.Tables[0];
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmdAddUser.Text = "Add User";
            }
        }



        private void ClearFields()
        {
            txtUserID.Text = "";
            txtPasswd.Text = "";
            txtConfirmPasswd.Text = "";
            cboStatus.SelectedValue = 1;
            cboLocation.SelectedValue = 1;
            txtAkuID.Text = "";
            txtEmpNo.Text = "";
            txtUserID.Focus();
        }

        private void cmdDeleteUser_Click(object sender, EventArgs e)
        {
            CDBOperations obj_op = null;

            try
            {
                obj_op = new CDBOperations();

                if (var_user_id != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to delete user ? Deletion of a user will also delete the permissions ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.ToString() == "Yes")
                    {
                        string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                        string[] fldvalue = { var_user_id, "", "", "", "", "2", "", "", "", "" };

                        obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                        cmdAddUser.Text = "Add User";

                        GetUsersData();
                    }
                }
                else
                {
                    MessageBox.Show("Please select record from the grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                IsUpdate = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                ClearFields();
                obj_op = null;
            }
        }

        private void cmdCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
