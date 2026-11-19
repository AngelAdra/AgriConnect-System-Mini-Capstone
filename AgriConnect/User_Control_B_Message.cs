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
    public partial class MessageBlu : UserControl
    {

        bool isUsed = false;
        public MessageBlu(string name, string message, User sender, User receiver, G_ProductCard show, FlowLayoutPanel use)
        {
            InitializeComponent();
            if (!isUsed)
            {
                lblSender.Text = name;
                rtbMessage.Text = $"Hello Mr/Ms {receiver.Username}, i'd Like to buy your Product {message}"; 
                use.Controls.Add(show);
                
                isUsed = true;
                

            }
            else {
                lblSender.Text = name;
                rtbMessage.Text = message;
        } }

        public void MyMessage()
        {

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
