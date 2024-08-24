namespace OOP_PROJECT
{
    partial class DeleteForm
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
            this.DeleteExpenseButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteExpenseField = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteExpenseName = new System.Windows.Forms.Label();
            this.DeleteCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteExpenseButton
            // 
            this.DeleteExpenseButton.BorderRadius = 5;
            this.DeleteExpenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteExpenseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteExpenseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteExpenseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteExpenseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteExpenseButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteExpenseButton.ForeColor = System.Drawing.Color.White;
            this.DeleteExpenseButton.Location = new System.Drawing.Point(310, 226);
            this.DeleteExpenseButton.Name = "DeleteExpenseButton";
            this.DeleteExpenseButton.Size = new System.Drawing.Size(197, 71);
            this.DeleteExpenseButton.TabIndex = 22;
            this.DeleteExpenseButton.Text = "Delete Expense";
            this.DeleteExpenseButton.Click += new System.EventHandler(this.DeleteExpenseButton_Click);
            // 
            // DeleteExpenseField
            // 
            this.DeleteExpenseField.BorderColor = System.Drawing.Color.Black;
            this.DeleteExpenseField.BorderRadius = 5;
            this.DeleteExpenseField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeleteExpenseField.DefaultText = "";
            this.DeleteExpenseField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeleteExpenseField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeleteExpenseField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteExpenseField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteExpenseField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteExpenseField.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DeleteExpenseField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteExpenseField.Location = new System.Drawing.Point(226, 143);
            this.DeleteExpenseField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteExpenseField.Name = "DeleteExpenseField";
            this.DeleteExpenseField.PasswordChar = '\0';
            this.DeleteExpenseField.PlaceholderText = "";
            this.DeleteExpenseField.SelectedText = "";
            this.DeleteExpenseField.Size = new System.Drawing.Size(353, 52);
            this.DeleteExpenseField.TabIndex = 21;
            // 
            // DeleteExpenseName
            // 
            this.DeleteExpenseName.AutoSize = true;
            this.DeleteExpenseName.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteExpenseName.Location = new System.Drawing.Point(266, 81);
            this.DeleteExpenseName.Name = "DeleteExpenseName";
            this.DeleteExpenseName.Size = new System.Drawing.Size(291, 33);
            this.DeleteExpenseName.TabIndex = 23;
            this.DeleteExpenseName.Text = "Enter the Expense Name ";
            // 
            // DeleteCloseBtn
            // 
            this.DeleteCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCloseBtn.Image = global::OOP_PROJECT.Properties.Resources.Cross;
            this.DeleteCloseBtn.ImageRotate = 0F;
            this.DeleteCloseBtn.Location = new System.Drawing.Point(759, 0);
            this.DeleteCloseBtn.Name = "DeleteCloseBtn";
            this.DeleteCloseBtn.Size = new System.Drawing.Size(40, 40);
            this.DeleteCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteCloseBtn.TabIndex = 24;
            this.DeleteCloseBtn.TabStop = false;
            this.DeleteCloseBtn.Click += new System.EventHandler(this.DeleteCloseBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCloseBtn);
            this.Controls.Add(this.DeleteExpenseName);
            this.Controls.Add(this.DeleteExpenseButton);
            this.Controls.Add(this.DeleteExpenseField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "DeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button DeleteExpenseButton;
        private Guna.UI2.WinForms.Guna2TextBox DeleteExpenseField;
        private System.Windows.Forms.Label DeleteExpenseName;
        private Guna.UI2.WinForms.Guna2PictureBox DeleteCloseBtn;
    }
}