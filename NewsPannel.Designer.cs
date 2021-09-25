namespace Theater_Ticketing_System
{
    partial class NewsPannel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.NumberDisplayLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.CancelNewsPannel = new Guna.UI.WinForms.GunaCircleButton();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.gunaUsernameTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.Display = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources._1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Controls.Add(this.CancelNewsPannel);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.gunaUsernameTextbox);
            this.panel1.Controls.Add(this.gunaPanel2);
            this.panel1.Controls.Add(this.gunaPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 439);
            this.panel1.TabIndex = 0;
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton.BackColor = System.Drawing.Color.Transparent;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.ForeColor = System.Drawing.Color.Black;
            this.EnterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnterButton.Location = new System.Drawing.Point(365, 386);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(156, 50);
            this.EnterButton.TabIndex = 14;
            this.EnterButton.Text = "Enter";
            this.EnterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaElipsePanel1.Controls.Add(this.NumberDisplayLabel);
            this.gunaElipsePanel1.Controls.Add(this.NumberLabel);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(273, 345);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(157, 27);
            this.gunaElipsePanel1.TabIndex = 13;
            // 
            // NumberDisplayLabel
            // 
            this.NumberDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberDisplayLabel.AutoSize = true;
            this.NumberDisplayLabel.BackColor = System.Drawing.Color.LightGray;
            this.NumberDisplayLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberDisplayLabel.Location = new System.Drawing.Point(36, 1);
            this.NumberDisplayLabel.Name = "NumberDisplayLabel";
            this.NumberDisplayLabel.Size = new System.Drawing.Size(118, 24);
            this.NumberDisplayLabel.TabIndex = 10;
            this.NumberDisplayLabel.Text = "/75 Words";
            // 
            // NumberLabel
            // 
            this.NumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.LightGray;
            this.NumberLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(7, 2);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(22, 24);
            this.NumberLabel.TabIndex = 12;
            this.NumberLabel.Text = "0";
            // 
            // CancelNewsPannel
            // 
            this.CancelNewsPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelNewsPannel.AnimationHoverSpeed = 0.07F;
            this.CancelNewsPannel.AnimationSpeed = 0.03F;
            this.CancelNewsPannel.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_cancel_48px;
            this.CancelNewsPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelNewsPannel.BaseColor = System.Drawing.Color.Transparent;
            this.CancelNewsPannel.BorderColor = System.Drawing.Color.Black;
            this.CancelNewsPannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelNewsPannel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelNewsPannel.FocusedColor = System.Drawing.Color.Empty;
            this.CancelNewsPannel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelNewsPannel.ForeColor = System.Drawing.Color.White;
            this.CancelNewsPannel.Image = null;
            this.CancelNewsPannel.ImageSize = new System.Drawing.Size(52, 52);
            this.CancelNewsPannel.Location = new System.Drawing.Point(469, 3);
            this.CancelNewsPannel.Name = "CancelNewsPannel";
            this.CancelNewsPannel.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.CancelNewsPannel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelNewsPannel.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.CancelNewsPannel.OnHoverImage = null;
            this.CancelNewsPannel.OnPressedColor = System.Drawing.Color.DarkGray;
            this.CancelNewsPannel.Size = new System.Drawing.Size(48, 44);
            this.CancelNewsPannel.TabIndex = 11;
            this.CancelNewsPannel.Click += new System.EventHandler(this.CancelNewsPannel_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.Location = new System.Drawing.Point(6, 386);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(156, 50);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // gunaUsernameTextbox
            // 
            this.gunaUsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaUsernameTextbox.BackColor = System.Drawing.Color.White;
            this.gunaUsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaUsernameTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaUsernameTextbox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaUsernameTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaUsernameTextbox.Location = new System.Drawing.Point(6, 187);
            this.gunaUsernameTextbox.Name = "gunaUsernameTextbox";
            this.gunaUsernameTextbox.PasswordChar = '\0';
            this.gunaUsernameTextbox.SelectedText = "";
            this.gunaUsernameTextbox.Size = new System.Drawing.Size(428, 193);
            this.gunaUsernameTextbox.TabIndex = 8;
            this.gunaUsernameTextbox.TextChanged += new System.EventHandler(this.gunaUsernameTextbox_TextChanged);
            this.gunaUsernameTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gunaUsernameTextbox_MouseClick);
            this.gunaUsernameTextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaUsernameTextbox_MouseDown_1);
            this.gunaUsernameTextbox.MouseEnter += new System.EventHandler(this.gunaUsernameTextbox_MouseEnter);
            this.gunaUsernameTextbox.MouseLeave += new System.EventHandler(this.gunaUsernameTextbox_MouseLeave);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.Controls.Add(this.Display);
            this.gunaPanel2.Controls.Add(this.NextButton);
            this.gunaPanel2.Controls.Add(this.BackButton);
            this.gunaPanel2.Location = new System.Drawing.Point(3, 114);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(514, 50);
            this.gunaPanel2.TabIndex = 1;
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.BackColor = System.Drawing.Color.Thistle;
            this.Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display.Enabled = false;
            this.Display.FlatAppearance.BorderSize = 0;
            this.Display.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Display.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(83, 4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(348, 43);
            this.Display.TabIndex = 4;
            this.Display.Text = "1st News..!!";
            this.Display.UseVisualStyleBackColor = false;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_right_80px;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(437, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(74, 43);
            this.NextButton.TabIndex = 3;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_left_80px;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 43);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Location = new System.Drawing.Point(3, 49);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(514, 46);
            this.gunaPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------NEWS---------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 50;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // NewsPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "NewsPannel";
            this.Size = new System.Drawing.Size(526, 445);
            this.Load += new System.EventHandler(this.NewsPannel_Load);
            this.panel1.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button Display;
        private Guna.UI.WinForms.GunaLineTextBox gunaUsernameTextbox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label NumberDisplayLabel;
        private Guna.UI.WinForms.GunaCircleButton CancelNewsPannel;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label NumberLabel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Button EnterButton;
    }
}
