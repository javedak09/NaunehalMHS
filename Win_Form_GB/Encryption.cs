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
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace Win_Form_GB
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void cmdSync_Click(object sender, EventArgs e)
        {

        }


        public void upload_forms_master()
        {
            List<forms_data_master> datas = new List<forms_data_master>();

            datas = fetchData_master();
            int total = datas.Count;

            if (datas.Count > 0)
            {

                var data_obj = JsonConvert.SerializeObject(datas);



                var table_var = "[{\"table\":\"camp_patient\", \"check\":\"users\"}, " + data_obj + "]";

                string requestParams = table_var.ToString();
                HttpWebRequest webRequest;


                //webRequest = (HttpWebRequest)WebRequest.Create("https://vcoe1.aku.edu/naunehal/api/sync.php");
                webRequest = (HttpWebRequest)WebRequest.Create(CVariables.getServerURL + CVariables.getSyncFileName);


                int winBuild = Environment.OSVersion.Version.Build;
                String userAgent = "NET/5.0 (Windows; Build/" + winBuild + ")";


                webRequest.Method = "POST";
                webRequest.UserAgent = userAgent;
                webRequest.ContentType = "application/json";


                //  byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    streamWriter.Write(requestParams);
                }


                var result = "";

                var httpResponse = (HttpWebResponse)webRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }


                //JavaScriptSerializer js = new JavaScriptSerializer();
                //SyncedClass sync = js.Deserialize<SyncedClass>("{\"error\":\"fsdfsdf\"}");

                //List<SyncedClass> list = JsonConvert.DeserializeObject<List<SyncedClass>>(result);
                //updateCampPatient_Detail(list[0].id);


                var message = JsonConvert.DeserializeObject<List<SyncedClass>>(result);


                var errormeg = "";
                var statusmessage = "";



                int errcount = 0;
                int statuscount = 0;
                int dupliatecount = 0;
                string id;
                List<string> errormsg = new List<string>();
                var displaymessage = "";


                try
                {
                    foreach (var item in message)
                    {

                        //messg = "\n error: "+item.error;
                        //messg += "\n message: " + item.message;
                        //messg += "\n status: " + item.status;



                        errormeg = item.error;
                        statusmessage = item.status;


                        if (errormeg == "1")
                        {
                            errcount++;
                            errormsg.Add("ID: " + item.id + " : " + item.message);
                        }



                        if (statusmessage == "1")
                        {
                            statuscount++;
                            id = item.id;

                            updateCampPatient_Master(id);
                        }
                        if (statusmessage == "2")
                        {
                            dupliatecount++;
                            id = item.id;

                            updateCampPatient_Master(id);
                        }

                    }

                    displaymessage = "\n  Total:" + total + "\n  Duplicate:" + dupliatecount + "\n  Successfull:" + statuscount + "\n  Error:" + errcount;
                    foreach (var errtext in errormsg)
                    {
                        displaymessage += "\n" + errtext;
                    }
                    MessageBox.Show("Data Upload" + displaymessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Upload Failed" + ex + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No new record upload", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            //if (result == null)
            //{
            //    MessageBox.Show("Data Upload", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Data Upload" + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }


        private void updateCampPatient_Master(string id)
        {

            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("update camp_patient set synced=1, synceddate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' where id = '" + id + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
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


        public List<forms_data_master> fetchData_master()
        {
            CConnection cn = new CConnection();

            List<forms_data_master> forms = new List<forms_data_master>();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_patient where synced is null or synced = ''", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                {

                    forms_data_master fd = new forms_data_master();

                    fd._id = ds.Tables[0].Rows[a]["id"].ToString();
                    fd.deviceid = SystemInformation.ComputerName;
                    fd.sysdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    fd.id = ds.Tables[0].Rows[a]["id"].ToString();
                    fd.mh01 = ds.Tables[0].Rows[a]["mh01"].ToString();
                    fd.mh02 = ds.Tables[0].Rows[a]["mh02"].ToString();
                    fd.mh03 = ds.Tables[0].Rows[a]["mh03"].ToString();
                    fd.mh04 = ds.Tables[0].Rows[a]["mh04"].ToString();
                    fd.mh05 = ds.Tables[0].Rows[a]["mh05"].ToString();
                    fd.uccode = ds.Tables[0].Rows[a]["uccode"].ToString();
                    fd.dist_id = ds.Tables[0].Rows[a]["dist_id"].ToString();
                    fd.databy = "desktop";
                    fd.userid = ds.Tables[0].Rows[a]["userid"].ToString();
                    fd.entrydate = ds.Tables[0].Rows[a]["entrydate"].ToString();
                    fd.form_id = ds.Tables[0].Rows[a]["form_id"].ToString();


                    forms.Add(fd);

                }

            }

            catch (Exception ex)
            {

            }

            finally
            {

            }

            return forms;
        }


        public class SyncedClass
        {
            public string error { get; set; }
            public string message { get; set; }
            public string status { get; set; }
            public string id { get; set; }
        }



        public class forms_data_master
        {
            public string _id;
            public string form_id;
            public string deviceid;
            public string sysdate;
            public string id;
            public string mh01;
            public string mh02;
            public string mh03;
            public string mh04;
            public string mh05;

            public string uccode;
            public string dist_id;
            public string databy;

            public string userid;
            public string entrydate;

        }


    }
}