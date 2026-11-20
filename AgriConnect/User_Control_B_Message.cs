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
        private static string getsender;
        public Message(string name, string message, MarketplaceListings receiver, ProductCard show, FlowLayoutPanel use)
        {
            InitializeComponent();
            if (!isUsed)
            {
                lblSender.Text = name;
                rtbMessage.Text = $"Hello Mr/Ms {receiver.MarketSeller}, i'd Like to inquire about your Product {message} Before setting an Order"; 
                use.Controls.Add(show);
                
                isUsed = true;
                getreceiver = receiver;
                getsender = name;
            }
            else {
                lblSender.Text = name;
                rtbMessage.Text = message;
        } }

        public Message( string message, FlowLayoutPanel use) :
            this(getsender, message, getreceiver , null, use)
        {
            lblSender.Text = getsender;
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
    }
}
