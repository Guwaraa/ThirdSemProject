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

namespace Theater_Ticketing_System
{
    public partial class NewsPannel : UserControl
    {
        public NewsPannel()
        {
            InitializeComponent();
            
        }
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        int newscounter = 1;
        private void NewsPannel_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();


            
        }

        private void CancelNewsPannel_Click(object sender, EventArgs e)
        {
            MyGlobal.newsclose = 1;
            gunaUsernameTextbox.Text = null;
            newscounter = 1;
            displaynews();
            timerstop = 0;
        }

        private void gunaUsernameTextbox_MouseDown(object sender, MouseEventArgs e)
        {
            gunaUsernameTextbox.Text = null;
        }
        int timerstop = 0;
       int counter=1;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            
            if(counter==1)
            {
               
                
                if(newscounter==1)
                {
                    BackButton.Enabled = false;

                }
                else
                {
                    BackButton.Enabled = true;
                }
                if(newscounter==1)
                {
                    Display.Text = "1st News..!!";
                }
                if (newscounter == 2)
                {
                    Display.Text = "2nd News..!!";
                }
                if (newscounter == 3)
                {
                    Display.Text = "3rd News..!!";
                }
                if (newscounter >=4)
                {
                    Display.Text =  newscounter +"th News..!!";
                }
                if(timerstop==0)
                {
                    displaynews();
                }

                counter = 0;
            }
            counter++;
        }
        public void displaynews()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *from NewsDetail where News_no='" + newscounter + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string news = dt.Rows[0]["Detail"].ToString();
                gunaUsernameTextbox.Text = news;
                UpdateButton.Enabled = true;
                EnterButton.Enabled = false;
                
            }
            catch (Exception ex)
            {
                UpdateButton.Enabled =false;
                EnterButton.Enabled = true;
                gunaUsernameTextbox.Text = null;

            }
            finally
            {
                con.Close();
            }
        }
        private void gunaUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            gunaUsernameTextbox.MaxLength = 75;
            NumberLabel.Text = gunaUsernameTextbox.Text.Length.ToString();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            newscounter = newscounter - 1;
            if(newscounter<1)
            {
                newscounter = 1;
            }
            timerstop = 0;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            newscounter++;
            timerstop = 0;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query="Update NewsDetail set Detail='"+gunaUsernameTextbox.Text+"' where News_no='"+newscounter+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            gunaUsernameTextbox.Text = null;
            displaynews();
            timerstop = 0;
            con.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "Insert  into NewsDetail(News_no,Detail)values('"+newscounter+"','" + gunaUsernameTextbox.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            gunaUsernameTextbox.Text = null;
            displaynews();
            timerstop = 0;
            con.Close();
        }

        private void gunaUsernameTextbox_MouseDown_1(object sender, MouseEventArgs e)
        {
            timerstop = 1;
            
        }

        private void gunaUsernameTextbox_MouseLeave(object sender, EventArgs e)
        {
          //  timerstop = 0;
        }

        private void gunaUsernameTextbox_MouseEnter(object sender, EventArgs e)
        {
            timerstop = 1;
        }

        private void gunaUsernameTextbox_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
