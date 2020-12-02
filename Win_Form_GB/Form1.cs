using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Data.SQLite;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;
//using Microsoft.Data.Sqlite;


namespace Win_Form_GB
{
    public partial class InfoActivity : Form
    {
        public InfoActivity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getProvince();

        }


        private void getProvince()
        {
            CConnection cn = new CConnection();

            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from province order by province", cn.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            q4.DisplayMember = "province";
            q4.ValueMember = "id";
            q4.DataSource = ds.Tables[0];
        }


        private void getDistrict()
        {
            CConnection cn = new CConnection();

            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from district where provid='" + q4.SelectedValue + "' order by district", cn.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            q5.DisplayMember = "district";
            q5.ValueMember = "id";
            q5.DataSource = ds.Tables[0];
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CVariables.frmlogin1.Show();
        }

        private void InfoActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void FORM_ID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(q1.Text) == true)
            {
                MessageBox.Show("Questionnaier Number cannot be blank or if you want to exit type 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q1.Focus();
            }
        }

        private void q2_Leave(object sender, EventArgs e)
        {
            if (q2.Text.IndexOf(" ") == -1)
            {
                if (q2.Text.Length == 10)
                {
                    try
                    {
                        if (q2.Text != "  /  /")
                        {
                            DateTime dt_q2 = new DateTime();
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            dt_q2 = Convert.ToDateTime(q2.Text);


                            if (dt_q2 > DateTime.Now.Date)
                            {
                                MessageBox.Show("Date of interview cannot be greater than todays's date ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                q2.Focus();
                            }

                        }
                        else if (q2.Text == "  /  /")
                        {
                            MessageBox.Show("Date of interview cannot be blank ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            q2.Focus();
                        }
                    }

                    catch (Exception ex)
                    {
                        if (ex.Message == "String was not recognized as a valid DateTime.")
                        {
                            MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            q2.Focus();
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            q2.Focus();
                        }
                    }

                    finally
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please enter complete date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    q2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter complete date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q2.Focus();
            }
        }

        private void q3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(q3.Text) == true)
            {
                MessageBox.Show("Please enter interviewer name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q3.Focus();
            }
        }

        private void q4_SelectedValueChanged(object sender, EventArgs e)
        {
            getDistrict();
        }

        private void q6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(q6.Text) == true)
            {
                MessageBox.Show("Please enter household number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q6.Focus();
            }
        }

        private void q7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(q7.Text) == true)
            {
                MessageBox.Show("Please enter household name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q7.Focus();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                MessageBox.Show("Please select gender ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rdoMale.Focus();
            }
            else
            {

                DateTime dt_q2 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt_q2 = Convert.ToDateTime(q2.Text);

                string[] dt = dt_q2.ToShortDateString().Split('/');
                string dt1 = dt[1] + "/" + dt[0] + "/" + dt[2];



                string var_q8 = "";

                if (rdoMale.Checked == true)
                {
                    var_q8 = "1";
                }
                else if (rdoFemale.Checked == true)
                {
                    var_q8 = "2";
                }

                CConnection cn = new CConnection();

                //SQLiteDataAdapter da = new SQLiteDataAdapter("insert into form (q1, q2, q3, q4, q5, q6, q7, q8) values('" + q1.Text + "', '" + dt1 + "', '" + q3.Text + "', '" + q4.SelectedValue + "', '" + q5.SelectedValue + "', '" + q6.Text + "', '" + q7.Text + "', '" + var_q8 + "')", cn.cn);
                //DataSet ds = new DataSet();
                //da.Fill(ds);


                SQLiteDataAdapter da = new SQLiteDataAdapter("insert into forms (q1, q2, q3, q4, q5, q6, q7, q8) values('" + q1.Text + "', '" + dt1 + "', '" + q3.Text.Replace("'", "") + "', '" + q4.SelectedValue + "', '" + q5.SelectedValue + "', '" + q6.Text + "', '" + q7.Text.Replace("'", "") + "', '" + var_q8 + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                MessageBox.Show("Record saved successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearFields();
            }
        }


        private void ClearFields()
        {
            q1.Text = "";
            q2.Text = "";
            q3.Text = "";
            q4.SelectedValue = "0";
            q5.SelectedValue = "0";
            q6.Text = "";
            q7.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void cmdSync_Click(object sender, EventArgs e)
        {
            CConnection cn = new CConnection();

            //SQLiteDataAdapter da = new SQLiteDataAdapter("select q1, strftime('%Y/%m/%d',datetime(substr(q2, 7, 4) || '-' || substr(q2, 1, 2) || '-' || substr(q2, 4, 2))) d2, q3, q4, q5, q6, q7, q8 from forms", cn.cn);

            SQLiteDataAdapter da = new SQLiteDataAdapter("select q1, strftime('%Y-%m-%d',datetime(substr(q2, 7, 4) || '-' || substr(q2, 1, 2) || '-' || substr(q2, 4, 2))) q2, q3, q4, q5, q6, q7, q8, _id, deviceid, strftime('%Y-%m-%d',datetime(substr(sysdate, 7, 4) || '-' || substr(sysdate, 1, 2) || '-' || substr(sysdate, 4, 2))) sysdate, synced, strftime('%Y-%m-%d', datetime(substr(syncedDate, 7, 4) || '-' || substr(syncedDate, 1, 2) || '-' || substr(syncedDate, 4, 2))) syncedDate from forms", cn.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://F46916:8080/uen_hfa/api/sync.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            string myjson = DataTableToJsonObj(ds.Tables[0]);


            //string JSONString = string.Empty;

            //JSONString = JsonConvert.SerializeObject(ds.Tables[0]);


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(myjson);
            }



            //string json = "";

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{

            //    var objectToSerialize = new RootObject();
            //    objectToSerialize.frm = new List<forms>
            //              {
            //                 new forms { pro_q1 = "1", pro_q2 = "index1" }
            //              };


            //    streamWriter.Write(new JavaScriptConverter().Serialize()
            //        { 
            //        });
            //}


            var result = "";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }


            //var result = "";
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    result = streamReader.ReadToEnd();
            //}


            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public string DataTableToJsonObj(DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Merge(dt);
            StringBuilder JsonString = new StringBuilder();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                JsonString.Append("[{\"table\":\"forms\"},[");



                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    JsonString.Append("{");
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        if (j < ds.Tables[0].Columns.Count - 1)
                        {
                            JsonString.Append("\"" + ds.Tables[0].Columns[j].ColumnName.ToString() + "\":" + "\"" + ds.Tables[0].Rows[i][j].ToString() + "\",");
                        }
                        else if (j == ds.Tables[0].Columns.Count - 1)
                        {
                            JsonString.Append("\"" + ds.Tables[0].Columns[j].ColumnName.ToString() + "\":" + "\"" + ds.Tables[0].Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == ds.Tables[0].Rows.Count - 1)
                    {
                        JsonString.Append("}");
                    }
                    else
                    {
                        JsonString.Append("},");
                    }
                }
                JsonString.Append("]]");
                return JsonString.ToString();
            }
            else
            {
                return null;
            }
        }



    }
}
