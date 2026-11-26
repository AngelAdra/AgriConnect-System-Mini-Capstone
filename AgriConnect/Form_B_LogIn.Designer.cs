namespace AgriConnect
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblBrand = new MaterialSkin.Controls.MaterialLabel();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(60, 204);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(340, 29);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(60, 276);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(340, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.DrawShadows = true;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Location = new System.Drawing.Point(60, 332);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(340, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Depth = 0;
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label1.Location = new System.Drawing.Point(60, 176);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.Depth = 0;
            this.label2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label2.Location = new System.Drawing.Point(60, 248);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = false;
            this.lblCreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(107)))), ((int)(((byte)(65)))));
            this.lblCreateAcc.Location = new System.Drawing.Point(60, 398);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(340, 20);
            this.lblCreateAcc.TabIndex = 5;
            this.lblCreateAcc.Text = "Doesn\'t Have an account? Create one here";
            this.lblCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateAcc.Click += new System.EventHandler(this.lblCreateAcc_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = false;
            this.lblBrand.Depth = 0;
            this.lblBrand.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblBrand.Location = new System.Drawing.Point(60, 88);
            this.lblBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(340, 36);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "AgriConnect";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
            this.lblWelcome.Location = new System.Drawing.Point(60, 126);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(340, 24);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Sign in to continue";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCreateAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Page";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.Label lblCreateAcc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialLabel lblBrand;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
    }
}
