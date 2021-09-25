namespace Theater_Ticketing_System
{
    partial class BookedTicket
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
            this.FormPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.PrintTicket = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.labelSeatno = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.Dateee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.CoverImage = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.Close = new System.Windows.Forms.Button();
            this.FormPanel.SuspendLayout();
            this.PrintTicket.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.AutoScroll = true;
            this.FormPanel.BackColor = System.Drawing.Color.Transparent;
            this.FormPanel.BaseColor = System.Drawing.Color.White;
            this.FormPanel.Controls.Add(this.Close);
            this.FormPanel.Controls.Add(this.PrintTicket);
            this.FormPanel.Location = new System.Drawing.Point(3, 1);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(693, 578);
            this.FormPanel.TabIndex = 0;
            // 
            // PrintTicket
            // 
            this.PrintTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintTicket.BackColor = System.Drawing.Color.Transparent;
            this.PrintTicket.BaseColor = System.Drawing.Color.Black;
            this.PrintTicket.Controls.Add(this.gunaElipsePanel1);
            this.PrintTicket.Location = new System.Drawing.Point(55, 136);
            this.PrintTicket.Name = "PrintTicket";
            this.PrintTicket.Size = new System.Drawing.Size(522, 271);
            this.PrintTicket.TabIndex = 1;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.PrintButton);
            this.gunaElipsePanel1.Controls.Add(this.LabelTotal);
            this.gunaElipsePanel1.Controls.Add(this.labelSeatno);
            this.gunaElipsePanel1.Controls.Add(this.labelTime);
            this.gunaElipsePanel1.Controls.Add(this.labelTitle);
            this.gunaElipsePanel1.Controls.Add(this.Dateee);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.Title);
            this.gunaElipsePanel1.Controls.Add(this.CoverImage);
            this.gunaElipsePanel1.Controls.Add(this.UsernameLabel);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(516, 265);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.Transparent;
            this.PrintButton.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_print_48px;
            this.PrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.Black;
            this.PrintButton.Location = new System.Drawing.Point(438, 220);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 42);
            this.PrintButton.TabIndex = 11;
            this.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(385, 229);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(51, 28);
            this.LabelTotal.TabIndex = 10;
            this.LabelTotal.Text = "...";
            // 
            // labelSeatno
            // 
            this.labelSeatno.AutoSize = true;
            this.labelSeatno.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatno.Location = new System.Drawing.Point(385, 171);
            this.labelSeatno.Name = "labelSeatno";
            this.labelSeatno.Size = new System.Drawing.Size(51, 28);
            this.labelSeatno.TabIndex = 9;
            this.labelSeatno.Text = "...";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(385, 107);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 28);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "...";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(385, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(51, 28);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "...";
            // 
            // Dateee
            // 
            this.Dateee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dateee.AutoSize = true;
            this.Dateee.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateee.Location = new System.Drawing.Point(340, 3);
            this.Dateee.Name = "Dateee";
            this.Dateee.Size = new System.Drawing.Size(51, 28);
            this.Dateee.TabIndex = 6;
            this.Dateee.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seatno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time  :";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(276, 49);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 28);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title :";
            // 
            // CoverImage
            // 
            this.CoverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverImage.Location = new System.Drawing.Point(3, 3);
            this.CoverImage.Name = "CoverImage";
            this.CoverImage.Size = new System.Drawing.Size(267, 259);
            this.CoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverImage.TabIndex = 0;
            this.CoverImage.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(431, 240);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(16, 13);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "...";
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
            this.Close.Location = new System.Drawing.Point(665, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 32);
            this.Close.TabIndex = 15;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BookedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.FormPanel);
            this.Name = "BookedTicket";
            this.Size = new System.Drawing.Size(699, 584);
            this.Load += new System.EventHandler(this.BookedTicket_Load);
            this.FormPanel.ResumeLayout(false);
            this.PrintTicket.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel FormPanel;
        private Guna.UI.WinForms.GunaElipsePanel PrintTicket;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label Dateee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox CoverImage;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label labelSeatno;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button Close;
    }
}
