using System;
using System.Windows.Forms;

namespace AgriConnect
{
    public partial class Notification : UserControl
    {
        public event EventHandler OpenRequested;
        public event EventHandler DiscardRequested;

        public SyncMessage LinkedMessage { get; private set; }

            public Notification()
        {
            InitializeComponent();

            btnOpen.Click += btnOpen_Click;
            btnOption.Click += btnOption_Click;
        }

        public void SetMessage(SyncMessage message)
        {
            LinkedMessage = message;
            lblNotif.Text = message.Sender + ": " + message.MessageText;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (OpenRequested != null)
                OpenRequested(this, EventArgs.Empty);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            if (DiscardRequested != null)
                DiscardRequested(this, EventArgs.Empty);
        }

        private void lblNotif_Click(object sender, EventArgs e)
        {
        }

        private void Notification_Load(object sender, EventArgs e)
        {
        }
    }
}
