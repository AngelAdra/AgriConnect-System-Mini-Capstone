namespace AgriConnect
{
    partial class market
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(market));
            this.flpMarket = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMarket
            // 
            this.flpMarket.AutoScroll = true;
            this.flpMarket.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMarket.Location = new System.Drawing.Point(12, 82);
            this.flpMarket.Name = "flpMarket";
            this.flpMarket.Size = new System.Drawing.Size(753, 356);
            this.flpMarket.TabIndex = 4;
            this.flpMarket.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMarket_Paint);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(677, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 32);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.flpMarket);
            this.Name = "market";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMarket;
        private System.Windows.Forms.Button btnReturn;
    }
}