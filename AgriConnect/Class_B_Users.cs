using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriConnect
{


    

    //Parent class serve as the blueprint of all child classes
    //this class is also abstract because so we cant instantiate it and for its main purpose is to be the blue print for the child classes
    public abstract class User                                                           
    {
        //backing fields wherein they are the one that store valid data
        //private so it's the only one that can access it and to encapsulate the data from potential data leaks
        //stores the username Eg. RojuneReforsado 
        private string _Username;
        //stores the password
        private string _UserPassword;
        //stores the role of the role of the user like Dual, Seller,  Buyer
        private string _UserRole;
        //stores  the phone number
        private string _PhoneNumber;
        //stores the full name fof the User
        private string _FullName;
        //stores the barangat
        private string _Barangay;

        //Full properties for the backing fields
        //These validated the inputs of every user most full properties validates the same thing is to check if its empty
        //but its likely to execute since the UI is already not accepting empty nor wrong inputs
        public string Username
        {
            get { return _Username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    //Check if the input is empty or not
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (User Name)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // it returns so i doesnt save the wrong input
                }
                //if its not empty the value will give the data to backing fields
                _Username = value;
            }
        }

        public string UserPassword
        {
            get { return _UserPassword; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (Password)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _UserPassword = value;
            }
        }

        public string UserRole
        {
            get { return _UserRole; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (Role)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _UserRole = value;
            }
        }

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (Phone Number)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _PhoneNumber = value;
            }
        }

        public string FullName
        {
            get { return _FullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (Full Name)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _FullName = value;
            }
        }

        public string Barangay
        {
            get { return _Barangay; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Emergency Fallback Protocol Initiated", "Blocked by Full Property (Barangay)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Barangay = value;
            }
        }

        public string Salt { get; set; }

public string PasswordHash { get; set; }

