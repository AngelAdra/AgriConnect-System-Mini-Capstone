namespace AgriConnect
{
    partial class K_Notification
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
            this.lblNotif.Location = new System.Drawing.Point(3, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(189, 56);
            this.lblNotif.TabIndex = 0;
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // K_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblNotif);
            this.Name = "K_Notification";
            this.Size = new System.Drawing.Size(290, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOption;
    }
}
