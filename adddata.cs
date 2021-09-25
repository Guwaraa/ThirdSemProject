using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Theater_Ticketing_System
{
    public partial class adddata : UserControl
    {
        public adddata()
        {
            InitializeComponent();
        }
        int i = 0;
        int start = 0;
        int start1 = 50;
        int start2 = 120;
        int start3 = 65;
        int end = 50;
        int timecount = 0;
       

        
        public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";

        private void adddata_Load(object sender, EventArgs e)
        {
            coverphotopannel.Hide();
            coverphotopicturebox.Hide();
            Trailerview.Hide();
            coverphotopannel.Size = new Size(345, 286);
            Trailerview.Size = new Size(345, 286);
            functioncall();
            displaytextbox();

        }

        private void viewbutton_Click(object sender, EventArgs e)
        {

            coverphotopannel.Show();
            coverphotopicturebox.Show();
            coverphotopicturebox.ImageLocation = coverphotolinktextbox.Text;
            coverphotopicturebox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void coverphotoclosepannel_Click(object sender, EventArgs e)
        {
            coverphotopannel.Hide();
            coverphotopicturebox.Hide();
            Trailerview.Hide();
            Trailerview.Stop();
        }

        private void Trailerview_Click(object sender, EventArgs e)
        {
            coverphotopannel.Show();
            Trailerview.Show();
            string html = "<html><head>";
            html += html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='345' height='286' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.Trailerview.DocumentText = string.Format(html, trailerlinktextbox.Text.Split('=')[1]);
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            //try
            //{


                if (addedsucess == 0)
                {
                    stringjoin();
                }
                if (castadded == 0)
                {
                    castjoin();
                }
                String releasetxt = Release.Value.ToString("yyyy-MM-dd");
                int id = Convert.ToInt32(MovieID.Text);
            MessageBox.Show(MovieID.Text);
                
                con.Open();
                string query = "Insert into MovieDetail(MovieID,MovieGener,MovieTitle,Relese,Rating,Trailer,CoverPhoto,Director,Producer,Time,Cast,Overview)Values('" + id + "','" + MovieGener.Text + "','" + MovieTitle.Text + "','" + releasetxt + "','" + Rating.Text + "','" + trailerlinktextbox.Text + "','" + coverphotolinktextbox.Text + "','" + Director.Text + "','" + Producer.Text + "','" + word + "','" + CastName + "','" + Overview.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
            //}
            //catch
            //{

            //}
            //finally
            //{
                con.Close();
            //}
            MovieGener.Text = " ";
            MovieID.Text = " ";
            trailerlinktextbox.Text = " ";
            coverphotolinktextbox.Text = " ";
            Overview.Text = " ";
            Director.Text = " ";
            Producer.Text = " ";
        }


        int addedsucess=0;
        private void Timeadder_Click(object sender, EventArgs e)
        {
            if(addedsucess==1)
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
        ComboBox h;
        ComboBox hours(int i, int start, int end)
        {
            h = new ComboBox();
            h.Name = "ComboBox" + i.ToString();
            h.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            h.Size = new Size(50, 50);
            h.Location = new Point(start,end);
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
            m.Location = new Point(start,end);
            return m;
        }
        ComboBox ap;
        ComboBox ampm(int i,int start,int end)
        {
            ap = new ComboBox();
            ap.Name = "AMPM" + i.ToString();
            ap.Items.AddRange(new string[] { "AM", "PM" });
            ap.Size = new Size(40, 50);
            ap.Location = new Point(start,end);
            return ap;

        }
        void functioncall()
        {
            if (timecount != 5)
            {
                timecount++;
                Timelabel.Text = "added :" + timecount.ToString()+" / 5";
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
        string word=null;
        void stringjoin()
        {
          
                word = word+";"+ h.SelectedItem.ToString() + " : " + m.SelectedItem.ToString() + " " + ap.SelectedItem.ToString();
                
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
            catch(Exception ex)
            {
                Timelabel.Text = "null value";
            }

        }
        /// ///////////////////////////////////
        int j = 1;
        int endpoint = 30;
        int castcount = 0;
        TextBox T;
        TextBox castname(int i,int start,int end)
        {
            
             T = new TextBox();
            T.Name = "Textname"+i.ToString();
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
        private void donecast_Click(object sender, EventArgs e)
        {
            try
            {
                string text = T.Text;
                if (text.Length>0)
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
            catch(Exception ex)
            {

            }
        }
        string CastName = null;
        void castjoin()
        {
            CastName = CastName+";"+T.Text;
            
        }
    }
}
