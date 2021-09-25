using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Theater_Ticketing_System
{
    public partial class TheaterTicketSystem : Form
    {
        public TheaterTicketSystem()
        {
            InitializeComponent();
        }
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";
        private void TheaterTicketSystem_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();
            signUpWindow.Visible = false;
            NewsTimer.Start();
            ////////////////
            BookTicket.Location = new Point(5, 120);
            BookTicketButton.Location = new Point(63, 120);
            BookedTicket.Location = new Point(5, 240);
            BookedTicketButton.Location = new Point(63, 240);
            MessagePicture.Location = new Point(5, 360);
            MessageButton.Location = new Point(63, 360);
            SettingPicture.Location = new Point(5, 480);
            SettingButton.Location = new Point(63, 480);
            PowerOffPicture.Location = new Point(5, 580);
            PowerOffButton.Location = new Point(63, 580);
            MinimixePicture.Location = new Point(5, 665);
            MinimizeButton.Location = new Point(63, 665);
            HomeImage.Enabled = false;
            BookTicket.Enabled = false;
            BookedTicket.Enabled = false;
            MessagePicture.Enabled = false;
            SettingPicture.Enabled = false;
            PowerOffPicture.Enabled = false;
            CloseMessageBoxPannel.Visible = false;
            afterLogged.Visible = false;
            PopupMessagebox.Visible = false;
            settingForm.Visible = false;
            messageForm.Visible = false ;
            MinimixePicture.Enabled = false;
            MenuButton.Enabled = false;
            MenuButton2.Enabled = false;
            /////////
            ticketBook.Visible = false;
            bookedTicketForm.Visible = false;
            MyGlobal.displaymovie = 1;
            displaymovie1.Visible = false;


        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (MyGlobal.LoginPassingValue == 1)
            {
                afterLogged.Visible = true;
            }
            if(MyGlobal.LoginPassingValue!=1)
            {
                
                signUpWindow.Visible = true;
            }
            SignUpButton.Visible = false;
            SignUpButton2.Visible = true;
            CloseMessageBoxPannel.Visible = false;
            RegisterCheck.Start();
           
        }
        private void signUpWindow_Load(object sender, EventArgs e)
        {

        }
         int counter=1;
         int timercount=1;


        private void SignUpButton2_Click(object sender, EventArgs e)
        {
            if (MyGlobal.LoginPassingValue == 1)
            {
                afterLogged.Visible = false;
            }

            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
           
        }
       
        private void RegisterCheck_Tick(object sender, EventArgs e)
        {

            if(timercount==1)
            {

                if(MyGlobal.RegisterPassingValue==1)
                {
                    signUpWindow.Visible = false;
                    MyGlobal.RegisterPassingValue = 0;
                }

                if (MyGlobal.LoginPassingValue==0)
                {
                    afterLogged.Visible = false;
                }
                if(MyGlobal.Advbackvalue==1)
                {
                    settingForm.Visible = false;
                    if (MyGlobal.LoginPassingValue == 1)
                    {
                        afterLogged.Visible = true;
                    }
                    if (MyGlobal.LoginPassingValue != 1)
                    {

                        signUpWindow.Visible = true;
                    }
                    SignUpButton.Visible = false;
                    SignUpButton2.Visible = true;
                    CloseMessageBoxPannel.Visible = false;
                    RegisterCheck.Start();
                    MyGlobal.Advbackvalue = 0;
                }

                if(MyGlobal.settingvalue==1)
                {
                    if (MyGlobal.LoginPassingValue == 1)
                    {
                        afterLogged.Visible = true;
                    }
                    if (MyGlobal.LoginPassingValue != 1)
                    {

                        signUpWindow.Visible = true;
                    }
                    SignUpButton.Visible = false;
                    SignUpButton2.Visible = true;
                    CloseMessageBoxPannel.Visible = false;
                    RegisterCheck.Start();
                    MyGlobal.settingvalue = 0;
                }
            }
            if(timercount==2)
            {
                
                if (MyGlobal.RegisterPassingValue == 1)
                {
                    signUpWindow.Visible = false;
                    MyGlobal.RegisterPassingValue = 0;
                    SignUpButton.Visible = true;
                    SignUpButton2.Visible = false;

                }
                if (MyGlobal.LoginPassingValue == 0)
                {
                    afterLogged.Visible = false;

                }
                timercount = 0;
            }
            timercount++;
        }

        private void NewsTimer_Tick(object sender, EventArgs e)
        {
            if (counter >= 1)
            {
                SqlConnection con = new SqlConnection(conString);
                try
                {
                    con.Open();
                    string query = "Select *from NewsDetail where News_no='" + counter + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                     UpdatedNewsLabel.Text = dt.Rows[0]["Detail"].ToString();
                    counter++;
                }
                catch (Exception ex)
                {

                    counter = 1;

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void HomeImage_MouseDown(object sender, MouseEventArgs e)
        {
           
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;

        }

        private void BookTicket_MouseDown(object sender, MouseEventArgs e)
        {
           
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
        }

        private void BookedTicket_MouseDown(object sender, MouseEventArgs e)
        {
            
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }

        }

        private void MessagePicture_MouseDown(object sender, MouseEventArgs e)
        {
            
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;



            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
           else
            {
                messageForm.Visible = true;
                
            }

        }

        private void SettingPicture_MouseDown(object sender, MouseEventArgs e)
        {
            
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
            else
            {
                settingForm.Visible = true;
            }

        }
        private void PowerOffPicture_MouseDown(object sender, MouseEventArgs e)
        {
            CloseMessageBoxPannel.Visible = true;
            CloseMessageBoxPannel.Location = new Point(360, 300);
            if (MyGlobal.LoginPassingValue == 1)
            {
                CloseMessageBoxPannel.Visible = true;
                CloseMessageBoxPannel.Location = new Point(360, 300);
                CloseMessageBoxlable.Text = " Please LOG&OUT Your account";

            }
            if (MyGlobal.LoginPassingValue != 1)
            {
                CloseMessageBoxPannel.Visible = true;
                CloseMessageBoxPannel.Location = new Point(360, 300);
                CloseMessageBoxlable.Text = "COME BACK SOON.....BIEEE !!!";
            }


        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            gunaMenuPanel.Size = new Size(69,714); 
            HomeButton.Visible = false;
            BookTicketButton.Visible = false;
            BookedTicketButton.Visible = false;
            MessageButton.Visible = false;
            SettingButton.Visible = false;
            gunaDisplayPanel.Size = new Size(1266,714);
            gunaDisplayPanel.Location = new Point(90,52);
            MenuButton.Visible = false;
            MenuButton2.Visible = true;
            HomeImage.Enabled = true;
            BookTicket.Enabled = true;
            BookedTicket.Enabled = true;
            MessagePicture.Enabled = true;
            SettingPicture.Enabled = true;
            PowerOffPicture.Enabled = true;
            MinimixePicture.Enabled = true;
            CloseMessageBoxPannel.Visible = false;
           
           
         


        }

        private void MenuButton2_Click(object sender, EventArgs e)
        {
            gunaDisplayPanel.Size = new Size(1110, 714);
            gunaDisplayPanel.Location = new Point(246, 52);
            MenuButton2.Visible = false;
            MenuButton.Visible = true;
            gunaMenuPanel.Size = new Size(220, 714);
            HomeButton.Visible = true;
            BookTicketButton.Visible = true;
            BookedTicketButton.Visible = true;
            MessageButton.Visible = true;
            SettingButton.Visible = true;
            HomeImage.Enabled = false;
            BookTicket.Enabled = false;
            BookedTicket.Enabled = false;
            MessagePicture.Enabled = false;
            SettingPicture.Enabled = false;
            PowerOffPicture.Enabled = false;
            CloseMessageBoxPannel.Visible = false;
            MinimixePicture.Enabled = false;
      
       
        
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            messageForm.Visible = false;
            settingForm.Visible = false;
            MenuButton.Enabled = false;
            MenuButton2.Enabled = false;



        }

        private void BookTicketButton_Click(object sender, EventArgs e)
        {
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
            else
            {
                
                MenuButton.Enabled = true;
                MenuButton2.Enabled = true;
                ticketBook.Visible = true;
                

            }
            


        }

        private void BookedTicketButton_Click(object sender, EventArgs e)
        {
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
            else
            {
                MenuButton.Enabled = true;
                MenuButton2.Enabled = true;
                bookedTicketForm.Visible = true;
                MyGlobal.refreshticketpannel = 1;
            }
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            
           


            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
            else
            {
                MyGlobal.start = 1;
                messageForm.Visible = true;
                MenuButton.Enabled = true;
                MenuButton2.Enabled = true;

            }
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            signUpWindow.Visible = false;
            SignUpButton.Visible = true;
            SignUpButton2.Visible = false;
            CloseMessageBoxPannel.Visible = false;
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
            else
            {
                settingForm.Visible = true;
                MenuButton.Enabled = true;
                MenuButton2.Enabled = true;
            }

        }
        private void PowerOffButton_Click(object sender, EventArgs e)
        {
            if (MyGlobal.LoginPassingValue == 1)
            {
                CloseMessageBoxPannel.Visible = true;
                CloseMessageBoxPannel.Location = new Point(360, 300);
                CloseMessageBoxlable.Text = " Please LOG&OUT Your account";
                
            }
            if (MyGlobal.LoginPassingValue !=1)
            {
                CloseMessageBoxPannel.Visible = true;
                CloseMessageBoxPannel.Location = new Point(360, 300);
                CloseMessageBoxlable.Text = "COME BACK SOON.....BIEEE !!!";
            }


        }


        private void CloseSureButton_Click(object sender, EventArgs e)
        {
            if (MyGlobal.LoginPassingValue == 1)
            {
                afterLogged.Visible = true;
                SignUpButton.Visible = false;
                SignUpButton2.Visible = true;
                CloseMessageBoxPannel.Visible = false;

            }
            if(MyGlobal.LoginPassingValue!=1)
            {
                Close();
            }
        }

        private void CloseNotLeavingButton_Click(object sender, EventArgs e)
        {
            CloseMessageBoxPannel.Visible = false;
        }

        private void CloseMessageBoxPannel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NotIntrestedButton_Click(object sender, EventArgs e)
        {
            PopupMessagebox.Visible = false;
        }
        void displaymovie()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select MovieTitle from MovieDetail";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int i = 0;
                for (; ; )
                {
                    string movie = dt.Rows[i]["MovieTitle"].ToString();
                    MovieDisplayCombox.Items.Add(movie);
                    i++;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();

            }

        }
        private void MessageBoxSure_Click(object sender, EventArgs e)
        {
            signUpWindow.Visible = true;
            SignUpButton.Visible = false;
            SignUpButton2.Visible = true;
            PopupMessagebox.Visible = false;
        }
        ///  /////////////////////////////////////////////////
        int time =0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            time++;
            if(time==1)
            {
                if(MyGlobal.Advback==1)
                {
                    settingForm.Visible = false;
                    MyGlobal.Advback = 0;
                }
                if(MyGlobal.Messageboxopenpassvalue==1)
                {
                    MyGlobal.start = 1;
                    messageForm.Visible = true;
                    MyGlobal.Messageboxopenpassvalue = 0;
                }
                if(MyGlobal.closemessagebox==1)
                {
                    messageForm.Visible = false;
                    MyGlobal.closemessagebox = 0;
                }
                if(MyGlobal.closebookticket==1)
                {
                    ticketBook.Visible = false;
                    MyGlobal.closebookticket = 0;
                }
                if(MyGlobal.displaymovie==1)
                {
                    displaymovie();
                    MyGlobal.displaymovie = 0;
                }
                if(MyGlobal.closedispaly==1)
                {
                    displaymovie1.Visible = false;
                    MyGlobal.closedispaly = 0;
                }
                if(MyGlobal.bookedticketmvoie==1)
                {
                    bookedTicketForm.Visible = false;
                    MyGlobal.bookedticketmvoie = 0;
                }
                time = 0;
            }
            

        }

        private void MessagePicture_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimixePicture_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void messageForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            displaymovie1.Visible = true;
            MyGlobal.movietitle = MovieDisplayCombox.Text;
            MyGlobal.refreshmovie = 1;

        }

        private void settingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
