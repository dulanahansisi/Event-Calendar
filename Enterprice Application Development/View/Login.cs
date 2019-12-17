using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Enterprice_Application_Development.View
{
    public partial class Login : Form
    {
        SqlConnection con;
        String connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Enterprice_Application_Development.Properties.Settings.sbdLoggingConnectionString"].ConnectionString;
            Load += new EventHandler(AppLoad);
        }

        private void AppLoad(object sender, System.EventArgs e)
        {
            this.Icon = Properties.Resources.Iconshock_Cms_User;
            this.picBxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picBxUser.Image = Properties.Resources.logIcon;
        }

        private void loginExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logIn(object sender, EventArgs e)
        {
            retrieveUsers();
        }

        private void retrieveUsers()
        {
            using (con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From Users", con))
            {
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                for (int i=0;i<dt.Rows.Count;i++)
                {
                    String strPass = dt.Rows[0][1].ToString();
                    String strUser = dt.Rows[0][2].ToString();

                    if (strUser.Contains(textBoxUserName.Text) && strPass.Contains(textBoxPassword.Text)&& !(textBoxUserName.Text=="")&& !(textBoxPassword.Text==""))
                    {
                        InitialView inView = new InitialView();
                        this.Hide();
                        inView.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!!!");
                    }

                }               

            }
            
        }

    }
}
