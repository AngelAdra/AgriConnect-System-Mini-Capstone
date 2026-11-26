using System;
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
    public partial class ProductCard : UserControl
    {
        private readonly Panel _targetPanel;
        private readonly FlowLayoutPanel _targeFLP;
        private readonly User getUser = null;
        private readonly string holdProduct;
        private readonly MarketplaceListings received = null;


        public ProductCard(
            string productName,
            int stock,
            double price,
            string fullName,
            string num,
            string img,
            string barangay,
            User block,
            Panel getPanel,
            FlowLayoutPanel getFLP,
            MarketplaceListings receive
            )
        {
            InitializeComponent();

            if (block != null && string.Equals(block.UserRole, "Seller", StringComparison.OrdinalIgnoreCase))
            {
                btnContackSeller.Enabled = false;
                btnSetOrder.Enabled = false;
            }
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
        public ProductCard() { }

        
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
            


            if (checkFLP == 0)
            {
                clear();
                ProductCard get = new ProductCard();
                
                IsPressed = true;
              
                _targetPanel.Focus();
                

                Message send = new Message(getUser, holdProduct, received, get, _targeFLP);
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
              
            }
        }

        private void lblBarangay_Click(object sender, EventArgs e)
        {

        }

        private void btnSetOrder_Click(object sender, EventArgs e)
        {
            if (getUser == null || string.Equals(getUser.UserRole, "Seller", StringComparison.OrdinalIgnoreCase))
            {
                btnSetOrder.Enabled = false;
                return;
            }

            if (received == null || received.productStock <= 0)
            {
                MessageBox.Show("This product is out of stock.", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (OrderForm orderForm = new OrderForm(received, getUser))
            {
                if (orderForm.ShowDialog(this) == DialogResult.OK)
                {
                    received.productStock = orderForm.RemainingStock;
                    lblStock.Text = $"Stock: {orderForm.RemainingStock}";
                    btnSetOrder.Enabled = orderForm.RemainingStock > 0;
                }
            }
        }
    }

    internal class OrderForm : Form
    {
        private readonly MarketplaceListings _listing;
        private readonly User _buyer;
        private readonly NumericUpDown _quantityInput;
        private readonly Label _totalLabel;

        public int RemainingStock { get; private set; }

        public OrderForm(MarketplaceListings listing, User buyer)
        {
            _listing = listing;
            _buyer = buyer;
            RemainingStock = listing.productStock;

            Text = "Set Order";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(360, 220);

            Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(20, 20),
                Text = "Product: " + listing.productName
            });

            Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(20, 55),
                Text = "Price per item: " + listing.productPrice.ToString("C2")
            });

            Controls.Add(new Label
            {
                AutoSize = true,
                Location = new Point(20, 90),
                Text = "Quantity:"
            });

            _quantityInput = new NumericUpDown
            {
                Location = new Point(110, 86),
                Minimum = 1,
                Maximum = Math.Max(1, listing.productStock),
                Value = 1,
                Width = 100,
                Enabled = listing.productStock > 0
            };
            _quantityInput.ValueChanged += QuantityInput_ValueChanged;
            Controls.Add(_quantityInput);

            _totalLabel = new Label
            {
                AutoSize = true,
                Location = new Point(20, 125)
            };
            Controls.Add(_totalLabel);

            Button confirmButton = new Button
            {
                Location = new Point(160, 170),
                Size = new Size(90, 30),
                Text = listing.productStock > 0 ? "Confirm" : "Out of stock",
                Enabled = listing.productStock > 0
            };
            confirmButton.Click += ConfirmButton_Click;
            Controls.Add(confirmButton);

            Button cancelButton = new Button
            {
                Location = new Point(260, 170),
                Size = new Size(80, 30),
                Text = "Cancel",
                DialogResult = DialogResult.Cancel
            };
            Controls.Add(cancelButton);

            AcceptButton = confirmButton;
            CancelButton = cancelButton;
            UpdateTotal();
        }

        private void QuantityInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = (decimal)_listing.productPrice * _quantityInput.Value;
            _totalLabel.Text = "Total: " + total.ToString("C2");
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int remainingStock;
            if (!SelfBuiltEngine.PlaceOrder(_listing, _buyer, (int)_quantityInput.Value, out remainingStock))
            {
                MessageBox.Show(
                    this,
                    "The order could not be completed. The product may have insufficient stock or could not be saved.",
                    "Order Not Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            RemainingStock = remainingStock;
            DialogResult = DialogResult.OK;
        }
    }
}
