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
        private User ActiveUser = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);
        private Seller currentConversationSeller;
        private User currentConversationReceiver;

        private void G_Buyer_Dashboard_Load(object sender, EventArgs e)
        {
            Collection active = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);
            txtUser.Text = $"User: {active.Username}";
            txtFullName.Text = $"Name: {active.FullName}";
            txtPhoneNumber.Text = $"Phone Number: {active.PhoneNumber}";
            txtRole.Text = $"Role: {active.UserRole}";
            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);
            LoadBuyerNotifications();
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

            SelfBuiltEngine.filterSearch(prod, flpSearch, ActiveUser, pMessage, flpMessage);
        }

        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);

            txtSearchFilter.Clear();
        }
        //FixBUgTom
        //CLEAN READY TO COMMIT
        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = rtbMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
                return;

            if (currentConversationSeller != null)
            {
                Buyer buyer = LoadBuyerRecord();

                if (buyer == null ||
                    !buyer.SendTo(currentConversationSeller.Username, text))
                {
                    MessageBox.Show("The reply could not be saved.");
                    return;
                }

                new Message(ActiveUser, text, flpMessage);
                rtbMessage.Clear();
                return;
            }

            if (currentConversationReceiver != null)
            {
                Buyer buyer = LoadBuyerRecord();

                if (buyer == null ||
                    !buyer.SendTo(
                        currentConversationReceiver.Username,
                        text,
                        currentConversationReceiver.UserRole))
                {
                    MessageBox.Show("The reply could not be saved.");
                    return;
                }

                new Message(ActiveUser, text, flpMessage);
                rtbMessage.Clear();
                return;
            }

            if (!Message.SaveToSync(ActiveUser, text))
            {
                MessageBox.Show("The message could not be saved.");
                return;
            }

            new Message(ActiveUser, text, flpMessage);
            rtbMessage.Clear();
        }

        private Buyer LoadBuyerRecord()
        {
            string path = FileGetter.GetFilePath("Buyer.Json");

            if (!File.Exists(path))
                return null;

            List<Buyer> buyers =
                JsonSerializer.Deserialize<List<Buyer>>(File.ReadAllText(path))
                ?? new List<Buyer>();

            return buyers.FirstOrDefault(buyer =>
                buyer.Username == ActiveUser.Username);
        }

        private Seller LoadSellerByFullName(string fullName)
        {
            string path = FileGetter.GetFilePath("Sellers.Json");

            if (!File.Exists(path))
                return null;

            List<Seller> sellers =
                JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(path))
                ?? new List<Seller>();

            return sellers.FirstOrDefault(seller =>
                seller.FullName == fullName);
        }

        private void LoadBuyerNotifications()
        {
            flowLayoutPanel1.Controls.Clear();

            Buyer buyer = LoadBuyerRecord();

            if (buyer == null || buyer.SyncMessages == null)
                return;

            List<string> shownSellers = new List<string>();

            foreach (SyncMessage message in buyer.SyncMessages)
            {
                if (message == null ||
                    message.Receiver != buyer.Username ||
                    shownSellers.Contains(message.Sender))
                {
                    continue;
                }

                shownSellers.Add(message.Sender);

                Notification notification = new Notification();
                notification.SetMessage(message);
                notification.OpenRequested += BuyerNotification_OpenRequested;
                notification.DiscardRequested += BuyerNotification_DiscardRequested;
                flowLayoutPanel1.Controls.Add(notification);
            }
        }

        private void BuyerNotification_OpenRequested(object sender, EventArgs e)
        {
            Notification notification = sender as Notification;

            if (notification != null)
                OpenBuyerConversation(notification.LinkedMessage);
        }

        private void OpenBuyerConversation(SyncMessage notificationMessage)
        {
            if (notificationMessage == null)
                return;

            Buyer buyer = LoadBuyerRecord();
            User receiver = LoadReceiverByFullName(notificationMessage.Sender);

            if (buyer == null || receiver == null || buyer.SyncMessages == null)
                return;

            currentConversationReceiver = receiver;
            flpMessage.Controls.Clear();

            foreach (SyncMessage message in buyer.SyncMessages)
            {
                if (message == null)
                    continue;

                bool buyerSent = message.Sender == buyer.FullName &&
                                 message.Receiver == receiver.Username;

                bool receiverSent = message.Sender == receiver.FullName &&
                                    message.Receiver == buyer.Username;

                if (buyerSent)
                    new Message(buyer, message.MessageText, flpMessage);
                else if (receiverSent)
                    new Message(receiver, message.MessageText, flpMessage);
            }
        }

        private void BuyerNotification_DiscardRequested(object sender, EventArgs e)
        {
            Notification notification = sender as Notification;

            if (notification == null)
                return;

            DialogResult result = MessageBox.Show(
                "Delete this conversation from both accounts?",
                "Discard Conversation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            if (DeleteBuyerConversation(notification.LinkedMessage))
            {
                currentConversationSeller = null;
                flpMessage.Controls.Clear();
                LoadBuyerNotifications();
            }
        }

        private bool DeleteBuyerConversation(SyncMessage notificationMessage)
        {
            if (notificationMessage == null)
                return false;

            Buyer buyer = LoadBuyerRecord();
            Seller seller = LoadSellerByFullName(notificationMessage.Sender);

            if (buyer == null || seller == null ||
                buyer.SyncMessages == null || seller.SyncMessages == null)
            {
                return false;
            }

            buyer.SyncMessages.RemoveAll(message =>
                IsBuyerConversationMessage(message, buyer, seller));

            seller.SyncMessages.RemoveAll(message =>
                IsBuyerConversationMessage(message, buyer, seller));

            string buyerPath = FileGetter.GetFilePath("Buyer.Json");
            string sellerPath = FileGetter.GetFilePath("Sellers.Json");
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            File.WriteAllText(buyerPath, JsonSerializer.Serialize(
                GetBuyerList(buyerPath, buyer), options));
            File.WriteAllText(sellerPath, JsonSerializer.Serialize(
                GetSellerList(sellerPath, seller), options));

            return true;
        }

        private bool IsBuyerConversationMessage(
            SyncMessage message,
            Buyer buyer,
            Seller seller)
        {
            if (message == null)
                return false;

            bool buyerSent = message.Sender == buyer.FullName &&
                             message.Receiver == seller.Username;

            bool sellerSent = message.Sender == seller.FullName &&
                              message.Receiver == buyer.Username;

            return buyerSent || sellerSent;
        }

        private List<Buyer> GetBuyerList(string path, Buyer buyer)
        {
            List<Buyer> buyers =
                JsonSerializer.Deserialize<List<Buyer>>(File.ReadAllText(path))
                ?? new List<Buyer>();

            Buyer savedBuyer = buyers.FirstOrDefault(item =>
                item.Username == buyer.Username);

            if (savedBuyer != null)
                savedBuyer.SyncMessages = buyer.SyncMessages;

            return buyers;
        }

        private List<Seller> GetSellerList(string path, Seller seller)
        {
            List<Seller> sellers =
                JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(path))
                ?? new List<Seller>();

            Seller savedSeller = sellers.FirstOrDefault(item =>
                item.Username == seller.Username);

            if (savedSeller != null)
                savedSeller.SyncMessages = seller.SyncMessages;

            return sellers;
        }
        private User LoadReceiverByFullName(string fullName)
        {
            string sellerPath = FileGetter.GetFilePath("Sellers.Json");

            if (File.Exists(sellerPath))
            {
                List<Seller> sellers =
                    JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(sellerPath))
                    ?? new List<Seller>();

                Seller seller = sellers.FirstOrDefault(user =>
                    user.FullName == fullName);

                if (seller != null)
                    return seller;
            }

            string dualPath = FileGetter.GetFilePath("Dual.Json");

            if (File.Exists(dualPath))
            {
                List<Dual> dualUsers =
                    JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                    ?? new List<Dual>();

                return dualUsers.FirstOrDefault(user =>
                    user.FullName == fullName);
            }

            return null;
        }
    }
}
