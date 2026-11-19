using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{
    public partial class E_LogIn : Form
    {
        public E_LogIn()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }
    

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            D_Registration make = new D_Registration();
            make.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill out the Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string LoginUser = txtUser.Text.Trim();
            string LogInPassword = txtPassword.Text.Trim();


            List<Collection> Collected = new List<Collection>();
            string getFile = C_Global_Variable.GetFilePath("Collection.Json");
            if (!File.Exists(getFile))
            {
                MessageBox.Show("No such account please create one to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string getJson = File.ReadAllText(getFile);



            Collected = JsonSerializer.Deserialize<List<Collection>>(getJson) ?? new List<Collection>();
            bool isValid = false;
            CurrentUser.currentUser = LoginUser;


            foreach (Collection user in Collected)
            {
                if (user.Username == LoginUser && user.UserPassword == LogInPassword)
                {
                    CurrentUser.UserRole = user.UserRole;
                    isValid = true;
                    break;
                }
            }


            if (isValid)
            {
                if (CurrentUser.UserRole == "Seller" || CurrentUser.UserRole == "Dual")
                {
                    F_Seller_Dual_Dashboard make_Seller_Dashboard = new F_Seller_Dual_Dashboard();
                    make_Seller_Dashboard.Show();
                   
                    this.Hide();
                }
                else
                {
                    G_Buyer_Dashboard make_Buyer_Dashboard = new G_Buyer_Dashboard();
                    make_Buyer_Dashboard.Show();
                   
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Incorrect Password or User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
               
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
