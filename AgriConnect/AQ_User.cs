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


    //Class that holds the current user and user role
    public static class CurrentUser
    {
        public static string currentUser { get; set; }
        public static string UserRole { get; set; } 

    }

    //Parent class serve as the blueprint of all child classes
    //this class is also abstract because so we cant instantiate it and for its main purpose is to be the blue print for the child classes
    public abstract class AQ_User                                                           
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

    }


    //Child class inherited user 
    public class Seller : AQ_User
    {
        //Seller have a has a relation
        //its unique to it because it stores its own list of products rather than lettingg the market know who owns it
        public List<SellerProducts> MyProducts { get; set; } = new List<SellerProducts>();
        

        //an empty constructor lets us instantiate object without giving any data its usefull for json serialization and deserealization
        public Seller() { }
        public Seller(string SellerFullName, string SellerName, string SellerPassword, string SellerRole, string SellerPN, string SellerBarangay)
        {
            FullName = SellerFullName;
            Username = SellerName;
            UserPassword = SellerPassword;
            UserRole = SellerRole;
            PhoneNumber = SellerPN;
            Barangay = SellerBarangay;
        }
    }
    
    //Buyer is also unique because it cant list but it can only buy
    public class Buyer : AQ_User
    {
      
        public Buyer() { }
        public Buyer(string BuyerFullName, string BuyerName, string BuyerPassword, string BuyerRole, string BuyerPN, string BuyerBarangay)
        {
            FullName = BuyerFullName;
            Username = BuyerName;
            UserPassword = BuyerPassword;
            UserRole = BuyerRole;
            PhoneNumber = BuyerPN;
            Barangay = BuyerBarangay;
        }
    }

    // Same as Seller but Dual has the ability to buy and sell
    public class Dual : AQ_User
    {
        //dual also have a has a relation to list its own list of data
        public List<SellerProducts> MyProducts { get; set; } = new List<SellerProducts>();
   

        public Dual() { }

        public Dual(
            string DualFullName, string DualUser, string DualPassword, string DualRole, string DualPN, string DualBarangay)
        {
            FullName = DualFullName;
            Username = DualUser;
            UserPassword = DualPassword;
            UserRole = DualRole;
            PhoneNumber = DualPN;
            Barangay = DualBarangay;
        }
    }

    //Collecting the dual, seller, and buyer 
    //Collection stores all child of our parent class
    //this is crucial for log in and getting the current user whos using the system
    public class Collection : AQ_User
    {
        public Collection() { }

        public Collection(
            string CollectionFullName, string CollectionUsers, string CollectionPasswords, string CollectionRoles, string CollectionPN, string CollectionBarangay)
        {
            FullName = CollectionFullName;
            Username = CollectionUsers;
            UserPassword = CollectionPasswords;
            UserRole = CollectionRoles;
            PhoneNumber = CollectionPN;
            Barangay = CollectionBarangay;
        }
    }

   

}
