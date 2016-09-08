namespace EnergiForbrug
{
    partial class Form5
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
            this.showUsageText = new System.Windows.Forms.RichTextBox();
            this.usageDateTo = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.usageDateFrom = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create_label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // showUsageText
            // 
            this.showUsageText.Location = new System.Drawing.Point(12, 285);
            this.showUsageText.Name = "showUsageText";
            this.showUsageText.Size = new System.Drawing.Size(379, 177);
            this.showUsageText.TabIndex = 0;
            this.showUsageText.Text = "";
            // 
            // usageDateTo
            // 
            this.usageDateTo.Location = new System.Drawing.Point(220, 82);
            this.usageDateTo.Name = "usageDateTo";
            this.usageDateTo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Søg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchDates);
            // 
            // usageDateFrom
            // 
            this.usageDateFrom.Location = new System.Drawing.Point(12, 82);
            this.usageDateFrom.Name = "usageDateFrom";
            this.usageDateFrom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dato Fra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dato Til:";
            // 
            // create_label
            // 
            this.create_label.AutoSize = true;
            this.create_label.Location = new System.Drawing.Point(13, 9);
            this.create_label.Name = "create_label";
            this.create_label.Size = new System.Drawing.Size(69, 13);
            this.create_label.TabIndex = 6;
            this.create_label.TabStop = true;
            this.create_label.Text = "Opret forbrug";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 474);
            this.Controls.Add(this.create_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usageDateFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usageDateTo);
            this.Controls.Add(this.showUsageText);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox showUsageText;
        private System.Windows.Forms.MonthCalendar usageDateTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar usageDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel create_label;
    }
}