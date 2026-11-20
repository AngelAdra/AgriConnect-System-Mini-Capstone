namespace AgriConnect
{
    partial class SellerHub_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerHub_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.LogOff = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDelist = new System.Windows.Forms.Button();
            this.listedProductBySeller = new System.Windows.Forms.DataGridView();
            this.btnMarket = new System.Windows.Forms.Button();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuickSearch = new System.Windows.Forms.Button();
            this.btnMyProducts = new System.Windows.Forms.Button();
            this.PListProduct = new System.Windows.Forms.Panel();
            this.pMyProductList = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.pMessage = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listedProductBySeller)).BeginInit();
            this.panel2.SuspendLayout();
            this.PListProduct.SuspendLayout();
            this.pMyProductList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.LogOff);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 490);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Silver;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(13, 53);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(137, 24);
            this.txtUser.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.Gold;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(15, 160);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(137, 24);
            this.txtRole.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Gold;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 119);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(137, 24);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Gold;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(14, 88);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(137, 24);
            this.txtFullName.TabIndex = 3;
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(17, 192);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(133, 26);
            this.LogOff.TabIndex = 2;
            this.LogOff.Text = "LogOut";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // Welcome
            // 
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(13, 10);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(137, 24);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(284, 17);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(113, 46);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(129, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(129, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(129, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(128, 97);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(150, 20);
            this.txtProductPrice.TabIndex = 7;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(128, 55);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(150, 20);
            this.txtProductStock.TabIndex = 6;
            this.txtProductStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductStock_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(128, 16);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(5, 13);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(118, 104);
            this.picProduct.TabIndex = 10;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelist
            // 
            this.btnDelist.Location = new System.Drawing.Point(284, 76);
            this.btnDelist.Name = "btnDelist";
            this.btnDelist.Size = new System.Drawing.Size(113, 42);
            this.btnDelist.TabIndex = 12;
            this.btnDelist.Text = "De-List";
            this.btnDelist.UseVisualStyleBackColor = true;
            this.btnDelist.Click += new System.EventHandler(this.btnDelist_Click);
            // 
            // listedProductBySeller
            // 
            this.listedProductBySeller.AllowUserToAddRows = false;
            this.listedProductBySeller.AllowUserToDeleteRows = false;
            this.listedProductBySeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listedProductBySeller.Location = new System.Drawing.Point(3, 68);
            this.listedProductBySeller.Name = "listedProductBySeller";
            this.listedProductBySeller.ReadOnly = true;
            this.listedProductBySeller.Size = new System.Drawing.Size(293, 331);
            this.listedProductBySeller.TabIndex = 14;
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(694, 453);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(121, 46);
            this.btnMarket.TabIndex = 15;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // flpSearch
            // 
            this.flpSearch.AutoScroll = true;
            this.flpSearch.Location = new System.Drawing.Point(3, 68);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(308, 229);
            this.flpSearch.TabIndex = 16;
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.Location = new System.Drawing.Point(12, 12);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(133, 20);
            this.txtSearchFilter.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(151, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 21);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flpSearch);
            this.panel2.Controls.Add(this.listedProductBySeller);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchFilter);
            this.panel2.Controls.Add(this.lblQuickSearch);
            this.panel2.Controls.Add(this.btnMyProducts);
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 402);
            this.panel2.TabIndex = 19;
            // 
            // lblQuickSearch
            // 
            this.lblQuickSearch.Location = new System.Drawing.Point(151, 39);
            this.lblQuickSearch.Name = "lblQuickSearch";
            this.lblQuickSearch.Size = new System.Drawing.Size(134, 21);
            this.lblQuickSearch.TabIndex = 20;
            this.lblQuickSearch.Text = "Quick search";
            this.lblQuickSearch.UseVisualStyleBackColor = true;
            this.lblQuickSearch.Click += new System.EventHandler(this.lblQuickSearch_Click);
            // 
            // btnMyProducts
            // 
            this.btnMyProducts.Location = new System.Drawing.Point(12, 38);
            this.btnMyProducts.Name = "btnMyProducts";
            this.btnMyProducts.Size = new System.Drawing.Size(133, 21);
            this.btnMyProducts.TabIndex = 19;
            this.btnMyProducts.Text = "My Products";
            this.btnMyProducts.UseVisualStyleBackColor = true;
            this.btnMyProducts.Click += new System.EventHandler(this.btnMyProducts_Click);
            // 
            // PListProduct
            // 
            this.PListProduct.Controls.Add(this.btnList);
            this.PListProduct.Controls.Add(this.txtProductPrice);
            this.PListProduct.Controls.Add(this.txtProductName);
            this.PListProduct.Controls.Add(this.label1);
            this.PListProduct.Controls.Add(this.txtProductStock);
            this.PListProduct.Controls.Add(this.picProduct);
            this.PListProduct.Controls.Add(this.label2);
            this.PListProduct.Controls.Add(this.btnDelist);
            this.PListProduct.Controls.Add(this.label3);
            this.PListProduct.Location = new System.Drawing.Point(207, 12);
            this.PListProduct.Name = "PListProduct";
            this.PListProduct.Size = new System.Drawing.Size(407, 130);
            this.PListProduct.TabIndex = 22;
            // 
            // pMyProductList
            // 
            this.pMyProductList.Controls.Add(this.panel2);
            this.pMyProductList.Location = new System.Drawing.Point(620, 136);
            this.pMyProductList.Name = "pMyProductList";
            this.pMyProductList.Size = new System.Drawing.Size(315, 311);
            this.pMyProductList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNotification);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(624, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 108);
            this.panel3.TabIndex = 24;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 86);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flpMessage
            // 
            this.flpMessage.AutoScroll = true;
            this.flpMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpMessage.Location = new System.Drawing.Point(14, 3);
            this.flpMessage.Name = "flpMessage";
            this.flpMessage.Size = new System.Drawing.Size(398, 289);
            this.flpMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(342, 298);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(120, 298);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(216, 30);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // pMessage
            // 
            this.pMessage.Controls.Add(this.flpMessage);
            this.pMessage.Controls.Add(this.btnSend);
            this.pMessage.Controls.Add(this.rtbMessage);
            this.pMessage.Location = new System.Drawing.Point(207, 148);
            this.pMessage.Name = "pMessage";
            this.pMessage.Size = new System.Drawing.Size(397, 341);
            this.pMessage.TabIndex = 25;
            // 
            // SellerHub_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 501);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pMyProductList);
            this.Controls.Add(this.PListProduct);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerHub_Dashboard";
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Seller_Dual_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listedProductBySeller)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PListProduct.ResumeLayout(false);
            this.PListProduct.PerformLayout();
            this.pMyProductList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.Label txtPhoneNumber;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDelist;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMyProducts;
        private System.Windows.Forms.Button lblQuickSearch;
        internal System.Windows.Forms.DataGridView listedProductBySeller;
        private System.Windows.Forms.Panel PListProduct;
        private System.Windows.Forms.Panel pMyProductList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Panel pMessage;
    }
}