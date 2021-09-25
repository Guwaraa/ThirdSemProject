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
    public partial class editdata : UserControl
    {
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        public editdata()
        {
            InitializeComponent();
        }

        private void editdata_Load(object sender, EventArgs e)
        {
            coverphotopannel.Hide();
            coverphotopicturebox.Hide();
            Trailerview.Hide();
            coverphotopannel.Size = new Size(345, 286);
            Trailerview.Size = new Size(345, 286);
            functioncall();
            displaytextbox();
            displaymovie();
            MovieID.Enabled = false;
            
            
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

        ComboBox h;
        int addedsucess = 0;
        ComboBox hours(int i, int start, int end)
        {
            h = new ComboBox();
            h.Name = "ComboBox" + i.ToString();
            h.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            h.Size = new Size(50, 50);
            h.Location = new Point(start, end);
            return h;
        }
        Label gap(int i, int start, int end)
        {
            Label L = new Label();
            L.Name = "Label" + i.ToString();
            L.Text = ":";
            L.Font = new Font("Arial", 15, FontStyle.Bold);
            L.Location = new Point(start, end);
            return L;
        }
        ComboBox m;
        ComboBox minute(int i, int start, int end)
        {
            m = new ComboBox();
            m.Name = "ComboBox" + i.ToString();
            m.Items.AddRange(new string[] { "00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            m.Size = new Size(50, 50);
            m.Location = new Point(start, end);
            return m;
        }
        ComboBox ap;
        ComboBox ampm(int i, int start, int end)
        {
            ap = new ComboBox();
            ap.Name = "AMPM" + i.ToString();
            ap.Items.AddRange(new string[] { "AM", "PM" });
            ap.Size = new Size(40, 50);
            ap.Location = new Point(start, end);
            return ap;

        }
        int i = 0;
        int start = 0;
        int start1 = 50;
        int start2 = 120;
        int start3 = 65;
        int end = 50;
        int timecount = 0;
        string word = null;

        private void TrailerviewButton_Click(object sender, EventArgs e)
        {
            coverphotopannel.Show();
            Trailerview.Show();
            string html = "<html><head>";
            html += html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='345' height='286' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.Trailerview.DocumentText = string.Format(html, trailerlinktextbox.Text.Split('=')[1]);
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            coverphotopannel.Show();
            coverphotopicturebox.Show();
            coverphotopicturebox.ImageLocation = coverphotolinktextbox.Text;
            coverphotopicturebox.BackgroundImageLayout = ImageLayout.Stretch;
        }

 
        int j = 1;
        int endpoint = 30;
        int castcount = 0;
        TextBox T;
        TextBox castname(int i, int start, int end)
        {

            T = new TextBox();
            T.Name = "Textname" + i.ToString();
            T.Location = new Point(start, end);
            T.Size = new Size(150, 100);
            T.Font = new Font("Consolas", 10, FontStyle.Bold);
            return T;
        }
        void displaytextbox()
        {
            if (castcount != 10)
            {
                castcount++;
                Castmaxlabel.Text = "added :" + castcount + " / 10";
                TextBox cast = castname(j, 0, endpoint);
                Castpannel.Controls.Add(cast);
                j++;
                endpoint = endpoint + 30;
            }
        }
        int castadded = 0;
        string CastName = null;
        void castjoin()
        {
            CastName = CastName + ";" + T.Text;

        }
        private void Addcast_Click(object sender, EventArgs e)
        {
            if (castadded == 1)
            {
                displaytextbox();
                castadded = 0;
            }
            else
            {
                Addcast.Visible = false;
                Castmaxlabel.Text = "press done to add";
            }
        }
        void functioncall()
        {
            if (timecount != 5)
            {
                timecount++;
                Timelabel.Text = "added :" + timecount.ToString() + " / 5";
                ComboBox hr = hours(i, start, end);
                Label L = gap(i, start1, end);
                ComboBox am = ampm(i, start2, end);
                ComboBox min = minute(i, start3, end);
                Timepannel.Controls.Add(min);
                Timepannel.Controls.Add(am);
                Timepannel.Controls.Add(hr);
                Timepannel.Controls.Add(L);
                end = end + 50;
                i++;
            }
        }

        private void donecast_Click(object sender, EventArgs e)
        {
            try
            {
                string text = T.Text;
                if (text.Length > 0)
                {
                    castjoin();
                    Castmaxlabel.Text = "added :" + castcount + " / 10";
                    Addcast.Visible = true;
                    castadded = 1;
                }
                else
                {
                    Castmaxlabel.Text = "Empty value";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Timedone_Click(object sender, EventArgs e)
        {
            try
            {

                if (h.SelectedItem.ToString() == null || m.SelectedItem.ToString() != null || ap.SelectedItem.ToString() != null)
                {
                    Timelabel.Text = "added :" + timecount.ToString() + "/5";
                    Timeadder.Visible = true;
                    addedsucess = 1;
                    stringjoin();
                }

            }
            catch (Exception ex)
            {
                Timelabel.Text = "null value";
            }

        }
        void stringjoin()
        {

            word = word + ";" + h.SelectedItem.ToString() + " : " + m.SelectedItem.ToString() + " " + ap.SelectedItem.ToString();

        }
        private void Timeadder_Click(object sender, EventArgs e)
        {
            if (addedsucess == 1)
            {
                functioncall();
                addedsucess = 0;
            }
            else
            {
                Timeadder.Visible = false;
                Timelabel.Text = "press done to add";
            }
        }

        private void coverphotoclosepannel_Click(object sender, EventArgs e)
        {
            coverphotopannel.Hide();
            coverphotopicturebox.Hide();
            Trailerview.Hide();
            Trailerview.Stop();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MovieDisplayCombox_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                string query = "Select *From MovieDetail Where Movietitle='" + MovieDisplayCombox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MovieGener.Text = dt.Rows[0]["MovieGener"].ToString();
                MovieID.Text = dt.Rows[0]["MovieID"].ToString();
                Director.Text = dt.Rows[0]["Director"].ToString();
                Producer.Text = dt.Rows[0]["Producer"].ToString();
                trailerlinktextbox.Text = dt.Rows[0]["Trailer"].ToString();
                coverphotolinktextbox.Text = dt.Rows[0]["CoverPhoto"].ToString();
                Overview.Text = dt.Rows[0]["Overview"].ToString();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                string relesedate = Release.Value.ToString("yyyy-MM-dd");
                con.Open();
                string query = "Update MovieDetail set MovieGener='" + MovieGener.Text + "' Where MovieID='" + MovieID.Text + "'";
                string query1 = "Update MovieDetail set Director='" + Director.Text + "' Where MovieID='" + MovieID.Text + "'";
                string query2 = "Update MovieDetail set Producer='" + Producer.Text + "' Where MovieID='" + MovieID.Text + "'";
                string query3 = "Update MovieDetail set Relese='" + relesedate + "' Where MovieID='" + MovieID.Text + "'";
                string query4 = "Update MovieDetail set Rating='" + Rating.Text + "' Where MovieID='" + MovieID.Text + "'";
                string query5 = "Update MovieDetail set Trailer='" + trailerlinktextbox.Text + "' Where MovieID='" + MovieID.Text + "'";
                string query6 = "Update MovieDetail set CoverPhoto='" + coverphotolinktextbox.Text + "' Where MovieID='" + MovieID.Text + "'";
                string query7 = "Update MovieDetail set Time='" + word + "' Where MovieID='" + MovieID.Text + "'";
                string query8 = "Update MovieDetail set Cast='" + CastName + "' Where MovieID='" + MovieID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                SqlDataAdapter sda5 = new SqlDataAdapter(query5, con);
                SqlDataAdapter sda6 = new SqlDataAdapter(query6, con);
                SqlDataAdapter sda7 = new SqlDataAdapter(query7, con);
                SqlDataAdapter sda8 = new SqlDataAdapter(query8, con);
                sda.SelectCommand.ExecuteNonQuery();
                sda1.SelectCommand.ExecuteNonQuery();
                sda2.SelectCommand.ExecuteNonQuery();
                sda3.SelectCommand.ExecuteNonQuery();
                sda4.SelectCommand.ExecuteNonQuery();
                sda5.SelectCommand.ExecuteNonQuery();
                sda6.SelectCommand.ExecuteNonQuery();
                sda7.SelectCommand.ExecuteNonQuery();
                sda8.SelectCommand.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            MovieGener.Text = " ";
            MovieID.Text = " ";
            trailerlinktextbox.Text = " ";
            coverphotolinktextbox.Text = " ";
            Overview.Text = " ";
            Director.Text = " ";
            Producer.Text = " ";

        }
    }
}
