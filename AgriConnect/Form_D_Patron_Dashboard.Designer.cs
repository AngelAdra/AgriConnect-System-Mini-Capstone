namespace AgriConnect
{
    partial class Patron_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patron_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.btnMarket = new System.Windows.Forms.Button();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pMessage = new System.Windows.Forms.Panel();
            this.flpMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pMessage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 488);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(45, 401);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.Gold;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(11, 129);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(144, 24);
            this.txtRole.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Gold;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(11, 95);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(144, 24);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Gold;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(11, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(144, 24);
            this.txtFullName.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gold;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(11, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(144, 24);
            this.txtUser.TabIndex = 11;
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(666, 1);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(133, 32);
            this.btnMarket.TabIndex = 1;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.Location = new System.Drawing.Point(8, 3);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(273, 20);
            this.txtSearchFilter.TabIndex = 3;
            this.txtSearchFilter.TextChanged += new System.EventHandler(this.txtSearchFilter_TextChanged);
            // 
            // flpSearch
            // 
            this.flpSearch.AutoScroll = true;
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpSearch.Location = new System.Drawing.Point(8, 51);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(270, 396);
            this.flpSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 21);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pMessage
            // 
            this.pMessage.Controls.Add(this.flpMessage);
            this.pMessage.Controls.Add(this.btnSend);
            this.pMessage.Controls.Add(this.rtbMessage);
            this.pMessage.Location = new System.Drawing.Point(344, 119);
            this.pMessage.Name = "pMessage";
            this.pMessage.Size = new System.Drawing.Size(301, 367);
            this.pMessage.TabIndex = 5;
            // 
            // flpMessage
            // 
            this.flpMessage.AutoScroll = true;
            this.flpMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpMessage.Location = new System.Drawing.Point(3, 16);
            this.flpMessage.Name = "flpMessage";
            this.flpMessage.Size = new System.Drawing.Size(298, 307);
            this.flpMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(231, 326);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(6, 329);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(216, 30);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flpSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.txtSearchFilter);
            this.panel2.Location = new System.Drawing.Point(643, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 450);
            this.panel2.TabIndex = 6;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Location = new System.Drawing.Point(147, 24);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(134, 21);
            this.lblRefresh.TabIndex = 5;
            this.lblRefresh.Text = "refresh";
            this.lblRefresh.UseVisualStyleBackColor = true;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.Location = new System.Drawing.Point(3, 5);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(290, 14);
            this.lblNotification.TabIndex = 1;
            this.lblNotification.Text = "Notifications";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNotification);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(344, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 101);
            this.panel3.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(295, 79);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Patron_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Patron_Dashboard";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.G_Buyer_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.G_Buyer_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.pMessage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.Label txtPhoneNumber;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pMessage;
        private System.Windows.Forms.FlowLayoutPanel flpMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button lblRefresh;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}