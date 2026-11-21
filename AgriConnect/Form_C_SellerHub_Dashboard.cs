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
    public partial class SellerHub_Dashboard : Form
    {
        public SellerHub_Dashboard()
        {
            InitializeComponent();

        }
        private string selectedImagePath = "";
        private User ActiveUser = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);
        private static market reOpen = new market();

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (ActiveUser.UserRole == "Seller")
                btnMarket.Text = "View Market";

            Collection active = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);
            txtUser.Text = $"User: {active.Username}";
            txtFullName.Text = $"Name: {active.FullName}";
            txtPhoneNumber.Text = $"Phone Number: {active.PhoneNumber}";
            txtRole.Text = $"Role: {active.UserRole}";



            RefreshSellerListedProduct();

            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);
            listedProductBySeller.Visible = false;
        }




        internal void RefreshSellerListedProduct()
        {
            BindingList<SellerProducts> bind = new BindingList<SellerProducts>();
            if (ActiveUser.UserRole == "Seller")
            {

                List<Seller> seller = new List<Seller>();
                string getJson = FileGetter.GetFilePath("Sellers.Json");
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
                string getJson = FileGetter.GetFilePath("Dual.Json");
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



            SelfBuiltEngine.SaveListTo(ActiveUser, productName, stock, price, tempPN, selectedImagePath);
            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);

            txtProductName.Clear();
            txtProductStock.Clear();
            txtProductPrice.Clear();
            selectedImagePath = "";

            RefreshSellerListedProduct();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
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

            SelfBuiltEngine.Delist(delist, ActiveUser);
            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);
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





        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (listedProductBySeller.Visible == true)
            {
                listedProductBySeller.Visible = false;
                flpSearch.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(txtSearchFilter.Text))
                return;

            string prod = txtSearchFilter.Text.Trim();

            SelfBuiltEngine.filterSearch(prod, flpSearch, ActiveUser, pMessage, flpMessage);
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }


}
