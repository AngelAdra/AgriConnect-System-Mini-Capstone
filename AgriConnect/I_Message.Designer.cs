namespace AgriConnect
{
    partial class I_Sender
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
            this.lblSender = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSender.Location = new System.Drawing.Point(6, 10);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(100, 14);
            this.lblSender.TabIndex = 1;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Location = new System.Drawing.Point(6, 27);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbMessage.Size = new System.Drawing.Size(226, 39);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            // 
            // I_Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.lblSender);
            this.Enabled = false;
            this.Name = "I_Sender";
            this.Size = new System.Drawing.Size(235, 69);
            this.Load += new System.EventHandler(this.I_Sender_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}
