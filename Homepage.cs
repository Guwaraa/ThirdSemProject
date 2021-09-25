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
    public partial class Homepage : UserControl
    {
        public Homepage()
        {
            InitializeComponent();
        }
       public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";
        int i = 0;
        int start=-362;
        int end=-440;

        int flag=0;
        private void Homepage_Load(object sender, EventArgs e)
        {
            displaymovie();
            MovieDisplay.Visible = false;
            RefreshTimer.Start();
        }
        void displaymovie()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *from MovieDetail";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int z = 0;
                for (; ; )
                {
                    if (flag == 3 || flag == 0)
                    {
                        end = end + 445;
                        start = -362;
                        flag = 0;
                    }
                    i = i + 1;
                    start = start + 367;
                    string coverphoto = dt.Rows[z]["CoverPhoto"].ToString();
                    PictureBox P = imagebox(i, start, end, coverphoto);
                    panel1.Controls.Add(P);
                    string text = dt.Rows[z]["MovieTitle"].ToString();
                    Label L = imagelablel(i, start, end + 340,text);
                    panel1.Controls.Add(L);
                    L.DoubleClick += new System.EventHandler(this.LabelDoubleClick);
                    flag++;
                    z++;
                }
            }
            catch(Exception e)
            {
             
            }
            finally
            {
                
                con.Close();
            }

        }
        void LabelDoubleClick(object sender,EventArgs e)
        {
            Label currentbox = (Label)sender;
            MyGlobal.movietitle = currentbox.Text;
            MovieDisplay.Visible = true;
            panel1.AutoScroll = false;
            MyGlobal.opentrailer = 1;
        }
        PictureBox imagebox(int i,int start,int end,string coverphoto)
        {
            PictureBox P = new PictureBox();
            P.Name = "PictureBox" + i.ToString();
            P.Location = new Point(start, end);
            P.Size = new Size(350, 350);
            P.BackColor = Color.Black;
            P.ImageLocation=coverphoto;
            P.SizeMode = PictureBoxSizeMode.StretchImage;
            return P;
        }
        

    

        Label imagelablel(int i,int start,int end,string text)
        {
            Label L = new Label();
            L.Name = "Label" + i.ToString();
            L.Location = new Point(start, end);
            L.Text = text;
            L.ForeColor = Color.Black;
            L.Size=new Size(330, 100);
            L.Font = new Font("Consolas", 20, FontStyle.Bold);
            L.Cursor = Cursors.Hand;
            L.TextAlign = ContentAlignment.MiddleCenter;
            return L;
        }

        int counter = 0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter==1)
            {
              if(MyGlobal.closedispaly==1)
                {
                    MovieDisplay.Visible = false;
                    panel1.AutoScroll = true;
                    MyGlobal.closedispaly = 0;
                }
                
                counter = 0;
            }
                   
        }

     
    }
}
