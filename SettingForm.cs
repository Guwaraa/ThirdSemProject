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
using System.Drawing.Drawing2D;

namespace Theater_Ticketing_System
{
    public partial class SettingForm : UserControl
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";
        
        private void SettingForm_Load(object sender, EventArgs e)
        {
            UsernameRemover.Location = new Point(350, 200);
            Usernamedisplay.Text = "Enter the Username ";
            newsPannel.Visible = false;
            movieDataentry.Visible = false;
            gunaErrorPicture.Visible = false;
            RefreshTimer.Start();
            UsernameRemover.Visible = false;
            passwordmodify.Visible = false;
            DownArrow.Visible = false;
            ChainArrow.Visible = false;
            ChainArrow2.Visible = false;
            UserPassSettingButton.Visible = false;
            RemoveAccSetting.Visible = false;
            AccountSetting2.Visible = false;
            AdvDownArrow.Visible = false;
            AdvChainArrow.Visible = false;
            AdvRemoveAccount.Visible = false;
            AdvSetting.Visible = false;
            AdvChainArrow2.Visible = false;
            AdvModifyNews.Visible = false;
           // AdvChainArrow3.Visible = false;
            //AdvChainArrow4.Visible = false;
            ///////////////////////////////
            AdvSetting.Location = new Point(77, 117);
            AdvanceSetting.Location = new Point(77, 117);
            AdvRightarrow.Location = new Point(44, 132);
            AdvDownArrow.Location = new Point(44, 132);
            AdvChainArrow.Location = new Point(72,174);
            AdvRemoveAccount.Location = new Point(112, 168);
            AdvChainArrow2.Location = new Point(72, 222);
            AdvModifyNews.Location = new Point(112,219);
            //////////////////////////////////////////////////
            AdvChainArrow3.Location = new Point(72, 270);
            AdvAdminAccount.Location = new Point(112, 267);
            AdvChainArrow4.Location = new Point(72, 318);
            EditMovieDetail.Location = new Point(112, 315);
            //////////////////////////////////
            PopupMessagebox.Location = new Point(360, 300);
            PopupMessagebox.Visible = false;
            RemoveAccountMessageBox.Visible = false;
            RemoveAccountMessageBox.Location = new Point(360, 300);
            ////////////////////////////////
            EditMovieDetail.Visible = false;
            AdvAdminAccount.Visible = false;
            AdvChainArrow3.Visible = false;
            AdvChainArrow4.Visible = false;

        }

        private void AccountSettingButton_Click(object sender, EventArgs e)
        {
            RightArrow.Visible = false;
            DownArrow.Visible = true;
            ChainArrow.Visible = true;
            ChainArrow2.Visible = true;
            UserPassSettingButton.Visible = true;
            RemoveAccSetting.Visible = true;
            AccountSettingButton.Visible = false;
            AccountSetting2.Visible = true;
            /////////////////////////////////////////////////////////////////////
            AdvSetting.Location = new Point(77, 220);
            AdvanceSetting.Location = new Point(77, 220);
            AdvRightarrow.Location = new Point(44, 235);
            AdvDownArrow.Location = new Point(44, 235);
            ////////////////////////////////
            AdvChainArrow.Location = new Point(72, 277);
            AdvRemoveAccount.Location = new Point(112, 271);
            AdvChainArrow2.Location=new Point(72,328);
            AdvModifyNews.Location = new Point(112,322);
            /////////////////////////////////
            AdvChainArrow3.Location = new Point(72, 373);
            AdvAdminAccount.Location = new Point(112, 370);
            AdvChainArrow4.Location = new Point(72, 421);
            EditMovieDetail.Location = new Point(112, 418);

        }

        private void AccountSetting2_Click(object sender, EventArgs e)
        {
            AccountSettingButton.Visible = true;
            AccountSetting2.Visible = false;
            DownArrow.Visible = false;
            ChainArrow.Visible = false;
            ChainArrow2.Visible = false;
            UserPassSettingButton.Visible = false;
            RemoveAccSetting.Visible = false;
            AccountSetting2.Visible = false;
            RightArrow.Visible = true;
            //////////////////////////////////////////////////////////
            AdvSetting.Location = new Point(77, 117);
            AdvanceSetting.Location = new Point(77, 117);
            AdvRightarrow.Location = new Point(44, 132);
            AdvDownArrow.Location = new Point(44, 132);
            //////////////////////////////////////////
            AdvChainArrow.Location = new Point(72, 174);
            AdvRemoveAccount.Location = new Point(112, 168);
            AdvChainArrow2.Location = new Point(72, 225);
            AdvModifyNews.Location = new Point(112, 219);
            ////////////////////////////////////
            AdvChainArrow3.Location = new Point(72, 270);
            AdvAdminAccount.Location = new Point(112, 267);
            AdvChainArrow4.Location = new Point(72, 318);
            EditMovieDetail.Location = new Point(112, 315);
        }

