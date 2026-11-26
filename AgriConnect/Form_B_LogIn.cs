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
    public partial class LogIn : MaterialSkin.Controls.MaterialForm
    {
        public LogIn()
        {
            InitializeComponent();
            ApplyMaterialTheme();
            this.AcceptButton = btnLogin;
        }
    

        private void ApplyMaterialTheme()
        {
            MaterialSkin.MaterialSkinManager skin = MaterialSkin.MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new MaterialSkin.ColorScheme(
                Color.FromArgb(0x2E, 0x8B, 0x57),   // primary   #2E8B57
                Color.FromArgb(0x1F, 0x6B, 0x41),   // dark primary
                Color.FromArgb(0x66, 0xBB, 0x6A),   // light     #66BB6A
                Color.FromArgb(0xF5, 0xA6, 0x23),   // accent    #F5A623
                MaterialSkin.TextShade.WHITE);
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
            Registration make = new Registration();
            make.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please fill out the Fields.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string loginUser = txtUser.Text.Trim();
            string loginPassword = txtPassword.Text;
            List<User> accounts = new List<User>();

            AddUsersFromFile<Collection>(accounts, "Collection.Json");
            AddUsersFromFile<Buyer>(accounts, "Buyer.Json");
            AddUsersFromFile<Seller>(accounts, "Sellers.Json");
            AddUsersFromFile<Dual>(accounts, "Dual.Json");

            User matchingUser = accounts.FirstOrDefault(user =>
                user.Username == loginUser &&
                PasswordSecurity.VerifyPassword(
                    loginPassword,
                    user.UserPassword));

            if (matchingUser == null)
            {
                bool accountExists = accounts.Any(user =>
                    user.Username == loginUser);

                bool needsPasswordUpdate = accounts.Any(user =>
                    user.Username == loginUser &&
                    string.IsNullOrEmpty(user.UserPassword));

                if (accountExists && needsPasswordUpdate)
                {
                    MessageBox.Show(
                        "This account uses the older password format. Reset or re-register the account.",
                        "Account Update Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Incorrect Password or User",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                return;
            }

            CurrentUser.currentUser = loginUser;
            CurrentUser.UserRole = matchingUser.UserRole;

            if (CurrentUser.UserRole == "Seller" ||
                CurrentUser.UserRole == "Dual")
            {
                SellerHub_Dashboard sellerDashboard =
                    new SellerHub_Dashboard();
                sellerDashboard.Show();
            }
            else
            {
                Patron_Dashboard buyerDashboard =
                    new Patron_Dashboard();
                buyerDashboard.Show();
            }

            this.Hide();
        }

        private static void AddUsersFromFile<T>(
            List<User> users,
            string fileName)
            where T : User
        {
            string filePath = FileGetter.GetFilePath(fileName);

            if (!File.Exists(filePath))
                return;

            List<T> records =
                JsonSerializer.Deserialize<List<T>>(File.ReadAllText(filePath))
                ?? new List<T>();

            users.AddRange(records);
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
