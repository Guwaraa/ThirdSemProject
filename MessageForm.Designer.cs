namespace Theater_Ticketing_System
{
    partial class MessageForm
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
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftClose = new Guna.UI.WinForms.GunaCircleButton();
            this.RightOpen = new Guna.UI.WinForms.GunaCircleButton();
            this.MessageBoxButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.messboxForm = new Theater_Ticketing_System.MessboxForm();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.Black;
            this.gunaElipsePanel2.Controls.Add(this.MessageLabel);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(72, 3);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(469, 49);
            this.gunaElipsePanel2.TabIndex = 3;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MessageLabel.Location = new System.Drawing.Point(294, 5);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(151, 41);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Message";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // LeftClose
            // 
            this.LeftClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftClose.AnimationHoverSpeed = 0.07F;
            this.LeftClose.AnimationSpeed = 0.03F;
            this.LeftClose.BackColor = System.Drawing.Color.Transparent;
            this.LeftClose.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_double_right_40px;
            this.LeftClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftClose.BaseColor = System.Drawing.Color.Transparent;
            this.LeftClose.BorderColor = System.Drawing.Color.Black;
            this.LeftClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LeftClose.FocusedColor = System.Drawing.Color.Empty;
            this.LeftClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeftClose.ForeColor = System.Drawing.Color.Transparent;
            this.LeftClose.Image = null;
            this.LeftClose.ImageSize = new System.Drawing.Size(52, 52);
            this.LeftClose.Location = new System.Drawing.Point(329, 58);
            this.LeftClose.Name = "LeftClose";
            this.LeftClose.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.LeftClose.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LeftClose.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.LeftClose.OnHoverImage = global::Theater_Ticketing_System.Properties.Resources.icons8_close_window_40px;
            this.LeftClose.OnPressedColor = System.Drawing.Color.Transparent;
            this.LeftClose.Size = new System.Drawing.Size(60, 51);
            this.LeftClose.TabIndex = 6;
            this.LeftClose.Click += new System.EventHandler(this.LeftClose_Click);
            // 
            // RightOpen
            // 
            this.RightOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightOpen.AnimationHoverSpeed = 0.07F;
            this.RightOpen.AnimationSpeed = 0.03F;
            this.RightOpen.BackColor = System.Drawing.Color.Transparent;
            this.RightOpen.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_double_left_40px;
            this.RightOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightOpen.BaseColor = System.Drawing.Color.Transparent;
            this.RightOpen.BorderColor = System.Drawing.Color.Black;
            this.RightOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightOpen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RightOpen.FocusedColor = System.Drawing.Color.Empty;
            this.RightOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RightOpen.ForeColor = System.Drawing.Color.Transparent;
            this.RightOpen.Image = null;
            this.RightOpen.ImageSize = new System.Drawing.Size(52, 52);
            this.RightOpen.Location = new System.Drawing.Point(462, 58);
            this.RightOpen.Name = "RightOpen";
            this.RightOpen.OnHoverBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.RightOpen.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.RightOpen.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.RightOpen.OnHoverImage = global::Theater_Ticketing_System.Properties.Resources.icons8_new_message_40px;
            this.RightOpen.OnPressedColor = System.Drawing.Color.Transparent;
            this.RightOpen.Size = new System.Drawing.Size(74, 53);
            this.RightOpen.TabIndex = 5;
            this.RightOpen.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // MessageBoxButton
            // 
            this.MessageBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBoxButton.AnimationHoverSpeed = 0.07F;
            this.MessageBoxButton.AnimationSpeed = 0.03F;
            this.MessageBoxButton.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.MessageBoxButton.BorderColor = System.Drawing.Color.Black;
            this.MessageBoxButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.MessageBoxButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.MessageBoxButton.CheckedForeColor = System.Drawing.Color.White;
            this.MessageBoxButton.CheckedImage = global::Theater_Ticketing_System.Properties.Resources.icons8_message_preview_64px;
            this.MessageBoxButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.MessageBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageBoxButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MessageBoxButton.FocusedColor = System.Drawing.Color.Empty;
            this.MessageBoxButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBoxButton.ForeColor = System.Drawing.Color.White;
            this.MessageBoxButton.Image = global::Theater_Ticketing_System.Properties.Resources.icons8_message_preview_64px1;
            this.MessageBoxButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MessageBoxButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.MessageBoxButton.Location = new System.Drawing.Point(392, 58);
            this.MessageBoxButton.Name = "MessageBoxButton";
            this.MessageBoxButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MessageBoxButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessageBoxButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MessageBoxButton.OnHoverImage = null;
            this.MessageBoxButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.MessageBoxButton.OnPressedColor = System.Drawing.Color.Black;
            this.MessageBoxButton.Size = new System.Drawing.Size(144, 51);
            this.MessageBoxButton.TabIndex = 4;
            this.MessageBoxButton.Text = "Compose";
            this.MessageBoxButton.Click += new System.EventHandler(this.MessageBoxButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_left_80px;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 5;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(2, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 49);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // messboxForm
            // 
            this.messboxForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messboxForm.BackColor = System.Drawing.Color.Black;
            this.messboxForm.Location = new System.Drawing.Point(3, 121);
            this.messboxForm.Name = "messboxForm";
            this.messboxForm.Size = new System.Drawing.Size(539, 395);
            this.messboxForm.TabIndex = 7;
            this.messboxForm.Load += new System.EventHandler(this.messboxForm_Load);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LeftClose);
            this.Controls.Add(this.RightOpen);
            this.Controls.Add(this.MessageBoxButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.messboxForm);
            this.Name = "MessageForm";
            this.Size = new System.Drawing.Size(544, 516);
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Label MessageLabel;
        private Guna.UI.WinForms.GunaAdvenceButton MessageBoxButton;
        private Guna.UI.WinForms.GunaCircleButton RightOpen;
        private Guna.UI.WinForms.GunaCircleButton LeftClose;
        private System.Windows.Forms.Timer RefreshTimer;
        private MessboxForm messboxForm;
    }
}
