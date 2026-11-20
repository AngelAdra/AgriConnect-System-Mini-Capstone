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
        

        private void G_Buyer_Dashboard_Load(object sender, EventArgs e)
        {
            Collection active = SelfBuiltEngine.activeHelper(CurrentUser.currentUser);
            txtUser.Text = $"User: {active.Username}";
            txtFullName.Text = $"Name: {active.FullName}";
            txtPhoneNumber.Text = $"Phone Number: {active.PhoneNumber}";
            txtRole.Text = $"Role: {active.UserRole}";
            SelfBuiltEngine.LoadSearch(flpSearch, ActiveUser, pMessage, flpMessage);

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
            //User target = null;

            string getMessage = rtbMessage.Text.Trim();
            
            
        }
    }
}
