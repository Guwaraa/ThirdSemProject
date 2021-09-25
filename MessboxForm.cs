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
    public partial class MessboxForm : UserControl
    {
        public MessboxForm()
        {
            InitializeComponent();
        }
       public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        int counter = 0;
        private void MessboxForm_Load(object sender, EventArgs e)
        {
            
            RefreshTimer.Start();
            
        }
        private void Close_Click(object sender, EventArgs e)
        {
            MyGlobal.closeit = 1;
        }

        private void ReciverComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "Select *from UserData where Username='" + ReciverComboBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string admin = dt.Rows[0]["Admin"].ToString();
            int check = Convert.ToInt32(admin);
            if (check == 1)
            {
                AdminorUserLabel.Text = "Admin";
            }
            else
            {
                AdminorUserLabel.Text = "User";
            }
            con.Close();
        }
        int datasymbol=0;
        private void SendButton_Click_1(object sender, EventArgs e)
        {
            /////////////////////////////////Numberinsertion
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
                    datasymbol = Convert.ToInt32(symbol);
                    i++;
                }
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
            ////////////////////////
            try
            {
                con.Open();
                datasymbol++;
                string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                string query = "Insert into MessageDetail(Number,Sender,Reciver,Title,Message,DateTime)Values('"+ datasymbol +"','" + MyGlobal.DTUser + "','" + ReciverComboBox.Text + "','" + TopicTextBox.Text + "','" + MessageTextBox.Text + "','"+date+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                TopicTextBox.Text=" ";
                ReciverComboBox.Text = " ";
                MessageTextBox.Text = " ";


            }
            finally
            {
                TopicTextBox.Text = " ";
                ReciverComboBox.Text = " ";
                MessageTextBox.Text = " ";
                con.Close();
            }



        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                if (MyGlobal.dropmenu == 1)
                {
                    DropDown();
                    MyGlobal.dropmenu = 0;
                }
                counter = 0;
            }


        }
        public void DropDown()
        {
            AdminorUserLabel.Text = null;
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select Username from UserData ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int i = 0;
                for (; ; )
                {
                  

                    string User = dt.Rows[i]["Username"].ToString();
                    if (MyGlobal.DTUser == User)
                    {
                        //comment;
                    }
                    else
                    {
                        ReciverComboBox.Items.Add(User);
                    }
                    i++;

                }
            }
            catch(Exception ex)
            {
               
            }
            finally
            {
                con.Close();
            }
         
        }
    }
}
