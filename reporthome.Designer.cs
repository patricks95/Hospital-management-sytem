namespace Early_Intervention_of_childhood
{
    partial class reporthome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporthome));
            this.reportdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.reportgetcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.back_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportdataGridView
            // 
            this.reportdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportdataGridView.Location = new System.Drawing.Point(24, 275);
            this.reportdataGridView.Name = "reportdataGridView";
            this.reportdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.reportdataGridView.RowTemplate.Height = 24;
            this.reportdataGridView.Size = new System.Drawing.Size(1888, 670);
            this.reportdataGridView.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(421, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportgetcheckedListBox
            // 
            this.reportgetcheckedListBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reportgetcheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportgetcheckedListBox.FormattingEnabled = true;
            this.reportgetcheckedListBox.Items.AddRange(new object[] {
            "Total items issue with patient",
            "Total services with patient",
            "All Recorde for Out Print"});
            this.reportgetcheckedListBox.Location = new System.Drawing.Point(24, 143);
            this.reportgetcheckedListBox.Name = "reportgetcheckedListBox";
            this.reportgetcheckedListBox.Size = new System.Drawing.Size(376, 89);
            this.reportgetcheckedListBox.TabIndex = 31;
            // 
            // pidtxt
            // 
            this.pidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidtxt.Location = new System.Drawing.Point(421, 156);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(129, 30);
            this.pidtxt.TabIndex = 32;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(1522, 101);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(99, 85);
            this.back_btn.TabIndex = 45;
            this.back_btn.UseVisualStyleBackColor = false;
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.setting_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setting_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("setting_btn.Image")));
            this.setting_btn.Location = new System.Drawing.Point(1622, 101);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(99, 85);
            this.setting_btn.TabIndex = 44;
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
            this.regbtn.Location = new System.Drawing.Point(1723, 101);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(99, 85);
            this.regbtn.TabIndex = 43;
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
            this.home_btn.Location = new System.Drawing.Point(1824, 101);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(95, 85);
            this.home_btn.TabIndex = 42;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // reporthome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 973);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.pidtxt);
            this.Controls.Add(this.reportgetcheckedListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportdataGridView);
            this.Name = "reporthome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporthome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reporthome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView reportdataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox reportgetcheckedListBox;
        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Button home_btn;
    }
}