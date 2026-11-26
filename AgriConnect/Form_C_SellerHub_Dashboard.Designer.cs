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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerHub_Dashboard));
            this.panel1 = new MaterialSkin.Controls.MaterialCard();
            this.txtUser = new MaterialSkin.Controls.MaterialLabel();
            this.txtRole = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.txtFullName = new MaterialSkin.Controls.MaterialLabel();
            this.LogOff = new MaterialSkin.Controls.MaterialButton();
            this.btnList = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDelist = new MaterialSkin.Controls.MaterialButton();
            this.listedProductBySeller = new System.Windows.Forms.DataGridView();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuickSearch = new MaterialSkin.Controls.MaterialButton();
            this.btnMyProducts = new MaterialSkin.Controls.MaterialButton();
            this.PListProduct = new MaterialSkin.Controls.MaterialCard();
            this.pMyProductList = new MaterialSkin.Controls.MaterialCard();
            this.panel3 = new MaterialSkin.Controls.MaterialCard();
            this.lblNotification = new MaterialSkin.Controls.MaterialLabel();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.pMessage = new MaterialSkin.Controls.MaterialCard();
            this.rtbDashboardOrder = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listedProductBySeller)).BeginInit();
            this.panel2.SuspendLayout();
            this.PListProduct.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.LogOff);
            this.panel1.Depth = 0;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(14);
            this.panel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14);
            this.panel1.Size = new System.Drawing.Size(280, 196);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.txtUser.Location = new System.Drawing.Point(16, 16);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 24);
            this.txtUser.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.Depth = 0;
            this.txtRole.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRole.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtRole.Location = new System.Drawing.Point(16, 112);
            this.txtRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(248, 24);
            this.txtRole.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtPhoneNumber.Location = new System.Drawing.Point(16, 80);
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 24);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtFullName.Location = new System.Drawing.Point(16, 48);
            this.txtFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(248, 24);
            this.txtFullName.TabIndex = 3;
            // 
            // LogOff
            // 
            this.LogOff.AutoSize = false;
            this.LogOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LogOff.Depth = 0;
            this.LogOff.HighEmphasis = true;
            this.LogOff.Icon = null;
            this.LogOff.Location = new System.Drawing.Point(16, 148);
            this.LogOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogOff.Name = "LogOff";
            this.LogOff.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LogOff.Size = new System.Drawing.Size(248, 36);
            this.LogOff.TabIndex = 2;
            this.LogOff.Text = "LogOut";
            this.LogOff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.LogOff.UseAccentColor = true;
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // btnList
            // 
            this.btnList.AutoSize = false;
            this.btnList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnList.Depth = 0;
            this.btnList.HighEmphasis = true;
            this.btnList.Icon = null;
            this.btnList.Location = new System.Drawing.Point(306, 30);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnList.Name = "btnList";
            this.btnList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnList.Size = new System.Drawing.Size(90, 36);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List";
            this.btnList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnList.UseAccentColor = false;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.label3.Location = new System.Drawing.Point(144, 104);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.label2.Location = new System.Drawing.Point(144, 58);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.label1.Location = new System.Drawing.Point(144, 12);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(144, 122);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(150, 25);
            this.txtProductPrice.TabIndex = 7;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // txtProductStock
            // 
            this.txtProductStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductStock.Location = new System.Drawing.Point(144, 76);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(150, 25);
            this.txtProductStock.TabIndex = 6;
            this.txtProductStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductStock_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(144, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 25);
            this.txtProductName.TabIndex = 2;
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduct.Location = new System.Drawing.Point(16, 16);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(112, 131);
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
            this.btnDelist.AutoSize = false;
            this.btnDelist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelist.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelist.Depth = 0;
            this.btnDelist.HighEmphasis = true;
            this.btnDelist.Icon = null;
            this.btnDelist.Location = new System.Drawing.Point(306, 78);
            this.btnDelist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelist.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelist.Name = "btnDelist";
            this.btnDelist.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelist.Size = new System.Drawing.Size(90, 36);
            this.btnDelist.TabIndex = 12;
            this.btnDelist.Text = "De-List";
            this.btnDelist.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnDelist.UseAccentColor = true;
            this.btnDelist.UseVisualStyleBackColor = true;
            this.btnDelist.Click += new System.EventHandler(this.btnDelist_Click);
            // 
            // listedProductBySeller
            // 
            this.listedProductBySeller.AllowUserToAddRows = false;
            this.listedProductBySeller.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.listedProductBySeller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listedProductBySeller.BackgroundColor = System.Drawing.Color.White;
            this.listedProductBySeller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listedProductBySeller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listedProductBySeller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listedProductBySeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listedProductBySeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listedProductBySeller.DefaultCellStyle = dataGridViewCellStyle3;
            this.listedProductBySeller.EnableHeadersVisualStyles = false;
            this.listedProductBySeller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listedProductBySeller.Location = new System.Drawing.Point(8, 104);
            this.listedProductBySeller.Name = "listedProductBySeller";
            this.listedProductBySeller.ReadOnly = true;
            this.listedProductBySeller.RowHeadersVisible = false;
            this.listedProductBySeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listedProductBySeller.Size = new System.Drawing.Size(312, 268);
            this.listedProductBySeller.TabIndex = 14;
            // 
            // flpSearch
            // 
            this.flpSearch.AutoScroll = true;
            this.flpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.flpSearch.Location = new System.Drawing.Point(8, 104);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(356, 268);
            this.flpSearch.TabIndex = 16;
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFilter.Location = new System.Drawing.Point(16, 16);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(249, 25);
            this.txtSearchFilter.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(272, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.flpSearch);
            this.panel2.Controls.Add(this.listedProductBySeller);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchFilter);
            this.panel2.Controls.Add(this.lblQuickSearch);
            this.panel2.Controls.Add(this.btnMyProducts);
            this.panel2.Location = new System.Drawing.Point(692, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 380);
            this.panel2.TabIndex = 19;
            // 
            // lblQuickSearch
            // 
            this.lblQuickSearch.AutoSize = false;
            this.lblQuickSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblQuickSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lblQuickSearch.Depth = 0;
            this.lblQuickSearch.HighEmphasis = true;
            this.lblQuickSearch.Icon = null;
            this.lblQuickSearch.Location = new System.Drawing.Point(212, 56);
            this.lblQuickSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblQuickSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQuickSearch.Name = "lblQuickSearch";
            this.lblQuickSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lblQuickSearch.Size = new System.Drawing.Size(152, 36);
            this.lblQuickSearch.TabIndex = 20;
            this.lblQuickSearch.Text = "Quick search";
            this.lblQuickSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.lblQuickSearch.UseAccentColor = false;
            this.lblQuickSearch.UseVisualStyleBackColor = true;
            this.lblQuickSearch.Click += new System.EventHandler(this.lblQuickSearch_Click);
            // 
            // btnMyProducts
            // 
            this.btnMyProducts.AutoSize = false;
            this.btnMyProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMyProducts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMyProducts.Depth = 0;
            this.btnMyProducts.HighEmphasis = true;
            this.btnMyProducts.Icon = null;
            this.btnMyProducts.Location = new System.Drawing.Point(16, 56);
            this.btnMyProducts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMyProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMyProducts.Name = "btnMyProducts";
            this.btnMyProducts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMyProducts.Size = new System.Drawing.Size(136, 36);
            this.btnMyProducts.TabIndex = 19;
            this.btnMyProducts.Text = "My Products";
            this.btnMyProducts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnMyProducts.UseAccentColor = false;
            this.btnMyProducts.UseVisualStyleBackColor = true;
            this.btnMyProducts.Click += new System.EventHandler(this.btnMyProducts_Click);
            // 
            // PListProduct
            // 
            this.PListProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PListProduct.Controls.Add(this.btnList);
            this.PListProduct.Controls.Add(this.txtProductPrice);
            this.PListProduct.Controls.Add(this.txtProductName);
            this.PListProduct.Controls.Add(this.label1);
            this.PListProduct.Controls.Add(this.txtProductStock);
            this.PListProduct.Controls.Add(this.picProduct);
            this.PListProduct.Controls.Add(this.label2);
            this.PListProduct.Controls.Add(this.btnDelist);
            this.PListProduct.Controls.Add(this.label3);
            this.PListProduct.Depth = 0;
            this.PListProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PListProduct.Location = new System.Drawing.Point(312, 80);
            this.PListProduct.Margin = new System.Windows.Forms.Padding(14);
            this.PListProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.PListProduct.Name = "PListProduct";
            this.PListProduct.Padding = new System.Windows.Forms.Padding(14);
            this.PListProduct.Size = new System.Drawing.Size(408, 160);
            this.PListProduct.TabIndex = 22;
            // 
            // pMyProductList
            // 
            this.pMyProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pMyProductList.Depth = 0;
            this.pMyProductList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pMyProductList.Location = new System.Drawing.Point(736, 244);
            this.pMyProductList.Margin = new System.Windows.Forms.Padding(14);
            this.pMyProductList.MouseState = MaterialSkin.MouseState.HOVER;
            this.pMyProductList.Name = "pMyProductList";
            this.pMyProductList.Size = new System.Drawing.Size(328, 380);
            this.pMyProductList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblNotification);
            this.panel3.Controls.Add(this.flpNotification);
            this.panel3.Depth = 0;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(736, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(14);
            this.panel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 148);
            this.panel3.TabIndex = 24;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblNotification
            // 
            this.lblNotification.Depth = 0;
            this.lblNotification.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNotification.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNotification.Location = new System.Drawing.Point(12, 8);
            this.lblNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(304, 20);
            this.lblNotification.TabIndex = 1;
            this.lblNotification.Text = "Notifications";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpNotification
            // 
            this.flpNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.flpNotification.Location = new System.Drawing.Point(8, 34);
            this.flpNotification.Name = "flpNotification";
            this.flpNotification.Size = new System.Drawing.Size(312, 106);
            this.flpNotification.TabIndex = 0;
            this.flpNotification.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flpMessage
            // 
            this.flpMessage.AutoScroll = true;
            this.flpMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.flpMessage.Location = new System.Drawing.Point(8, 8);
            this.flpMessage.Name = "flpMessage";
            this.flpMessage.Size = new System.Drawing.Size(356, 296);
            this.flpMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = false;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(299, 318);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSend.Size = new System.Drawing.Size(65, 36);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = true;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(8, 314);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(272, 44);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // pMessage
            // 
            this.pMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pMessage.Controls.Add(this.flpMessage);
            this.pMessage.Controls.Add(this.btnSend);
            this.pMessage.Controls.Add(this.rtbMessage);
            this.pMessage.Depth = 0;
            this.pMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pMessage.Location = new System.Drawing.Point(312, 256);
            this.pMessage.Margin = new System.Windows.Forms.Padding(14);
            this.pMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.pMessage.Name = "pMessage";
            this.pMessage.Size = new System.Drawing.Size(372, 368);
            this.pMessage.TabIndex = 25;
            // 
            // rtbDashboardOrder
            // 
            this.rtbDashboardOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.rtbDashboardOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDashboardOrder.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDashboardOrder.Location = new System.Drawing.Point(16, 292);
            this.rtbDashboardOrder.Name = "rtbDashboardOrder";
            this.rtbDashboardOrder.Size = new System.Drawing.Size(280, 332);
            this.rtbDashboardOrder.TabIndex = 26;
            this.rtbDashboardOrder.Text = "";
            // 
            // SellerHub_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtbDashboardOrder);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pMyProductList);
            this.Controls.Add(this.PListProduct);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellerHub_Dashboard";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listedProductBySeller)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PListProduct.ResumeLayout(false);
            this.PListProduct.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard panel1;
        private MaterialSkin.Controls.MaterialLabel txtRole;
        private MaterialSkin.Controls.MaterialLabel txtPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel txtFullName;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductName;
        private MaterialSkin.Controls.MaterialButton btnList;
        private MaterialSkin.Controls.MaterialButton LogOff;
        private MaterialSkin.Controls.MaterialLabel txtUser;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialButton btnDelist;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnMyProducts;
        private MaterialSkin.Controls.MaterialButton lblQuickSearch;
        internal System.Windows.Forms.DataGridView listedProductBySeller;
        private MaterialSkin.Controls.MaterialCard PListProduct;
        private MaterialSkin.Controls.MaterialCard pMyProductList;
        private MaterialSkin.Controls.MaterialCard panel3;
        private MaterialSkin.Controls.MaterialLabel lblNotification;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
        private System.Windows.Forms.FlowLayoutPanel flpMessage;
        private MaterialSkin.Controls.MaterialButton btnSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private MaterialSkin.Controls.MaterialCard pMessage;
        private System.Windows.Forms.RichTextBox rtbDashboardOrder;
    }
}
