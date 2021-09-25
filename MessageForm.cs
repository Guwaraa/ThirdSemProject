 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Theater_Ticketing_System
{
    public partial class MessageForm : UserControl
    {
        public MessageForm()
        {
            InitializeComponent();
        }
//.......................
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";
       //......................
        int startpostion =100;
        int endposition =130;
        //---------------------------------
        int beginingposition = 120;
        int lastposition = 185;
        //---------------------------------
        int bposition =900;
        //---------------------------------
        int buttonlast = 240;
        //---------------------------------
        int deletebutton = 900;
        //---------------------------------
        int circleButton = 30;

        int i =0;
        private void MessageForm_Load(object sender, EventArgs e)
        {
            MessageBoxButton.Visible = false;
            LeftClose.Visible = false;
            RightOpen.Visible = true;
            messboxForm.Visible = false;
            RefreshTimer.Start();
        }
       
        private void BackButton_Click_1(object sender, EventArgs e)
        {
            MyGlobal.closemessagebox = 1;
        }
        Label addsender(int i , string sender ,int start, int end)
        {
            
            Label l = new Label();
            l.Name = "Sender" + i.ToString();
            l.Text =sender;
            l.Location = new Point(start, end);
            l.ForeColor = Color.Black;
            l.Size = new Size(600,50);
            l.Font = new Font("Consolas", 18, FontStyle.Bold);
            l.BringToFront();
            return l;
        }
        Label addtopic(int i,string topic ,int start,int end)
        {
            Label l = new Label();
            l.Name = "Topic" + i.ToString();
            l.Text = topic;
            l.Location = new Point(start, end);
            l.ForeColor = Color.Black;
            l.Size = new Size(800,50);
            l.Font = new Font("Consolas", 16);
            l.BringToFront();
            return l;

        }
        Label addmessage(int i,string message,int start,int end)
        {
            Label m = new Label();
            m.Name = "message" + i.ToString();
            m.Text = message;
            m.Location = new Point(start, end+60);
            m.ForeColor = Color.RoyalBlue;
            m.Size = new Size(900, 300);
            m.Font = new Font("Consolas", 16);
            m.BringToFront();
            return m;
        }
        Label adddate(int i,string date,int start,int end)
        {
            Label l = new Label();
            l.Name = "Date" + i.ToString();
            l.Text = date;
            l.Location = new Point(start, end);
            l.ForeColor = Color.Black;
            l.Size = new Size(100, 50);
            l.Font = new Font("Consolas", 16,FontStyle.Underline);
            l.BringToFront();
            return l;
        }
        Button viewbutton(int i,int start,int end)
        {
            Button B = new Button();
            B.Name = "View" + i.ToString();
            B.Text = "View" + i.ToString();
            B.Font = new Font("Consolas", 17);
            B.Cursor = Cursors.Hand;
            B.Location = new Point(start, end);
            B.Size = new Size(170,50);
            B.FlatAppearance.BorderSize = 0;
            B.FlatStyle = FlatStyle.Popup;
            B.FlatAppearance.MouseOverBackColor = Color.Silver;
            B.FlatAppearance.MouseDownBackColor = Color.Gray;
            return B;
        }
        Button Replybutton(int i, int start, int end)
        {
            Button B = new Button();
            B.Name = "Reply" + i.ToString();
            B.Text = "Reply" + i.ToString();
            B.Font = new Font("Consolas", 17);
            B.Cursor = Cursors.Hand;
            B.Location = new Point(start, end);
            B.Size = new Size(170, 50);
            B.FlatAppearance.BorderSize = 0;
            B.FlatStyle = FlatStyle.Popup;
            B.FlatAppearance.MouseOverBackColor = Color.Silver;
            B.FlatAppearance.MouseDownBackColor = Color.Gray;
            return B;
        }
      
        GunaCircleButton UsernameButton(int i,int start,int end)
        {
            GunaCircleButton G = new GunaCircleButton();
            G.Name = "Username" + i.ToString();
            G.BackgroundImage = Image.FromFile(@"D:\Theater Ticketing System\Resources\images.png");
            G.Location = new Point(start, end);

            G.BackgroundImageLayout = ImageLayout.Stretch;
            G.Size = new Size(50,55);
            G.BaseColor = Color.Transparent;

            G.Enabled = false;
            return G;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButton.Visible = true;
            LeftClose.Visible = true;
            RightOpen.Visible = false;
           // MessageBox.Show(MyGlobal.start.ToString());
        }

        private void LeftClose_Click(object sender, EventArgs e)
        {
            MessageBoxButton.Visible = false;
            LeftClose.Visible = false;
            RightOpen.Visible = true;
            
            
        }
        int list;
        int checker = 0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
                if (MyGlobal.start == 1)
                {
                    countfuntion();
                if (list != checker)
                {
                    check();
                    checker = list;
                }  
                }
            if (MyGlobal.closeit == 1)
            {
                messboxForm.Visible = false;
                MyGlobal.closeit = 0;
            }
        }
        
        int countfuntion()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {

                con.Open();
                string query = "Select *from MessageDetail";
                SqlDataAdapter sda = new SqlDataAdapter(query, conString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int i = 0;
                for (; ; )
                {
                    string symbol = dt.Rows[i]["Number"].ToString();
                   list = Convert.ToInt32(symbol);
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
            return 0;
        }
        public void check()
        {
            
            int a = 0;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *from MessageDetail where Reciver='" + MyGlobal.DTUser + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                i = 0;
                for (; ; )
                {
                    //..........................................................
                    string sender = dt.Rows[i]["Sender"].ToString();
                    Label l = addsender(i, sender, startpostion, endposition);
                    this.Controls.Add(l);
                    //..........................................................
                    string topic = dt.Rows[i]["Title"].ToString();
                    Label M = addtopic(i, topic, beginingposition, lastposition);
                    this.Controls.Add(M);
                    //..........................................................
                    string message = dt.Rows[i]["Message"].ToString();
                    Label me = addmessage(i, message, beginingposition, lastposition);
                    this.Controls.Add(me);
                    //..........................................................
                    string date = dt.Rows[i]["DateTime"].ToString();
                    Label N = adddate(i, date,bposition, endposition);
                    this.Controls.Add(N);
                    //..........................................................
                    GunaCircleButton G = UsernameButton(i, circleButton, endposition);
                    this.Controls.Add(G);
                    //..........................................................
                    endposition += 200;
                    lastposition += 200;
                    buttonlast += 200;
                    i++;
                }

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                i = 0;
                con.Close();
                MyGlobal.start = 0;
               
            }
        }

        private void MessageBoxButton_Click(object sender, EventArgs e)
        {
            MyGlobal.dropmenu = 1;
            messboxForm.Visible = true; 
        }

        private void messboxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
