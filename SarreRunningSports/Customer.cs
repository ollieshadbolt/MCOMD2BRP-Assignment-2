using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarreRunningSports
{
    public sealed class Customer : IName
    {
        // attributes
        private String mName;
        private String mEmail;
        private bool mGDPR;
        private List<Purchase> mPurchases = new List<Purchase>();

        // constructor
        public Customer(String Name, String Email, bool GDPR, Purchase Purchase)
        {
            this.Name = Name;
            this.Email = Email;
            this.GDPR = GDPR;

            AddPurchase(Purchase);
        }

        // method
        public void AddPurchase(Purchase Purchase)
        {
            mPurchases.Add(Purchase);
        }

        // accessors
        public String Name
        {
            get
            {
                return mName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Customer name cannot be null or empty!");
                }
                else
                {
                    mName = value;
                }
            }
        }

        public String Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                try
                {
                    mEmail = new System.Net.Mail.MailAddress(value).Address;
                }
                catch
                {
                    throw new ArgumentException("Customer email is invalid!");
                }
            }
        }

        public bool GDPR
        {
            get
            {
                return mGDPR;
            }
            set
            {
                mGDPR = value;
            }
        }

        public List<Purchase> Purchases
        {
            get
            {
                return mPurchases;
            }
        }
    }
}
