using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{
    public partial class Message : UserControl
    {

        bool isUsed = false;
        private static MarketplaceListings getreceiver;
        private static User getsender;
        public Message(User senderName, string message, MarketplaceListings receiver, ProductCard show, FlowLayoutPanel use)
        {
            InitializeComponent();
            if (!isUsed)
            {
                lblSender.Text = senderName.FullName;
                rtbMessage.Text = $"Hello Mr/Ms {receiver.MarketSeller}, i'd Like to inquire about your Product {message} Before setting an Order"; 
                use.Controls.Add(show);
                
                isUsed = true;
                getreceiver = receiver;
                getsender = senderName;
                

                if(senderName.UserRole == "Buyer")
                {
                    Buyer buyerSender = SelfBuiltEngine.getBuyer(senderName);

                    if (buyerSender == null ||
                        !buyerSender.SendTo(
                            receiver.MarketSeller,
                            rtbMessage.Text,
                            receiver.role))
                    {
                        MessageBox.Show(
                            "The message could not be saved.",
                            "Message Not Sent",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else if (senderName.UserRole == "Dual")
                {
                    Dual dualSender = SelfBuiltEngine.getUser(senderName) as Dual;

                    if (receiver.role != "Seller" ||
                        dualSender == null ||
                        !dualSender.SendToSeller(
                            receiver.MarketSeller,
                            rtbMessage.Text))
                    {
                        MessageBox.Show(
                            "A Dual account can only start a conversation with a Seller.",
                            "Message Not Sent",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

            }
            else {
                lblSender.Text = senderName.FullName;
                rtbMessage.Text = message;
        } }

        public Message( User senderName, string message, FlowLayoutPanel use)
        {
            InitializeComponent();

            lblSender.Text = senderName.FullName;
            rtbMessage.Text = message;
            use.Controls.Add(this);
        }


        private void I_Sender_Load(object sender, EventArgs e)
        {

        }

        private void adjustBubbleHeight()
        {
            int lineCount = rtbMessage.GetLineFromCharIndex(rtbMessage.TextLength);
            int lineHeight = rtbMessage.Font.Height;
            int targetHeight =  (lineCount * lineHeight) + 12;

            if (targetHeight < 25)
                targetHeight = 25;

            rtbMessage.Height = targetHeight;

            this.Height = rtbMessage.Top + rtbMessage.Height + 10;


        }


        public void SetMessageText(string message)
        {
            rtbMessage.Text = message;
            adjustBubbleHeight();
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            adjustBubbleHeight();
        }

        public static bool SaveToSync(User senderName, string message)
        {
            if (senderName == null ||
                getreceiver == null ||
                string.IsNullOrWhiteSpace(message))
            {
                return false;
            }

            if (senderName.UserRole == "Buyer")
            {
                Buyer buyerSender = SelfBuiltEngine.getBuyer(senderName);

                return buyerSender != null &&
                       buyerSender.SendTo(
                           getreceiver.MarketSeller,
                           message,
                           getreceiver.role);
            }

            if (senderName.UserRole == "Dual")
            {
                if (getreceiver.role != "Seller")
                    return false;

                Dual dualSender = SelfBuiltEngine.getUser(senderName) as Dual;

                return dualSender != null &&
                       dualSender.SendToSeller(
                           getreceiver.MarketSeller,
                           message);
            }

            return false;
        }
    }
}
