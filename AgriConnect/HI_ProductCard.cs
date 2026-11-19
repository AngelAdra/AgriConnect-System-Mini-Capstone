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
    public partial class G_ProductCard : UserControl
    {
        private readonly Panel _targetPanel;
        private readonly FlowLayoutPanel _targeFLP;
        private AQ_User getUser = null;
        private string holdProduct;
        private AQ_User received = null;

        public G_ProductCard(
            string productName,
            int stock,
            double price,
            string fullName,
            string num,
            string img,
            string barangay,
            AQ_User block,
            Panel getPanel,
            FlowLayoutPanel getFLP,
            AQ_User receive
            )
        {
            InitializeComponent();

            if (block.UserRole == "Seller")
                btnContackSeller.Enabled = false;
            lblProdName.Text = $"Product: {productName}";
            lblStock.Text = $"Stock: {stock}";
            lblProdPrice.Text = $"Price: {price}";
            lblSellerName.Text = $"Seller: {fullName}";
            lblContackNum.Text = $"ContactNumber: {num}";
            lblBarangay.Text = $"Barangay: {barangay}";
            picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picProduct.Image = Image.FromFile(img);
            _targetPanel = getPanel;
            _targeFLP = getFLP;
            getUser = block;
            holdProduct = productName;
            received = receive;
        }



        private void G_ProductCard_Load(object sender, EventArgs e)
        {

        }


        private void btnReserveHarvest_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool IsPressed = false;
        private int checkFLP = 0;
        

        private void btnContackSeller_Click(object sender, EventArgs e)
        {
            clear();


            if (!IsPressed)
            {
                
                IsPressed = true;
              
                _targetPanel.Focus();
                btnContackSeller.Enabled = false;

                I_Sender send = new I_Sender(getUser.FullName, holdProduct, getUser, received, this, _targeFLP);
                _targeFLP.Controls.Add(send);
                checkFLP = _targeFLP.Controls.Count;
                
            } else
            {
                MessageBox.Show("Message Sent");
                
            }


        }

        private void clear()
        {
            while (_targeFLP.Controls.Count > 0)
            {
                Control send = _targeFLP.Controls[0];
                _targeFLP.Controls.Remove(send);
                send.Dispose();
                IsPressed = false;
            }
        }

        private void lblBarangay_Click(object sender, EventArgs e)
        {

        }
    }
}
