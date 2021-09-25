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
    public partial class Displaymovie : UserControl
    {
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        public Displaymovie()
        {
            InitializeComponent();
        }
       
        int counter = 0;
        int count = 0;
        int trailer;
        string photo;
        string trailerlinktextbox;

        private void Displaymovie_Load(object sender, EventArgs e)
        {
          
            
        }
       

        private void BookNow_Click(object sender, EventArgs e)
        {
            if (MyGlobal.LoginPassingValue != 1)
            {
                PopupMessagebox.Visible = true;
                PopupMessagebox.Location = new Point(360, 300);
                PopupMessageBoxPanel.Text = "LOG&IN your account to access.....!!!";
            }
            else
            {
                ticketBook.BringToFront();
                ticketBook.Visible = true;
                MyGlobal.ticketbookrefresh = 1;
                MyGlobal.backupticketbookrefresh = 1;
                MyGlobal.coverphoto = photo;
            }
        }

        private void MovieGener_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cast_Click(object sender, EventArgs e)
        {

        }

        private void level_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
         
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
            RefreshTimer.Start();
            ticketBook.Visible = false;
            PopupMessagebox.Visible = false;


        }

        private void CastButton_Click(object sender, EventArgs e)
        {
            count = 1;
            DownCastButton.Visible = true;
            CastButton.Visible = false;
            Castpanel.Show();
            Castpanel.BringToFront();
            castdisplay();


        }
        string cast;
        void castdisplay() 
        {
            int start=0;
            int end=0;
            int i;
            Label C;
            for (i=1;i<=castname.Length;i++)
            {
                try
                {
                    if (castname.Substring(i, 1) == ";")
                    {
                        C = addcast(i, cast, start, end);
                        Castpanel.Controls.Add(C);
                        cast = null;
                        end = end + 45;
                    }
                    else
                    {
                        cast = cast + castname.Substring(i, 1);
                    }
                }
                catch(Exception ex)
                {

                }
            }
            
            C = addcast(i, cast, start, end);
            Castpanel.Controls.Add(C);
            cast = null;
        }
        Label addcast(int i, string namecast,int start,int end)
        {
            Label C = new Label();
            C.Name = "Label" + i.ToString();
            C.Text = namecast;
            C.Location = new Point(start, end);
            C.Font = new Font("Consolos", 14,FontStyle.Bold);
            C.Size = new Size(350,50);

            return C;
        }


        private void DownCastButton_Click(object sender, EventArgs e)
        {
            count = 0;
            CastButton.Visible = true;
            DownCastButton.Visible = false;
            Castpanel.Hide();
          
        }
  
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter==1)
            {
                if (count == 0)
                {
                    Castpanel.Hide();

                }
                if(MyGlobal.opentrailer==1)
                {
                    display();
                    MyGlobal.opentrailer = 0;
                }
                if(MyGlobal.closebookticket==1)
                {
                    ticketBook.Visible = false;
                    MyGlobal.closebookticket = 0;
                }
                if(MyGlobal.refreshmovie==1)
                {
                    display();
                    MyGlobal.refreshmovie = 0;
                }
            }
            counter = 0;
           
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MyGlobal.closedispaly = 1;
            MyGlobal.opentrailer = 0;
            photo = null;
            trailerlinktextbox = null;
            TrailerView.Stop();
        }
        string castname=null;
        void display()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *from MovieDetail where MovieTitle='" + MyGlobal.movietitle + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                photo = dt.Rows[0]["CoverPhoto"].ToString();
                trailerlinktextbox = "https://www.youtube.com/watch?v=nX2fcXN_Yks";
                MovieGener.Text = dt.Rows[0]["MovieGener"].ToString();
                ReleseDate.Text = dt.Rows[0]["Relese"].ToString();
                Director.Text = dt.Rows[0]["Director"].ToString();
                Rating.Text = dt.Rows[0]["Rating"].ToString();
                Producer.Text = dt.Rows[0]["Producer"].ToString();
                castname = dt.Rows[0]["Cast"].ToString();
                Desciption.Text = dt.Rows[0]["Overview"].ToString();
                  pictureBox.ImageLocation = photo;
                string html = "<html><head>";
                html += html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='720' height='337' frameborder='0' allowfullscreen></iframe>";
                html += "</body></html>";
                this.TrailerView.DocumentText = string.Format(html, trailerlinktextbox.Split('=')[1]);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
              
            }
        }
        private void Language_Click(object sender, EventArgs e)
        {

        }
        private void MessageBoxSure_Click(object sender, EventArgs e)
        {
            MyGlobal.closedispaly = 1;
            MyGlobal.opentrailer = 0;
            PopupMessagebox.Visible = false;
            photo = null;
            trailerlinktextbox = null;
            TrailerView.Stop();
        }

        private void NotIntrestedButton_Click(object sender, EventArgs e)
        {
            PopupMessagebox.Visible = false;
        }
    }
}
