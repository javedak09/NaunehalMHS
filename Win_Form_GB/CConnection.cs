using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
//using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace Win_Form_GB
{
    class CConnection
    {
        public SQLiteConnection cn = null;

        public CConnection()
        {
            try
            {
                cn = new SQLiteConnection(ConfigurationSettings.AppSettings["cnStr1"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

            }
        }

        public void MConnOpen()
        {
            try
            {
                cn.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
            }
        }

        public void MConnClose()
        {
            try
            {
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
            }
        }
    }
}
