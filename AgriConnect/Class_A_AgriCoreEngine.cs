using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{
    //Class that holds the current user and user role
    
    internal class C_Global_Variable
    {
        //this method backs two parens and into the project name folder
        //instead of our json going inside Bin>Debug its goes to a specific pparent folder
        internal static string ProjectRoot
        {
            //the current folder is AgriConnect > Bin > Debug it backs two step to
            //AgriConnect > Bin to
            //AgriConnect
            //get returns the AgriConnect Folder 
            get
            {
                return Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            }
        }

        //this methods stores the Json file inside the "Users" Folder
        //the signature collects the json that it needs to store such us Sellers.Json
        internal static string GetFilePath(string fileName)
        {

            //{
            //folder path combines our project root method to our "Users" folder
            string folderPath = Path.Combine(ProjectRoot, "Users");
            //the if statement checks  if our "Users" folder exist or not if not then it created a new one
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            //then it returns the folder path and the Json we wanna store
            return Path.Combine(folderPath, fileName);
            //}
        }

    }
    internal static class ActiveUserHelper
    {
        internal static User getUser(User target)
        {


            if (target.UserRole == "Seller")
            {

                List<Seller> seller = new List<Seller>();
                string getJson = C_Global_Variable.GetFilePath("Sellers.Json");
                if (!File.Exists(getJson))
                {
                    MessageBox.Show("file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                string readFile = File.ReadAllText(getJson);
                seller = JsonSerializer.Deserialize<List<Seller>>(readFile);

                foreach (Seller get in seller)
                {
                    if (get.Username == target.Username)
                    {

                        return get;
                    }
                }
            }
            else if (target.UserRole == "Dual")
            {

                List<Dual> dual = new List<Dual>();
                string getJson = C_Global_Variable.GetFilePath("Dual.Json");
                if (!File.Exists(getJson))
                {
                    MessageBox.Show("file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                string readFile = File.ReadAllText(getJson);
                dual = JsonSerializer.Deserialize<List<Dual>>(readFile);

                foreach (Dual get in dual)
                {
                    if (get.Username == target.Username)
                    {
                        return get;
                    }
                }
            }
            else if (target.UserRole == "Buyer")
            {

                List<Buyer> buyer = new List<Buyer>();
                string getJson = C_Global_Variable.GetFilePath("Buyer.Json");
                if (!File.Exists(getJson))
                {
                    MessageBox.Show("file not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                foreach (Buyer get in buyer)
                {
                    if (get.Username == target.Username)
                    {

                        return get;
                    }
                }
            }

            return null;
        }

        internal static void Delist(string delist, User target)
        {
            if (target.UserRole == "Seller")
            {
                string sellerfilePath = C_Global_Variable.GetFilePath("Sellers.Json");
                string marketfilePath = C_Global_Variable.GetFilePath("MarketListing.Json");
                Seller tempUser = new Seller();
                SellerProducts list = new SellerProducts();
                MarketplaceListings marketProduct = new MarketplaceListings();
                if (!File.Exists(marketfilePath) && !File.Exists(sellerfilePath))
                {
                    MessageBox.Show("File Not Found", "File Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Seller> seller = new List<Seller>();
                List<MarketplaceListings> marketList = new List<MarketplaceListings>();

                string sellerJson = File.ReadAllText(sellerfilePath);
                string marketJson = File.ReadAllText(marketfilePath);

                seller = JsonSerializer.Deserialize<List<Seller>>(sellerJson);
                marketList = JsonSerializer.Deserialize<List<MarketplaceListings>>(marketJson);
                foreach (Seller get in seller)
                {
                    if (target.Username == get.Username && get.Username == target.Username)
                    {
                        tempUser = get;

                        break;
                    }
                }

                if (marketList.Count != 0)
                {
                    foreach (SellerProducts get in tempUser.MyProducts)
                    {
                        if (get.productName == delist)
                        {
                            list = get;


                            break;
                        }
                    }
                    foreach (MarketplaceListings get in marketList)
                    {
                        if (get.productName == delist && get.MarketSeller == target.Username)
                        {
                            marketProduct = get;

                            break;
                        }
                    }
                }

                string compare = list.productName;
                if (compare != delist)
                {
                    MessageBox.Show("Product not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tempUser.MyProducts.Remove(list);
                marketList.Remove(marketProduct);

                string updateUser = JsonSerializer.Serialize(seller, new JsonSerializerOptions { WriteIndented = true });
                string updateMarket = JsonSerializer.Serialize(marketList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(sellerfilePath, updateUser);
                File.WriteAllText(marketfilePath, updateMarket);

                MessageBox.Show("Product Delisted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (target.UserRole == "Dual")
            {
                string dualFilePath = C_Global_Variable.GetFilePath("Dual.Json");
                string marketFilePath = C_Global_Variable.GetFilePath("MarketListing.Json");
                Dual tempUser = new Dual();
                SellerProducts list = new SellerProducts();
                MarketplaceListings marketProduct = new MarketplaceListings();
                if (!File.Exists(marketFilePath) && !File.Exists(dualFilePath))
                {
                    MessageBox.Show("File Not Found", "File Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                List<Dual> dual = new List<Dual>();
                List<MarketplaceListings> marketList = new List<MarketplaceListings>();

                string dualJson = File.ReadAllText(dualFilePath);
                string marketJson = File.ReadAllText(marketFilePath);

                dual = JsonSerializer.Deserialize<List<Dual>>(dualJson);
                marketList = JsonSerializer.Deserialize<List<MarketplaceListings>>(marketJson);
                foreach (Dual get in dual)
                {
                    if (target.Username == get.Username && get.Username == target.Username)
                    {
                        tempUser = get;

                        break;
                    }
                }
                if (marketList.Count != 0)
                {
                    foreach (SellerProducts get in tempUser.MyProducts)
                    {
                        if (get.productName == delist)
                        {
                            list = get;


                            break;
                        }
                    }
                    foreach (MarketplaceListings get in marketList)
                    {
                        if (get.productName == delist && get.MarketSeller == target.Username)
                        {
                            marketProduct = get;

                            break;
                        }
                    }
                }
                string compare = list.productName;
                if (compare != delist)
                {
                    MessageBox.Show("Product not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tempUser.MyProducts.Remove(list);
                marketList.Remove(marketProduct);

                string updateUser = JsonSerializer.Serialize(dual, new JsonSerializerOptions { WriteIndented = true });
                string updateMarket = JsonSerializer.Serialize(marketList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dualFilePath, updateUser);
                File.WriteAllText(marketFilePath, updateMarket);
                MessageBox.Show("Product Delisted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static Collection activeHelper(string activeUser)
        {
            string filePath = C_Global_Variable.GetFilePath("Collection.Json");
            if (!File.Exists(filePath))
                return null;

            string readJson = File.ReadAllText(filePath);
            List<Collection> AllUsers = JsonSerializer.Deserialize<List<Collection>>(readJson);

            if (AllUsers == null)
                return null;

            foreach (var user in AllUsers)
            {
                if (user.Username == activeUser)
                {
                    return user;
                }
            }




            return null;
        }



        internal static void ClearSession()
        {
            CurrentUser.currentUser = null;
        }

        internal static void SaveListTo(User Target, string productName, int stock, double price, string PN, string imgPath)
        {


            if (Target.UserRole == "Seller")
            {

                string filePath = C_Global_Variable.GetFilePath("Sellers.Json");
                string getSellersJson = File.ReadAllText(filePath);
                List<Seller> SellerList = new List<Seller>();
                SellerList = JsonSerializer.Deserialize<List<Seller>>(getSellersJson);


                string marketFilePath = C_Global_Variable.GetFilePath("MarketListing.Json");
                List<MarketplaceListings> productList = new List<MarketplaceListings>();
                if (File.Exists(marketFilePath))
                {
                    string existingMarketJson = File.ReadAllText(marketFilePath);
                    productList = JsonSerializer.Deserialize<List<MarketplaceListings>>(existingMarketJson);

                }
                Seller saveHere = new Seller();
                foreach (var user in SellerList)
                {
                    if (user.Username == Target.Username)
                    {

                        saveHere = user;

                        break;
                    }
                }
                string saveList;
                if (productList.Count != 0)
                {

                    foreach (SellerProducts products in saveHere.MyProducts)
                    {
                        if (productName == products.productName)

                        {
                            saveToMarket(saveHere, products, productList, productName, stock, price, marketFilePath);
                            ListUpdate(SellerList, saveHere, filePath);
                            return;
                        }
                    }
                }
                SellerProducts savethis = new SellerProducts(productName, stock, price);
                MarketplaceListings saveMarket = new MarketplaceListings(saveHere.Username, productName, stock, price, PN, imgPath, saveHere.Barangay);

                saveHere.MyProducts.Add(savethis);
                productList.Add(saveMarket);

                string saveMarketList = JsonSerializer.Serialize(productList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(marketFilePath, saveMarketList);
                saveList = JsonSerializer.Serialize(SellerList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, saveList);



                MessageBox.Show("Product Listed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (Target.UserRole == "Dual")
            {


                string filePath = C_Global_Variable.GetFilePath("Dual.Json");
                string getJson = File.ReadAllText(filePath);
                List<Dual> dualList = new List<Dual>();
                dualList = JsonSerializer.Deserialize<List<Dual>>(getJson);


                string marketFilePath = C_Global_Variable.GetFilePath("MarketListing.Json");
                List<MarketplaceListings> productList = new List<MarketplaceListings>();
                if (File.Exists(marketFilePath))
                {
                    string existingMarketJson = File.ReadAllText(marketFilePath);
                    productList = JsonSerializer.Deserialize<List<MarketplaceListings>>(existingMarketJson);

                }

                Dual saveHere = new Dual();
                foreach (var user in dualList)
                {
                    if (user.Username == Target.Username)
                    {
                        saveHere = user;
                        break;
                    }
                }

                string saveList;
                if (productList.Count != 0)
                {
                    foreach (SellerProducts products in saveHere.MyProducts)
                    {
                        if (productName == products.productName)

                        {
                            saveToMarket(saveHere, products, productList, productName, stock, price, marketFilePath);
                            ListUpdate(dualList, products, filePath, stock, price);
                            return;
                        }
                    }
                }



                SellerProducts saveThis = new SellerProducts(productName, stock, price);
                MarketplaceListings saveMarket = new MarketplaceListings(saveHere.Username, productName, stock, price, PN, imgPath, saveHere.Barangay);


                saveHere.MyProducts.Add(saveThis);
                productList.Add(saveMarket);
                string saveMarketList = JsonSerializer.Serialize(productList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(marketFilePath, saveMarketList);
                saveList = JsonSerializer.Serialize(dualList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, saveList);

                MessageBox.Show("Product Listed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
        }


        internal static User saveToMarket(User target, SellerProducts updateMyList, List<MarketplaceListings> productList, string productName, int stock,
            double price, string filePath)
        {
            if (target is Seller sellerSave)
            {
                MarketplaceListings getProduct = new MarketplaceListings();
                foreach (MarketplaceListings get in productList)
                {

                    if (get.productName == productName && get.MarketSeller == target.Username)
                    {
                        getProduct = get;

                        break;
                    }
                }

                MessageBox.Show($"User Found: {getProduct.MarketSeller}");
                MessageBox.Show($"Product Found: {getProduct.productName}");


                updateMyList.productStock = stock;
                updateMyList.productPrice = price;
                getProduct.productStock = stock;
                getProduct.productPrice = price;
                string savethis = JsonSerializer.Serialize(productList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, savethis);
                return sellerSave;

            }
            else if (target is Dual dualSave)
            {
                MarketplaceListings getProduct = new MarketplaceListings();
                foreach (MarketplaceListings get in productList)
                {

                    if (get.productName == productName && get.MarketSeller == target.Username)
                    {
                        getProduct = get;

                        break;
                    }
                }

                MessageBox.Show($"User Found: {getProduct.MarketSeller}");
                MessageBox.Show($"Product Found: {getProduct.productName}");


                updateMyList.productStock = stock;
                updateMyList.productPrice = price;
                getProduct.productStock = stock;
                getProduct.productPrice = price;
                string savethis = JsonSerializer.Serialize(productList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, savethis);
                return dualSave;
            }


            return null;
        }


        internal static void ListUpdate(List<Seller> sellerList, Seller target, string filePath)
        {
            string saveList = JsonSerializer.Serialize(sellerList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, saveList);
            MessageBox.Show("List Updated", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void ListUpdate(List<Dual> dualList, SellerProducts updateMyList, string filePath,
            int productStock, double productPrice)
        {
            updateMyList.productStock = productStock;
            updateMyList.productPrice = productPrice;
            string saveList = JsonSerializer.Serialize(dualList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, saveList);
            MessageBox.Show("List Updated", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }


}
