namespace EnergiForbrug
{
    partial class Form3
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
            this.create_label = new System.Windows.Forms.LinkLabel();
            this.overviewLabel = new System.Windows.Forms.LinkLabel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // create_label
            // 
            this.create_label.AutoSize = true;
            this.create_label.Location = new System.Drawing.Point(46, 13);
            this.create_label.Name = "create_label";
            this.create_label.Size = new System.Drawing.Size(33, 13);
            this.create_label.TabIndex = 0;
            this.create_label.TabStop = true;
            this.create_label.Text = "Opret";
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Location = new System.Drawing.Point(85, 13);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(46, 13);
            this.overviewLabel.TabIndex = 1;
            this.overviewLabel.TabStop = true;
            this.overviewLabel.Text = "Oversigt";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(137, 13);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLabel.TabIndex = 2;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Log ud";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.overviewLabel);
            this.Controls.Add(this.create_label);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel create_label;
        private System.Windows.Forms.LinkLabel overviewLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
    }
}