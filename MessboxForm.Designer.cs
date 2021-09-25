namespace Theater_Ticketing_System
{
    partial class MessboxForm
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
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Close = new System.Windows.Forms.Button();
            this.AdminorUserLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.TopicTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.ReciverComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.gunaElipsePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel4.Controls.Add(this.Close);
            this.gunaElipsePanel4.Controls.Add(this.AdminorUserLabel);
            this.gunaElipsePanel4.Controls.Add(this.SendButton);
            this.gunaElipsePanel4.Controls.Add(this.MessageTextBox);
            this.gunaElipsePanel4.Controls.Add(this.gunaElipsePanel5);
            this.gunaElipsePanel4.Controls.Add(this.TopicTextBox);
            this.gunaElipsePanel4.Controls.Add(this.ReciverComboBox);
            this.gunaElipsePanel4.Controls.Add(this.label2);
            this.gunaElipsePanel4.Controls.Add(this.label1);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Size = new System.Drawing.Size(536, 509);
            this.gunaElipsePanel4.TabIndex = 1;
            this.gunaElipsePanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel4_Paint);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Theater_Ticketing_System.Properties.Resources.icons8_close_window_40px;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.Location = new System.Drawing.Point(470, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(63, 37);
            this.Close.TabIndex = 14;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AdminorUserLabel
            // 
            this.AdminorUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminorUserLabel.AutoSize = true;
            this.AdminorUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminorUserLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminorUserLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminorUserLabel.Location = new System.Drawing.Point(439, 59);
            this.AdminorUserLabel.Name = "AdminorUserLabel";
            this.AdminorUserLabel.Size = new System.Drawing.Size(51, 28);
            this.AdminorUserLabel.TabIndex = 13;
            this.AdminorUserLabel.Text = "A/U";
            this.AdminorUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.Black;
            this.SendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SendButton.Location = new System.Drawing.Point(189, 453);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(156, 50);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click_1);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MessageTextBox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.MessageTextBox.Location = new System.Drawing.Point(11, 185);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.PasswordChar = '\0';
            this.MessageTextBox.SelectedText = "";
            this.MessageTextBox.Size = new System.Drawing.Size(510, 259);
            this.MessageTextBox.TabIndex = 11;
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.Black;
            this.gunaElipsePanel5.Location = new System.Drawing.Point(8, 182);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Size = new System.Drawing.Size(516, 265);
            this.gunaElipsePanel5.TabIndex = 10;
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopicTextBox.BackColor = System.Drawing.Color.White;
            this.TopicTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TopicTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TopicTextBox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.TopicTextBox.Location = new System.Drawing.Point(99, 74);
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.PasswordChar = '\0';
            this.TopicTextBox.SelectedText = "";
            this.TopicTextBox.Size = new System.Drawing.Size(172, 44);
            this.TopicTextBox.TabIndex = 9;
            // 
            // ReciverComboBox
            // 
            this.ReciverComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReciverComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ReciverComboBox.BaseColor = System.Drawing.Color.White;
            this.ReciverComboBox.BorderColor = System.Drawing.Color.Silver;
            this.ReciverComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReciverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReciverComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ReciverComboBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciverComboBox.ForeColor = System.Drawing.Color.Black;
            this.ReciverComboBox.FormattingEnabled = true;
            this.ReciverComboBox.Location = new System.Drawing.Point(334, 90);
            this.ReciverComboBox.Name = "ReciverComboBox";
            this.ReciverComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReciverComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ReciverComboBox.Size = new System.Drawing.Size(190, 33);
            this.ReciverComboBox.TabIndex = 4;
            this.ReciverComboBox.SelectedIndexChanged += new System.EventHandler(this.ReciverComboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(277, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topic:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // MessboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gunaElipsePanel4);
            this.Name = "MessboxForm";
            this.Size = new System.Drawing.Size(542, 515);
            this.Load += new System.EventHandler(this.MessboxForm_Load);
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private System.Windows.Forms.Label AdminorUserLabel;
        private System.Windows.Forms.Button SendButton;
        private Guna.UI.WinForms.GunaLineTextBox MessageTextBox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private Guna.UI.WinForms.GunaLineTextBox TopicTextBox;
        private Guna.UI.WinForms.GunaComboBox ReciverComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}
