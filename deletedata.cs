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
    public partial class deletedata : UserControl
    {
        public deletedata()
        {
            InitializeComponent();
        }
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        private void deletedata_Load(object sender, EventArgs e)
        {
            displaymovie();
           
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

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MovieNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MovieDisplayCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CastButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from MovieDetail Where MovieTitle='" + MovieDisplayCombox.Text + "'";
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
       

  

        private void MovieDisplayCombox_SelectedValueChanged(object sender, EventArgs e)
        {
          display();
        }
        string photo;
        void display()
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *from MovieDetail where MovieTitle='" +MovieDisplayCombox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                photo = dt.Rows[0]["CoverPhoto"].ToString();
                MovieGener.Text = dt.Rows[0]["MovieGener"].ToString();
                ReleseDate.Text = dt.Rows[0]["Relese"].ToString();
                Director.Text = dt.Rows[0]["Director"].ToString();
                Rating.Text = dt.Rows[0]["Rating"].ToString();
                Producer.Text = dt.Rows[0]["Producer"].ToString();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                MoviePictureBox.ImageLocation = photo;
            }


        }
    }
}
