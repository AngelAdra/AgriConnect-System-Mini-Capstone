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
    public partial class SellerHub_Dashboard : MaterialSkin.Controls.MaterialForm
    {
        private Buyer currentConversationBuyer;
        private Dual currentConversationDual;

        public SellerHub_Dashboard()
        {
            InitializeComponent();
            ApplyMaterialTheme();
            btnSend.Click += btnSend_Click;
            SelfBuiltEngine.OrderPlaced += Dashboard_OrderPlaced;
            FormClosed += Dashboard_FormClosed;
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

        private string selectedImagePath = "";
        private User ActiveUser = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Collection active = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);
            txtUser.Text = $"User: {active.Username}";
            txtFullName.Text = $"Name: {active.FullName}";
            txtPhoneNumber.Text = $"Phone Number: {active.PhoneNumber}";
            txtRole.Text = $"Role: {active.UserRole}";



            RefreshSellerListedProduct();

            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);
            LoadNotifications();
            LoadSellerOrderOutput();
            listedProductBySeller.Visible = false;
        }

        private void LoadSellerOrderOutput()
        {
            rtbDashboardOrder.Clear();
            rtbDashboardOrder.ReadOnly = true;

            string path = FileGetter.GetFilePath("Orders.Json");
            if (!File.Exists(path))
            {
                rtbDashboardOrder.AppendText("========== ORDERS RECEIVED ==========\r\nNo orders received yet.\r\n");
                return;
            }

            List<ProductOrder> orders =
                JsonSerializer.Deserialize<List<ProductOrder>>(File.ReadAllText(path))
                ?? new List<ProductOrder>();

            List<ProductOrder> receivedOrders = orders.Where(item =>
                item.SellerUsername == ActiveUser.Username).ToList();

            rtbDashboardOrder.AppendText("========== ORDERS RECEIVED ==========\r\n");
            if (receivedOrders.Count == 0)
            {
                rtbDashboardOrder.AppendText("No orders received yet.\r\n");
                return;
            }

            for (int i = 0; i < receivedOrders.Count; i++)
            {
                ProductOrder order = receivedOrders[i];
                rtbDashboardOrder.AppendText(
                    $"Order #{i + 1}\r\n--------------------------------------\r\n" +
                    $"Buyer: {order.BuyerName}\r\nProduct: {order.ProductName}\r\n" +
                    $"Quantity: {order.Quantity}\r\nUnit price: {order.UnitPrice:C2}\r\n" +
                    $"Total: {order.Total:C2}\r\nPlaced: {order.OrderedAt:g}\r\n" +
                    "======================================\r\n\r\n");
            }
        }

        private void Dashboard_OrderPlaced(ProductOrder order)
        {
            if (order != null && order.SellerUsername == ActiveUser.Username)
                LoadSellerOrderOutput();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelfBuiltEngine.OrderPlaced -= Dashboard_OrderPlaced;
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
