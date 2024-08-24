namespace OOP_PROJECT
{
    partial class Loginform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginExpenseHeading = new System.Windows.Forms.Label();
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LoginPageBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginPagePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginFirstHeading = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginExpenseHeading
            // 
            this.LoginExpenseHeading.AutoSize = true;
            this.LoginExpenseHeading.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.LoginExpenseHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginExpenseHeading.Location = new System.Drawing.Point(706, 41);
            this.LoginExpenseHeading.Name = "LoginExpenseHeading";
            this.LoginExpenseHeading.Size = new System.Drawing.Size(539, 68);
            this.LoginExpenseHeading.TabIndex = 3;
            this.LoginExpenseHeading.Text = "EXPENSE TRACKER";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPanel.BorderRadius = 10;
            this.LoginPanel.BorderThickness = 3;
            this.LoginPanel.Controls.Add(this.LoginPageBtn);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.PasswordField);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.UsernameField);
            this.LoginPanel.Controls.Add(this.LoginPagePicture);
            this.LoginPanel.Controls.Add(this.LoginFirstHeading);
            this.LoginPanel.Location = new System.Drawing.Point(661, 123);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(638, 790);
            this.LoginPanel.TabIndex = 2;
            // 
            // LoginPageBtn
            // 
            this.LoginPageBtn.AutoSize = true;
            this.LoginPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPageBtn.Location = new System.Drawing.Point(382, 736);
            this.LoginPageBtn.Name = "LoginPageBtn";
            this.LoginPageBtn.Size = new System.Drawing.Size(136, 26);
            this.LoginPageBtn.TabIndex = 18;
            this.LoginPageBtn.Text = "Create one!";
            this.LoginPageBtn.Click += new System.EventHandler(this.LoginPageBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Don\'t have an account?";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BorderRadius = 5;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(376, 595);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(183, 69);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(75, 520);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(146, 32);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordField
            // 
            this.PasswordField.BorderRadius = 5;
            this.PasswordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordField.DefaultText = "";
            this.PasswordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordField.Location = new System.Drawing.Point(241, 509);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '\0';
            this.PasswordField.PlaceholderText = "";
            this.PasswordField.SelectedText = "";
            this.PasswordField.Size = new System.Drawing.Size(318, 55);
            this.PasswordField.TabIndex = 6;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(75, 431);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(152, 32);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameField
            // 
            this.UsernameField.BorderRadius = 5;
            this.UsernameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameField.DefaultText = "";
            this.UsernameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameField.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UsernameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameField.Location = new System.Drawing.Point(241, 418);
            this.UsernameField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.PasswordChar = '\0';
            this.UsernameField.PlaceholderText = "";
            this.UsernameField.SelectedText = "";
            this.UsernameField.Size = new System.Drawing.Size(318, 55);
            this.UsernameField.TabIndex = 4;
            // 
            // LoginPagePicture
            // 
            this.LoginPagePicture.Image = global::OOP_PROJECT.Properties.Resources.Main_LOGO;
            this.LoginPagePicture.ImageRotate = 0F;
            this.LoginPagePicture.Location = new System.Drawing.Point(183, 23);
            this.LoginPagePicture.Name = "LoginPagePicture";
            this.LoginPagePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LoginPagePicture.Size = new System.Drawing.Size(263, 256);
            this.LoginPagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPagePicture.TabIndex = 3;
            this.LoginPagePicture.TabStop = false;
            // 
            // LoginFirstHeading
            // 
            this.LoginFirstHeading.AutoSize = true;
            this.LoginFirstHeading.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFirstHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginFirstHeading.Location = new System.Drawing.Point(173, 301);
            this.LoginFirstHeading.Name = "LoginFirstHeading";
            this.LoginFirstHeading.Size = new System.Drawing.Size(319, 60);
            this.LoginFirstHeading.TabIndex = 2;
            this.LoginFirstHeading.Text = "Login First";
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.LoginExpenseHeading);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Loginform";
            this.Text = "loginform";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginExpenseHeading;
        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox PasswordField;
        private System.Windows.Forms.Label UsernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox UsernameField;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LoginPagePicture;
        private System.Windows.Forms.Label LoginFirstHeading;
        private System.Windows.Forms.Label LoginPageBtn;
        private System.Windows.Forms.Label label3;
    }
}