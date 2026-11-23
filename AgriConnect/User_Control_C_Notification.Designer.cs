namespace AgriConnect
{
    partial class Notification
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
            this.lblNotif = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotif
            // 
            this.lblNotif.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblNotif.Location = new System.Drawing.Point(3, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(189, 56);
            this.lblNotif.TabIndex = 0;
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotif.Click += new System.EventHandler(this.lblNotif_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(198, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(89, 29);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(198, 27);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(89, 29);
            this.btnOption.TabIndex = 2;
            this.btnOption.Text = "Done/Discard";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblNotif);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(290, 57);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOption;
    }
}
