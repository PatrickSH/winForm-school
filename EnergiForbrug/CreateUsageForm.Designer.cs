namespace EnergiForbrug
{
    partial class CreateUsageForm
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
            this.usageDate = new System.Windows.Forms.MonthCalendar();
            this.usageType = new System.Windows.Forms.TextBox();
            this.usageText = new System.Windows.Forms.TextBox();
            this.addUsageClick = new System.Windows.Forms.Button();
            this.create_label = new System.Windows.Forms.LinkLabel();
            this.overviewLabel = new System.Windows.Forms.LinkLabel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usageDate
            // 
            this.usageDate.Location = new System.Drawing.Point(18, 81);
            this.usageDate.Name = "usageDate";
            this.usageDate.TabIndex = 0;
            // 
            // usageType
            // 
            this.usageType.Location = new System.Drawing.Point(18, 44);
            this.usageType.Name = "usageType";
            this.usageType.Size = new System.Drawing.Size(100, 20);
            this.usageType.TabIndex = 1;
            this.usageType.Text = "Type";
            // 
            // usageText
            // 
            this.usageText.Location = new System.Drawing.Point(203, 44);
            this.usageText.Name = "usageText";
            this.usageText.Size = new System.Drawing.Size(100, 20);
            this.usageText.TabIndex = 2;
            this.usageText.Text = "Forbrug";
            // 
            // addUsageClick
            // 
            this.addUsageClick.Location = new System.Drawing.Point(228, 150);
            this.addUsageClick.Name = "addUsageClick";
            this.addUsageClick.Size = new System.Drawing.Size(75, 23);
            this.addUsageClick.TabIndex = 3;
            this.addUsageClick.Text = "Tilføj";
            this.addUsageClick.UseVisualStyleBackColor = true;
            this.addUsageClick.Click += new System.EventHandler(this.addUsageButtonClick);
            // 
            // create_label
            // 
            this.create_label.AutoSize = true;
            this.create_label.Location = new System.Drawing.Point(15, 9);
            this.create_label.Name = "create_label";
            this.create_label.Size = new System.Drawing.Size(69, 13);
            this.create_label.TabIndex = 4;
            this.create_label.TabStop = true;
            this.create_label.Text = "Opret forbrug";
            this.create_label.Click += new System.EventHandler(this.createUsagePage);
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Location = new System.Drawing.Point(90, 9);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(46, 13);
            this.overviewLabel.TabIndex = 5;
            this.overviewLabel.TabStop = true;
            this.overviewLabel.Text = "Oversigt";
            this.overviewLabel.Click += new System.EventHandler(this.overviewLink);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(142, 9);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLabel.TabIndex = 6;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Log ud";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.overviewLabel);
            this.Controls.Add(this.create_label);
            this.Controls.Add(this.addUsageClick);
            this.Controls.Add(this.usageText);
            this.Controls.Add(this.usageType);
            this.Controls.Add(this.usageDate);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar usageDate;
        private System.Windows.Forms.TextBox usageType;
        private System.Windows.Forms.TextBox usageText;
        private System.Windows.Forms.Button addUsageClick;
        private System.Windows.Forms.LinkLabel create_label;
        private System.Windows.Forms.LinkLabel overviewLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
    }
}