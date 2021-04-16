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
using System.Net;
using System.IO;
using Newtonsoft.Json;



namespace Win_Form_GB
{
    public partial class frmLogin_Copy : Form
    {
        public frmLogin_Copy()
        {
            InitializeComponent();
            DistrictDropDown();
            //UCDropDown();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void DistrictDropDown()
        {
            try
            {
                CConnection cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from district ", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                da.Fill(ds);

                combox_cr02.DataSource = ds.Tables[0];
                combox_cr02.DisplayMember = "district";
                combox_cr02.ValueMember = "id";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UCDropDown()
        {
            try
            {
                CConnection cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from UC ", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                da.Fill(ds);

                combox_cr03.DataSource = ds.Tables[0];
                combox_cr03.DisplayMember = "UC";
                combox_cr03.ValueMember = "id";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdoEng.Checked == false && rdoUrdu.Checked == false)
            {
                MessageBox.Show("Please select at least one language ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                CConnection cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from users where username='" + txtUserID.Text + "' and password='" + txtPassword.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            CVariables.UserID = ds.Tables[0].Rows[0][0].ToString();
                            CVariables.UserName = ds.Tables[0].Rows[0][1].ToString();
                            CVariables.GetPassword = ds.Tables[0].Rows[0]["password"].ToString();
                            CVariables.GetDBName = "gbdata";


                            CVariables.IsUserFirstOrSecond = "User1";


                            if (ds.Tables[0].Rows[0]["IsUserOrAdmin"].ToString() == "True")
                            {
                                CVariables.IsAdmin = true;
                            }
                            else
                            {
                                CVariables.IsAdmin = false;
                            }


                            if (rdoEng.Checked == true)
                            {
                                CVariables.setLanguage = "1";
                            }
                            else
                            {
                                CVariables.setLanguage = "2";
                            }


                            CVariables.frmlogin1 = this;
                            this.Hide();

                            frmMain obj_main = new frmMain();
                            obj_main.Show();
                        }
                        else
                        {
                            MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUserID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserID.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Focus();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string webGetMethod_copy(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }


        private string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }


        private void InsertData(string str_json)
        {

            String Users = File.ReadAllText(str_json);


            //string myResponse = "";

            //using (System.IO.StreamReader re = new System.IO.StreamReader(str_json))
            //{
            //    myResponse = re.ReadToEnd().ToString();

            //    string[] str = JsonConvert.DeserializeObject<string[]>(myResponse);
            //    String Users = File.ReadAllText(str[0]);
            //}
        }


        private void cmdDownload_Click(object sender, EventArgs e)
        {
            try
            {

                //string str_json = webGetMethod("http://f46916:8080/uen_hfa/api/users.php");
                //string result = str_json.Replace(@"\\", "");
                //InsertData(str_json);


                WebRequest request = WebRequest.Create("http://f46916:8080/uen_hfa/api/users.php");
                request.Method = "GET";
                WebResponse response = request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
                string jsonString = sr.ReadToEnd();


                sr.Close();

                //String Users = File.ReadAllText(str[0]);


                //using (StreamReader re = new StreamReader(jsonString))
                //{

                //User usr = JsonConvert.DeserializeObject<User>(jsonString);


                var obj = JsonConvert.DeserializeObject<List<User>>(jsonString);


                CConnection cn = new CConnection();

                SQLiteDataAdapter da = null;
                DataSet ds = null;

                da = new SQLiteDataAdapter("delete from users", cn.cn);
                ds = new DataSet();
                da.Fill(ds);


                for (int a = 0; a <= obj.Count - 1; a++)
                {

                    string qry = "insert into users(username, password, full_name, district_code, designation, auth_level, dd) values('" + obj[a].username + "', '" + obj[a].password + "', '" + obj[a].full_name + "', '" + obj[a].district_code + "', '" + obj[a].designation + "', '" + obj[a].auth_level + "', '" + obj[a].dd + "')";

                    da = new SQLiteDataAdapter(qry, cn.cn);

                    ds = new DataSet();
                    da.Fill(ds);

                }


                MessageBox.Show("Users downloaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void Download_ucs()
        {
            try
            {

                //string str_json = webGetMethod("http://f46916:8080/uen_hfa/api/users.php");
                //string result = str_json.Replace(@"\\", "");
                //InsertData(str_json);


                WebRequest request = WebRequest.Create("http://f38158/gbapi/api/ucs.php");
                request.Method = "GET";
                WebResponse response = request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
                string jsonString = sr.ReadToEnd();


                sr.Close();

                //String Users = File.ReadAllText(str[0]);


                //using (StreamReader re = new StreamReader(jsonString))
                //{

                //User usr = JsonConvert.DeserializeObject<User>(jsonString);


                var obj = JsonConvert.DeserializeObject<List<ucs_model>>(jsonString);


                CConnection cn = new CConnection();

                SQLiteDataAdapter da = null;
                DataSet ds = null;

                da = new SQLiteDataAdapter("delete from ucs", cn.cn);
                ds = new DataSet();
                da.Fill(ds);


                for (int a = 0; a <= obj.Count - 1; a++)
                {

                    string qry = "insert into ucs(uc_code,uc_name,tehsil_code) values('" + obj[a].uc_code + "', '" + obj[a].uc_name + "', '" + obj[a].district_code + "')";

                    da = new SQLiteDataAdapter(qry, cn.cn);

                    ds = new DataSet();
                    da.Fill(ds);

                }


                MessageBox.Show("Users downloaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }


    class User
    {

        public string username { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public string district_code { get; set; }
        public string designation { get; set; }
        public string auth_level { get; set; }
        public string dd { get; set; }

    }


    class ucs_model
    {

        public string uc_code { get; set; }
        public string uc_name { get; set; }
        public string district_code { get; set; }
        

    }
}
