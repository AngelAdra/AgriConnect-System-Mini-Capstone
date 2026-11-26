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

            // Palette: primary #2E8B57, dark #1F6B41, light #66BB6A, tint #E8F5E9, accent #F5A623
            Color primary = Color.FromArgb(0x2E, 0x8B, 0x57);
            Color primaryDark = Color.FromArgb(0x1F, 0x6B, 0x41);
            Color lightGreen = Color.FromArgb(0x66, 0xBB, 0x6A);
            Color tint = Color.FromArgb(0xE8, 0xF5, 0xE9);
            Color accent = Color.FromArgb(0xF5, 0xA6, 0x23);
            Color textDark = Color.FromArgb(0x26, 0x32, 0x38);

            Text = "Set Order";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            ClientSize = new Size(380, 308);

            // Header band
            Panel header = new Panel
            {
                BackColor = primary,
                Location = new Point(0, 0),
                Size = new Size(380, 56)
            };
            header.Controls.Add(new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point),
                Location = new Point(20, 0),
                Size = new Size(340, 56),
                Text = "Set Order",
                TextAlign = ContentAlignment.MiddleLeft
            });
            Panel headerAccent = new Panel
            {
                BackColor = accent,
                Location = new Point(0, 52),
                Size = new Size(380, 4)
            };
            header.Controls.Add(headerAccent);
            headerAccent.BringToFront();
            Controls.Add(header);

            Controls.Add(new Label
            {
                AutoSize = false,
                AutoEllipsis = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = textDark,
                Location = new Point(20, 74),
                Size = new Size(340, 24),
                Text = "Product: " + listing.productName,
                TextAlign = ContentAlignment.MiddleLeft
            });

            Controls.Add(new Label
            {
                AutoSize = false,
                AutoEllipsis = true,
                ForeColor = textDark,
                Location = new Point(20, 102),
                Size = new Size(340, 24),
                Text = "Price per item: " + listing.productPrice.ToString("C2"),
                TextAlign = ContentAlignment.MiddleLeft
            });

            Controls.Add(new Label
            {
                AutoSize = false,
                ForeColor = textDark,
                Location = new Point(20, 140),
                Size = new Size(84, 28),
                Text = "Quantity:",
                TextAlign = ContentAlignment.MiddleLeft
            });

            _quantityInput = new NumericUpDown
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(110, 141),
                Minimum = 1,
                Maximum = Math.Max(1, listing.productStock),
                Value = 1,
                Width = 110,
                TextAlign = HorizontalAlignment.Right,
                Enabled = listing.productStock > 0
            };
            _quantityInput.ValueChanged += QuantityInput_ValueChanged;
            Controls.Add(_quantityInput);

            // Total card with amber accent strip
            Panel totalCard = new Panel
            {
                BackColor = tint,
                Location = new Point(20, 184),
                Size = new Size(340, 52)
            };
            totalCard.Controls.Add(new Panel
            {
                BackColor = accent,
                Location = new Point(0, 0),
                Size = new Size(5, 52)
            });

            _totalLabel = new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = primaryDark,
                Location = new Point(17, 0),
                Size = new Size(315, 52),
                TextAlign = ContentAlignment.MiddleLeft
            };
            totalCard.Controls.Add(_totalLabel);
            Controls.Add(totalCard);

            Button confirmButton = new Button
            {
                BackColor = primary,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.White,
                Location = new Point(140, 256),
                Size = new Size(120, 36),
                Text = listing.productStock > 0 ? "Confirm" : "Out of stock",
                UseVisualStyleBackColor = false,
                Enabled = listing.productStock > 0
            };
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatAppearance.MouseOverBackColor = primaryDark;
            confirmButton.FlatAppearance.MouseDownBackColor = primaryDark;
            confirmButton.Click += ConfirmButton_Click;
            Controls.Add(confirmButton);

            Button cancelButton = new Button
            {
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = primary,
                Location = new Point(270, 256),
                Size = new Size(90, 36),
                Text = "Cancel",
                UseVisualStyleBackColor = false,
                DialogResult = DialogResult.Cancel
            };
            cancelButton.FlatAppearance.BorderColor = lightGreen;
            cancelButton.FlatAppearance.BorderSize = 1;
            cancelButton.FlatAppearance.MouseOverBackColor = tint;
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
