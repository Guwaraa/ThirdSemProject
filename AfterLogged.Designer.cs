namespace Theater_Ticketing_System
{
    partial class AfterLogged
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Username = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserCharacter = new System.Windows.Forms.Button();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDetailDataSet1 = new Theater_Ticketing_System.UserDetailDataSet1();
            this.userDataTableAdapter = new Theater_Ticketing_System.UserDetailDataSet1TableAdapters.UserDataTableAdapter();
            this.DataRefresh = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailDataSet1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Black;
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(224, 357);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.panel3);
            this.gunaElipsePanel2.Controls.Add(this.panel2);
            this.gunaElipsePanel2.Controls.Add(this.panel1);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(218, 351);
            this.gunaElipsePanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(3, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 64);
            this.panel3.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.LogOutButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(206, 58);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOutButton.Location = new System.Drawing.Point(3, 3);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(203, 61);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "LOG&OUT";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(3, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 64);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.Username);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(206, 58);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Username.Enabled = false;
            this.Username.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Username.FlatAppearance.BorderSize = 0;
            this.Username.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Username.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Username.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Username.Location = new System.Drawing.Point(3, 3);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(203, 55);
            this.Username.TabIndex = 7;
            this.Username.Text = "&.";
            this.Username.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 134);
            this.panel1.TabIndex = 0;
            // 
            // UserCharacter
            // 
            this.UserCharacter.BackColor = System.Drawing.Color.Transparent;
            this.UserCharacter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserCharacter.Enabled = false;
            this.UserCharacter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UserCharacter.FlatAppearance.BorderSize = 0;
            this.UserCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.UserCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.UserCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserCharacter.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCharacter.ForeColor = System.Drawing.Color.Lime;
            this.UserCharacter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserCharacter.Location = new System.Drawing.Point(3, 3);
            this.UserCharacter.Name = "UserCharacter";
            this.UserCharacter.Size = new System.Drawing.Size(203, 125);
            this.UserCharacter.TabIndex = 7;
            this.UserCharacter.Text = "A";
            this.UserCharacter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserCharacter.UseVisualStyleBackColor = false;
            this.UserCharacter.Click += new System.EventHandler(this.UserCharacter_Click);
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "UserData";
            this.userDataBindingSource.DataSource = this.userDetailDataSet1;
            // 
            // userDetailDataSet1
            // 
            this.userDetailDataSet1.DataSetName = "UserDetailDataSet1";
            this.userDetailDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataTableAdapter
            // 
            this.userDataTableAdapter.ClearBeforeFill = true;
            // 
            // DataRefresh
            // 
            this.DataRefresh.Tick += new System.EventHandler(this.DataRefresh_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.images;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.UserCharacter);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Lime;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 128);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AfterLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "AfterLogged";
            this.Size = new System.Drawing.Size(230, 363);
            this.Load += new System.EventHandler(this.AfterLogged_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailDataSet1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button LogOutButton;
        private UserDetailDataSet1 userDetailDataSet1;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private UserDetailDataSet1TableAdapters.UserDataTableAdapter userDataTableAdapter;
        private System.Windows.Forms.Button Username;
        private System.Windows.Forms.Button UserCharacter;
        private System.Windows.Forms.Timer DataRefresh;
    }
}
