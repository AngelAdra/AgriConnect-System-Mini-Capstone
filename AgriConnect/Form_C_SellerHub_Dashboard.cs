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
        private Buyer currentConversationBuyer;
        private Dual currentConversationDual;

        public SellerHub_Dashboard()
        {
            InitializeComponent();
            btnSend.Click += btnSend_Click;
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
            LoadNotifications();
            listedProductBySeller.Visible = false;
        }

        private void LoadNotifications()
        {
            flpNotification.Controls.Clear();

            List<SyncMessage> messages = null;

            if (ActiveUser.UserRole == "Seller")
            {
                string path = FileGetter.GetFilePath("Sellers.Json");
                if (!File.Exists(path))
                    return;

                List<Seller> sellers =
                    JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(path))
                    ?? new List<Seller>();

                Seller seller = sellers.FirstOrDefault(user =>
                    user.Username == ActiveUser.Username);
                messages = seller == null ? null : seller.SyncMessages;
            }
            else if (ActiveUser.UserRole == "Dual")
            {
                string path = FileGetter.GetFilePath("Dual.Json");
                if (!File.Exists(path))
                    return;

                List<Dual> dualUsers =
                    JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(path))
                    ?? new List<Dual>();

                Dual dual = dualUsers.FirstOrDefault(user =>
                    user.Username == ActiveUser.Username);
                messages = dual == null ? null : dual.SyncMessages;
            }

            if (messages == null)
                return;

            List<string> shownSenders = new List<string>();

            foreach (SyncMessage message in messages)
            {
                if (message == null ||
                    message.Receiver != ActiveUser.Username ||
                    shownSenders.Contains(message.Sender))
                {
                    continue;
                }

                shownSenders.Add(message.Sender);

                Notification notification = new Notification();
                notification.SetMessage(message);
                notification.OpenRequested += Notification_OpenRequested;
                flpNotification.Controls.Add(notification);
            }
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notification_OpenRequested(object sender, EventArgs e)
        {
            Notification notification = sender as Notification;

            if (notification != null)
                OpenConversation(notification.LinkedMessage);
        }   

        private void OpenConversation(SyncMessage notificationMessage)
        {
            if (notificationMessage == null)
                return;

            string buyerPath = FileGetter.GetFilePath("Buyer.Json");

            if (File.Exists(buyerPath))
            {
                List<Buyer> buyers =
                    JsonSerializer.Deserialize<List<Buyer>>(File.ReadAllText(buyerPath))
                    ?? new List<Buyer>();

                Buyer buyer = buyers.FirstOrDefault(user =>
                    user.FullName == notificationMessage.Sender);

                if (buyer != null)
                {
                    currentConversationBuyer = buyer;
                    currentConversationDual = null;
                    flpMessage.Controls.Clear();

                    foreach (SyncMessage message in buyer.SyncMessages)
                    {
                        if (message == null)
                            continue;

                        if (message.Sender == buyer.FullName &&
                            message.Receiver == ActiveUser.Username)
                        {
                            new Message(buyer, message.MessageText, flpMessage);
                        }
                        else if (message.Sender == ActiveUser.FullName &&
                                 message.Receiver == buyer.Username)
                        {
                            new Message(ActiveUser, message.MessageText, flpMessage);
                        }
                    }

                    return;
                }
            }

            string dualPath = FileGetter.GetFilePath("Dual.Json");

            if (!File.Exists(dualPath))
                return;

            List<Dual> dualUsers =
                JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                ?? new List<Dual>();

            Dual dual = dualUsers.FirstOrDefault(user =>
                user.FullName == notificationMessage.Sender);

            if (dual == null)
                return;

            currentConversationBuyer = null;
            currentConversationDual = dual;
            flpMessage.Controls.Clear();

            foreach (SyncMessage message in dual.SyncMessages)
            {
                if (message == null)
                    continue;

                if (message.Sender == dual.FullName &&
                    message.Receiver == ActiveUser.Username)
                {
                    new Message(dual, message.MessageText, flpMessage);
                }
                else if (message.Sender == ActiveUser.FullName &&
                         message.Receiver == dual.Username)
                {
                    new Message(ActiveUser, message.MessageText, flpMessage);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = rtbMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
                return;

            if (currentConversationDual != null)
            {
                if (!SaveDualReply(text))
                {
                    MessageBox.Show("The reply could not be saved.");
                    return;
                }
            }
            else if (currentConversationBuyer != null)
            {
                if (!SaveSellerReply(text))
                {
                    MessageBox.Show("The reply could not be saved.");
                    return;
                }
            }
            else if (ActiveUser.UserRole == "Dual" &&
                     Message.SaveToSync(ActiveUser, text))
            {
                // Continues the Dual-initiated Seller conversation.
            }
            else
            {
                MessageBox.Show("Open a conversation before sending a reply.");
                return;
            }

            new Message(ActiveUser, text, flpMessage);
            rtbMessage.Clear();
        }

        private bool SaveSellerReply(string text)
        {
            string buyerPath = FileGetter.GetFilePath("Buyer.Json");

            if (!File.Exists(buyerPath))
                return false;

            List<Buyer> buyers =
                JsonSerializer.Deserialize<List<Buyer>>(File.ReadAllText(buyerPath))
                ?? new List<Buyer>();

            Buyer buyer = buyers.FirstOrDefault(user =>
                user.Username == currentConversationBuyer.Username);

            if (buyer == null)
                return false;

            if (buyer.SyncMessages == null)
                buyer.SyncMessages = new List<SyncMessage>();

            SyncMessage reply = new SyncMessage(
                ActiveUser.FullName,
                buyer.Username,
                text.Trim());

            if (ActiveUser.UserRole == "Seller")
            {
                string sellerPath = FileGetter.GetFilePath("Sellers.Json");

                if (!File.Exists(sellerPath))
                    return false;

                List<Seller> sellers =
                    JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(sellerPath))
                    ?? new List<Seller>();

                Seller seller = sellers.FirstOrDefault(user =>
                    user.Username == ActiveUser.Username);

                if (seller == null)
                    return false;

                if (seller.SyncMessages == null)
                    seller.SyncMessages = new List<SyncMessage>();

                seller.SyncMessages.Add(reply);

                File.WriteAllText(
                    sellerPath,
                    JsonSerializer.Serialize(sellers, new JsonSerializerOptions { WriteIndented = true }));
            }
            else if (ActiveUser.UserRole == "Dual")
            {
                string dualPath = FileGetter.GetFilePath("Dual.Json");

                if (!File.Exists(dualPath))
                    return false;

                List<Dual> dualUsers =
                    JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                    ?? new List<Dual>();

                Dual dual = dualUsers.FirstOrDefault(user =>
                    user.Username == ActiveUser.Username);

                if (dual == null)
                    return false;

                if (dual.SyncMessages == null)
                    dual.SyncMessages = new List<SyncMessage>();

                dual.SyncMessages.Add(reply);

                File.WriteAllText(
                    dualPath,
                    JsonSerializer.Serialize(dualUsers, new JsonSerializerOptions { WriteIndented = true }));
            }
            else
            {
                return false;
            }

            buyer.SyncMessages.Add(reply);

            File.WriteAllText(
                buyerPath,
                JsonSerializer.Serialize(buyers, new JsonSerializerOptions { WriteIndented = true }));

            return true;
        }

        private bool SaveDualReply(string text)
        {
            if (ActiveUser.UserRole != "Seller" || currentConversationDual == null)
                return false;

            string dualPath = FileGetter.GetFilePath("Dual.Json");
            string sellerPath = FileGetter.GetFilePath("Sellers.Json");

            if (!File.Exists(dualPath) || !File.Exists(sellerPath))
                return false;

            List<Dual> dualUsers =
                JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                ?? new List<Dual>();

            List<Seller> sellers =
                JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(sellerPath))
                ?? new List<Seller>();

            Dual dual = dualUsers.FirstOrDefault(user =>
                user.Username == currentConversationDual.Username);

            Seller seller = sellers.FirstOrDefault(user =>
                user.Username == ActiveUser.Username);

            if (dual == null || seller == null)
                return false;

            if (dual.SyncMessages == null)
                dual.SyncMessages = new List<SyncMessage>();

            if (seller.SyncMessages == null)
                seller.SyncMessages = new List<SyncMessage>();

            SyncMessage reply = new SyncMessage(
                seller.FullName,
                dual.Username,
                text.Trim());

            dual.SyncMessages.Add(reply);
            seller.SyncMessages.Add(reply);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            File.WriteAllText(dualPath, JsonSerializer.Serialize(dualUsers, options));
            File.WriteAllText(sellerPath, JsonSerializer.Serialize(sellers, options));

            return true;
        }
    }
}
