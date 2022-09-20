namespace Early_Intervention_of_childhood
{
    partial class patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scarchtxt = new System.Windows.Forms.TextBox();
            this.scarchbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(639, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(727, 62);
            this.label4.TabIndex = 16;
            this.label4.Text = "Early Intervention Of Childhood";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(840, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 59);
            this.label1.TabIndex = 17;
            this.label1.Text = "Patient Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 139);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_id,
            this.FirstName,
            this.LastName,
            this.dob,
            this.gender,
            this.nic,
            this.gs,
            this.district,
            this.gradient,
            this.mobile1,
            this.mobile2,
            this.p_address});
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1900, 541);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patient_id
            // 
            this.patient_id.DataPropertyName = "patient_id";
            this.patient_id.HeaderText = "PATIENT ID";
            this.patient_id.MinimumWidth = 6;
            this.patient_id.Name = "patient_id";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FIRST NAME";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LAST NAME";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "DOB";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            // 
            // nic
            // 
            this.nic.DataPropertyName = "nic";
            this.nic.HeaderText = "NIC";
            this.nic.MinimumWidth = 6;
            this.nic.Name = "nic";
            // 
            // gs
            // 
            this.gs.DataPropertyName = "gs";
            this.gs.HeaderText = "GS DEVISION";
            this.gs.MinimumWidth = 6;
            this.gs.Name = "gs";
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "DISTRICT";
            this.district.MinimumWidth = 6;
            this.district.Name = "district";
            // 
            // gradient
            // 
            this.gradient.DataPropertyName = "gradient";
            this.gradient.HeaderText = "GARDIENT";
            this.gradient.MinimumWidth = 6;
            this.gradient.Name = "gradient";
            // 
            // mobile1
            // 
            this.mobile1.DataPropertyName = "mobile1";
            this.mobile1.HeaderText = "MOBILE 1";
            this.mobile1.MinimumWidth = 6;
            this.mobile1.Name = "mobile1";
            // 
            // mobile2
            // 
            this.mobile2.DataPropertyName = "mobile2";
            this.mobile2.HeaderText = "MOBILE 2";
            this.mobile2.MinimumWidth = 6;
            this.mobile2.Name = "mobile2";
            // 
            // p_address
            // 
            this.p_address.DataPropertyName = "p_address";
            this.p_address.HeaderText = "P ADDRESS";
            this.p_address.MinimumWidth = 6;
            this.p_address.Name = "p_address";
            // 
            // scarchtxt
            // 
            this.scarchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scarchtxt.Location = new System.Drawing.Point(1603, 212);
            this.scarchtxt.Name = "scarchtxt";
            this.scarchtxt.Size = new System.Drawing.Size(193, 30);
            this.scarchtxt.TabIndex = 27;
            // 
            // scarchbtn
            // 
            this.scarchbtn.BackColor = System.Drawing.Color.MediumBlue;
            this.scarchbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scarchbtn.ForeColor = System.Drawing.Color.White;
            this.scarchbtn.Location = new System.Drawing.Point(1802, 207);
            this.scarchbtn.Name = "scarchbtn";
            this.scarchbtn.Size = new System.Drawing.Size(110, 43);
            this.scarchbtn.TabIndex = 28;
            this.scarchbtn.Text = "Scarch";
            this.scarchbtn.UseVisualStyleBackColor = false;
            this.scarchbtn.Click += new System.EventHandler(this.scarchbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(189, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 139);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(1515, 27);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(99, 85);
            this.back_btn.TabIndex = 49;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.setting_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setting_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("setting_btn.Image")));
            this.setting_btn.Location = new System.Drawing.Point(1615, 27);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(99, 85);
            this.setting_btn.TabIndex = 48;
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regbtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.regbtn.Image = ((System.Drawing.Image)(resources.GetObject("regbtn.Image")));
            this.regbtn.Location = new System.Drawing.Point(1716, 27);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(99, 85);
            this.regbtn.TabIndex = 47;
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.Location = new System.Drawing.Point(1817, 27);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(95, 85);
            this.home_btn.TabIndex = 46;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 799);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.scarchbtn);
            this.Controls.Add(this.scarchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox scarchtxt;
        private System.Windows.Forms.Button scarchbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn gs;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradient;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile2;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_address;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Button home_btn;
    }
}