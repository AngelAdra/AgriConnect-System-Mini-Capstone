using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AgriConnect
{
    public partial class market : Form
    {
        private User get = null;
        private readonly Panel _targetPanel;
        private readonly FlowLayoutPanel _targetFLP;
        public market(User reveived, Panel getPanel, FlowLayoutPanel getFLP)
        {
            InitializeComponent();
            get = reveived;
            _targetPanel = getPanel;
            _targetFLP = getFLP;
        }
        public market() { }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCatalogCards();
        }

        private void LoadCatalogCards()
        {
            flpMarket.Controls.Clear();
            List<MarketplaceListings> getDeserealizedMarket =
                SelfBuiltEngine.MarketDeserealizer(new List<MarketplaceListings>());

            foreach (var get in getDeserealizedMarket)
            {
                ProductCard card = new ProductCard(
                    get.productName,
                    get.productStock,
                    get.productPrice,
                    get.MarketSeller,
                    get.MarketPhoneNumber,
                    get.ImagePath,
                    get.barangay,
                    this.get,
                    _targetPanel,
                    _targetFLP,
                    get);

                flpMarket.Controls.Add(card);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void flpMarket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
