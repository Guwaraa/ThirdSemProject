using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Theater_Ticketing_System
{
    public partial class AfterLogged : UserControl
    {

        public AfterLogged()
        {
            InitializeComponent();
        }
       public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";


        private void AfterLogged_Load(object sender, EventArgs e)
        {
            DataRefresh.Start();

         
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            
            int active = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update UserData set ActiveStatus='" + active + "'where Username='" +MyGlobal.DTUser+ "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MyGlobal.LoginPassingValue = 0;

        }
        int counter = 1;
        private void DataRefresh_Tick(object sender, EventArgs e)
        {
            if(counter==1)
            {
                Username.Text = MyGlobal.DTUser;
                UserCharacter.Text = MyGlobal.DTCuser;
                counter = 0;
                UserCharacter.ForeColor = Color.LimeGreen;
            }
            counter = 1;
        }

        private void UserCharacter_Click(object sender, EventArgs e)
        {

        }
    }
}
