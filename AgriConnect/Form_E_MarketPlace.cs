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
            string getMarket = C_Global_Variable.GetFilePath("MarketListing.Json");
            if (!File.Exists(getMarket))
            {
                MessageBox.Show("Empty Market List", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string readJson = File.ReadAllText(getMarket);
            List<MarketplaceListings> list = new List<MarketplaceListings>();
            list = JsonSerializer.Deserialize<List<MarketplaceListings>>(readJson);

            foreach (var get in list)
            {
                User receive = ActiveUserHelper.activeHelper(get.MarketSeller);
                ActiveUserHelper.getUser(receive);

                G_ProductCard card = new G_ProductCard(
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
                    receive);
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
