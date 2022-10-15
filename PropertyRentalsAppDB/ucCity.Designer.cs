namespace PropertyRentalsAppDB
{
    partial class ucCity
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
            this.btbnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.txtCityDesc = new System.Windows.Forms.TextBox();
            this.txtCityID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCity)).BeginInit();
            this.SuspendLayout();
            // 
            // btbnAdd
            // 
            this.btbnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btbnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbnAdd.ForeColor = System.Drawing.Color.White;
            this.btbnAdd.Location = new System.Drawing.Point(373, 57);
            this.btbnAdd.Name = "btbnAdd";
            this.btbnAdd.Size = new System.Drawing.Size(125, 35);
            this.btbnAdd.TabIndex = 6;
            this.btbnAdd.Text = "Add";
            this.btbnAdd.UseVisualStyleBackColor = false;
            this.btbnAdd.Click += new System.EventHandler(this.btbnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvCity);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btbnAdd);
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.txtCityDesc);
            this.groupBox1.Controls.Add(this.txtCityID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage City";
            // 
            // dgvCity
            // 
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(20, 168);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.Size = new System.Drawing.Size(478, 170);
            this.dgvCity.TabIndex = 8;
            this.dgvCity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCity_CellClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(373, 101);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(125, 35);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(169, 118);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(187, 28);
            this.cmbProvince.TabIndex = 5;
            // 
            // txtCityDesc
            // 
            this.txtCityDesc.Location = new System.Drawing.Point(169, 86);
            this.txtCityDesc.Name = "txtCityDesc";
            this.txtCityDesc.Size = new System.Drawing.Size(187, 26);
            this.txtCityDesc.TabIndex = 4;
            // 
            // txtCityID
            // 
            this.txtCityID.Location = new System.Drawing.Point(169, 54);
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.Size = new System.Drawing.Size(187, 26);
            this.txtCityID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Province:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City ID:";
            // 
            // errCity
            // 
            this.errCity.ContainerControl = this;
            // 
            // ucCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucCity";
            this.Size = new System.Drawing.Size(684, 462);
            this.Load += new System.EventHandler(this.ucCity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.TextBox txtCityDesc;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errCity;
    }
}
