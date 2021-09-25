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
    public partial class SignUpWindow : UserControl
    {
      
        public SignUpWindow()
        {

            InitializeComponent();
            
        }
       public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";


        private void SignUpWindow_Load(object sender, EventArgs e)
        {
            gunaPasswordTextBox2.Visible = false;
            CancelButton.Visible = false;
            ButtonRegister.Visible = false;
            gunaReEnter.Visible = false;
            gunaPasswordTextBox.UseSystemPasswordChar = true;
            gunaPasswordTextBox2.UseSystemPasswordChar = true;
            EyeCloseButton.Visible = false;
            gunaUserCheckbox.Checked = false;
            gunaUserCheckbox.Checked = false;
            gunaUsernameTextbox.Text = null;
            gunaPasswordTextBox.Text = null;
            gunaPasswordTextBox2.Text = null;
            ButtonRegister.Enabled = false;
            gunaErrorPicture.Visible = false;
            gunaErrorPicture2.Visible = false;




        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            gunaPasswordTextBox2.Visible = true;
            CancelButton.Visible = true;
            ButtonRegister.Visible = true;
            gunaReEnter.Visible = true;
            gunaUsernameTextbox.Text = null;
            gunaPasswordTextBox.Text = null;
            gunaAdminCheckBox.Visible = false;
            gunaUserCheckbox.Visible = false;
            gunaUserCheckbox.Checked = false;
            gunaUserCheckbox.Checked = false;
            gunaPasswordTextBox.LineColor = Color.Gainsboro;
            gunaPasswordTextBox2.LineColor = Color.Gainsboro;
            gunaUsernameTextbox.LineColor = Color.Gainsboro;
            gunaErrorPicture.Visible = false;
            gunaErrorPicture2.Visible = false;




        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            gunaPasswordTextBox2.Visible = false;
            CancelButton.Visible = false;
            ButtonRegister.Visible = false;
            gunaReEnter.Visible = false;
            gunaUsernameTextbox.Text = null;
            gunaPasswordTextBox.Text = null;
            gunaPasswordTextBox2.Text = null;
            gunaAdminCheckBox.Visible = true;
            gunaUserCheckbox.Visible = true;
            gunaUserCheckbox.Checked = false;
            gunaUserCheckbox.Checked = false;
            LogInButton.Enabled = true;
            gunaPasswordTextBox.LineColor = Color.Gainsboro;
            gunaPasswordTextBox2.LineColor = Color.Gainsboro;
            gunaUsernameTextbox.LineColor = Color.Gainsboro;

        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            gunaPasswordTextBox.UseSystemPasswordChar = false;
            gunaPasswordTextBox2.UseSystemPasswordChar = false;
            EyeCloseButton.Visible = true;
            EyeButton.Visible = false;
        }

        private void EyeCloseButton_Click(object sender, EventArgs e)
        {
            gunaPasswordTextBox.UseSystemPasswordChar = true;
            gunaPasswordTextBox2.UseSystemPasswordChar = true;
            EyeCloseButton.Visible = false;
            EyeButton.Visible = true;

        }

        private void gunaPasswordBox2_TextChanged(object sender, EventArgs e)
        {
           
                if (gunaPasswordTextBox.Text == gunaPasswordTextBox2.Text)
                {
                    gunaPasswordTextBox2.ForeColor = Color.Green;
                    gunaPasswordTextBox.ForeColor = Color.Green;
                    ButtonRegister.Enabled = true;
                    LogInButton.Enabled = false;
                }
                else
                {
                gunaPasswordTextBox.ForeColor = Color.Red;
                gunaPasswordTextBox2.ForeColor = Color.Red;
                    ButtonRegister.Enabled = false;
                    LogInButton.Enabled = false;

                }
            
        }

        private void gunaUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            gunaPasswordTextBox.Text = null;
            gunaPasswordTextBox2.Text = null;
            ButtonRegister.Enabled = false;
            gunaUsernameTextbox.LineColor = Color.RoyalBlue;
            gunaErrorPicture.Visible = false;
            gunaErrorPicture2.Visible = false;



        }

        private void gunaUsernameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void gunaPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        int check = 0;

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(gunaUsernameTextbox.Text))
            {
                gunaPasswordTextBox.Text = "";
                gunaUsernameTextbox.Text = "";
                gunaPasswordTextBox2.Text = "";
                gunaUsernameTextbox.LineColor = Color.Red;
                gunaPasswordTextBox.LineColor = Color.Red;
                gunaPasswordTextBox2.LineColor = Color.Red;
                gunaErrorPicture.Visible = true;
                gunaErrorPicture2.Visible = true;
            }
            else
            {
                check=checkusername();
                if (check == 1)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(conString);
                        con.Open();
                        string user = gunaUsernameTextbox.Text;
                        string pass = gunaPasswordTextBox2.Text;
                        int active = 0;
                        int LogUser = 1;
                        int Admin = 0;
                        string q = "Insert into UserData(Username,Password,ActiveStatus,Admin,LogUser)values('" + user + "','" + pass + "','" + active + "','" + Admin + "','" + LogUser + "')";
                        SqlDataAdapter SDA = new SqlDataAdapter(q, con);
                        SDA.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        gunaUsernameTextbox.Text = "";
                        gunaPasswordTextBox.Text = "";
                        gunaPasswordTextBox2.Text = "";
                        /////////////////////////////////////////////CANCEL//////////////////////////////////////////////////////////
                        gunaPasswordTextBox2.Visible = false;
                        CancelButton.Visible = false;
                        ButtonRegister.Visible = false;
                        gunaReEnter.Visible = false;
                        gunaUsernameTextbox.Text = null;
                        gunaPasswordTextBox.Text = null;
                        gunaPasswordTextBox2.Text = null;
                        gunaAdminCheckBox.Visible = true;
                        gunaUserCheckbox.Visible = true;
                        gunaUserCheckbox.Checked = false;
                        gunaUserCheckbox.Checked = false;
                        LogInButton.Enabled = true;
                        gunaPasswordTextBox.LineColor = Color.Gainsboro;
                        gunaPasswordTextBox2.LineColor = Color.Gainsboro;
                        gunaUsernameTextbox.LineColor = Color.Gainsboro;
                    }
                    catch (Exception ex)
                    {
                        gunaPasswordTextBox.Text = "";
                        gunaUsernameTextbox.Text = "";
                        gunaPasswordTextBox2.Text = "";
                        gunaUsernameTextbox.LineColor = Color.Red;
                        gunaPasswordTextBox.LineColor = Color.Red;
                        gunaPasswordTextBox2.LineColor = Color.Red;
                        gunaErrorPicture.Visible = true;
                        gunaErrorPicture2.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Username is already being used .. Try another one !!");

                }
            }

        }
        int temp;
        public int checkusername()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {            
                con.Open();
                string query = "Select *From UserData where Username ='" + gunaUsernameTextbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string DTUser = dt.Rows[0]["Username"].ToString();
            }
            catch (Exception ex)
            {
                temp = 1;

            }
            finally
            { 
                con.Close();
            }
            return temp;
        }
        int admin;
        int user;
        private void LogInButton_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(conString);
            try
            {
                if (gunaAdminCheckBox.Checked)
                {
                    admin = 1;
                    MyGlobal.DTAdmin = 1;

                }
                if(gunaUserCheckbox.Checked)
                {
                    user = 1;
                    MyGlobal.DTuser = 1;
                }
                con.Open();
                string query = "Select *From UserData where Username ='" + gunaUsernameTextbox.Text + "'and Password='" + gunaPasswordTextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MyGlobal.DTUser = dt.Rows[0]["Username"].ToString();                
                MyGlobal.DTPassword = dt.Rows[0]["Password"].ToString();
                string DTAdmin = dt.Rows[0]["Admin"].ToString();
                string DTUser = dt.Rows[0]["LogUser"].ToString();
                MyGlobal.DTCuser = MyGlobal.DTUser.Substring(0,2);
                if (admin.ToString() == DTAdmin && MyGlobal.DTUser== gunaUsernameTextbox.Text && MyGlobal.DTPassword== gunaPasswordTextBox.Text)
                { 
                    gunaAdminCheckBox.Checked = false;
                    admin = 0;
                    upadatedata();
                    
                }
                else
                {
                    gunaPasswordTextBox.Text = "";
                    gunaUsernameTextbox.Text = "";
                    gunaUsernameTextbox.LineColor = Color.Red;
                    gunaPasswordTextBox.LineColor = Color.Red;
                    gunaErrorPicture.Visible = true;
                    gunaErrorPicture2.Visible = true;
                }
                if (user.ToString() == DTUser && MyGlobal.DTUser == gunaUsernameTextbox.Text && MyGlobal.DTPassword == gunaPasswordTextBox.Text)
                {
                    gunaUserCheckbox.Checked = false;
                    user = 0;
                    upadatedata();
                    
                
                }
                else
                {
                    gunaPasswordTextBox.Text = "";
                    gunaUsernameTextbox.Text = "";
                    gunaUsernameTextbox.LineColor = Color.Red;
                    gunaPasswordTextBox.LineColor = Color.Red;
                    gunaErrorPicture.Visible = true;
                    gunaErrorPicture2.Visible = true;
                }
                gunaUsernameTextbox.Text = "";
                gunaPasswordTextBox.Text = "";
            }
            catch(Exception ex)
            {
                gunaPasswordTextBox.Text = "";
                gunaUsernameTextbox.Text = "";
                gunaUsernameTextbox.LineColor = Color.Red;
                gunaPasswordTextBox.LineColor = Color.Red;
                gunaErrorPicture.Visible = true;
                gunaErrorPicture2.Visible = true;
            }
            finally
            {
                con.Close();
            }
        }
        public void upadatedata()
        {
            int active = 1;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="Update UserData set ActiveStatus='"+active+"'where Username='"+gunaUsernameTextbox.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MyGlobal.RegisterPassingValue = 1;
            MyGlobal.LoginPassingValue = 1;

        }

        private void gunaUserCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaAdminCheckBox.Checked)
            {
                gunaAdminCheckBox.Checked = false;
               
            }
        }

        private void gunaAdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaUserCheckbox.Checked)
            {
                gunaUserCheckbox.Checked = false;
                
            }
            

        }

        private void gunaPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
           
            gunaPasswordTextBox.LineColor = Color.RoyalBlue;
            gunaPasswordTextBox.ForeColor = Color.Black;
            gunaPasswordTextBox2.Text = null;


        }

        private void gunaErrorPicture2_Click(object sender, EventArgs e)
        {

        }
    }
}
