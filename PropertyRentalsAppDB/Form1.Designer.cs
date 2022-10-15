namespace PropertyRentalsAppDB
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ucAgency1 = new PropertyRentalsAppDB.ucAgency();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to Sign-in Page";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucAgency1
            // 
            this.ucAgency1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucAgency1.Location = new System.Drawing.Point(100, 0);
            this.ucAgency1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucAgency1.Name = "ucAgency1";
            this.ucAgency1.Size = new System.Drawing.Size(893, 556);
            this.ucAgency1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 649);
            this.Controls.Add(this.ucAgency1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ucAgency ucAgency1;
    }
}

