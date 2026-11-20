using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{
    public partial class Patron_Dashboard : Form
    {
        public Patron_Dashboard()
        {
            InitializeComponent();
        }

        private static market reOpen = new market();
        private User ActiveUser = ActiveUserHelper.activeHelper(CurrentUser.currentUser);
        

        private void G_Buyer_Dashboard_Load(object sender, EventArgs e)
        {
            Collection active = ActiveUserHelper.activeHelper(CurrentUser.currentUser);
            txtUser.Text = $"User: {active.Username}";
            txtFullName.Text = $"Name: {active.FullName}";
            txtPhoneNumber.Text = $"Phone Number: {active.PhoneNumber}";
            txtRole.Text = $"Role: {active.UserRole}";
            loadSearch();
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
                if (prod.productName.ToLower().Contains(product.ToLower()) ||
                    (prod.MarketSeller.ToLower().Contains(product.ToLower())) ||
                    (prod.barangay.ToLower().Contains(product.ToLower())) ||
                    (prod.MarketPhoneNumber.ToLower().Contains(product.ToLower())))
                {
                    User receive = ActiveUserHelper.activeHelper(prod.MarketSeller);
                    ActiveUserHelper.getUser(receive);

                    ProductCard set = new ProductCard(
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

        private void reload() {

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
                User receive = ActiveUserHelper.activeHelper(display.MarketSeller);
                ActiveUserHelper.getUser(receive);


                ProductCard card = new ProductCard(
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




        private void txtPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn open = new LogIn();
            reOpen.Dispose();
            open.Show();
            this.Dispose();
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

        private void G_Buyer_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtSearchFilter.Text))
                return;

            string prod = txtSearchFilter.Text.Trim();
            filterSearch(prod);
        }

        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void flpSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            loadSearch();
            txtSearchFilter.Clear();
        }

        private void flpMessage_Paint(object sender, PaintEventArgs e)
        {

        }
        //FixBUgTom

        private void btnSend_Click(object sender, EventArgs e)
        {
            string getMessage = rtbMessage.Text.Trim();
            Message display = new Message(getMessage, flpMessage);
            
        }

        private void pMessage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
