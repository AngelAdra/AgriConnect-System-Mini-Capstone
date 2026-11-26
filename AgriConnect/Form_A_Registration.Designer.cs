namespace AgriConnect
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbOptions = new System.Windows.Forms.ComboBox();
            this.btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.btnReturn = new MaterialSkin.Controls.MaterialButton();
            this.cmbBarangay = new System.Windows.Forms.ComboBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(40, 158);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 29);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(270, 228);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cmbOptions
            // 
            this.cmbOptions.BackColor = System.Drawing.Color.White;
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Items.AddRange(new object[] {
            "Seller",
            "Buyer",
            "Dual"});
            this.cmbOptions.Location = new System.Drawing.Point(40, 298);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(210, 29);
            this.cmbOptions.TabIndex = 3;
            this.cmbOptions.SelectedIndexChanged += new System.EventHandler(this.cmbOptions_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = false;
            this.btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreate.Depth = 0;
            this.btnCreate.DrawShadows = true;
            this.btnCreate.HighEmphasis = true;
            this.btnCreate.Location = new System.Drawing.Point(40, 356);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(440, 44);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreate.UseAccentColor = false;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnaCreate_Click);
            // 
            // txtPN
            // 
            this.txtPN.BackColor = System.Drawing.Color.White;
            this.txtPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPN.Location = new System.Drawing.Point(270, 158);
            this.txtPN.MaxLength = 11;
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(210, 29);
            this.txtPN.TabIndex = 5;
            this.txtPN.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            this.txtPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPN_KeyDown);
            this.txtPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPN_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = false;
            this.btnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReturn.Depth = 0;
            this.btnReturn.DrawShadows = true;
            this.btnReturn.HighEmphasis = true;
            this.btnReturn.Location = new System.Drawing.Point(40, 412);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(440, 36);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReturn.UseAccentColor = true;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbBarangay
            // 
            this.cmbBarangay.BackColor = System.Drawing.Color.White;
            this.cmbBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarangay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarangay.FormattingEnabled = true;
            this.cmbBarangay.Items.AddRange(new object[] {
            "Allang",
            "Oma-Oma",
            "Malama",
            "Paulba",
            "Tastas",
            "Macalidong",
            "Busac",
            "Palapas",
            "Abella",
            "Bacong"});
            this.cmbBarangay.Location = new System.Drawing.Point(270, 298);
            this.cmbBarangay.Name = "cmbBarangay";
            this.cmbBarangay.Size = new System.Drawing.Size(210, 29);
            this.cmbBarangay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Depth = 0;
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // lbl
            // 
            this.lbl.AutoSize = false;
            this.lbl.Depth = 0;
            this.lbl.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lbl.Location = new System.Drawing.Point(40, 274);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(210, 22);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.Depth = 0;
            this.label3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label3.Location = new System.Drawing.Point(40, 204);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.Depth = 0;
            this.label4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label4.Location = new System.Drawing.Point(270, 134);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "PhoneNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = false;
            this.label5.Depth = 0;
            this.label5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label5.Location = new System.Drawing.Point(270, 274);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Barangay";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(40, 228);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(210, 29);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = false;
            this.label6.Depth = 0;
            this.label6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.label6.Location = new System.Drawing.Point(270, 204);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Depth = 0;
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.Location = new System.Drawing.Point(40, 84);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 36);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Create your account";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBarangay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbOptions);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbOptions;
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private System.Windows.Forms.TextBox txtPN;
        private MaterialSkin.Controls.MaterialButton btnReturn;
        private System.Windows.Forms.ComboBox cmbBarangay;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label5;
        private System.Windows.Forms.TextBox txtFullName;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
    }
}
