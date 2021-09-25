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
    public partial class TicketBook : UserControl
    {
        public TicketBook()
        {
            InitializeComponent();
        }
       public string conString="Data Source=DESKTOP-SNP7JH6\\SQLEXPRESS;Initial Catalog=UserDetail;Integrated Security=True";
        int ATOB = 300;
        int CTOE = 350;
        int FTOH = 400;
        int seecommand = 0;
        private void TicketBook_Load(object sender, EventArgs e)
        {
            RefreshTimer.Start();
            ExtraTimer.Start();
            listBox1.Visible = false;
            listBox2.Visible = false;
            displaymovie();
            BlockA.Size = new Size(100, 40);
            BlockB.Size = new Size(100, 40);
            BlockB.Location = new Point(300, 287);
            BlockC.Size = new Size(100, 40);
            BlockC.Location = new Point(425, 287);
            PasswordTextBox.Size = new Size(250, 40);
            PasswordTextBox.UseSystemPasswordChar = true;
            EyeButton.Location = new Point(415, 355);



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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
        private void A1_Click(object sender, EventArgs e)
        {
         
           if(listBox1.Items.Contains("A1"))
            {
              
                listBox1.Items.Remove("A1");
                A1.BackColor = Color.Transparent;
                A1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
           else
            {
                listBox1.Items.Add("A1");
                A1.BackColor = Color.Lime;
                A1.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
         
            stringjoin();

        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A2"))
            {

                listBox1.Items.Remove("A2");
                A2.BackColor = Color.Transparent;
                A2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {
                listBox1.Items.Add("A2");
                A2.BackColor = Color.Lime;
                A2.FlatAppearance.MouseOverBackColor = Color.Lime;
//
              
            }
          
            stringjoin();

        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A3"))
            {

                listBox1.Items.Remove("A3");
                A3.BackColor = Color.Transparent;
                A3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A3");
                A3.BackColor = Color.Lime;
                A3.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
            stringjoin();

        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A4"))
            {

                listBox1.Items.Remove("A4");
                A4.BackColor = Color.Transparent;
                A4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A4");
                A4.BackColor = Color.Lime;
                A4.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }
        private void A5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A5"))
            {

                listBox1.Items.Remove("A5");
                A5.BackColor = Color.Transparent;
                A5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A5");
                A5.BackColor = Color.Lime;
                A5.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
           
            stringjoin();

        }
        private void A6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A6"))
            {

                listBox1.Items.Remove("A6");
                A6.BackColor = Color.Transparent;
                A6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A6");
                A6.BackColor = Color.Lime;
                A6.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
            
            stringjoin();

        }
        private void A7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A7"))
            {

                listBox1.Items.Remove("A7");
                A7.BackColor = Color.Transparent;
                A7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A7");
                A7.BackColor = Color.Lime;
                A7.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
         
            stringjoin();

        }
        private void A8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A8"))
            {

                listBox1.Items.Remove("A8");
                A8.BackColor = Color.Transparent;
                A8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A8");
                A8.BackColor = Color.Lime;
                A8.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }
        private void A9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A9"))
            {

                listBox1.Items.Remove("A9");
                A9.BackColor = Color.Transparent;
                A9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A9");
                A9.BackColor = Color.Lime;
                A9.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }
        private void A10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A10"))
            {

                listBox1.Items.Remove("A10");
                A10.BackColor = Color.Transparent;
                A10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("A10");
                A10.BackColor = Color.Lime;
                A10.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
        
            stringjoin();

        }
        private void B1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B1"))
            {

                listBox1.Items.Remove("B1");
                B1.BackColor = Color.Transparent;
                B1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B1");
                B1.BackColor = Color.Lime;
                B1.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
        
            stringjoin();

        }
        private void B2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B2"))
            {

                listBox1.Items.Remove("B2");
                B2.BackColor = Color.Transparent;
                B2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B2");
                B2.BackColor = Color.Lime;
                B2.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
        
            stringjoin();


        }
        private void B3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B3"))
            {

                listBox1.Items.Remove("B3");
                B3.BackColor = Color.Transparent;
                B3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B3");
                B3.BackColor = Color.Lime;
                B3.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }
        private void B4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B4"))
            {

                listBox1.Items.Remove("B4");
                B4.BackColor = Color.Transparent;
                B4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B4");
                B4.BackColor = Color.Lime;
                B4.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
         
            stringjoin();

        }
        private void B5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B5"))
            {

                listBox1.Items.Remove("B5");
                B5.BackColor = Color.Transparent;
                B5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B5");
                B5.BackColor = Color.Lime;
                B5.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
        
            stringjoin();

        }
        private void B6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B6"))
            {

                listBox1.Items.Remove("B6");
                B6.BackColor = Color.Transparent;
                B6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B6");
                B6.BackColor = Color.Lime;
                B6.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
           
            stringjoin();

        }
        private void B7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B7"))
            {

                listBox1.Items.Remove("B7");
                B7.BackColor = Color.Transparent;
                B7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B7");
                B7.BackColor = Color.Lime;
                B7.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }
        private void B8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B8"))
            {

                listBox1.Items.Remove("B8");
                B8.BackColor = Color.Transparent;
                B8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B8");
                B8.BackColor = Color.Lime;
                B8.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B9"))
            {

                listBox1.Items.Remove("B9");
                B9.BackColor = Color.Transparent;
                B9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B9");
                B9.BackColor = Color.Lime;
                B9.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B10"))
            {

                listBox1.Items.Remove("B10");
                B10.BackColor = Color.Transparent;
                B10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("B10");
                B10.BackColor = Color.Lime;
                B10.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
           
            stringjoin();

        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C1"))
            {

                listBox1.Items.Remove("C1");
                C1.BackColor = Color.Transparent;
                C1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C1");
                C1.BackColor = Color.Lime;
                C1.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C2"))
            {

                listBox1.Items.Remove("C2");
                C2.BackColor = Color.Transparent;
                C2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C2");
                C2.BackColor = Color.Lime;
                C2.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C3"))
            {

                listBox1.Items.Remove("C3");
                C3.BackColor = Color.Transparent;
                C3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C3");
                C3.BackColor = Color.Lime;
                C3.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
           
            stringjoin();

        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C4"))
            {

                listBox1.Items.Remove("C4");
                C4.BackColor = Color.Transparent;
                C4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C4");
                C4.BackColor = Color.Lime;
                C4.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
           
            stringjoin();

        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C5"))
            {

                listBox1.Items.Remove("C5");
                C5.BackColor = Color.Transparent;
                C5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C5");
                C5.BackColor = Color.Lime;
                C5.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
         
            stringjoin();

        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C6"))
            {

                listBox1.Items.Remove("C6");
                C6.BackColor = Color.Transparent;
                C6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C6");
                C6.BackColor = Color.Lime;
                C6.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C7"))
            {

                listBox1.Items.Remove("C7");
                C7.BackColor = Color.Transparent;
                C7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C7");
                C7.BackColor = Color.Lime;
                C7.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
          
            stringjoin();

        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C8"))
            {

                listBox1.Items.Remove("C8");
                C8.BackColor = Color.Transparent;
                C8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C8");
                C8.BackColor = Color.Lime;
                C8.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
           
            stringjoin();

        }

        private void C9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C9"))
            {

                listBox1.Items.Remove("C9");
                C9.BackColor = Color.Transparent;
                C9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C9");
                C9.BackColor = Color.Lime;
                C9.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }
         
            stringjoin();

        }

        private void C10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C10"))
            {

                listBox1.Items.Remove("C10");
                C10.BackColor = Color.Transparent;
                C10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("C10");
                C10.BackColor = Color.Lime;
                C10.FlatAppearance.MouseOverBackColor = Color.Lime;
//
            }

            stringjoin();

        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D1"))
            {
                listBox1.Items.Remove("D1");
                D1.BackColor = Color.Transparent;
                D1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {
                listBox1.Items.Add("D1");
                D1.BackColor = Color.Lime;
                D1.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
   
            stringjoin();
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D2"))
            {

                listBox1.Items.Remove("D2");
                D2.BackColor = Color.Transparent;
                D2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D2");
                D2.BackColor = Color.Lime;
                D2.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
      
            stringjoin();
        }

        private void D3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D3"))
            {

                listBox1.Items.Remove("D3");
                D3.BackColor = Color.Transparent;
                D3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D3");
                D3.BackColor = Color.Lime;
                D3.FlatAppearance.MouseOverBackColor = Color.Lime;
            }

            stringjoin();
        }

        private void D4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D4"))
            {

                listBox1.Items.Remove("D4");
                D4.BackColor = Color.Transparent;
                D4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D4");
                D4.BackColor = Color.Lime;
                D4.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void D5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D5"))
            {

                listBox1.Items.Remove("D5");
                D5.BackColor = Color.Transparent;
                D5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D5");
                D5.BackColor = Color.Lime;
                D5.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
       
            stringjoin();
        }

        private void D6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D6"))
            {

                listBox1.Items.Remove("D6");
                D6.BackColor = Color.Transparent;
                D6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D6");
                D6.BackColor = Color.Lime;
                D6.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void D7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D7"))
            {

                listBox1.Items.Remove("D7");
                D7.BackColor = Color.Transparent;
                D7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D7");
                D7.BackColor = Color.Lime;
                D7.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void D8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D8"))
            {

                listBox1.Items.Remove("D8");
                D8.BackColor = Color.Transparent;
                D8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D8");
                D8.BackColor = Color.Lime;
                D8.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void D9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D9"))
            {

                listBox1.Items.Remove("D9");
                D9.BackColor = Color.Transparent;
                D9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D9");
                D9.BackColor = Color.Lime;
                D9.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void D10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("D10"))
            {

                listBox1.Items.Remove("D10");
                D10.BackColor = Color.Transparent;
                D10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("D10");
                D10.BackColor = Color.Lime;
                D10.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E1"))
            {

                listBox1.Items.Remove("E1");
                E1.BackColor = Color.Transparent;
                E1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E1");
                E1.BackColor = Color.Lime;
                E1.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
       
            stringjoin();
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E2"))
            {

                listBox1.Items.Remove("E2");
                E2.BackColor = Color.Transparent;
                E2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E2");
                E2.BackColor = Color.Lime;
                E2.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void E3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E3"))
            {

                listBox1.Items.Remove("E3");
                E3.BackColor = Color.Transparent;
                E3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E3");
                E3.BackColor = Color.Lime;
                E3.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void E4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E4"))
            {

                listBox1.Items.Remove("E4");
                E4.BackColor = Color.Transparent;
                E4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E4");
                E4.BackColor = Color.Lime;
                E4.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void E5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E5"))
            {

                listBox1.Items.Remove("E5");
                E5.BackColor = Color.Transparent;
                E5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E5");
                E5.BackColor = Color.Lime;
                E5.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void E6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E6"))
            {

                listBox1.Items.Remove("E6");
                E6.BackColor = Color.Transparent;
                E6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E6");
                E6.BackColor = Color.Lime;
                E6.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void E7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E7"))
            {

                listBox1.Items.Remove("E7");
                E7.BackColor = Color.Transparent;
                E7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E7");
                E7.BackColor = Color.Lime;
                E7.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void E8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E8"))
            {

                listBox1.Items.Remove("E8");
                E8.BackColor = Color.Transparent;
                E8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E8");
                E8.BackColor = Color.Lime;
                E8.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void E9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E9"))
            {

                listBox1.Items.Remove("E9");
                E9.BackColor = Color.Transparent;
                E9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E9");
                E9.BackColor = Color.Lime;
                E9.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void E10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("E10"))
            {

                listBox1.Items.Remove("E10");
                E10.BackColor = Color.Transparent;
                E10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("E10");
                E10.BackColor = Color.Lime;
                E10.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();

        }

  

        private void Seat_Click(object sender, EventArgs e)
        {

        }

        private void F1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F1"))
            {

                listBox1.Items.Remove("F1");
                F1.BackColor = Color.Transparent;
                F1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F1");
                F1.BackColor = Color.Lime;
                F1.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void F2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F2"))
            {

                listBox1.Items.Remove("F2");
                F2.BackColor = Color.Transparent;
                F2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F2");
                F2.BackColor = Color.Lime;
                F2.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
            
            stringjoin();
        }

        private void F3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F3"))
            {

                listBox1.Items.Remove("F3");
                F3.BackColor = Color.Transparent;
                F3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {
                listBox1.Items.Add("F3");
                F3.BackColor = Color.Lime;
                F3.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void F4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F4"))
            {

                listBox1.Items.Remove("F4");
                F4.BackColor = Color.Transparent;
                F4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F4");
                F4.BackColor = Color.Lime;
                F4.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void F5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F5"))
            {

                listBox1.Items.Remove("F5");
                F5.BackColor = Color.Transparent;
                F5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F5");
                F5.BackColor = Color.Lime;
                F5.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void F6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F6"))
            {

                listBox1.Items.Remove("F6");
                F6.BackColor = Color.Transparent;
                F6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F6");
                F6.BackColor = Color.Lime;
                F6.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void F7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F7"))
            {

                listBox1.Items.Remove("F7");
                F7.BackColor = Color.Transparent;
                F7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F7");
                F7.BackColor = Color.Lime;
                F7.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void F8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F8"))
            {

                listBox1.Items.Remove("F8");
                F8.BackColor = Color.Transparent;
                F8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F8");
                F8.BackColor = Color.Lime;
                F8.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void F9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F9"))
            {

                listBox1.Items.Remove("F9");
                F9.BackColor = Color.Transparent;
                F9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F9");
                F9.BackColor = Color.Lime;
                F9.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void F10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("F10"))
            {

                listBox1.Items.Remove("F10");
                F10.BackColor = Color.Transparent;
                F10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("F10");
                F10.BackColor = Color.Lime;
                F10.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void G1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G1"))
            {

                listBox1.Items.Remove("G1");
                G1.BackColor = Color.Transparent;
                G1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G1");
                G1.BackColor = Color.Lime;
                G1.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
           
            stringjoin();
        }

        private void G2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G2"))
            {

                listBox1.Items.Remove("G2");
                G2.BackColor = Color.Transparent;
                G2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G2");
                G2.BackColor = Color.Lime;
                G2.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void G3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G3"))
            {

                listBox1.Items.Remove("G3");
                G3.BackColor = Color.Transparent;
                G3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G3");
                G3.BackColor = Color.Lime;
                G3.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void G4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G4"))
            {

                listBox1.Items.Remove("G4");
                G4.BackColor = Color.Transparent;
                G4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G4");
                G4.BackColor = Color.Lime;
                G4.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
           
            stringjoin();
        }

        private void G5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G5"))
            {

                listBox1.Items.Remove("G5");
                G5.BackColor = Color.Transparent;
                G5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G5");
                G5.BackColor = Color.Lime;
                G5.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void G6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G6"))
            {

                listBox1.Items.Remove("G6");
                G6.BackColor = Color.Transparent;
                G6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G6");
                G6.BackColor = Color.Lime;
                G6.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void G7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G7"))
            {

                listBox1.Items.Remove("G7");
                G7.BackColor = Color.Transparent;
                G7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G7");
                G7.BackColor = Color.Lime;
                G7.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void G8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G8"))
            {

                listBox1.Items.Remove("G8");
                G8.BackColor = Color.Transparent;
                G8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G8");
                G8.BackColor = Color.Lime;
                G8.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void G9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G9"))
            {

                listBox1.Items.Remove("G9");
                G9.BackColor = Color.Transparent;
                G9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G9");
                G9.BackColor = Color.Lime;
                G9.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
        
            stringjoin();
        }

        private void G10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("G10"))
            {

                listBox1.Items.Remove("G10");
                G10.BackColor = Color.Transparent;
                G10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("G10");
                G10.BackColor = Color.Lime;
                G10.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void H1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H1"))
            {

                listBox1.Items.Remove("H1");
                H1.BackColor = Color.Transparent;
                H1.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H1");
                H1.BackColor = Color.Lime;
                H1.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
           
            stringjoin();
        }

        private void H2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H2"))
            {

                listBox1.Items.Remove("H2");
                H2.BackColor = Color.Transparent;
                H2.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H2");
                H2.BackColor = Color.Lime;
                H2.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void H3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H3"))
            {

                listBox1.Items.Remove("H3");
                H3.BackColor = Color.Transparent;
                H3.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H3");
                H3.BackColor = Color.Lime;
                H3.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void H4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H4"))
            {

                listBox1.Items.Remove("H4");
                H4.BackColor = Color.Transparent;
                H4.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H4");
                H4.BackColor = Color.Lime;
                H4.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void H5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H5"))
            {

                listBox1.Items.Remove("H5");
                H5.BackColor = Color.Transparent;
                H5.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
         
            else
            {

                listBox1.Items.Add("H5");
                H5.BackColor = Color.Lime;
                H5.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
         
            stringjoin();
        }

        private void H6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H6"))
            {

                listBox1.Items.Remove("H6");
                H6.BackColor = Color.Transparent;
                H6.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H6");
                H6.BackColor = Color.Lime;
                H6.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void H7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H7"))
            {

                listBox1.Items.Remove("H7");
                H7.BackColor = Color.Transparent;
                H7.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H7");
                H7.BackColor = Color.Lime;
                H7.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
          
            stringjoin();
        }

        private void H8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H8"))
            {

                listBox1.Items.Remove("H8");
                H8.BackColor = Color.Transparent;
                H8.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H8");
                H8.BackColor = Color.Lime;
                H8.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
           
            stringjoin();
        }

        private void H9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H9"))
            {

                listBox1.Items.Remove("H9");
                H9.BackColor = Color.Transparent;
                H9.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H9");
                H9.BackColor = Color.Lime;
                H9.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
            stringjoin();
        }

        private void H10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("H10"))
            {

                listBox1.Items.Remove("H10");
                H10.BackColor = Color.Transparent;
                H10.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
            else
            {

                listBox1.Items.Add("H10");
                H10.BackColor = Color.Lime;
                H10.FlatAppearance.MouseOverBackColor = Color.Lime;
            }
            stringjoin();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MyGlobal.closebookticket = 1;
        }
        void stringjoin()
        {
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in listBox1.Items)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
               
            }
            Seat.Text = sb.ToString();
           
            price(sb.ToString());
        }
        int sum = 0;
        void price(string seat)
        {
            sum = 0;
            int i = 0;
            string seatno;
            for(i=0;i<=seat.Length;i++)
            {
                try
                {
                    seatno = seat.Substring(i, 1);
                    if(seatno=="A"||seatno=="B")
                    {
                        Totalamount.Text = summofprice(ATOB).ToString()+".00/-";
                    }
                    if (seatno == "C" || seatno == "D"||seatno=="E")
                    {
                        Totalamount.Text = summofprice(CTOE).ToString()+".00/-";

                    }
                    if (seatno == "F" || seatno == "G"||seatno=="H")
                    {
                        Totalamount.Text = summofprice(FTOH).ToString()+".00/-";
                    }

                }
                catch(Exception ex)
                {
                }
            }
        }
        

        int summofprice(int value)
        {
            sum = sum + value;
            return sum;
        }

        int counter = 0;
        int visival = 0;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter==1)
            {
                if (listBox1.Items.Count == 0)
                {
                    Totalamount.Text = "00.00/-";
                }
              
                if(visival==1)
                {
                    PasswordTextBox.UseSystemPasswordChar =false;
                    visival = 0;
                }
                else
                {
                    PasswordTextBox.UseSystemPasswordChar = true;

                }



                counter = 0;
            }
        }
        string displaytime;
        private void MovieDisplayCombox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "Select *from MovieDetail where MovieTitle='" + MovieDisplayCombox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                displaytime = dt.Rows[0]["Time"].ToString();
            }
            catch(Exception ex)
            {
                con.Close();
            }
            timedisplay(displaytime);
            
        }
        void bookedseatdisplay(string combotime)
        {
            string flag = null;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                string query = "Select MovieTitle from TicketBook";
                string query1 = "Select Time from TicketBook";
                string query2 = "Select Seatno from TicketBook";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                sda.Fill(dt);
                sda1.Fill(dt1);
                sda2.Fill(dt2);
                int count = 0;
                for (; ; )
                {
                    string title = dt.Rows[count]["MovieTitle"].ToString();
                    string time = dt1.Rows[count]["Time"].ToString();
                    if(title==MovieDisplayCombox.Text && time==combotime)
                    {
                        string seat = dt2.Rows[count]["Seatno"].ToString();
                        for (int i = 0; i <= seat.Length; i++)
                        {
                            try
                            {
                                if (seat.Substring(i, 1) == " ")
                                {
                                    listBox2.Items.Add(flag);
                                    flag = null;
                                }
                                else
                                {
                                    flag = flag + seat.Substring(i, 1);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    count++;
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        void timedisplay(string time)
        {
            string flag=null;
            for(int i=1;i<=time.Length;i++)
            {
                try
                {
                    if (time.Substring(i, 1) == ";")
                    {
                        TImeDisplayCombox.Items.Add(flag);
                        flag = null;
                    }
                    else
                    {
                        flag = flag + time.Substring(i, 1);

                    }
                }
                catch
                {

                }
            }
            TImeDisplayCombox.Items.Add(flag);
        }

     

 

        private void BlockA_TextChanged_1(object sender, EventArgs e)
        {
            if (BlockA.Text.Length == 4)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BlockB_TextChanged_1(object sender, EventArgs e)
        {
            if (BlockB.Text.Length == 4)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BlockC_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            visival = 1;
        }
        
        private void HomeButton_Click(object sender, EventArgs e)
        {
            string datetxt = DateTime.Value.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "Insert into TicketBook(MovieTitle,TIme,Date,Seatno,Total,CoverPhoto,Username)Values('" + MovieDisplayCombox.Text + "','" + TImeDisplayCombox.Text + "','" + datetxt + "','" + Seat.Text + "','" + Totalamount.Text + "','"+MyGlobal.coverphoto+"','"+MyGlobal.DTUser+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        int count = 0;

        private void ExtraTimer_Tick(object sender, EventArgs e)
        {
            count++;
            if(count==1)
            {
                if (MyGlobal.ticketbookrefresh == 1)
                {
                    MovieDisplayCombox.Text = MyGlobal.movietitle;
                }
               
                
            }
            if(count==2)
            {
                if (MyGlobal.ticketbookrefresh == 1)
                {
                    MovieDisplayCombox.Text = MyGlobal.movietitle;
                }
                if(MyGlobal.backupticketbookrefresh==1)
                {
                    MovieDisplayCombox.Text = MyGlobal.movietitle;
                    MyGlobal.ticketbookrefresh = 0;

                }
                count = 0;
            }
        }

        private void TImeDisplayCombox_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            bookedseatdisplay(TImeDisplayCombox.Text);
            disableseat();
        }
        void disableseat()
        {
            if(listBox2.Items.Contains("A1"))
            {
                A1.BackColor = Color.OrangeRed;
                A1.Enabled = false;

            }
            else
            {
                A1.BackColor = Color.Transparent;
                A1.Enabled = true;
            }
            if (listBox2.Items.Contains("A2"))
            {
                A2.BackColor = Color.OrangeRed;
                A2.Enabled = false;

            }
            else
            {
                A2.BackColor = Color.Transparent;
                A2.Enabled = true;
            }
            if (listBox2.Items.Contains("A3"))
            {
                A3.BackColor = Color.OrangeRed;
                A3.Enabled = false;

            }
            else
            {
                A3.BackColor = Color.Transparent;
                A3.Enabled = true;
            }
            if (listBox2.Items.Contains("A4"))
            {
                A4.BackColor = Color.OrangeRed;
                A4.Enabled = false;

            }
            else
            {
                A4.BackColor = Color.Transparent;
                A4.Enabled = true;
            }
            if (listBox2.Items.Contains("A5"))
            {
                A5.BackColor = Color.OrangeRed;
                A5.Enabled = false;

            }
            else
            {
                A5.BackColor = Color.Transparent;
                A5.Enabled = true;
            }
            if (listBox2.Items.Contains("A6"))
            {
                A6.BackColor = Color.OrangeRed;
                A6.Enabled = false;

            }
            else
            {
                A6.BackColor = Color.Transparent;
                A6.Enabled = true;
            }
            if (listBox2.Items.Contains("A7"))
            {
                A7.BackColor = Color.OrangeRed;
                A7.Enabled = false;

            }
            else
            {
                A7.BackColor = Color.Transparent;
                A7.Enabled = true;
            }
            if (listBox2.Items.Contains("A8"))
            {
                A8.BackColor = Color.OrangeRed;
                A8.Enabled = false;

            }
            else
            {
                A8.BackColor = Color.Transparent;
                A8.Enabled = true;
            }
            if (listBox2.Items.Contains("A9"))
            {
                A9.BackColor = Color.OrangeRed;
                A9.Enabled = false;

            }
            else
            {
                A9.BackColor = Color.Transparent;
                A9.Enabled = true;
            }
            if (listBox2.Items.Contains("A10"))
            {
                A10.BackColor = Color.OrangeRed;
                A10.Enabled = false;

            }
            else
            {
                A10.BackColor = Color.Transparent;
                A10.Enabled = true;
            }
            if (listBox2.Items.Contains("B1"))
            {
                B1.BackColor = Color.OrangeRed;
                B1.Enabled = false;

            }
            else
            {
                B1.BackColor = Color.Transparent;
                B1.Enabled = true;
            }
            if (listBox2.Items.Contains("B2"))
            {
                B2.BackColor = Color.OrangeRed;
                B2.Enabled = false;

            }
            else
            {
                B2.BackColor = Color.Transparent;
                B2.Enabled = true;
            }
            if (listBox2.Items.Contains("B3"))
            {
                B3.BackColor = Color.OrangeRed;
                B3.Enabled = false;

            }
            else
            {
                B3.BackColor = Color.Transparent;
                B3.Enabled = true;
            }
            if (listBox2.Items.Contains("B4"))
            {
                B4.BackColor = Color.OrangeRed;
                B4.Enabled = false;

            }
            else
            {
                B4.BackColor = Color.Transparent;
                B4.Enabled = true;
            }
            if (listBox2.Items.Contains("B5"))
            {
                B5.BackColor = Color.OrangeRed;
                B5.Enabled = false;


            }
            else
            {
                B5.BackColor = Color.Transparent;
                B5.Enabled = true;
            }
            if (listBox2.Items.Contains("B6"))
            {
                B6.BackColor = Color.OrangeRed;
                B6.Enabled = false;

            }
            else
            {
                B6.BackColor = Color.Transparent;
                B6.Enabled = true;
            }
            if (listBox2.Items.Contains("B7"))
            {
                B7.BackColor = Color.OrangeRed;
                B7.Enabled = false;

            }
            else
            {
                B7.BackColor = Color.Transparent;
                B7.Enabled = true;
            }
            if (listBox2.Items.Contains("B8"))
            {
                B8.BackColor = Color.OrangeRed;
                B8.Enabled = false;

            }
            else
            {
                B8.BackColor = Color.Transparent;
                B8.Enabled = true;
            }
            if (listBox2.Items.Contains("B9"))
            {
                B9.BackColor = Color.OrangeRed;
                B9.Enabled = false;

            }
            else
            {
                B9.BackColor = Color.Transparent;
                B9.Enabled = true;
            }
            if (listBox2.Items.Contains("B10"))
            {
                B10.BackColor = Color.OrangeRed;
                B10.Enabled = false;

            }
            else
            {
                B10.BackColor = Color.Transparent;
                B10.Enabled = true;
            }
            if (listBox2.Items.Contains("C1"))
            {
                C1.BackColor = Color.OrangeRed;
                C1.Enabled = false;

            }
            else
            {
                C1.BackColor = Color.Transparent;
                C1.Enabled = true;
            }
            if (listBox2.Items.Contains("C2"))
            {
                C2.BackColor = Color.OrangeRed;
                C2.Enabled = false;

            }
            else
            {
                C2.BackColor = Color.Transparent;
                C2.Enabled = true;
            }
            if (listBox2.Items.Contains("C3"))
            {
                C3.BackColor = Color.OrangeRed;
                C3.Enabled = false;

            }
            else
            {
                C3.BackColor = Color.Transparent;
                C3.Enabled = true;
            }
            if (listBox2.Items.Contains("C4"))
            {
                C4.BackColor = Color.OrangeRed;
                C4.Enabled = false;

            }
            else
            {
                C4.BackColor = Color.Transparent;
                C4.Enabled = true;
            }
            if (listBox2.Items.Contains("C5"))
            {
                C5.BackColor = Color.OrangeRed;
                C5.Enabled = false;

            }
            else
            {
                C5.BackColor = Color.Transparent;
                C5.Enabled = true;
            }
            if (listBox2.Items.Contains("C6"))
            {
                C6.BackColor = Color.OrangeRed;
                C6.Enabled = false;

            }
            else
            {
                C6.BackColor = Color.Transparent;
                C6.Enabled = true;
            }
            if (listBox2.Items.Contains("C7"))
            {
                C7.BackColor = Color.OrangeRed;
                C7.Enabled = false;

            }
            else
            {
                C7.BackColor = Color.Transparent;
                C7.Enabled = true;
            }
            if (listBox2.Items.Contains("C8"))
            {
                C8.BackColor = Color.OrangeRed;
                C8.Enabled = false;

            }
            else
            {
                C8.BackColor = Color.Transparent;
                C8.Enabled = true;
            }
            if (listBox2.Items.Contains("C9"))
            {
                C9.BackColor = Color.OrangeRed;
                C9.Enabled = false;

            }
            else
            {
                C9.BackColor = Color.Transparent;
                C9.Enabled = true;
            }
            if (listBox2.Items.Contains("C10"))
            {
                C10.BackColor = Color.OrangeRed;
                C10.Enabled = false;

            }
            else
            {
                C10.BackColor = Color.Transparent;
                C10.Enabled = true;
            }
            if (listBox2.Items.Contains("D1"))
            {
                D1.BackColor = Color.OrangeRed;
                D1.Enabled = false;

            }
            else
            {
                D1.BackColor = Color.Transparent;
                D1.Enabled = true;
            }
            if (listBox2.Items.Contains("D2"))
            {
                D2.BackColor = Color.OrangeRed;
                D2.Enabled = false;

            }
            else
            {
                D2.BackColor = Color.Transparent;
                D2.Enabled = true;
            }
            if (listBox2.Items.Contains("D3"))
            {
                D3.BackColor = Color.OrangeRed;
                D3.Enabled = false;

            }
            else
            {
                D3.BackColor = Color.Transparent;
                D3.Enabled = true;
            }
            if (listBox2.Items.Contains("D4"))
            {
                D4.BackColor = Color.OrangeRed;
                D4.Enabled = false;

            }
            else
            {
                D4.BackColor = Color.Transparent;
                D4.Enabled = true;
            }
            if (listBox2.Items.Contains("D5"))
            {
                D5.BackColor = Color.OrangeRed;
                D5.Enabled = false;

            }
            else
            {
                D5.BackColor = Color.Transparent;
                D5.Enabled = true;
            }
            if (listBox2.Items.Contains("D6"))
            {
                D6.BackColor = Color.OrangeRed;
                D6.Enabled = false;

            }
            else
            {
                D6.BackColor = Color.Transparent;
                D6.Enabled = true;
            }
            if (listBox2.Items.Contains("D7"))
            {
                D7.BackColor = Color.OrangeRed;
                D7.Enabled = false;

            }
            else
            {
                D7.BackColor = Color.Transparent;
                D7.Enabled = true;
            }
            if (listBox2.Items.Contains("D8"))
            {
                D8.BackColor = Color.OrangeRed;
                D8.Enabled = false;

            }
            else
            {
                D8.BackColor = Color.Transparent;
                D8.Enabled = true;
            }
            if (listBox2.Items.Contains("D9"))
            {
                D9.BackColor = Color.OrangeRed;
                D9.Enabled = false;

            }
            else
            {
                D9.BackColor = Color.Transparent;
                D9.Enabled = true;
            }
            if (listBox2.Items.Contains("D10"))
            {
                D10.BackColor = Color.OrangeRed;
                D10.Enabled = false;

            }
            else
            {
                D10.BackColor = Color.Transparent;
                D10.Enabled = true;
            }
            if (listBox2.Items.Contains("E1"))
            {
                E1.BackColor = Color.OrangeRed;
                E1.Enabled = false;

            }
            else
            {
                E1.BackColor = Color.Transparent;
                E1.Enabled = true;
            }
            if (listBox2.Items.Contains("E2"))
            {
                E2.BackColor = Color.OrangeRed;
                E2.Enabled = false;

            }

            else
            {
                E2.BackColor = Color.Transparent;
                E2.Enabled = true;
            }
            if (listBox2.Items.Contains("E3"))
            {
                E3.BackColor = Color.OrangeRed;
                E3.Enabled = false;

            }
            else
            {
                E3.BackColor = Color.Transparent;
                E3.Enabled = true;
            }
            if (listBox2.Items.Contains("E4"))
            {
                E4.BackColor = Color.OrangeRed;
                E4.Enabled = false;

            }
            else
            {
                E4.BackColor = Color.Transparent;
                E4.Enabled = true;
            }
            if (listBox2.Items.Contains("E5"))
            {
                E5.BackColor = Color.OrangeRed;
                E5.Enabled = false;

            }
            else
            {
                E5.BackColor = Color.Transparent;
                E5.Enabled = true;
            }
            if (listBox2.Items.Contains("E6"))
            {
                E6.BackColor = Color.OrangeRed;
                E6.Enabled = false;

            }
            else
            {
                E6.BackColor = Color.Transparent;
                E6.Enabled = true;
            }
            if (listBox2.Items.Contains("E7"))
            {
                E7.BackColor = Color.OrangeRed;
                E7.Enabled = false;

            }
            else
            {
                E7.BackColor = Color.Transparent;
                E7.Enabled = true;
            }
            if (listBox2.Items.Contains("E8"))
            {
                E8.BackColor = Color.OrangeRed;
                E8.Enabled = false;

            }
            else
            {
                E8.BackColor = Color.Transparent;
                E8.Enabled = true;
            }
            if (listBox2.Items.Contains("E9"))
            {
                E9.BackColor = Color.OrangeRed;
                E9.Enabled = false;

            }
            else
            {
                E9.BackColor = Color.Transparent;
                E9.Enabled = true;
            }
            if (listBox2.Items.Contains("E10"))
            {
                E10.BackColor = Color.OrangeRed;
                E10.Enabled = false;

            }
            else
            {
                E10.BackColor = Color.Transparent;
                E10.Enabled = true;
            }
            if (listBox2.Items.Contains("F1"))
            {
                F1.BackColor = Color.OrangeRed;
                F1.Enabled = false;

            }
            else
            {
                F1.BackColor = Color.Transparent;
                F1.Enabled = true;
            }
            if (listBox2.Items.Contains("F2"))
            {
                F2.BackColor = Color.OrangeRed;
                F2.Enabled = false;

            }
            else
            {
                F2.BackColor = Color.Transparent;
                F2.Enabled = true;
            }
            if (listBox2.Items.Contains("F3"))
            {
                F3.BackColor = Color.OrangeRed;
                F3.Enabled = false;

            }
            else
            {
                F3.BackColor = Color.Transparent;
                F3.Enabled = true;
            }
            if (listBox2.Items.Contains("F4"))
            {
                F4.BackColor = Color.OrangeRed;
                F4.Enabled = false;

            }
            else
            {
                F4.BackColor = Color.Transparent;
                F4.Enabled = true;
            }
            if (listBox2.Items.Contains("F5"))
            {
                F5.BackColor = Color.OrangeRed;
                F5.Enabled = false;

            }
            else
            {
                F5.BackColor = Color.Transparent;
                F5.Enabled = true;
            }
            if (listBox2.Items.Contains("F6"))
            {
                F6.BackColor = Color.OrangeRed;
                F6.Enabled = false;

            }
            else
            {
                F6.BackColor = Color.Transparent;
                F6.Enabled = true;
            }
            if (listBox2.Items.Contains("F7"))
            {
                F7.BackColor = Color.OrangeRed;
                F7.Enabled = false;

            }
            else
            {
                F7.BackColor = Color.Transparent;
                F7.Enabled = true;
            }
            if (listBox2.Items.Contains("F8"))
            {
                F8.BackColor = Color.OrangeRed;
                F8.Enabled = false;

            }
            else
            {
                F8.BackColor = Color.Transparent;
                F8.Enabled = true;
            }
            if (listBox2.Items.Contains("F9"))
            {
                F9.BackColor = Color.OrangeRed;
                F9.Enabled = false;

            }
            else
            {
                F9.BackColor = Color.Transparent;
                F9.Enabled = true;
            }
            if (listBox2.Items.Contains("F10"))
            {
                F10.BackColor = Color.OrangeRed;
                F10.Enabled = false;

            }
            else
            {
                F10.BackColor = Color.Transparent;
                F10.Enabled = true;
            }
            if (listBox2.Items.Contains("G1"))
            {
                G1.BackColor = Color.OrangeRed;
                G1.Enabled = false;

            }
            else
            {
                G1.BackColor = Color.Transparent;
                G1.Enabled = true;
            }
            if (listBox2.Items.Contains("G2"))
            {
                G2.BackColor = Color.OrangeRed;
                G2.Enabled = false;

            }
            else
            {
                G2.BackColor = Color.Transparent;
                G2.Enabled = true;
            }
            if (listBox2.Items.Contains("G3"))
            {
                G3.BackColor = Color.OrangeRed;
                G3.Enabled = false;

            }
            else
            {
                G3.BackColor = Color.Transparent;
                G3.Enabled = true;
            }
            if (listBox2.Items.Contains("G4"))
            {
                G4.BackColor = Color.OrangeRed;
                G4.Enabled = false;

            }
            else
            {
                G4.BackColor = Color.Transparent;
                G4.Enabled = true;
            }
            if (listBox2.Items.Contains("G5"))
            {
                G5.BackColor = Color.OrangeRed;
                G5.Enabled = false;

            }
            else
            {
                G5.BackColor = Color.Transparent;
                G5.Enabled = true;
            }
            if (listBox2.Items.Contains("G6"))
            {
                G6.BackColor = Color.OrangeRed;
                G6.Enabled = false;

            }
            else
            {
                G6.BackColor = Color.Transparent;
                G6.Enabled = true;
            }
            if (listBox2.Items.Contains("G7"))
            {
                G7.BackColor = Color.OrangeRed;
                G7.Enabled = false;

            }
            else
            {
                G7.BackColor = Color.Transparent;
                G7.Enabled = true;
            }
            if (listBox2.Items.Contains("G8"))
            {
                G8.BackColor = Color.OrangeRed;
                G8.Enabled = false;

            }
            else
            {
                G8.BackColor = Color.Transparent;
                G8.Enabled = true;
            }
            if (listBox2.Items.Contains("G9"))
            {
                G9.BackColor = Color.OrangeRed;
                G9.Enabled = false;

            }
            else
            {
                G9.BackColor = Color.Transparent;
                G9.Enabled = true;
            }
            if (listBox2.Items.Contains("G10"))
            {
                G10.BackColor = Color.OrangeRed;
                G10.Enabled = false;

            }
            else
            {
                G10.BackColor = Color.Transparent;
                G10.Enabled = true;
            }
            if (listBox2.Items.Contains("H1"))
            {
                H1.BackColor = Color.OrangeRed;
                H1.Enabled = false;

            }
            else
            {
                H1.BackColor = Color.Transparent;
                H1.Enabled = true;
            }
            if (listBox2.Items.Contains("H2"))
            {
                H2.BackColor = Color.OrangeRed;
                H2.Enabled = false;

            }
            else
            {
                H2.BackColor = Color.Transparent;
                H2.Enabled = true;
            }
            if (listBox2.Items.Contains("H3"))
            {
                H3.BackColor = Color.OrangeRed;
                H3.Enabled = false;

            }
            else
            {
                H3.BackColor = Color.Transparent;
                H3.Enabled = true;
            }
            if (listBox2.Items.Contains("H4"))
            {
                H4.BackColor = Color.OrangeRed;
                H4.Enabled = false;

            }
            else
            {
                H4.BackColor = Color.Transparent;
                H4.Enabled = true;
            }
            if (listBox2.Items.Contains("H5"))
            {
                H5.BackColor = Color.OrangeRed;
                H5.Enabled = false;

            }
            else
            {
                H5.BackColor = Color.Transparent;
                H5.Enabled = true;
            }
            if (listBox2.Items.Contains("H6"))
            {
                H6.BackColor = Color.OrangeRed;
                H6.Enabled = false;

            }
            else
            {
                H6.BackColor = Color.Transparent;
                H6.Enabled = true;
            }
            if (listBox2.Items.Contains("H7"))
            {
                H7.BackColor = Color.OrangeRed;
                H7.Enabled = false;

            }
            else
            {
                H7.BackColor = Color.Transparent;
                H7.Enabled = true;
            }
            if (listBox2.Items.Contains("H8"))
            {
                H8.BackColor = Color.OrangeRed;
                H8.Enabled = false;

            }
            else
            {
                H8.BackColor = Color.Transparent;
                H8.Enabled = true;
            }
            if (listBox2.Items.Contains("H9"))
            {
                H9.BackColor = Color.OrangeRed;
                H9.Enabled = false;

            }
            else
            {
                H9.BackColor = Color.Transparent;
                H9.Enabled = true;
            }
            if (listBox2.Items.Contains("H10"))
            {
                H10.BackColor = Color.OrangeRed;
                H10.Enabled = false;

            }
            else
            {
                H10.BackColor = Color.Transparent;
                H10.Enabled = true;
            }
        }
    }
}
