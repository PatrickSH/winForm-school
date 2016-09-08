namespace EnergiForbrug
{
    partial class Form2
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
            this.usernameReg = new System.Windows.Forms.TextBox();
            this.passwordReg = new System.Windows.Forms.TextBox();
            this.freeOrNot = new System.Windows.Forms.RadioButton();
            this.createUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameReg
            // 
            this.usernameReg.Location = new System.Drawing.Point(61, 39);
            this.usernameReg.Name = "usernameReg";
            this.usernameReg.Size = new System.Drawing.Size(150, 20);
            this.usernameReg.TabIndex = 0;
            this.usernameReg.Text = "Brugernavn";
            // 
            // passwordReg
            // 
            this.passwordReg.Location = new System.Drawing.Point(61, 83);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.Size = new System.Drawing.Size(150, 20);
            this.passwordReg.TabIndex = 1;
            this.passwordReg.Text = "Password";
            // 
            // freeOrNot
            // 
            this.freeOrNot.AutoSize = true;
            this.freeOrNot.Location = new System.Drawing.Point(61, 122);
            this.freeOrNot.Name = "freeOrNot";
            this.freeOrNot.Size = new System.Drawing.Size(142, 17);
            this.freeOrNot.TabIndex = 2;
            this.freeOrNot.TabStop = true;
            this.freeOrNot.Text = "Jeg vil gerne se reklamer";
            this.freeOrNot.UseVisualStyleBackColor = true;
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(61, 157);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(150, 23);
            this.createUser.TabIndex = 3;
            this.createUser.Text = "Opret";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUserClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.freeOrNot);
            this.Controls.Add(this.passwordReg);
            this.Controls.Add(this.usernameReg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameReg;
        private System.Windows.Forms.TextBox passwordReg;
        private System.Windows.Forms.RadioButton freeOrNot;
        private System.Windows.Forms.Button createUser;
    }
}