protected void SetPassword(string password)
{
    Salt = PasswordSecurity.GenerateSalt();
    PasswordHash = PasswordSecurity.HashPassword(password, Salt);
}
        

    }


    //Child class inherited user 
    public class Seller : User
    {
        public List<SellerProducts> MyProducts { get; set; } =
            new List<SellerProducts>();

        public List<SyncMessage> SyncMessages { get; set; } =
            new List<SyncMessage>();

        public Seller()
        {
        }

        public Seller(
            string SellerFullName,
            string SellerName,
            string SellerPassword,
            string SellerRole,
            string SellerPN,
            string SellerBarangay)
        {
            FullName = SellerFullName;
            Username = SellerName;
            // Seller constructor
            SetPassword(SellerPassword);
            UserRole = SellerRole;
            PhoneNumber = SellerPN;
            Barangay = SellerBarangay;
        }
    }

    //Buyer is also unique because it cant list but it can only buy
    public class Buyer : User
    {
        public List<SyncMessage> SyncMessages { get; set; } =
            new List<SyncMessage>();

        public Buyer()
        {
        }

        public Buyer(
            string BuyerFullName,
            string BuyerName,
            string BuyerPassword,
            string BuyerRole,
            string BuyerPN,
            string BuyerBarangay)
        {
            FullName = BuyerFullName;
            Username = BuyerName;
            // Buyer constructor
            SetPassword(BuyerPassword);
            UserRole = BuyerRole;
            PhoneNumber = BuyerPN;
            Barangay = BuyerBarangay;
        }

        public bool SendTo(string target, string message)
        {
            return SendTo(target, message, "Seller");
        }

        public bool SendTo(string target, string message, string receiverRole)
        {
            if (string.IsNullOrWhiteSpace(target) ||
                string.IsNullOrWhiteSpace(message))
            {
                return false;
            }

            string buyerPath = FileGetter.GetFilePath("Buyer.Json");

            if (!File.Exists(buyerPath))
                return false;

            List<Buyer> buyers =
                JsonSerializer.Deserialize<List<Buyer>>(File.ReadAllText(buyerPath))
                ?? new List<Buyer>();

            Buyer buyerRecord = buyers.FirstOrDefault(buyer =>
                string.Equals(buyer.Username, Username, StringComparison.OrdinalIgnoreCase));

            if (buyerRecord == null)
                return false;

            if (buyerRecord.SyncMessages == null)
                buyerRecord.SyncMessages = new List<SyncMessage>();

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            if (receiverRole == "Seller")
            {
                string sellerPath = FileGetter.GetFilePath("Sellers.Json");

                if (!File.Exists(sellerPath))
                    return false;

                List<Seller> sellers =
                    JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(sellerPath))
                    ?? new List<Seller>();

                Seller seller = sellers.FirstOrDefault(user =>
                    string.Equals(user.Username, target, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(user.FullName, target, StringComparison.OrdinalIgnoreCase));

                if (seller == null)
                    return false;

                if (seller.SyncMessages == null)
                    seller.SyncMessages = new List<SyncMessage>();

                SyncMessage newMessage = new SyncMessage(
                    buyerRecord.FullName,
                    seller.Username,
                    message.Trim());

                buyerRecord.SyncMessages.Add(newMessage);
                seller.SyncMessages.Add(newMessage);

                File.WriteAllText(
                    sellerPath,
                    JsonSerializer.Serialize(sellers, options));
            }
            else if (receiverRole == "Dual")
            {
                string dualPath = FileGetter.GetFilePath("Dual.Json");

                if (!File.Exists(dualPath))
                    return false;

                List<Dual> dualUsers =
                    JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                    ?? new List<Dual>();

                Dual dual = dualUsers.FirstOrDefault(user =>
                    string.Equals(user.Username, target, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(user.FullName, target, StringComparison.OrdinalIgnoreCase));

                if (dual == null)
                    return false;

                if (dual.SyncMessages == null)
                    dual.SyncMessages = new List<SyncMessage>();

                SyncMessage newMessage = new SyncMessage(
                    buyerRecord.FullName,
                    dual.Username,
                    message.Trim());

                buyerRecord.SyncMessages.Add(newMessage);
                dual.SyncMessages.Add(newMessage);

                File.WriteAllText(
                    dualPath,
                    JsonSerializer.Serialize(dualUsers, options));
            }
            else
            {
                return false;
            }

            File.WriteAllText(
                buyerPath,
                JsonSerializer.Serialize(buyers, options));

            return true;
        }

        public bool SendToDual(string target, string message)
        {
            return SendTo(target, message, "Dual");
        }

        public bool SendToSeller(string target, string message)
        {
            if (string.IsNullOrWhiteSpace(target) ||
                string.IsNullOrWhiteSpace(message))
            {
                return false;
            }

            string dualPath = FileGetter.GetFilePath("Dual.Json");
            string sellerPath = FileGetter.GetFilePath("Sellers.Json");

            if (!File.Exists(dualPath) || !File.Exists(sellerPath))
                return false;

            List<Dual> dualUsers =
                JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                ?? new List<Dual>();

            List<Seller> sellers =
                JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(sellerPath))
                ?? new List<Seller>();

            Dual dual = dualUsers.FirstOrDefault(user =>
                string.Equals(user.Username, Username, StringComparison.OrdinalIgnoreCase));

            Seller seller = sellers.FirstOrDefault(user =>
                string.Equals(user.Username, target, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(user.FullName, target, StringComparison.OrdinalIgnoreCase));

            if (dual == null || seller == null)
                return false;

            if (dual.SyncMessages == null)
                dual.SyncMessages = new List<SyncMessage>();

            if (seller.SyncMessages == null)
                seller.SyncMessages = new List<SyncMessage>();

            SyncMessage newMessage = new SyncMessage(
                dual.FullName,
                seller.Username,
                message.Trim());

            dual.SyncMessages.Add(newMessage);
            seller.SyncMessages.Add(newMessage);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            File.WriteAllText(dualPath, JsonSerializer.Serialize(dualUsers, options));
            File.WriteAllText(sellerPath, JsonSerializer.Serialize(sellers, options));

            return true;
        }

    }

    // Same as Seller but Dual has the ability to buy and sell
    public class Dual : User
    {
        public List<SellerProducts> MyProducts { get; set; } =
            new List<SellerProducts>();

        public List<SyncMessage> SyncMessages { get; set; } =
            new List<SyncMessage>();

        public Dual()
        {
        }

        public Dual(
            string DualFullName,
            string DualUser,
            string DualPassword,
            string DualRole,
            string DualPN,
            string DualBarangay)
        {
            FullName = DualFullName;
            Username = DualUser;
            // Dual constructor
            SetPassword(DualPassword);
            UserRole = DualRole;
            PhoneNumber = DualPN;
            Barangay = DualBarangay;
        }

        public bool SendToSeller(string target, string message)
        {
            if (string.IsNullOrWhiteSpace(target) ||
                string.IsNullOrWhiteSpace(message))
            {
                return false;
            }

            string dualPath = FileGetter.GetFilePath("Dual.Json");
            string sellerPath = FileGetter.GetFilePath("Sellers.Json");

            if (!File.Exists(dualPath) || !File.Exists(sellerPath))
                return false;

            List<Dual> dualUsers =
                JsonSerializer.Deserialize<List<Dual>>(File.ReadAllText(dualPath))
                ?? new List<Dual>();

            List<Seller> sellers =
                JsonSerializer.Deserialize<List<Seller>>(File.ReadAllText(sellerPath))
                ?? new List<Seller>();

            Dual dual = dualUsers.FirstOrDefault(user =>
                string.Equals(user.Username, Username, StringComparison.OrdinalIgnoreCase));

            Seller seller = sellers.FirstOrDefault(user =>
                string.Equals(user.Username, target, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(user.FullName, target, StringComparison.OrdinalIgnoreCase));

            if (dual == null || seller == null)
                return false;

            if (dual.SyncMessages == null)
                dual.SyncMessages = new List<SyncMessage>();

            if (seller.SyncMessages == null)
                seller.SyncMessages = new List<SyncMessage>();

            SyncMessage newMessage = new SyncMessage(
                dual.FullName,
                seller.Username,
                message.Trim());

            dual.SyncMessages.Add(newMessage);
            seller.SyncMessages.Add(newMessage);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            File.WriteAllText(dualPath, JsonSerializer.Serialize(dualUsers, options));
            File.WriteAllText(sellerPath, JsonSerializer.Serialize(sellers, options));

            return true;
        }
    }

    //Collecting the dual, seller, and buyer 
    //Collection stores all child of our parent class
    //this is crucial for log in and getting the current user whos using the system
    public class Collection : User
    {
        public Collection() { }

        public Collection(
            string CollectionFullName, string CollectionUsers, string CollectionPasswords, string CollectionRoles, string CollectionPN, string CollectionBarangay)
        {
            FullName = CollectionFullName;
            Username = CollectionUsers;
            // Collection constructor
            SetPassword(CollectionPasswords);
            UserRole = CollectionRoles;
            PhoneNumber = CollectionPN;
            Barangay = CollectionBarangay;
        }
    }

   

}
