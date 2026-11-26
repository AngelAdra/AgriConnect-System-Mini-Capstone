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
            this.panel1 = new MaterialSkin.Controls.MaterialCard();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.txtRole = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.txtFullName = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.pMessage = new MaterialSkin.Controls.MaterialCard();
            this.flpMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.panel2 = new MaterialSkin.Controls.MaterialCard();
            this.lblRefresh = new MaterialSkin.Controls.MaterialButton();
            this.lblNotification = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbDashboardOrderSetted = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.pMessage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1  (profile card)
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Depth = 0;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(14);
            this.panel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14);
            this.panel1.Size = new System.Drawing.Size(280, 196);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.DrawShadows = true;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Location = new System.Drawing.Point(16, 148);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(248, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLogout.UseAccentColor = true;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = false;
            this.txtRole.Depth = 0;
            this.txtRole.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtRole.Location = new System.Drawing.Point(16, 112);
            this.txtRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(248, 24);
            this.txtRole.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoSize = false;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtPhoneNumber.Location = new System.Drawing.Point(16, 80);
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 24);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = false;
            this.txtFullName.Depth = 0;
            this.txtFullName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtFullName.Location = new System.Drawing.Point(16, 48);
            this.txtFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(248, 24);
            this.txtFullName.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = false;
            this.txtUser.Depth = 0;
            this.txtUser.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.txtUser.Location = new System.Drawing.Point(16, 16);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 24);
            this.txtUser.TabIndex = 11;
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFilter.Location = new System.Drawing.Point(16, 16);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(296, 25);
            this.txtSearchFilter.TabIndex = 3;
            this.txtSearchFilter.TextChanged += new System.EventHandler(this.txtSearchFilter_TextChanged);
            // 
            // flpSearch
            // 
            this.flpSearch.AutoScroll = true;
            this.flpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpSearch.Location = new System.Drawing.Point(8, 104);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(312, 432);
            this.flpSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.DrawShadows = true;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Location = new System.Drawing.Point(16, 56);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pMessage  (conversation card)
            // 
            this.pMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pMessage.Controls.Add(this.flpMessage);
            this.pMessage.Controls.Add(this.btnSend);
            this.pMessage.Controls.Add(this.rtbMessage);
            this.pMessage.Depth = 0;
            this.pMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pMessage.Location = new System.Drawing.Point(312, 244);
            this.pMessage.Margin = new System.Windows.Forms.Padding(14);
            this.pMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.pMessage.Name = "pMessage";
            this.pMessage.Padding = new System.Windows.Forms.Padding(0);
            this.pMessage.Size = new System.Drawing.Size(408, 380);
            this.pMessage.TabIndex = 5;
            // 
            // flpMessage
            // 
            this.flpMessage.AutoScroll = true;
            this.flpMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.flpMessage.Location = new System.Drawing.Point(8, 8);
            this.flpMessage.Name = "flpMessage";
            this.flpMessage.Size = new System.Drawing.Size(392, 308);
            this.flpMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = false;
            this.btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.DrawShadows = true;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Location = new System.Drawing.Point(324, 330);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(76, 36);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = true;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(8, 326);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(308, 44);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // panel2  (marketplace / search card)
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.flpSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.txtSearchFilter);
            this.panel2.Depth = 0;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(736, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(14);
            this.panel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0);
            this.panel2.Size = new System.Drawing.Size(328, 544);
            this.panel2.TabIndex = 6;
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = false;
            this.lblRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lblRefresh.Depth = 0;
            this.lblRefresh.DrawShadows = true;
            this.lblRefresh.HighEmphasis = true;
            this.lblRefresh.Location = new System.Drawing.Point(172, 56);
            this.lblRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(140, 36);
            this.lblRefresh.TabIndex = 5;
            this.lblRefresh.Text = "refresh";
            this.lblRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.lblRefresh.UseAccentColor = false;
            this.lblRefresh.UseVisualStyleBackColor = true;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = false;
            this.lblNotification.Depth = 0;
            this.lblNotification.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNotification.Location = new System.Drawing.Point(12, 8);
            this.lblNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(384, 20);
            this.lblNotification.TabIndex = 1;
            this.lblNotification.Text = "Notifications";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3  (notifications card)
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblNotification);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Depth = 0;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(312, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(14);
            this.panel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0);
            this.panel3.Size = new System.Drawing.Size(408, 148);
            this.panel3.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 106);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rtbDashboardOrderSetted
            // 
            this.rtbDashboardOrderSetted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtbDashboardOrderSetted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDashboardOrderSetted.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDashboardOrderSetted.Location = new System.Drawing.Point(16, 292);
            this.rtbDashboardOrderSetted.Name = "rtbDashboardOrderSetted";
            this.rtbDashboardOrderSetted.Size = new System.Drawing.Size(280, 332);
            this.rtbDashboardOrderSetted.TabIndex = 24;
            this.rtbDashboardOrderSetted.Text = "";
            // 
            // Patron_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.rtbDashboardOrderSetted);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Patron_Dashboard";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buyer Dashboard";
            this.Load += new System.EventHandler(this.G_Buyer_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.pMessage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialLabel txtRole;
        private MaterialSkin.Controls.MaterialLabel txtPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel txtFullName;
        private MaterialSkin.Controls.MaterialLabel txtUser;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialCard pMessage;
        private System.Windows.Forms.FlowLayoutPanel flpMessage;
        private MaterialSkin.Controls.MaterialCard panel2;
        private MaterialSkin.Controls.MaterialButton lblRefresh;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private MaterialSkin.Controls.MaterialButton btnSend;
        private MaterialSkin.Controls.MaterialLabel lblNotification;
        private MaterialSkin.Controls.MaterialCard panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbDashboardOrderSetted;
    }
}
