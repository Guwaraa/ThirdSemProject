namespace Theater_Ticketing_System
{
    partial class Displaymovie
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
            this.TrailerView = new System.Windows.Forms.WebBrowser();
            this.DataPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.Desciption = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Producer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.lael666 = new System.Windows.Forms.Label();
            this.ReleseDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieGener = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.CastButton = new System.Windows.Forms.Button();
            this.BookNow = new System.Windows.Forms.Button();
            this.DownCastButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Castpanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.Close = new System.Windows.Forms.Button();
            this.ticketBook = new Theater_Ticketing_System.TicketBook();
            this.PopupMessagebox = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.MessageBoxSure = new System.Windows.Forms.Button();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.NotIntrestedButton = new System.Windows.Forms.Button();
            this.gunaElipsePanel6 = new Guna.UI.WinForms.GunaElipsePanel();
            this.PopupMessageBoxPanel = new Guna.UI.WinForms.GunaLabel();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.PopupMessagebox.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel3.SuspendLayout();
            this.gunaElipsePanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrailerView
            // 
            this.TrailerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrailerView.Location = new System.Drawing.Point(4, 343);
            this.TrailerView.MinimumSize = new System.Drawing.Size(20, 20);
            this.TrailerView.Name = "TrailerView";
            this.TrailerView.Size = new System.Drawing.Size(390, 230);
            this.TrailerView.TabIndex = 1;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.BackColor = System.Drawing.Color.White;
            this.DataPanel.BaseColor = System.Drawing.Color.White;
            this.DataPanel.Controls.Add(this.Desciption);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.Producer);
            this.DataPanel.Controls.Add(this.label5);
            this.DataPanel.Controls.Add(this.Director);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.Rating);
            this.DataPanel.Controls.Add(this.lael666);
            this.DataPanel.Controls.Add(this.ReleseDate);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Controls.Add(this.MovieGener);
            this.DataPanel.Controls.Add(this.level);
            this.DataPanel.Location = new System.Drawing.Point(400, 343);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(355, 189);
            this.DataPanel.TabIndex = 7;
            this.DataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // Desciption
            // 
            this.Desciption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desciption.AutoSize = true;
            this.Desciption.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desciption.Location = new System.Drawing.Point(3, 174);
            this.Desciption.MaximumSize = new System.Drawing.Size(350, 150);
            this.Desciption.Name = "Desciption";
            this.Desciption.Size = new System.Drawing.Size(24, 18);
            this.Desciption.TabIndex = 10;
            this.Desciption.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // Producer
            // 
            this.Producer.AutoSize = true;
            this.Producer.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Producer.Location = new System.Drawing.Point(128, 123);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(30, 22);
            this.Producer.TabIndex = 9;
            this.Producer.Text = "..";
            this.Producer.Click += new System.EventHandler(this.Language_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Producer   :";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Director.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Director.Location = new System.Drawing.Point(128, 93);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(30, 22);
            this.Director.TabIndex = 7;
            this.Director.Text = "..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Director   :";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rating.Location = new System.Drawing.Point(128, 63);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(30, 22);
            this.Rating.TabIndex = 5;
            this.Rating.Text = "..";
            this.Rating.Click += new System.EventHandler(this.label1_Click);
            // 
            // lael666
            // 
            this.lael666.AutoSize = true;
            this.lael666.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lael666.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lael666.Location = new System.Drawing.Point(3, 63);
            this.lael666.Name = "lael666";
            this.lael666.Size = new System.Drawing.Size(130, 22);
            this.lael666.TabIndex = 4;
            this.lael666.Text = "Rating     :";
            // 
            // ReleseDate
            // 
            this.ReleseDate.AutoSize = true;
            this.ReleseDate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleseDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReleseDate.Location = new System.Drawing.Point(128, 33);
            this.ReleseDate.Name = "ReleseDate";
            this.ReleseDate.Size = new System.Drawing.Size(40, 22);
            this.ReleseDate.TabIndex = 3;
            this.ReleseDate.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Relese On  :";
            // 
            // MovieGener
            // 
            this.MovieGener.AutoSize = true;
            this.MovieGener.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieGener.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MovieGener.Location = new System.Drawing.Point(128, 3);
            this.MovieGener.Name = "MovieGener";
            this.MovieGener.Size = new System.Drawing.Size(30, 22);
            this.MovieGener.TabIndex = 1;
            this.MovieGener.Text = "..";
            this.MovieGener.Click += new System.EventHandler(this.MovieGener_Click);
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level.Location = new System.Drawing.Point(3, 3);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(130, 22);
            this.level.TabIndex = 0;
            this.level.Text = "Movie Gener:";
            this.level.Click += new System.EventHandler(this.level_Click);
            // 
            // CastButton
            // 
            this.CastButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CastButton.BackColor = System.Drawing.Color.LightCyan;
            this.CastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CastButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CastButton.FlatAppearance.BorderSize = 0;
            this.CastButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.CastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CastButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CastButton.ForeColor = System.Drawing.Color.Black;
            this.CastButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CastButton.Location = new System.Drawing.Point(400, 538);
            this.CastButton.Name = "CastButton";
            this.CastButton.Size = new System.Drawing.Size(355, 35);
            this.CastButton.TabIndex = 10;
            this.CastButton.Text = "Movie Cast";
            this.CastButton.UseVisualStyleBackColor = false;
            this.CastButton.Click += new System.EventHandler(this.CastButton_Click);
            // 
            // BookNow
            // 
            this.BookNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookNow.BackColor = System.Drawing.Color.Transparent;
            this.BookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookNow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BookNow.FlatAppearance.BorderSize = 0;
            this.BookNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BookNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNow.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNow.ForeColor = System.Drawing.Color.White;
            this.BookNow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookNow.Location = new System.Drawing.Point(596, 298);
            this.BookNow.Name = "BookNow";
            this.BookNow.Size = new System.Drawing.Size(156, 38);
            this.BookNow.TabIndex = 7;
            this.BookNow.Text = "Book Now";
            this.BookNow.UseVisualStyleBackColor = false;
            this.BookNow.Click += new System.EventHandler(this.BookNow_Click);
            // 
            // DownCastButton
            // 
            this.DownCastButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownCastButton.BackColor = System.Drawing.Color.LightGray;
            this.DownCastButton.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_pull_down_100px;
            this.DownCastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownCastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownCastButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DownCastButton.FlatAppearance.BorderSize = 0;
            this.DownCastButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.DownCastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DownCastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownCastButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownCastButton.ForeColor = System.Drawing.Color.Black;
            this.DownCastButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownCastButton.Location = new System.Drawing.Point(400, 538);
            this.DownCastButton.Name = "DownCastButton";
            this.DownCastButton.Size = new System.Drawing.Size(355, 35);
            this.DownCastButton.TabIndex = 13;
            this.DownCastButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DownCastButton.UseVisualStyleBackColor = false;
            this.DownCastButton.Click += new System.EventHandler(this.DownCastButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(752, 335);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Castpanel
            // 
            this.Castpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Castpanel.AutoScroll = true;
            this.Castpanel.BackColor = System.Drawing.Color.Transparent;
            this.Castpanel.BaseColor = System.Drawing.Color.White;
            this.Castpanel.Location = new System.Drawing.Point(400, 343);
            this.Castpanel.Name = "Castpanel";
            this.Castpanel.Size = new System.Drawing.Size(355, 189);
            this.Castpanel.TabIndex = 13;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_cancel_48px;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.Location = new System.Drawing.Point(727, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 32);
            this.Close.TabIndex = 14;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ticketBook
            // 
            this.ticketBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ticketBook.Location = new System.Drawing.Point(0, 0);
            this.ticketBook.Name = "ticketBook";
            this.ticketBook.Size = new System.Drawing.Size(758, 578);
            this.ticketBook.TabIndex = 15;
            // 
            // PopupMessagebox
            // 
            this.PopupMessagebox.BackColor = System.Drawing.Color.Black;
            this.PopupMessagebox.BaseColor = System.Drawing.Color.Black;
            this.PopupMessagebox.Controls.Add(this.gunaElipsePanel2);
            this.PopupMessagebox.Controls.Add(this.gunaElipsePanel3);
            this.PopupMessagebox.Controls.Add(this.gunaElipsePanel6);
            this.PopupMessagebox.Location = new System.Drawing.Point(163, 239);
            this.PopupMessagebox.Name = "PopupMessagebox";
            this.PopupMessagebox.Size = new System.Drawing.Size(433, 101);
            this.PopupMessagebox.TabIndex = 16;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Black;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.MessageBoxSure);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(4, 58);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(213, 40);
            this.gunaElipsePanel2.TabIndex = 5;
            // 
            // MessageBoxSure
            // 
            this.MessageBoxSure.BackColor = System.Drawing.Color.Transparent;
            this.MessageBoxSure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageBoxSure.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MessageBoxSure.FlatAppearance.BorderSize = 0;
            this.MessageBoxSure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.MessageBoxSure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MessageBoxSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageBoxSure.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBoxSure.ForeColor = System.Drawing.Color.Black;
            this.MessageBoxSure.Location = new System.Drawing.Point(0, -2);
            this.MessageBoxSure.Name = "MessageBoxSure";
            this.MessageBoxSure.Size = new System.Drawing.Size(213, 40);
            this.MessageBoxSure.TabIndex = 14;
            this.MessageBoxSure.Text = "Sure";
            this.MessageBoxSure.UseVisualStyleBackColor = false;
            this.MessageBoxSure.Click += new System.EventHandler(this.MessageBoxSure_Click);
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Black;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.NotIntrestedButton);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(220, 58);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(209, 40);
            this.gunaElipsePanel3.TabIndex = 4;
            // 
            // NotIntrestedButton
            // 
            this.NotIntrestedButton.BackColor = System.Drawing.Color.Transparent;
            this.NotIntrestedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotIntrestedButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NotIntrestedButton.FlatAppearance.BorderSize = 0;
            this.NotIntrestedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.NotIntrestedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NotIntrestedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotIntrestedButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotIntrestedButton.ForeColor = System.Drawing.Color.Black;
            this.NotIntrestedButton.Location = new System.Drawing.Point(0, -2);
            this.NotIntrestedButton.Name = "NotIntrestedButton";
            this.NotIntrestedButton.Size = new System.Drawing.Size(213, 40);
            this.NotIntrestedButton.TabIndex = 13;
            this.NotIntrestedButton.Text = "Not Intrested";
            this.NotIntrestedButton.UseVisualStyleBackColor = false;
            this.NotIntrestedButton.Click += new System.EventHandler(this.NotIntrestedButton_Click);
            // 
            // gunaElipsePanel6
            // 
            this.gunaElipsePanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel6.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel6.Controls.Add(this.PopupMessageBoxPanel);
            this.gunaElipsePanel6.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel6.Name = "gunaElipsePanel6";
            this.gunaElipsePanel6.Size = new System.Drawing.Size(427, 52);
            this.gunaElipsePanel6.TabIndex = 4;
            // 
            // PopupMessageBoxPanel
            // 
            this.PopupMessageBoxPanel.AutoSize = true;
            this.PopupMessageBoxPanel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupMessageBoxPanel.Location = new System.Drawing.Point(0, 9);
            this.PopupMessageBoxPanel.Name = "PopupMessageBoxPanel";
            this.PopupMessageBoxPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PopupMessageBoxPanel.Size = new System.Drawing.Size(22, 24);
            this.PopupMessageBoxPanel.TabIndex = 0;
            this.PopupMessageBoxPanel.Text = ".";
            this.PopupMessageBoxPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Displaymovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.Controls.Add(this.PopupMessagebox);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.BookNow);
            this.Controls.Add(this.CastButton);
            this.Controls.Add(this.TrailerView);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.DownCastButton);
            this.Controls.Add(this.Castpanel);
            this.Controls.Add(this.ticketBook);
            this.Name = "Displaymovie";
            this.Size = new System.Drawing.Size(758, 578);
            this.Load += new System.EventHandler(this.Displaymovie_Load);
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.PopupMessagebox.ResumeLayout(false);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel6.ResumeLayout(false);
            this.gunaElipsePanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.WebBrowser TrailerView;
        private Guna.UI.WinForms.GunaElipsePanel DataPanel;
        private System.Windows.Forms.Button BookNow;
        private System.Windows.Forms.Label MovieGener;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label Producer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label lael666;
        private System.Windows.Forms.Label ReleseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Desciption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CastButton;
        private System.Windows.Forms.Button DownCastButton;
        private Guna.UI.WinForms.GunaElipsePanel Castpanel;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button Close;
        private TicketBook ticketBook;
        private Guna.UI.WinForms.GunaElipsePanel PopupMessagebox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Button MessageBoxSure;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private System.Windows.Forms.Button NotIntrestedButton;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel6;
        private Guna.UI.WinForms.GunaLabel PopupMessageBoxPanel;
    }
}
