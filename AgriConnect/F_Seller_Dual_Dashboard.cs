using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using System.Drawing.Text;

namespace AgriConnect
{
    public partial class F_Seller_Dual_Dashboard : Form
    {
        public F_Seller_Dual_Dashboard()
        {
            InitializeComponent();

        }
        private string selectedImagePath = "";
        private AQ_User ActiveUser = ActiveUserHelper.activeHelper(CurrentUser.currentUser);
        private static market reOpen = new market();

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (ActiveUser.UserRole == "Seller")
                btnMarket.Text = "View Market";
            
                Collection active = ActiveUserHelper.activeHelper(CurrentUser.currentUser);
            txtUser.Text = $"User: {active.Username}";
            txtFullName.Text = $"Name: {active.FullName}";
            txtPhoneNumber.Text = $"Phone Number: {active.PhoneNumber}";
            txtRole.Text = $"Role: {active.UserRole}";


           
            RefreshSellerListedProduct();
            loadSearch();
            listedProductBySeller.Visible = false;
        }

        


        internal void RefreshSellerListedProduct()
        {
            BindingList<SellerProducts> bind = new BindingList<SellerProducts>();
            if (ActiveUser.UserRole == "Seller")
            {

                List<Seller> seller = new List<Seller>();
                string getJson = C_Global_Variable.GetFilePath("Sellers.Json");
                if (!File.Exists(getJson))
                    return;
                
                string readFile = File.ReadAllText(getJson);
                seller = JsonSerializer.Deserialize<List<Seller>>(readFile);

                foreach (Seller get in seller)
                {
                    if (get.Username == ActiveUser.Username)
                    {
                        bind = new BindingList<SellerProducts>(get.MyProducts);
                        break;
                    }

                }
                listedProductBySeller.DataSource = bind;
            }
            else if (ActiveUser.UserRole == "Dual")
            {

                List<Dual> dual = new List<Dual>();
                string getJson = C_Global_Variable.GetFilePath("Dual.Json");
                if (!File.Exists(getJson))
                {
                    MessageBox.Show("file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string readFile = File.ReadAllText(getJson);
                dual = JsonSerializer.Deserialize<List<Dual>>(readFile);

                foreach (Dual get in dual)
                {
                    if (get.Username == ActiveUser.Username)
                    {
                        bind = new BindingList<SellerProducts>(get.MyProducts);
                        break;
                    }
                }
                listedProductBySeller.DataSource = bind;
            }
        }



        private void txtProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
        string.IsNullOrWhiteSpace(txtProductStock.Text) ||
        string.IsNullOrWhiteSpace(txtProductPrice.Text))
            {
                MessageBox.Show("Please fill out all fields!");
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please double-click the picture box to select a product image first!", "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = txtProductName.Text.Trim();
            int stock = Convert.ToInt32(txtProductStock.Text.Trim());
            double price = Convert.ToDouble(txtProductPrice.Text.Trim());

            List<SellerProducts> TempList = new List<SellerProducts>();


            string tempPN = ActiveUser.PhoneNumber;



            ActiveUserHelper.SaveListTo(ActiveUser, productName, stock, price, tempPN, selectedImagePath);
            loadSearch();

            txtProductName.Clear();
            txtProductStock.Clear();
            txtProductPrice.Clear();
            selectedImagePath = "";
            
            RefreshSellerListedProduct();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            E_LogIn login = new E_LogIn();
            reOpen.Dispose();
            login.Show();
            this.Dispose();
        }



        private void picProductPreview_Click(object sender, EventArgs e)
        {

        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Product Image";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                picProduct.Image = Image.FromFile(selectedImagePath);
                picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDelist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please Enter your product to Delist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string delist = txtProductName.Text.Trim();

            ActiveUserHelper.Delist(delist, ActiveUser);
            loadSearch();
            txtProductName.Clear();
            RefreshSellerListedProduct();


        }

        
        private void btnMarket_Click(object sender, EventArgs e)
        {
            if (reOpen == null || reOpen.IsDisposed)
            {
                reOpen = new market(ActiveUser, pMessage, flpMessage);
                reOpen.Show();
            }
            else
            {

                if (reOpen.WindowState == FormWindowState.Minimized)
                {
                    reOpen.WindowState = FormWindowState.Normal;
                }


                reOpen.Show();
                reOpen.Activate();
            }
        }

        private void F_Seller_Dual_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reOpen != null && !reOpen.IsDisposed)
            {
                DialogResult res = MessageBox.Show("closing this window will close the market too are you sure?", "Confirm Close", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void filterSearch(string product)
        {


            reload();

            string get = C_Global_Variable.GetFilePath("MarketListing.Json");

            if (!File.Exists(get))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string readJson = File.ReadAllText(get);
            List<MarketplaceListings> list = new List<MarketplaceListings>();
            list = JsonSerializer.Deserialize<List<MarketplaceListings>>(readJson);
            

            foreach (var prod in list)
            {
                if (prod.productName.ToLower().Contains(product.ToLower())||
                    (prod.MarketSeller.ToLower().Contains(product.ToLower())) ||
                    (prod.barangay.ToLower().Contains(product.ToLower()))||
                    (prod.MarketPhoneNumber.ToLower().Contains(product.ToLower())))
                {
                    AQ_User receive = ActiveUserHelper.activeHelper(prod.MarketSeller);
                    ActiveUserHelper.getUser(receive);


                    G_ProductCard set = new G_ProductCard(
                        prod.productName,
                        prod.productStock,
                        prod.productPrice,
                        prod.MarketSeller,
                        prod.MarketPhoneNumber,
                        prod.ImagePath,
                        prod.barangay,
                        ActiveUser,
                        pMessage,
                        flpMessage,
                        receive
                        );
                    flpSearch.Controls.Add(set);
                }
            }
            if (flpSearch.Controls.Count == 0)
            {
                MessageBox.Show("Product Not Found ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSearch();
            }
        }

        private void reload()
        {

            if (flpSearch.Controls.Count == 0)
                return;

            while (flpSearch.Controls.Count > 0)
            {
                Control card = flpSearch.Controls[0];
                flpSearch.Controls.Remove(card);
                card.Dispose();

            }
        }
        
        private void loadSearch()
        {
            flpSearch.SuspendLayout();

            string get = C_Global_Variable.GetFilePath("MarketListing.Json");

            if (!File.Exists(get))
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string readJson = File.ReadAllText(get);
            List<MarketplaceListings> list = new List<MarketplaceListings>();
            list = JsonSerializer.Deserialize<List<MarketplaceListings>>(readJson);
            foreach (var display in list)
            {
                AQ_User receive = ActiveUserHelper.activeHelper(display.MarketSeller);
                ActiveUserHelper.getUser(receive);

                G_ProductCard card = new G_ProductCard(
                    display.productName,
                    display.productStock,
                    display.productPrice,
                    display.MarketSeller,
                    display.MarketPhoneNumber,
                    display.ImagePath,
                    display.barangay,
                    ActiveUser,
                    pMessage,
                    flpMessage,
                    receive
                    );
                flpSearch.Controls.Add(card);
                
            }
            flpSearch.ResumeLayout();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(listedProductBySeller.Visible == true)
            {
                listedProductBySeller.Visible = false;
                flpSearch.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(txtSearchFilter.Text))
                return;

            string prod = txtSearchFilter.Text.Trim();
            
            filterSearch(prod);
        }

        private void MarketPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMyProducts_Click(object sender, EventArgs e)
        {
            flpSearch.SuspendLayout();
            listedProductBySeller.Visible = true;
            flpSearch.Visible = false;
            flpSearch.ResumeLayout();
        }

       

        private void lblQuickSearch_Click(object sender, EventArgs e)
        {
            flpSearch.SuspendLayout();
            flpSearch.Visible = true;
            listedProductBySeller.Visible = false;
            flpSearch.ResumeLayout();
        }

        private void listedProductBySeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
