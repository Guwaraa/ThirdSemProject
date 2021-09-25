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
using System.IO;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing;

namespace Theater_Ticketing_System
{
    public partial class BookedTicket : UserControl
    {
        public BookedTicket()
        {
            InitializeComponent();
        }
      public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";
        private void BookedTicket_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();
            PrintTicket.Visible = false;
           
        }
        string movieTitle;
        string Time;
        string date;
        string seatno;
        string total;
        string coverphoto;
        int i = 0;
        int photostart=5;
        int photoend=5;
        int datestart =800;
        int dateend = 80;
        int movietitlestart = 400;
        int movietitleend = -20;
        int timestart = 270;
        int timeend = 80;
        int seatnostart = 270;
        int seatnoend = 130;
        int totalstart = 270;
        int totalend = 180;
       
        void display()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *From TicketBook Where Username='" + MyGlobal.DTUser + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (; ; )
                {
                    movieTitle = dt.Rows[i]["MovieTitle"].ToString();
                    Time = dt.Rows[i]["Time"].ToString();
                    date = dt.Rows[i]["Date"].ToString();
                    seatno = dt.Rows[i]["Seatno"].ToString();
                    total = dt.Rows[i]["Total"].ToString();
                    coverphoto = dt.Rows[i]["CoverPhoto"].ToString();
                    //////////////////////
                    PictureBox P = picdisplay(i, coverphoto,photostart,photoend);
                    FormPanel.Controls.Add(P);
                    //////////////////////
                    Label L = displaymovietitle(i, movieTitle,movietitlestart,movietitleend);
                    FormPanel.Controls.Add(L);
                    //////////////////////
                    Label T = displayTime(i, Time,timestart,timeend);
                    FormPanel.Controls.Add(T);
                    //////////////////////
                    Label D = displayDate(i,date,datestart,dateend);
                    FormPanel.Controls.Add(D);
                    //////////////////////
                    Label S = displaySeatno(i, seatno,seatnostart,seatnoend);
                    FormPanel.Controls.Add(S);
                    /////////////////////
                    Label To = displaytotal(i,total,totalstart,totalend);
                    FormPanel.Controls.Add(To);
                    ////////////////////////
                    i++;
                    photoend = photoend + 300;
                    dateend = dateend + 300;
                    movietitleend = movietitleend+300;
                    timeend = timeend+300;
                    seatnoend = seatnoend + 300;
                    totalend = totalend + 300;
                }
            }
            catch
            {

            }

        }
        PictureBox picdisplay(int i,string photo,int start,int end)
        {
            PictureBox P = new PictureBox();
            P.Name = "Picture" + i.ToString();
            P.ImageLocation = photo;
            P.Location = new Point(start, end);
            P.Size = new Size(250, 250);
            P.SizeMode = PictureBoxSizeMode.StretchImage;
            return P;
        }
        Label displaymovietitle(int i,string moviename,int start,int end)
        {
            Label L = new Label();
            L.Name = "Label" + i.ToString();
            L.Text = moviename;
            L.Location = new Point(start, end);
            L.ForeColor = Color.Black;
            L.Size = new Size(330, 100);
            L.Font = new Font("Consolas", 20, FontStyle.Bold);
            L.Cursor = Cursors.Hand;
            L.TextAlign = ContentAlignment.MiddleCenter;
            L.DoubleClick += L_DoubleClick; ;
            return L;
        }

        private void L_DoubleClick(object sender, EventArgs e)
        {
            Label text = (Label)sender;
            string title = text.Text;
            MessageBox.Show(title);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "Select *from TicketBook where MovieTitle='" +title+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string username = dt.Rows[0]["Username"].ToString();
            if(MyGlobal.DTUser==username)
            {
                PrintTicket.Visible = true;
                labelTitle.Text = dt.Rows[0]["MovieTitle"].ToString();
                labelTime.Text = dt.Rows[0]["Time"].ToString();
                labelSeatno.Text = dt.Rows[0]["Seatno"].ToString();
                LabelTotal.Text = dt.Rows[0]["Total"].ToString();
                CoverImage.ImageLocation= dt.Rows[0]["CoverPhoto"].ToString();
                Dateee.Text = dt.Rows[0]["Date"].ToString();
                UsernameLabel.Text = dt.Rows[0]["Username"].ToString();
                UsernameLabel.Visible = false;

            }

            con.Close();
        }

  

        Label displayTime(int i,string time,int start ,int end)
        {
            Label T = new Label();
            T.Name = "Time" + i.ToString();
            T.Text = "MovieTime  : "+time;
            T.Location = new Point(start, end);
            T.ForeColor = Color.Black;
            T.Size = new Size(400,20);
            T.Font = new Font("Consolas", 15, FontStyle.Regular);
            return T;

        }
        Label displayDate(int i,string date,int start,int end)
        {
            Label D = new Label();
            D.Name = "Date" + i.ToString();
            D.Location = new Point(start, end);
            D.Text = "Date  : "+date;
            D.ForeColor =Color.Black;
            D.Size = new Size(400,20);
            D.Font = new Font("Consolas", 15, FontStyle.Underline);
            return D;
        }
        Label displaySeatno(int i,string seat,int start,int end)
        {
            Label S = new Label();
            S.Name = "Seatno" + i.ToString();
            S.Location = new Point(start, end);
            S.Text ="Seatno     : "+seat;
            S.ForeColor = Color.Black;
            S.Size = new Size(400, 20);
            S.Font = new Font("Consolas", 15, FontStyle.Regular);
            return S;
        }
        Label displaytotal(int i,string total,int start,int end)
        {
            Label To = new Label();
            To.Name = "Total" + i.ToString();
            To.Location = new Point(start, end);
            To.Text ="Total    : "+total;
            To.ForeColor = Color.Black;
            To.Size = new Size(400, 20);
            To.Font = new Font("Consolas", 15, FontStyle.Regular);
            return To;
        }

       
        int  num =0;
        private void PrintButton_Click(object sender, EventArgs e)
        {
            UsernameLabel.Visible = true;
            PrintButton.Visible = false;
            num = num + 1;
            CaptureMyScreen(num);
                   
        }
        void CaptureMyScreen(int i)
        {
            try
            {
                var bmp = new Bitmap(PrintTicket.Width, PrintTicket.Height);
                PrintTicket.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Users\susha\Desktop\Ticket"+i + ".jpg", ImageFormat.Jpeg);
                PrintTicket.Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PrintButton.Visible = true;
        }
        int count = 0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            count++;
            if(count==1)
            {
                if(MyGlobal.refreshticketpannel==1)
                {
                    display();
                    MyGlobal.refreshticketpannel = 1;
                }
                count = 0;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MyGlobal.bookedticketmvoie = 1;
        }
    }
}
