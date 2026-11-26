using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgriConnect
{
    public partial class Registration : MaterialSkin.Controls.MaterialForm
    {
        public Registration()
        {
            InitializeComponent();
            ApplyMaterialTheme();
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnaCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(cmbOptions.Text) || string.IsNullOrEmpty(txtPN.Text))
            {
                MessageBox.Show("Please fill out the Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            string user = txtUser.Text.Trim();
            string FullName = txtFullName.Text.Trim();
            string Password = txtPassword.Text;

            if (Password.Length < 8 || !Password.All(char.IsLetterOrDigit))
            {
                MessageBox.Show(
                    "Password must be at least 8 characters and contain only letters and digits.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string PhoneNumber = txtPN.Text.Trim();
            string option = cmbOptions.Text.Trim();
            string Barangay = cmbBarangay.Text.Trim();
            bool hasDigit = Password.Any(char.IsDigit);
            bool hasLetter = Password.Any(char.IsLetter);

            if(!hasDigit || !hasLetter)
            {
                MessageBox.Show("Your Password should be alphanumeric.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (PhoneNumber.Length <= 10)
            {
                MessageBox.Show("Your Number should be 11 digits", " Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (option)
            {
                case "Seller":
                    
                    string SellerFilePath = FileGetter.GetFilePath("Sellers.Json");
                    List<Seller> sellerList = new List<Seller>();

                    if (File.Exists(SellerFilePath))
                    {
                        string existingJson = File.ReadAllText(SellerFilePath);
                        sellerList = JsonSerializer.Deserialize<List<Seller>>(existingJson);
                    }


                    Seller newSeller = new Seller(FullName, user, Password, option, PhoneNumber, Barangay);
                    sellerList.Add(newSeller);

                    string SellerOutput = JsonSerializer.Serialize(sellerList, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(SellerFilePath, SellerOutput);

                    


                    MessageBox.Show("Registered as Seller");
                    break;

                case "Buyer":
                    
                    string BuyerFilePath = FileGetter.GetFilePath("Buyer.Json");

                    List<Buyer> BuyerList = new List<Buyer>();

                    if (File.Exists(BuyerFilePath))
                    {
                        string existingJson = File.ReadAllText(BuyerFilePath);
                        BuyerList = JsonSerializer.Deserialize<List<Buyer>>(existingJson);
                    }

                    Buyer newBuyer = new Buyer(FullName, user, Password, option, PhoneNumber, Barangay);
                    BuyerList.Add(newBuyer);

                    string BuyerOutput = JsonSerializer.Serialize(BuyerList, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(BuyerFilePath, BuyerOutput);

                    
                    MessageBox.Show("Registered as Buyer");
                    break;

                case "Dual":
                    
                    string DualFilePath = FileGetter.GetFilePath("Dual.Json");

                    List<Dual> DualList = new List<Dual>();

                    if (File.Exists(DualFilePath))
                    {
                        string existingJson = File.ReadAllText(DualFilePath);
                        DualList = JsonSerializer.Deserialize<List<Dual>>(existingJson);
                    }

                    Dual newDual = new Dual(FullName, user, Password, option, PhoneNumber, Barangay);
                    DualList.Add(newDual);

                    string DualOutput = JsonSerializer.Serialize(DualList, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(DualFilePath, DualOutput);

                    MessageBox.Show("Registered as Dual");
                    break;
            }

            string ProjectRoot = FileGetter.ProjectRoot;
            string CollectionFilePath = FileGetter.GetFilePath("Collection.Json");
            List<Collection> CollectionList = new List<Collection>();

            if (File.Exists(CollectionFilePath))
            {
                string existingJson = File.ReadAllText(CollectionFilePath);
                CollectionList = JsonSerializer.Deserialize<List<Collection>>(existingJson);
            }

            Collection newCollection = new Collection(FullName, user, Password, option, PhoneNumber, Barangay);
            CollectionList.Add(newCollection);

            String CollectionOutput = JsonSerializer.Serialize(CollectionList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(CollectionFilePath, CollectionOutput);


            txtUser.Clear();
            txtPN.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
            cmbOptions.SelectedIndex = -1;
            cmbBarangay.SelectedIndex = -1;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LogIn back = new LogIn();
            this.Dispose();
            back.Show();
        }

        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFullName.Focus();
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPN.Focus();
        }

        private void txtPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
