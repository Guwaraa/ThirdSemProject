using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater_Ticketing_System
{
    public partial class MovieDataentry : UserControl
    {
        public MovieDataentry()
        {
            InitializeComponent();
        }

        private void CancelButtons_Click(object sender, EventArgs e)
        {
            MyGlobal.movieclosedata = 1;
        }
        private void MovieDataentry_Load(object sender, EventArgs e)
        {
            adddata.Visible = true;
            deletedata.Visible = false;
            editdata.Visible = false;
        }
        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
          
           

        }

        private void AddButtons_Click(object sender, EventArgs e)
        {
            deletedata.Visible =false;
            editdata.Visible = false;
            adddata.Visible = true;
          
        }

        private void DeleteDataButooons_Click(object sender, EventArgs e)
        {
            deletedata.Visible = true;
            editdata.Visible = false;
            adddata.Visible = false;
            
        }

        private void EditButtons_Click(object sender, EventArgs e)
        {
            deletedata.Visible = false;
            editdata.Visible = true;
            adddata.Visible = false;

        }
    }

}
