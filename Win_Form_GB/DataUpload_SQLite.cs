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
using System.Configuration;
using System.Reflection;

namespace Win_Form_GB
{
    public partial class DataUpload_SQLite : Form
    {
        public DataUpload_SQLite()
        {
            InitializeComponent();
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            upload_forms_4mm();
        }


        public void upload_forms_4mm()
        {
            List<forms_data> datas = new List<forms_data>();

            datas = fetchData_forms4mm();
            int total = datas.Count;

            if (datas.Count > 0)
            {

                var data_obj = JsonConvert.SerializeObject(datas);


                var table_var = "[{\"table\":\"Forms4mm\"}, " + data_obj + "]";

                string requestParams = table_var.ToString();
                HttpWebRequest webRequest;


                //webRequest = (HttpWebRequest)WebRequest.Create("https://vcoe1.aku.edu/amanhicovid_19study/api/sync.php");
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

                            //updateCampPatient_Master(id);
                        }
                        if (statusmessage == "2")
                        {
                            dupliatecount++;
                            id = item.id;

                            //updateCampPatient_Master(id);
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


        public List<forms_data> fetchData_forms4mm()
        {
            CConnection cn = new CConnection();

            List<forms_data> forms = new List<forms_data>();


            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Forms4mm where synced is null or synced = ''", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);




                for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                {

                    forms_data fd = new forms_data();

                    //fd._id = ds.Tables[0].Rows[a]["id"].ToString();
                    //fd.deviceid = SystemInformation.ComputerName;                    


                    fd._id = ds.Tables[0].Rows[a]["_id"].ToString();
                    fd.projectName = "amanhicovid_19study Baseline Survey";
                    fd._uid = ds.Tables[0].Rows[a]["_uid"].ToString();
                    fd.username = ds.Tables[0].Rows[a]["username"].ToString();
                    fd.sysdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    fd.istatus = ds.Tables[0].Rows[a]["istatus"].ToString();
                    fd.istatus96x = ds.Tables[0].Rows[a]["istatus96x"].ToString();
                    fd.endingdatetime = ds.Tables[0].Rows[a]["endingdatetime"].ToString();
                    fd.gps = ds.Tables[0].Rows[a]["gps"].ToString();
                    fd.deviceid = ds.Tables[0].Rows[a]["deviceid"].ToString();
                    fd.devicetagid = ds.Tables[0].Rows[a]["devicetagid"].ToString();
                    fd.synced = ds.Tables[0].Rows[a]["synced"].ToString();
                    fd.synced_date = ds.Tables[0].Rows[a]["synced_date"].ToString();
                    fd.appversion = ds.Tables[0].Rows[a]["appversion"].ToString();
                    fd.studyid = ds.Tables[0].Rows[a]["studyid"].ToString();
                    fd.dssid = ds.Tables[0].Rows[a]["dssid"].ToString();
                    fd.week = ds.Tables[0].Rows[a]["week"].ToString();


                    var obj1 = JsonConvert.DeserializeObject<s02_data>(ds.Tables[0].Rows[a]["s02"].ToString());


                    fd.mm0101 = obj1.mm0101;
                    fd.mm0102 = obj1.mm0102;
                    fd.mm0102a = obj1.mm0102a;
                    fd.mm0103 = obj1.mm0103;
                    fd.mm0104 = obj1.mm0104;
                    fd.mm0105 = obj1.mm0105;
                    fd.mm0106 = obj1.mm0106;
                    fd.mm0107 = obj1.mm0107;
                    fd.mm0108 = obj1.mm0108;
                    fd.mm0108a = obj1.mm0108a;
                    fd.mm0108b = obj1.mm0108b;
                    fd.mm0201 = obj1.mm0201;
                    fd.mm0301 = obj1.mm0301;
                    fd.mm03010 = obj1.mm03010;
                    fd.mm03011 = obj1.mm03011;
                    fd.mm03012 = obj1.mm03012;
                    fd.mm03013 = obj1.mm03013;
                    fd.mm03014 = obj1.mm03014;
                    fd.mm03015 = obj1.mm03015;
                    fd.mm03016 = obj1.mm03016;
                    fd.mm03017 = obj1.mm03017;
                    fd.mm03018 = obj1.mm03018;
                    fd.mm03019 = obj1.mm03019;
                    fd.mm0302 = obj1.mm0302;
                    fd.mm03020 = obj1.mm03020;
                    fd.mm03021 = obj1.mm03021;
                    fd.mm03022 = obj1.mm03022;
                    fd.mm03023 = obj1.mm03023;
                    fd.mm03024 = obj1.mm03024;
                    fd.mm03025 = obj1.mm03025;
                    fd.mm03026 = obj1.mm03026;
                    fd.mm03027 = obj1.mm03027;
                    fd.mm03028 = obj1.mm03028;
                    fd.mm03029 = obj1.mm03029;
                    fd.mm0303 = obj1.mm0303;
                    fd.mm03030 = obj1.mm03030;
                    fd.mm03031 = obj1.mm03031;
                    fd.mm03032 = obj1.mm03032;
                    fd.mm03033 = obj1.mm03033;
                    fd.mm03034 = obj1.mm03034;
                    fd.mm03035 = obj1.mm03035;
                    fd.mm03036 = obj1.mm03036;
                    fd.mm03037 = obj1.mm03037;
                    fd.mm03038 = obj1.mm03038;
                    fd.mm03039 = obj1.mm03039;
                    fd.mm0304 = obj1.mm0304;
                    fd.mm03040 = obj1.mm03040;
                    fd.mm03041 = obj1.mm03041;
                    fd.mm03042 = obj1.mm03042;
                    fd.mm03043 = obj1.mm03043;
                    fd.mm03044 = obj1.mm03044;
                    fd.mm03045 = obj1.mm03045;
                    fd.mm03046 = obj1.mm03046;
                    fd.mm03047 = obj1.mm03047;
                    fd.mm03048 = obj1.mm03048;
                    fd.mm03049 = obj1.mm03049;
                    fd.mm0305 = obj1.mm0305;
                    fd.mm0306 = obj1.mm0306;
                    fd.mm0307 = obj1.mm0307;
                    fd.mm0308 = obj1.mm0308;
                    fd.mm0309 = obj1.mm0309;
                    fd.mm0401 = obj1.mm0401;
                    fd.mm04010 = obj1.mm04010;
                    fd.mm04011 = obj1.mm04011;
                    fd.mm04012 = obj1.mm04012;
                    fd.mm0402 = obj1.mm0402;
                    fd.mm0403 = obj1.mm0403;
                    fd.mm0404 = obj1.mm0404;
                    fd.mm0405 = obj1.mm0405;
                    fd.mm0406 = obj1.mm0406;
                    fd.mm0407 = obj1.mm0407;
                    fd.mm0408 = obj1.mm0408;
                    fd.mm0409 = obj1.mm0409;
                    fd.mm0501 = obj1.mm0501;
                    fd.mm05010 = obj1.mm05010;
                    fd.mm05011 = obj1.mm05011;
                    fd.mm05012 = obj1.mm05012;
                    fd.mm05013 = obj1.mm05013;
                    fd.mm0502 = obj1.mm0502;
                    fd.mm0503 = obj1.mm0503;
                    fd.mm0504 = obj1.mm0504;
                    fd.mm0505 = obj1.mm0505;
                    fd.mm0506 = obj1.mm0506;
                    fd.mm0507 = obj1.mm0507;
                    fd.mm0508 = obj1.mm0508;
                    fd.mm0508015x = obj1.mm0508015x;
                    fd.mm0601 = obj1.mm0601;
                    fd.mm0602 = obj1.mm0602;
                    fd.mm0603 = obj1.mm0603;
                    fd.mm0604 = obj1.mm0604;
                    fd.mm0605 = obj1.mm0605;
                    fd.mm0606 = obj1.mm0606;
                    fd.mm0701 = obj1.mm0701;
                    fd.mm0702 = obj1.mm0702;
                    fd.chklmp = obj1.chklmp;
                    fd.mm0703 = obj1.mm0703;
                    fd.mm202 = obj1.mm202;
                    fd.mm202077x = obj1.mm202077x;
                    fd.mmsid = obj1.mmsid;
                    fd.mm0801 = obj1.mm0801;
                    fd.mm0802 = obj1.mm0802;
                    fd.mm080277x = obj1.mm080277x;
                    fd.mm0803a = obj1.mm0803a;
                    fd.mm0803b = obj1.mm0803b;
                    fd.chkvaccdta = obj1.chkvaccdta;
                    fd.chkvaccdtb = obj1.chkvaccdtb;
                    fd.mm0704 = obj1.mm0704;
                    fd.mm070477x = obj1.mm070477x;
                    fd.chkvaccdtc = obj1.chkvaccdtc;

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


        public class forms_data
        {
            public string _id;
            public string _uid;
            public string projectName;
            public string appversion;
            public string deviceid;
            public string devicetagid;
            public string dssid;
            public string endingdatetime;
            public string gps;
            public string istatus;
            public string istatus96x;
            public string studyid;
            public string synced;
            public string synced_date;
            public string sysdate;
            public string username;
            public string week;



            public string mmsid;
            public string mm0101;
            public string mm0102;
            public string mm0102a;
            public string mm0103;
            public string mm0104;
            public string mm0105;
            public string mm0106;
            public string mm0107;
            public string mm0108;
            public string mm0108a;
            public string mm0108b;
            public string mm0201;
            public string mm0301;
            public string mm03010;
            public string mm03011;
            public string mm03012;
            public string mm03013;
            public string mm03014;
            public string mm03015;
            public string mm03016;
            public string mm03017;
            public string mm03018;
            public string mm03019;
            public string mm0302;
            public string mm03020;
            public string mm03021;
            public string mm03022;
            public string mm03023;
            public string mm03024;
            public string mm03025;
            public string mm03026;
            public string mm03027;
            public string mm03028;
            public string mm03029;
            public string mm0303;
            public string mm03030;
            public string mm03031;
            public string mm03032;
            public string mm03033;
            public string mm03034;
            public string mm03035;
            public string mm03036;
            public string mm03037;
            public string mm03038;
            public string mm03039;
            public string mm0304;
            public string mm03040;
            public string mm03041;
            public string mm03042;
            public string mm03043;
            public string mm03044;
            public string mm03045;
            public string mm03046;
            public string mm03047;
            public string mm03048;
            public string mm03049;
            public string mm0305;
            public string mm0306;
            public string mm0307;
            public string mm0308;
            public string mm0309;
            public string mm0401;
            public string mm04010;
            public string mm04011;
            public string mm04012;
            public string mm0402;
            public string mm0403;
            public string mm0404;
            public string mm0405;
            public string mm0406;
            public string mm0407;
            public string mm0408;
            public string mm0409;
            public string mm0501;
            public string mm05010;
            public string mm05011;
            public string mm05012;
            public string mm05013;
            public string mm0502;
            public string mm0503;
            public string mm0504;
            public string mm0505;
            public string mm0506;
            public string mm0507;
            public string mm0508;
            public string mm0508015x;
            public string mm0601;
            public string mm0602;
            public string mm0603;
            public string mm0604;
            public string mm0605;
            public string mm0606;
            public string mm0701;
            public string mm0702;
            public string chklmp;
            public string mm0703;
            public string mm202;
            public string mm202077x;
            public string mm0801;
            public string mm0802;
            public string mm080277x;
            public string mm0803a;
            public string mm0803b;
            public string chkvaccdta;
            public string chkvaccdtb;
            public string mm0704;
            public string mm070477x;
            public string chkvaccdtc;


        }


        public class s02_data
        {

            public string mmsid;
            public string mm0101;
            public string mm0102;
            public string mm0102a;
            public string mm0103;
            public string mm0104;
            public string mm0105;
            public string mm0106;
            public string mm0107;
            public string mm0108;
            public string mm0108a;
            public string mm0108b;
            public string mm0201;
            public string mm0301;
            public string mm03010;
            public string mm03011;
            public string mm03012;
            public string mm03013;
            public string mm03014;
            public string mm03015;
            public string mm03016;
            public string mm03017;
            public string mm03018;
            public string mm03019;
            public string mm0302;
            public string mm03020;
            public string mm03021;
            public string mm03022;
            public string mm03023;
            public string mm03024;
            public string mm03025;
            public string mm03026;
            public string mm03027;
            public string mm03028;
            public string mm03029;
            public string mm0303;
            public string mm03030;
            public string mm03031;
            public string mm03032;
            public string mm03033;
            public string mm03034;
            public string mm03035;
            public string mm03036;
            public string mm03037;
            public string mm03038;
            public string mm03039;
            public string mm0304;
            public string mm03040;
            public string mm03041;
            public string mm03042;
            public string mm03043;
            public string mm03044;
            public string mm03045;
            public string mm03046;
            public string mm03047;
            public string mm03048;
            public string mm03049;
            public string mm0305;
            public string mm0306;
            public string mm0307;
            public string mm0308;
            public string mm0309;
            public string mm0401;
            public string mm04010;
            public string mm04011;
            public string mm04012;
            public string mm0402;
            public string mm0403;
            public string mm0404;
            public string mm0405;
            public string mm0406;
            public string mm0407;
            public string mm0408;
            public string mm0409;
            public string mm0501;
            public string mm05010;
            public string mm05011;
            public string mm05012;
            public string mm05013;
            public string mm0502;
            public string mm0503;
            public string mm0504;
            public string mm0505;
            public string mm0506;
            public string mm0507;
            public string mm0508;
            public string mm0508015x;
            public string mm0601;
            public string mm0602;
            public string mm0603;
            public string mm0604;
            public string mm0605;
            public string mm0606;
            public string mm0701;
            public string mm0702;
            public string chklmp;
            public string mm0703;
            public string mm202;
            public string mm202077x;
            public string mm0801;
            public string mm0802;
            public string mm080277x;
            public string mm0803a;
            public string mm0803b;
            public string chkvaccdta;
            public string chkvaccdtb;
            public string mm0704;
            public string mm070477x;
            public string chkvaccdtc;

        }




        public class forms_data_21cm
        {
            public string _id;
            public string _uid;
            public string projectName;
            public string appversion;
            public string deviceid;
            public string devicetagid;
            public string dssid;
            public string endingdatetime;
            public string gps;
            public string istatus;
            public string istatus96x;
            public string studyid;
            public string synced;
            public string synced_date;
            public string sysdate;
            public string username;
            public string week;


            public string cm0101;
            public string cm0102;
            public string cm0102a;
            public string cm0103;
            public string cm0104;
            public string cm0105;
            public string cm0106;
            public string cm0107;
            public string cm0108;
            public string cm0109;
            public string cm0109mx;
            public string cm0110;
            public string cm0111;
            public string cm0112;
            public string cm0201;
            public string cm0202;
            public string cm020277x;
            public string cm0301;
            public string cm03010;
            public string cm03011;
            public string cm03012;
            public string cm03013;
            public string cm03014;
            public string cm03015;
            public string cm03016;
            public string cm03017;
            public string cm03018;
            public string cm03019;
            public string cm0302;
            public string cm03020;
            public string cm03021;
            public string cm03022;
            public string cm03023;
            public string cm03024;
            public string cm03025;
            public string cm03026;
            public string cm03027;
            public string cm03028;
            public string cm03029;
            public string cm0303;
            public string cm03030;
            public string cm03031;
            public string cm03032;
            public string cm03033;
            public string cm03034;
            public string cm03035;
            public string cm03036;
            public string cm03037;
            public string cm03038;
            public string cm03039;
            public string cm0304;
            public string cm03040;
            public string cm03041;
            public string cm03042;
            public string cm03043;
            public string cm03044;
            public string cm03045;
            public string cm03046;
            public string cm03047;
            public string cm03048;
            public string cm03049;
            public string cm0305;
            public string cm03050;
            public string cm03051;
            public string cm0306;
            public string cm0307;
            public string cm0308;
            public string cm0309;
            public string cm0401;
            public string cm04010;
            public string cm04011;
            public string cm04012;
            public string cm04013;
            public string cm0402;
            public string cm0403;
            public string cm0404;
            public string cm0405;
            public string cm0406;
            public string cm0407;
            public string cm0408;
            public string cm0408015x;
            public string cm0501;
            public string cm05011;
            public string cm05012;
            public string cm05013;
            public string cm0501301x;
            public string cm05015;
            public string cm05016;
            public string cm0501601x;
            public string cm05018;
            public string cm0501801x;
            public string cm0502;
            public string cm05020;
            public string cm0503;
            public string cm0504;
            public string cm0505;
            public string cm0506;
            public string cm0507;
            public string cm0508;
            public string cm0509;
            public string cm050901x;
            public string cm0601;
            public string cm0602;
            public string cm0603;
            public string cm0604;
            public string cm0606;
            public string cm0607;
            public string cm0608;
            public string cm0609;
            public string cm0605;
            public string cmsid;
            public string cm0701;
            public string cm0702;
            public string cm070277x;
            public string cm0703a;
            public string cm0703b;
            public string chkvaccdta;
            public string chkvaccdtb;
            public string chkdt3ch;


        }


        public class s02_data_21cm
        {

            public string cm0101;
            public string cm0102;
            public string cm0102a;
            public string cm0103;
            public string cm0104;
            public string cm0105;
            public string cm0106;
            public string cm0107;
            public string cm0108;
            public string cm0109;
            public string cm0109mx;
            public string cm0110;
            public string cm0111;
            public string cm0112;
            public string cm0201;
            public string cm0202;
            public string cm020277x;
            public string cm0301;
            public string cm03010;
            public string cm03011;
            public string cm03012;
            public string cm03013;
            public string cm03014;
            public string cm03015;
            public string cm03016;
            public string cm03017;
            public string cm03018;
            public string cm03019;
            public string cm0302;
            public string cm03020;
            public string cm03021;
            public string cm03022;
            public string cm03023;
            public string cm03024;
            public string cm03025;
            public string cm03026;
            public string cm03027;
            public string cm03028;
            public string cm03029;
            public string cm0303;
            public string cm03030;
            public string cm03031;
            public string cm03032;
            public string cm03033;
            public string cm03034;
            public string cm03035;
            public string cm03036;
            public string cm03037;
            public string cm03038;
            public string cm03039;
            public string cm0304;
            public string cm03040;
            public string cm03041;
            public string cm03042;
            public string cm03043;
            public string cm03044;
            public string cm03045;
            public string cm03046;
            public string cm03047;
            public string cm03048;
            public string cm03049;
            public string cm0305;
            public string cm03050;
            public string cm03051;
            public string cm0306;
            public string cm0307;
            public string cm0308;
            public string cm0309;
            public string cm0401;
            public string cm04010;
            public string cm04011;
            public string cm04012;
            public string cm04013;
            public string cm0402;
            public string cm0403;
            public string cm0404;
            public string cm0405;
            public string cm0406;
            public string cm0407;
            public string cm0408;
            public string cm0408015x;
            public string cm0501;
            public string cm05011;
            public string cm05012;
            public string cm05013;
            public string cm0501301x;
            public string cm05015;
            public string cm05016;
            public string cm0501601x;
            public string cm05018;
            public string cm0501801x;
            public string cm0502;
            public string cm05020;
            public string cm0503;
            public string cm0504;
            public string cm0505;
            public string cm0506;
            public string cm0507;
            public string cm0508;
            public string cm0509;
            public string cm050901x;
            public string cm0601;
            public string cm0602;
            public string cm0603;
            public string cm0604;
            public string cm0606;
            public string cm0607;
            public string cm0608;
            public string cm0609;
            public string cm0605;
            public string cmsid;
            public string cm0701;
            public string cm0702;
            public string cm070277x;
            public string cm0703a;
            public string cm0703b;
            public string chkvaccdta;
            public string chkvaccdtb;
            public string chkdt3ch;

        }



        public class SyncMsg
        {
            public string syncdata { get; set; }
        }


        public class SyncedClass
        {
            public string error { get; set; }
            public string message { get; set; }
            public string status { get; set; }
            public string id { get; set; }
        }

        private void cmdUpload1_Click(object sender, EventArgs e)
        {
            upload_forms_21cm();
        }


        public void upload_forms_21cm()
        {
            List<forms_data_21cm> datas = new List<forms_data_21cm>();

            datas = fetchData_forms21cm();
            int total = datas.Count;

            if (datas.Count > 0)
            {

                var data_obj = JsonConvert.SerializeObject(datas);


                var table_var = "[{\"table\":\"Forms21cm\"}, " + data_obj + "]";

                string requestParams = table_var.ToString();
                HttpWebRequest webRequest;


                //webRequest = (HttpWebRequest)WebRequest.Create("https://vcoe1.aku.edu/amanhicovid_19study/api/sync.php");
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

                            //updateCampPatient_Master(id);
                        }
                        if (statusmessage == "2")
                        {
                            dupliatecount++;
                            id = item.id;

                            //updateCampPatient_Master(id);
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



        public List<forms_data_21cm> fetchData_forms21cm()
        {
            CConnection cn = new CConnection();

            List<forms_data_21cm> forms = new List<forms_data_21cm>();


            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Forms21cm where synced is null or synced = ''", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);




                for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                {

                    forms_data_21cm fd = new forms_data_21cm();

                    //fd._id = ds.Tables[0].Rows[a]["id"].ToString();
                    //fd.deviceid = SystemInformation.ComputerName;                    


                    fd._id = ds.Tables[0].Rows[a]["_id"].ToString();
                    fd.projectName = "amanhicovid_19study Baseline Survey";
                    fd._uid = ds.Tables[0].Rows[a]["_uid"].ToString();
                    fd.username = ds.Tables[0].Rows[a]["username"].ToString();
                    fd.sysdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    fd.istatus = ds.Tables[0].Rows[a]["istatus"].ToString();
                    fd.istatus96x = ds.Tables[0].Rows[a]["istatus96x"].ToString();
                    fd.endingdatetime = ds.Tables[0].Rows[a]["endingdatetime"].ToString();
                    fd.gps = ds.Tables[0].Rows[a]["gps"].ToString();
                    fd.deviceid = ds.Tables[0].Rows[a]["deviceid"].ToString();
                    fd.devicetagid = ds.Tables[0].Rows[a]["devicetagid"].ToString();
                    fd.synced = ds.Tables[0].Rows[a]["synced"].ToString();
                    fd.synced_date = ds.Tables[0].Rows[a]["synced_date"].ToString();
                    fd.appversion = ds.Tables[0].Rows[a]["appversion"].ToString();
                    fd.studyid = ds.Tables[0].Rows[a]["studyid"].ToString();
                    fd.dssid = ds.Tables[0].Rows[a]["dssid"].ToString();
                    fd.week = ds.Tables[0].Rows[a]["week"].ToString();


                    var obj1 = JsonConvert.DeserializeObject<s02_data_21cm>(ds.Tables[0].Rows[a]["s02"].ToString());


                    fd.cm0101 = obj1.cm0101;
                    fd.cm0102 = obj1.cm0102;
                    fd.cm0102a = obj1.cm0102a;
                    fd.cm0103 = obj1.cm0103;
                    fd.cm0104 = obj1.cm0104;
                    fd.cm0105 = obj1.cm0105;
                    fd.cm0106 = obj1.cm0106;
                    fd.cm0107 = obj1.cm0107;
                    fd.cm0108 = obj1.cm0108;
                    fd.cm0109 = obj1.cm0109;
                    fd.cm0109mx = obj1.cm0109mx;
                    fd.cm0110 = obj1.cm0110;
                    fd.cm0111 = obj1.cm0111;
                    fd.cm0112 = obj1.cm0112;
                    fd.cm0201 = obj1.cm0201;
                    fd.cm0202 = obj1.cm0202;
                    fd.cm020277x = obj1.cm020277x;
                    fd.cm0301 = obj1.cm0301;
                    fd.cm03010 = obj1.cm03010;
                    fd.cm03011 = obj1.cm03011;
                    fd.cm03012 = obj1.cm03012;
                    fd.cm03013 = obj1.cm03013;
                    fd.cm03014 = obj1.cm03014;
                    fd.cm03015 = obj1.cm03015;
                    fd.cm03016 = obj1.cm03016;
                    fd.cm03017 = obj1.cm03017;
                    fd.cm03018 = obj1.cm03018;
                    fd.cm03019 = obj1.cm03019;
                    fd.cm0302 = obj1.cm0302;
                    fd.cm03020 = obj1.cm03020;
                    fd.cm03021 = obj1.cm03021;
                    fd.cm03022 = obj1.cm03022;
                    fd.cm03023 = obj1.cm03023;
                    fd.cm03024 = obj1.cm03024;
                    fd.cm03025 = obj1.cm03025;
                    fd.cm03026 = obj1.cm03026;
                    fd.cm03027 = obj1.cm03027;
                    fd.cm03028 = obj1.cm03028;
                    fd.cm03029 = obj1.cm03029;
                    fd.cm0303 = obj1.cm0303;
                    fd.cm03030 = obj1.cm03030;
                    fd.cm03031 = obj1.cm03031;
                    fd.cm03032 = obj1.cm03032;
                    fd.cm03033 = obj1.cm03033;
                    fd.cm03034 = obj1.cm03034;
                    fd.cm03035 = obj1.cm03035;
                    fd.cm03036 = obj1.cm03036;
                    fd.cm03037 = obj1.cm03037;
                    fd.cm03038 = obj1.cm03038;
                    fd.cm03039 = obj1.cm03039;
                    fd.cm0304 = obj1.cm0304;
                    fd.cm03040 = obj1.cm03040;
                    fd.cm03041 = obj1.cm03041;
                    fd.cm03042 = obj1.cm03042;
                    fd.cm03043 = obj1.cm03043;
                    fd.cm03044 = obj1.cm03044;
                    fd.cm03045 = obj1.cm03045;
                    fd.cm03046 = obj1.cm03046;
                    fd.cm03047 = obj1.cm03047;
                    fd.cm03048 = obj1.cm03048;
                    fd.cm03049 = obj1.cm03049;
                    fd.cm0305 = obj1.cm0305;
                    fd.cm03050 = obj1.cm03050;
                    fd.cm03051 = obj1.cm03051;
                    fd.cm0306 = obj1.cm0306;
                    fd.cm0307 = obj1.cm0307;
                    fd.cm0308 = obj1.cm0308;
                    fd.cm0309 = obj1.cm0309;
                    fd.cm0401 = obj1.cm0401;
                    fd.cm04010 = obj1.cm04010;
                    fd.cm04011 = obj1.cm04011;
                    fd.cm04012 = obj1.cm04012;
                    fd.cm04013 = obj1.cm04013;
                    fd.cm0402 = obj1.cm0402;
                    fd.cm0403 = obj1.cm0403;
                    fd.cm0404 = obj1.cm0404;
                    fd.cm0405 = obj1.cm0405;
                    fd.cm0406 = obj1.cm0406;
                    fd.cm0407 = obj1.cm0407;
                    fd.cm0408 = obj1.cm0408;
                    fd.cm0408015x = obj1.cm0408015x;
                    fd.cm0501 = obj1.cm0501;
                    fd.cm05011 = obj1.cm05011;
                    fd.cm05012 = obj1.cm05012;
                    fd.cm05013 = obj1.cm05013;
                    fd.cm0501301x = obj1.cm0501301x;
                    fd.cm05015 = obj1.cm05015;
                    fd.cm05016 = obj1.cm05016;
                    fd.cm0501601x = obj1.cm0501601x;
                    fd.cm05018 = obj1.cm05018;
                    fd.cm0501801x = obj1.cm0501801x;
                    fd.cm0502 = obj1.cm0502;
                    fd.cm05020 = obj1.cm05020;
                    fd.cm0503 = obj1.cm0503;
                    fd.cm0504 = obj1.cm0504;
                    fd.cm0505 = obj1.cm0505;
                    fd.cm0506 = obj1.cm0506;
                    fd.cm0507 = obj1.cm0507;
                    fd.cm0508 = obj1.cm0508;
                    fd.cm0509 = obj1.cm0509;
                    fd.cm050901x = obj1.cm050901x;
                    fd.cm0601 = obj1.cm0601;
                    fd.cm0602 = obj1.cm0602;
                    fd.cm0603 = obj1.cm0603;
                    fd.cm0604 = obj1.cm0604;
                    fd.cm0606 = obj1.cm0606;
                    fd.cm0607 = obj1.cm0607;
                    fd.cm0608 = obj1.cm0608;
                    fd.cm0609 = obj1.cm0609;
                    fd.cm0605 = obj1.cm0605;
                    fd.cmsid = obj1.cmsid;
                    fd.cm0701 = obj1.cm0701;
                    fd.cm0702 = obj1.cm0702;
                    fd.cm070277x = obj1.cm070277x;
                    fd.cm0703a = obj1.cm0703a;
                    fd.cm0703b = obj1.cm0703b;
                    fd.chkvaccdta = obj1.chkvaccdta;
                    fd.chkvaccdtb = obj1.chkvaccdtb;
                    fd.chkdt3ch = obj1.chkdt3ch;


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

        private void DataUpload_SQLite_Load(object sender, EventArgs e)
        {

        }
    }
}
