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
    public partial class Passwordmodify : UserControl
    {
        public Passwordmodify()
        {
            InitializeComponent();
        }
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        private void Passwordmodify_Load(object sender, EventArgs e)
        {
            gunaPasswordTextBox2.Visible = false;
            gunaErrorPicture.Visible = false;
            EyeCloseButton.Visible = false;
            RefreshTimer.Start();
            gunaPasswordTextBox.UseSystemPasswordChar = true;
            gunaPasswordTextBox2.UseSystemPasswordChar = true;
            ContinueButton.Enabled = false;
            ContinueButton2.Visible = false;
            Textlabel.Text="Verify your password.!!";


        }
        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
        int counter = 0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter==1)
            {
                Usernamedisplaypanel.Text = MyGlobal.DTUser+"!!";
                counter = 0;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MyGlobal.closevalue = 1;
            gunaPasswordTextBox.Text = "";
            gunaPasswordTextBox2.Visible = false;
            ContinueButton2.Visible = false;
            ContinueButton.Visible = true;
            Textlabel.Text = "Verify your password.!!";
            MyGlobal.newsclose = 1;

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {

            if (gunaPasswordTextBox.Text == MyGlobal.DTPassword)
            {
                ContinueButton.Enabled = false;
                gunaPasswordTextBox2.Visible = true;
                gunaPasswordTextBox.Text = "";
                ContinueButton.Visible = false;
                Textlabel.Text = "Enter the new password";
                ContinueButton2.Visible = true;
                ContinueButton2.Enabled = false;
            }
            else
            {
                ContinueButton.Enabled = false;
                gunaPasswordTextBox.Text = "";
                gunaErrorPicture.Visible = true;
                gunaPasswordTextBox.LineColor = Color.Red;
            }
        }

        private void EyeCloseButton_Click(object sender, EventArgs e)
        {
            gunaPasswordTextBox.UseSystemPasswordChar = true;
            gunaPasswordTextBox2.UseSystemPasswordChar = true;
            EyeCloseButton.Visible = false;
            EyeButton.Visible = true;
        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            gunaPasswordTextBox.UseSystemPasswordChar = false;
            gunaPasswordTextBox2.UseSystemPasswordChar = false;
            EyeCloseButton.Visible = true;
            EyeButton.Visible = false;
        }
        

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            gunaErrorPicture.Visible = false;
            gunaPasswordTextBox.LineColor = Color.RoyalBlue;
            gunaPasswordTextBox.LineColor = Color.RoyalBlue;
            gunaPasswordTextBox.ForeColor = Color.Black;
            gunaPasswordTextBox2.Text = null;
            if (String.IsNullOrEmpty(gunaPasswordTextBox.Text))
            {
                ContinueButton.Enabled = true;
            }
            else
            {
                ContinueButton.Enabled = true;
            }

        }

        private void gunaPasswordTextBox2_TextChanged(object sender, EventArgs e)
        {
            Textlabel.Text = "Re-Enter password";
            if (gunaPasswordTextBox.Text == gunaPasswordTextBox2.Text)
            {
                gunaPasswordTextBox2.ForeColor = Color.Green;
                gunaPasswordTextBox.ForeColor = Color.Green;
                ContinueButton2.Enabled = true;
                



            }
            else
            {
                gunaPasswordTextBox.ForeColor = Color.Red;
                gunaPasswordTextBox2.ForeColor = Color.Red;
                ContinueButton2.Enabled = false;              
            }
        }
        private void ContinueButton2_Click(object sender, EventArgs e)
        { 
            if (String.IsNullOrEmpty(gunaPasswordTextBox.Text)) 
            {
                gunaPasswordTextBox.LineColor = Color.Red;
                gunaPasswordTextBox2.LineColor = Color.Red;
                ContinueButton2.Enabled = false;
            }
            else
            {
                if (String.IsNullOrEmpty(gunaPasswordTextBox2.Text))
                {
                    gunaPasswordTextBox.LineColor = Color.Red;
                    gunaPasswordTextBox2.LineColor = Color.Red;
                    ContinueButton2.Enabled = false;
                }
                else
                {
                    Textlabel.Text = "Sucessfully changed";
                    int active = 0;
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update UserData set ActiveStatus='" + active + "'where Username='" + MyGlobal.DTUser + "'";
                    cmd.CommandText = "Update UserData set Password='" + gunaPasswordTextBox2.Text + "'where Username='" + MyGlobal.DTUser + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    gunaPasswordTextBox.Text = "";
                    gunaPasswordTextBox2.Text = "";
                    MyGlobal.LoginPassingValue = 0;
                    MyGlobal.Advback = 1;
                    MyGlobal.Advbackvalue = 1;
                    MyGlobal.closevalue = 1;
                    gunaPasswordTextBox.Text = "";
                    gunaPasswordTextBox2.Visible = false;
                    ContinueButton2.Visible = false;
                    ContinueButton.Visible = true;
                    Textlabel.Text = "Verify your password.!!";

                }
            }
        }
    }
}
