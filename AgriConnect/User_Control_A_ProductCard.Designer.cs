namespace AgriConnect
{
    partial class ProductCard
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
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.btnContackSeller = new System.Windows.Forms.Button();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblContackNum = new System.Windows.Forms.Label();
            this.lblBaranggay = new System.Windows.Forms.Label();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.btnSetOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Khaki;
            this.picProduct.Location = new System.Drawing.Point(3, 18);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(278, 117);
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(62, 155);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(0, 13);
            this.lblProductName.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(62, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 2;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(62, 181);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 3;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(62, 194);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(0, 13);
            this.lblSeller.TabIndex = 4;
            // 
            // btnContackSeller
            // 
            this.btnContackSeller.Location = new System.Drawing.Point(3, 210);
            this.btnContackSeller.Name = "btnContackSeller";
            this.btnContackSeller.Size = new System.Drawing.Size(278, 24);
            this.btnContackSeller.TabIndex = 6;
            this.btnContackSeller.Text = "Contact Seller";
            this.btnContackSeller.UseVisualStyleBackColor = true;
            this.btnContackSeller.Click += new System.EventHandler(this.btnContackSeller_Click);
            // 
            // lblProdName
            // 
            this.lblProdName.Location = new System.Drawing.Point(21, 138);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(233, 17);
            this.lblProdName.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(21, 164);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(96, 17);
            this.lblStock.TabIndex = 8;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.Location = new System.Drawing.Point(21, 190);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(96, 17);
            this.lblProdPrice.TabIndex = 9;
            // 
            // lblSellerName
            // 
            this.lblSellerName.Location = new System.Drawing.Point(3, 0);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(123, 17);
            this.lblSellerName.TabIndex = 10;
            // 
            // lblContackNum
            // 
            this.lblContackNum.Location = new System.Drawing.Point(123, 164);
            this.lblContackNum.Name = "lblContackNum";
            this.lblContackNum.Size = new System.Drawing.Size(158, 17);
            this.lblContackNum.TabIndex = 11;
            // 
            // lblBaranggay
            // 
            this.lblBaranggay.Location = new System.Drawing.Point(123, 190);
            this.lblBaranggay.Name = "lblBaranggay";
            this.lblBaranggay.Size = new System.Drawing.Size(158, 17);
            this.lblBaranggay.TabIndex = 12;
            // 
            // lblBarangay
            // 
            this.lblBarangay.Location = new System.Drawing.Point(126, 181);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(158, 17);
            this.lblBarangay.TabIndex = 13;
            this.lblBarangay.Click += new System.EventHandler(this.lblBarangay_Click);
            // 
            // btnSetOrder
            // 
            this.btnSetOrder.Location = new System.Drawing.Point(3, 240);
            this.btnSetOrder.Name = "btnSetOrder";
            this.btnSetOrder.Size = new System.Drawing.Size(278, 24);
            this.btnSetOrder.TabIndex = 14;
            this.btnSetOrder.Text = "SetOrder";
            this.btnSetOrder.UseVisualStyleBackColor = true;
            // 
            // G_ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Controls.Add(this.btnSetOrder);
            this.Controls.Add(this.lblBarangay);
            this.Controls.Add(this.lblBaranggay);
            this.Controls.Add(this.lblContackNum);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.btnContackSeller);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.picProduct);
            this.Name = "G_ProductCard";
            this.Size = new System.Drawing.Size(284, 267);
            this.Load += new System.EventHandler(this.G_ProductCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Button btnContackSeller;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblContackNum;
        private System.Windows.Forms.Label lblBaranggay;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.Button btnSetOrder;
    }
}