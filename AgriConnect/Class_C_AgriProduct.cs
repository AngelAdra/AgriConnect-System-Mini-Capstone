using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{
    
    //abstract class products is the blueprint for storing product data such as name, stock, and price
    public abstract class Products
    {
        //three main backing fields that most child classes require to fulfill
        private string _productName;
        private int _productStock;
        private double _productPrice;

        //full properties validates  the input before storing it in the backing fields
        public string productName
        {
            get { return _productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (Product Name)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _productName = value;

            }
        }

        public int productStock
        {
            get { return _productStock; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated your stock should not be less than 0", "Blocked by Full Property (Product Name)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _productStock = value;
            }
        }

        public double productPrice
        {
            get { return _productPrice; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated your stock should not be negative", "Blocked by Full Property (Product Name)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _productPrice = value;

            }

        }

    }

    //this class is a component for our seller and dual
    //this canallso be used to store temporary list of data
    public class SellerProducts : Products
    {
        public SellerProducts() { }
        public SellerProducts(string sellerGoods, int sellerstock, double sellerPrice)
        {
            productName = sellerGoods;
            productStock = sellerstock;
            productPrice = sellerPrice;

        }

    }
    //market listing class has unique fields market store all products dual and seller Lists
    public class MarketplaceListings : Products
    {
        //this stores the seller's name
        public string MarketSeller { get; set; }
        //this stores the Phone number of the seller
        public string MarketPhoneNumber { get; set; }
        //this stores the image the seller set for the products
        public string ImagePath { get; set; }
        public string barangay { get; set; }
        public MarketplaceListings() { }
        public MarketplaceListings(string MarketSeller, string marketProduct, int marketStock, double MarketPrice,string marketPN, string imgPath, string barangay)
        {
            this.MarketSeller = MarketSeller;
            productName = marketProduct;
            productStock = marketStock;
            productPrice = MarketPrice;
            MarketPhoneNumber = marketPN;
            ImagePath = imgPath;
            this.barangay = barangay;
        }


    }

}
