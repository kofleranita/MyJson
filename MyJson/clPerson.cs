using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJson
{
    class clPerson
    {
        private string name;
        private DateTime expireDate;
        private double price;
        private string[] size;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime ExpireDate
        {
            get
            {
                return expireDate;
            }

            set
            {
                expireDate = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string[] Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public void Person(string myName, DateTime myExpireDate, float myPrice, string[] mySize)
        {
            this.name = myName;
            this.expireDate = myExpireDate;
            this.price = myPrice;
            this.size = mySize;
        }
    }

}