        private void AdvanceSetting_Click(object sender, EventArgs e)
        {


            if (MyGlobal.DTAdmin == 1)
            {
                RemoveAccountMessageBox.Visible = false;
                AdvDownArrow.Visible = true;
                AdvChainArrow.Visible = true;
                AdvRemoveAccount.Visible = true;
                AdvChainArrow2.Visible = true;
                AdvModifyNews.Visible=true;
                AdvSetting.Visible = true;
                AdvanceSetting.Visible = false;
                AdvRightarrow.Visible = false;
                EditMovieDetail.Visible = true;
                AdvAdminAccount.Visible = true;
                AdvChainArrow3.Visible = true;
                AdvChainArrow4.Visible = true;


            }
            else
            {
                PopupMessagebox.Visible = true;
                RemoveAccountMessageBox.Visible = false;

                PopupMessageBoxLable.Text = "LOGIN as administrator to access...!!";
                PopupMessageBoxLable.TextAlign = ContentAlignment.BottomCenter;
            }
        }

        private void AdvSetting_Click(object sender, EventArgs e)
        {

            AdvDownArrow.Visible = false;
            AdvChainArrow.Visible = false;
            AdvRemoveAccount.Visible = false;
            AdvSetting.Visible = false;
            AdvanceSetting.Visible = true;
            AdvRightarrow.Visible = true;
            AdvChainArrow2.Visible = false;
            AdvModifyNews.Visible = false;
            EditMovieDetail.Visible = false;
            AdvAdminAccount.Visible = false;
            AdvChainArrow3.Visible = false;
            AdvChainArrow4.Visible = false;



        }
        /// <summary>/
       
        private void BackButton_Click(object sender, EventArgs e)
        {
            MyGlobal.Advback = 1;


        }

        private void MessageBoxSure_Click(object sender, EventArgs e)
        {
            PopupMessagebox.Visible = false;
            MyGlobal.Advbackvalue = 1;
        }

        private void NotIntrestedButton_Click(object sender, EventArgs e)
        {
            PopupMessagebox.Visible = false;
        }

        private void RemoveAccSetting_Click(object sender, EventArgs e)
        {
            if (MyGlobal.DTAdmin == 1)
            {
                UsernameRemover.Visible = true;
            }
            else
            {
                RemoveAccountMessageBox.Visible = true;
            }
            PopupMessagebox.Visible = false;

        }

        private void gunaElipsePanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonNotIntrested_Click(object sender, EventArgs e)
        {
            RemoveAccountMessageBox.Visible = false;
        }

        private void ButtonSure_Click(object sender, EventArgs e)
        {
            RemoveAccountMessageBox.Visible = false;
            MyGlobal.Advback = 1;
            MyGlobal.Messageboxopenpassvalue = 1;           
        }
        private void UserPassSettingButton_Click(object sender, EventArgs e)
        {
             passwordmodify.Visible = true;
             passwordmodify.BringToFront();


        }

        int counter = 0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                if(MyGlobal.closevalue==1)
                {
                   passwordmodify.Visible = false;
                    MyGlobal.closevalue = 0;
                }
                if(MyGlobal.newsclose==1)
                {
                    newsPannel.Visible = false;
                    newsPannel.SendToBack();
                    passwordmodify.SendToBack();
                    MyGlobal.newsclose = 0;
                }
                if(MyGlobal.movieclosedata==1)
                {
                    movieDataentry.SendToBack();
                    movieDataentry.Visible = false;
                    MyGlobal.movieclosedata = 0;
                }
                counter = 0;

            }
        }

        private void AdvRemoveAccount_Click(object sender, EventArgs e)
        {
            UsernameRemover.Visible = true;
           
        }
        //int temp = 0;
        private void gunaUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            gunaUsernameTextbox.LineColor = Color.RoyalBlue;
            gunaErrorPicture.Visible = false;
            Usernamedisplay.Text = "Enter your Username ";
        }

        private void UsernameRemover_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonRemoveSure_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *From UserData where Username='" + gunaUsernameTextbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               
                string User = dt.Rows[0]["Username"].ToString();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Userdata Where Username='" + User + "'";
                cmd.ExecuteNonQuery();
                Usernamedisplay.Text="The username is DELETED !!";
                gunaUsernameTextbox = null;



            }
            catch (Exception ex)
            {
                gunaUsernameTextbox.Text = "";
                gunaUsernameTextbox.LineColor = Color.Red;
                gunaErrorPicture.Visible = true;
                Usernamedisplay.Text = "Your Username is not available..TRY AGAIN !!";

            }
            finally
            {
                con.Close();
            }
        }
        private void buttonNotInrestedRemover_Click(object sender, EventArgs e)
        {
            UsernameRemover.Visible = false;
            gunaUsernameTextbox.Text = "";
            gunaUsernameTextbox.LineColor = Color.RoyalBlue;
            gunaErrorPicture.Visible = false;
            Usernamedisplay.Text = "Enter the Username ";
        }

        private void AdvModifyNews_Click(object sender, EventArgs e)
        {
            newsPannel.Visible = true;
            newsPannel.BringToFront();
            //newsPannel.Refresh();

        }

       

        private void EditMovieDetail_Click_1(object sender, EventArgs e)
        {
            movieDataentry.BringToFront();
            movieDataentry.Visible = true;
        }

        private void gunaElipsePanel13_Paint(object sender, PaintEventArgs e)
        {

        }


        

        private void gunaUsernameTextbox_MouseEnter(object sender, EventArgs e)
        {
            Usernamedisplay.Text = "Enter the Username ";
            gunaUsernameTextbox.LineColor = Color.RoyalBlue;
            gunaErrorPicture.Visible = false;

        }
    }
}
