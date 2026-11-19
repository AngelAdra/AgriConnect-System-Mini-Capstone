using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{
    public abstract class MessageBlueprint

    {
        private string _Sender;
        private string _Receiver;
        private string _Message;

        public string Sender
        {
            get { return _Sender; }
            set
            {
                if (value == null)
                {
                    MessageBox.Show(
                        "Emergency Fallback Protocol Initiated",
                        "Blocked by Full Property (Sender)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                _Sender = value;
            }
        }

        public string Receiver
        {
            get { return _Receiver; }
            set
            {
                if (value == null)
                {
                    MessageBox.Show(
                        "Emergency Fallback Protocol Initiated",
                        "Blocked by Full Property (Receiver)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                _Receiver = value;
            }
        }

        public string MessageText
        {
            get { return _Message; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show(
                        "Emergency Fallback Protocol Initiated",
                        "Blocked by Full Property (Message)",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                _Message = value;
            }
        }
    }

    public class SyncMessage : MessageBlueprint
    {
        public SyncMessage()
        {
        }

        public SyncMessage(
            string userSender,
            string userReceiver,
            string messageSent)
        {
            Sender = userSender;
            Receiver = userReceiver;
            MessageText = messageSent;
        }
    }
}

  