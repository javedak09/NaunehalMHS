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
    public partial class frmMain : Form
    {
        private static string mynode = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //CDBOperations obj_op = null;
            //DataSet ds = null;

            try
            {
                this.Text = CVariables.AppName1;
                toolStripStatusLabel1.Text = "          " + DateTime.Now.ToLongDateString();
                toolStripStatusLabel2.Text = "                    " + DateTime.Now.ToShortTimeString() + "                                        ";


                toolStripStatusLabel3.Text = "         Logged in as:   " + CVariables.UserName.ToUpper() + "  -  (User 1) ";

                //timer1.Enabled = true;


                treeView1.Nodes[0].ExpandAll();


                naviBar1.ActiveBand = naviBand6;


                naviBand1.Visible = false;
                naviBand3.Visible = false;
                naviBand5.Visible = false;
                naviBand2.Visible = false;
                naviBand4.Visible = false;



                if (CVariables.IsAdmin == true)
                {
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    //entryStatusToolStripMenuItem.Visible = true;


                    //obj_op = new CDBOperations();
                    //ds = obj_op.GetFormData_VisitID("sp_GetRecords", "0", "", "");

                    //NaviBand band = null;

                    //for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                    //{
                    //    band = new NaviBand();

                    //    band.Name = ds.Tables[0].Rows[a]["ID"].ToString();
                    //    band.Text = ds.Tables[0].Rows[a]["BandText"].ToString();
                    //    band.SmallImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\images\\" + ds.Tables[0].Rows[a]["BandSmallImage"].ToString());
                    //    band.LargeImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\images\\" + ds.Tables[0].Rows[a]["BandLargeImage"].ToString());

                    //    naviBar1.LayoutStyle = NaviLayoutStyle.Office2007Silver;

                    //    naviBar1.Bands.Add(band);
                    //}

                    //naviBar1.ShowMoreOptionsButton = false;

                    //naviBar1.VisibleLargeButtons = ds.Tables[0].Rows.Count;

                    //naviBar1.ActiveBand = naviBar1.Bands[0];



                }
                else
                {
                    if (CVariables.IsAdmin == false)
                    {
                        menuStrip1.Items[1].Visible = false;
                        menuStrip1.Items[2].Visible = false;
                        //entryStatusToolStripMenuItem.Visible = false;

                    }
                    else if (CVariables.IsAdmin == false)
                    {

                    }
                    else
                    {
                        menuStrip1.Items[1].Visible = false;
                        menuStrip1.Items[2].Visible = false;
                        //entryStatusToolStripMenuItem.Visible = true;
                    }

                }


            }


            catch (Exception ex)
            {

            }

            finally
            {
                //obj_op = null;
                //ds = null;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            //frmMessage frm = new frmMessage();
            //frm.ShowDialog();

            upload_forms_master();
            upload_forms();

            //frm.Close();

            GC.Collect();
            CVariables.frmlogin1.Show();


        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }



        private void OpenForm(Form frm)
        {
            bool IsFormOpen = false;

            if (this.MdiChildren.Length == 0)
            {
                CVariables.frm1 = this;
                frm.MdiParent = this;
                frm.Top = 0;
                frm.Left = 0;
                frm.Show();
            }
            else
            {

                for (int a = 0; a <= MdiChildren.Length - 1; a++)
                {
                    IsFormOpen = true;
                }


                if (!IsFormOpen)
                {
                    CVariables.frm1 = this;
                    frm.MdiParent = this;
                    frm.Top = 0;
                    frm.Left = 0;
                    frm.Show();
                }
            }
        }


        private void ClearBackColor()
        {
            TreeNodeCollection nodes = treeView1.Nodes;

            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        private void ClearRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.BackColor = Color.White;
                ClearRecursive(tn);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Name == "logout")
                {
                    //frmMessage frm = new frmMessage();
                    //frm.ShowDialog();

                    upload_forms_master();
                    upload_forms();

                    //frm.Close();

                    this.Close();
                    CVariables.frmlogin1.Show();
                }
                else if (e.Node.Name == "frm")
                {
                    frmMSHIMG frm = new frmMSHIMG();
                    OpenForm(frm);
                    frm = null;
                }

                //else if (e.Node.Name == "IFR")
                //{
                //    IFR frm = new IFR();
                //    OpenForm(frm);
                //    frm = null;
                //}
                //else if (e.Node.Name == "Lab")
                //{
                //    Lab frm = new Lab();
                //    OpenForm(frm);
                //    frm = null;
                //}

                ClearBackColor();


                //TreeNode[] tn = treeView1.Nodes[0].Nodes.Find(txtNodeSearch.Text, true);

                for (int i = 0; i < treeView1.Nodes[0].Nodes.Count - 1; i++)
                {
                    treeView1.SelectedNode = treeView1.Nodes[i];
                    treeView1.SelectedNode.BackColor = Color.White;
                }

            }

            catch (Exception ex)
            {

            }
        }

        private void userPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermissions frm = new frmPermissions();
            CVariables.frm1 = this;
            frm.MdiParent = this;
            frm.Top = 0;
            frm.Left = 0;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMessage frm = new frmMessage();
            //frm.ShowDialog();

            upload_forms_master();
            upload_forms();

            //frm.Close();

            this.Close();
            CVariables.frmlogin1.Show();
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


                webRequest = (HttpWebRequest)WebRequest.Create("https://vcoe1.aku.edu/naunehal/api/sync.php");


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



        public void upload_forms()
        {
            List<forms_data> datas = new List<forms_data>();

            datas = fetchData();
            int total = datas.Count;

            if (datas.Count > 0)
            {

                var data_obj = JsonConvert.SerializeObject(datas);



                var table_var = "[{\"table\":\"camp_patient_dtl\", \"check\":\"users\"}, " + data_obj + "]";

                string requestParams = table_var.ToString();
                HttpWebRequest webRequest;


                webRequest = (HttpWebRequest)WebRequest.Create("https://vcoe1.aku.edu/naunehal/api/sync.php");


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

                            updateCampPatient_Detail(id);
                        }
                        if (statusmessage == "2")
                        {
                            dupliatecount++;
                            id = item.id;

                            updateCampPatient_Detail(id);
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


        private void updateCampPatient_Detail(string id)
        {

            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("update camp_patient_dtl set synced=1, synceddate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' where id = '" + id + "'", cn.cn);
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




        public List<forms_data> fetchData()
        {
            CConnection cn = new CConnection();

            List<forms_data> forms = new List<forms_data>();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from camp_patient_dtl where synced is null or synced = ''", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                {

                    forms_data fd = new forms_data();

                    fd._id = ds.Tables[0].Rows[a]["id"].ToString();
                    fd.deviceid = SystemInformation.ComputerName;
                    fd.sysdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    fd.id = ds.Tables[0].Rows[a]["id"].ToString();
                    fd.form_id = ds.Tables[0].Rows[a]["form_id"].ToString();
                    fd.mh01 = ds.Tables[0].Rows[a]["mh01"].ToString();
                    fd.mh02 = ds.Tables[0].Rows[a]["mh02"].ToString();
                    fd.mh03 = ds.Tables[0].Rows[a]["mh03"].ToString();
                    fd.mh04 = ds.Tables[0].Rows[a]["mh04"].ToString();
                    fd.mh05 = ds.Tables[0].Rows[a]["mh05"].ToString();
                    fd.mh06 = ds.Tables[0].Rows[a]["mh06"].ToString();
                    fd.mh07 = ds.Tables[0].Rows[a]["mh07"].ToString();
                    fd.mh08 = ds.Tables[0].Rows[a]["mh08"].ToString();
                    fd.mh09y = ds.Tables[0].Rows[a]["mh09y"].ToString();
                    fd.mh09m = ds.Tables[0].Rows[a]["mh09m"].ToString();
                    fd.mh09d = ds.Tables[0].Rows[a]["mh09d"].ToString();
                    fd.mh010 = ds.Tables[0].Rows[a]["mh010"].ToString();
                    fd.mh011 = ds.Tables[0].Rows[a]["mh011"].ToString();
                    fd.mh012 = ds.Tables[0].Rows[a]["mh012"].ToString();
                    fd.chkWeight = ds.Tables[0].Rows[a]["chkWeight"].ToString();
                    fd.mh013 = ds.Tables[0].Rows[a]["mh013"].ToString();
                    fd.mh014 = ds.Tables[0].Rows[a]["mh014"].ToString();
                    fd.mh015 = ds.Tables[0].Rows[a]["mh015"].ToString();
                    fd.chkHeight = ds.Tables[0].Rows[a]["chkHeight"].ToString();
                    fd.mh016 = ds.Tables[0].Rows[a]["mh016"].ToString();
                    fd.chkMUAC = ds.Tables[0].Rows[a]["chkMUAC"].ToString();


                    fd.mh01701 = ds.Tables[0].Rows[a]["mh01701"].ToString();
                    fd.mh01702 = ds.Tables[0].Rows[a]["mh01702"].ToString();
                    fd.mh01703 = ds.Tables[0].Rows[a]["mh01703"].ToString();
                    fd.mh01704 = ds.Tables[0].Rows[a]["mh01704"].ToString();
                    fd.mh017077 = ds.Tables[0].Rows[a]["mh017077"].ToString();
                    fd.mh017077x = ds.Tables[0].Rows[a]["mh017077x"].ToString();


                    fd.mh01801 = ds.Tables[0].Rows[a]["mh01801"].ToString();
                    fd.mh01802 = ds.Tables[0].Rows[a]["mh01802"].ToString();
                    fd.mh01803 = ds.Tables[0].Rows[a]["mh01803"].ToString();
                    fd.mh01804 = ds.Tables[0].Rows[a]["mh01804"].ToString();
                    fd.mh01805 = ds.Tables[0].Rows[a]["mh01805"].ToString();
                    fd.mh01806 = ds.Tables[0].Rows[a]["mh01806"].ToString();
                    fd.mh01807 = ds.Tables[0].Rows[a]["mh01807"].ToString();
                    fd.mh01808 = ds.Tables[0].Rows[a]["mh01808"].ToString();
                    fd.mh01809 = ds.Tables[0].Rows[a]["mh01809"].ToString();
                    fd.mh018010 = ds.Tables[0].Rows[a]["mh018010"].ToString();
                    fd.mh018011 = ds.Tables[0].Rows[a]["mh018011"].ToString();
                    fd.mh018012 = ds.Tables[0].Rows[a]["mh018012"].ToString();
                    fd.mh018013 = ds.Tables[0].Rows[a]["mh018013"].ToString();
                    fd.mh018014 = ds.Tables[0].Rows[a]["mh018014"].ToString();
                    fd.mh018015 = ds.Tables[0].Rows[a]["mh018015"].ToString();
                    fd.mh018016 = ds.Tables[0].Rows[a]["mh018016"].ToString();
                    fd.mh018077 = ds.Tables[0].Rows[a]["mh018077"].ToString();
                    fd.mh018077x = ds.Tables[0].Rows[a]["mh018077x"].ToString();

                    fd.chkNoneDiag = ds.Tables[0].Rows[a]["chkNoneDiag"].ToString();


                    fd.mh01901 = ds.Tables[0].Rows[a]["mh01901"].ToString();
                    fd.mh01902 = ds.Tables[0].Rows[a]["mh01902"].ToString();
                    fd.mh01903 = ds.Tables[0].Rows[a]["mh01903"].ToString();
                    fd.mh01904 = ds.Tables[0].Rows[a]["mh01904"].ToString();
                    fd.mh01905 = ds.Tables[0].Rows[a]["mh01905"].ToString();
                    fd.mh01906 = ds.Tables[0].Rows[a]["mh01906"].ToString();
                    fd.mh01907 = ds.Tables[0].Rows[a]["mh01907"].ToString();
                    fd.mh01908 = ds.Tables[0].Rows[a]["mh01908"].ToString();
                    fd.mh01909 = ds.Tables[0].Rows[a]["mh01909"].ToString();
                    fd.mh019010 = ds.Tables[0].Rows[a]["mh019010"].ToString();
                    fd.mh019011 = ds.Tables[0].Rows[a]["mh019011"].ToString();
                    fd.mh019012 = ds.Tables[0].Rows[a]["mh019012"].ToString();
                    fd.mh019013 = ds.Tables[0].Rows[a]["mh019013"].ToString();
                    fd.mh019014 = ds.Tables[0].Rows[a]["mh019014"].ToString();
                    fd.mh019015 = ds.Tables[0].Rows[a]["mh019015"].ToString();
                    fd.mh019077 = ds.Tables[0].Rows[a]["mh019077"].ToString();
                    fd.mh019077x = ds.Tables[0].Rows[a]["mh019077x"].ToString();
                    fd.chkNone = ds.Tables[0].Rows[a]["chkNone"].ToString();


                    fd.mh020 = ds.Tables[0].Rows[a]["mh020"].ToString();
                    fd.mh021 = ds.Tables[0].Rows[a]["mh021"].ToString();
                    fd.mh022 = ds.Tables[0].Rows[a]["mh022"].ToString();
                    fd.mh023 = ds.Tables[0].Rows[a]["mh023"].ToString();
                    fd.mh024 = ds.Tables[0].Rows[a]["mh024"].ToString();
                    fd.mh025 = ds.Tables[0].Rows[a]["mh025"].ToString();


                    fd.mh02601 = ds.Tables[0].Rows[a]["mh02601"].ToString();
                    fd.mh02602 = ds.Tables[0].Rows[a]["mh02602"].ToString();
                    fd.mh02603 = ds.Tables[0].Rows[a]["mh02603"].ToString();
                    fd.mh02604 = ds.Tables[0].Rows[a]["mh02604"].ToString();
                    fd.mh02605 = ds.Tables[0].Rows[a]["mh02605"].ToString();
                    fd.mh02606 = ds.Tables[0].Rows[a]["mh02606"].ToString();
                    fd.mh027a = ds.Tables[0].Rows[a]["mh027a"].ToString();

                    fd.mh02607 = ds.Tables[0].Rows[a]["mh02607"].ToString();
                    fd.mh02608 = ds.Tables[0].Rows[a]["mh02608"].ToString();
                    fd.mh02609 = ds.Tables[0].Rows[a]["mh02609"].ToString();
                    fd.mh026010 = ds.Tables[0].Rows[a]["mh026010"].ToString();
                    fd.mh026011 = ds.Tables[0].Rows[a]["mh026011"].ToString();
                    fd.mh027b = ds.Tables[0].Rows[a]["mh027b"].ToString();

                    fd.mh026012 = ds.Tables[0].Rows[a]["mh026012"].ToString();
                    fd.mh026013 = ds.Tables[0].Rows[a]["mh026013"].ToString();
                    fd.mh026014 = ds.Tables[0].Rows[a]["mh026014"].ToString();
                    fd.mh026015 = ds.Tables[0].Rows[a]["mh026015"].ToString();
                    fd.mh026016 = ds.Tables[0].Rows[a]["mh026016"].ToString();
                    fd.mh026017 = ds.Tables[0].Rows[a]["mh026017"].ToString();
                    fd.mh026018 = ds.Tables[0].Rows[a]["mh026018"].ToString();
                    fd.mh026019 = ds.Tables[0].Rows[a]["mh026019"].ToString();
                    fd.chkVaccination = ds.Tables[0].Rows[a]["chkVaccination"].ToString();


                    fd.mh027 = ds.Tables[0].Rows[a]["mh027"].ToString();
                    fd.mh028 = ds.Tables[0].Rows[a]["mh028"].ToString();
                    fd.mh029 = ds.Tables[0].Rows[a]["mh029"].ToString();

                    fd.mh01101 = ds.Tables[0].Rows[a]["mh01101"].ToString();
                    fd.mh01102 = ds.Tables[0].Rows[a]["mh01102"].ToString();
                    fd.mh01103 = ds.Tables[0].Rows[a]["mh01103"].ToString();
                    
                    
                    fd.uccode = ds.Tables[0].Rows[a]["uccode"].ToString();
                    fd.dist_id = ds.Tables[0].Rows[a]["dist_id"].ToString();
                    fd.databy = "desktop";
                    fd.userid = ds.Tables[0].Rows[a]["userid"].ToString();
                    fd.entrydate = ds.Tables[0].Rows[a]["entrydate"].ToString();
                    fd.master_id = ds.Tables[0].Rows[a]["master_id"].ToString();


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
            public string form_id;
            public string deviceid;
            public string sysdate;
            public string id;
            public string mh01;
            public string mh02;
            public string mh03;
            public string mh04;
            public string mh05;
            public string mh06;
            public string mh07;
            public string mh08;
            public string mh09y;
            public string mh09m;
            public string mh09d;
            public string mh010;
            public string mh011;
            public string mh012;
            public string chkWeight;
            public string mh013;
            public string mh014;
            public string mh015;
            public string chkHeight;
            public string mh016;
            public string chkMUAC;
            public string mh01701;
            public string mh01702;
            public string mh01703;
            public string mh01704;
            public string mh017077;
            public string mh017077x;

            public string mh01801;
            public string mh01802;
            public string mh01803;
            public string mh01804;
            public string mh01805;
            public string mh01806;
            public string mh01807;
            public string mh01808;
            public string mh01809;
            public string mh018010;
            public string mh018011;
            public string mh018012;
            public string mh018013;
            public string mh018014;
            public string mh018015;
            public string mh018016;
            public string mh018077;
            public string mh018077x;
            public string chkNoneDiag;


            public string mh01901;
            public string mh01902;
            public string mh01903;
            public string mh01904;
            public string mh01905;
            public string mh01906;
            public string mh01907;
            public string mh01908;
            public string mh01909;
            public string mh019010;
            public string mh019011;
            public string mh019012;
            public string mh019013;
            public string mh019014;
            public string mh019015;
            public string mh019077;
            public string mh019077x;
            public string chkNone;


            public string mh020;
            public string mh021;
            public string mh022;
            public string mh023;
            public string mh024;
            public string mh025;

            public string mh02601;
            public string mh02602;
            public string mh02603;
            public string mh02604;
            public string mh02605;
            public string mh02606;
            public string mh02607;
            public string mh02608;
            public string mh02609;
            public string mh026010;
            public string mh026011;
            public string mh026012;
            public string mh026013;
            public string mh026014;
            public string mh026015;
            public string mh026016;
            public string mh026017;
            public string mh026018;
            public string mh026019;
            public string chkVaccination;

            public string mh027;
            public string mh028;
            public string mh029;


            public string mh01101;
            public string mh01102;
            public string mh01103;

            public string mh027a;
            public string mh027b;

            public string uccode;
            public string dist_id;
            public string databy;
            public string userid;
            public string entrydate;

            public string master_id;
        }


        public class forms_data_master
        {
            public string _id;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMSHIMG frm = new frmMSHIMG();
            OpenForm(frm);
            frm = null;
        }
    }
}