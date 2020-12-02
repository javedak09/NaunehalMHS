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




                if (CVariables.IsAdmin == true)
                {
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    entryStatusToolStripMenuItem.Visible = true;


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
                        entryStatusToolStripMenuItem.Visible = false;

                    }
                    else if (CVariables.IsAdmin == false)
                    {

                    }
                    else
                    {
                        menuStrip1.Items[1].Visible = false;
                        menuStrip1.Items[2].Visible = false;
                        entryStatusToolStripMenuItem.Visible = true;
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
                if (e.Node.Name == "Screening")
                {
                    frmScreening frm = new frmScreening();
                    OpenForm(frm);
                    frm = null;
                }
                else if (e.Node.Name == "FollowUp")
                {
                    frmFollowUpcs frm = new frmFollowUpcs();
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
            this.Close();
            CVariables.frmlogin1.Show();
        }
    }
}
