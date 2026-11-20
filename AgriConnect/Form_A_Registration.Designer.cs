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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbBarangay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(217, 185);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(183, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(451, 185);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cmbOptions
            // 
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Items.AddRange(new object[] {
            "Seller",
            "Buyer",
            "Dual"});
            this.cmbOptions.Location = new System.Drawing.Point(217, 294);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(183, 21);
            this.cmbOptions.TabIndex = 3;
            this.cmbOptions.SelectedIndexChanged += new System.EventHandler(this.cmbOptions_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Ivory;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreate.FlatAppearance.BorderSize = 10;
            this.btnCreate.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(323, 336);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(195, 30);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnaCreate_Click);
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(451, 239);
            this.txtPN.MaxLength = 11;
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(183, 20);
            this.txtPN.TabIndex = 5;
            this.txtPN.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            this.txtPN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPN_KeyDown);
            this.txtPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPN_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Ivory;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(360, 381);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 29);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbBarangay
            // 
            this.cmbBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbBarangay.Location = new System.Drawing.Point(451, 294);
            this.cmbBarangay.Name = "cmbBarangay";
            this.cmbBarangay.Size = new System.Drawing.Size(183, 21);
            this.cmbBarangay.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(226, 278);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(31, 15);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "PhoneNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Barangay";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(217, 239);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(183, 20);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 501);
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
            this.Name = "Registration";
            this.Text = "Registry";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbOptions;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbBarangay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label6;
    }
}