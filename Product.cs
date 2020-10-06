using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Product
    {
        private ProductWeight weight;
        private ProductName name;
        private ProductProducer producer;
        private ProductCategory category;
        private DateTime productionDate;
        private DateTime expirationDate;

        public Product(ProductWeight weight, ProductName name, DateTime productionDate, 
            DateTime expirationDate, ProductProducer producer, ProductCategory category)
        {
            this.weight = weight;
            this.name = name;
            this.productionDate = productionDate;
            this.expirationDate = expirationDate;
            this.producer = producer;
            this.category = category;

        }


        public ProductWeight Weight
        {
            get { return weight; }
        }

        public ProductName Name
        {
            get { return name; }
        }

        public string ProductionDate1
        {
            get
            {
                return productionDate.Year.ToString();
            }
        }

        public string ProductionDate2
        {
            get
            {
                return productionDate.Year.ToString();
            }
        }

        public string ProductionDate3
        {
            get
            {
                return productionDate.Year.ToString();
            }
        }

        public string ProductionDate4
        {
            get
            {
                return productionDate.Year.ToString();
            }
        }

        public string ExpirationDate1
        {
            get
            {
                return expirationDate.Year.ToString();
            }
        }

        public string ExpirationDate2
        {
            get
            {
                return expirationDate.Year.ToString();
            }
        }

        public string ExpirationDate3
        {
            get
            {
                return expirationDate.Year.ToString();
            }
        }

        public string ExpirationDate4
        {
            get
            {
                return expirationDate.Year.ToString();
            }
        }



        public ProductProducer Producer
        {
            get { return producer; }
        }

        public ProductCategory Category
        {
            get { return category; }
        }


    }

    public enum ProductName
    {
        Milk,
        Apple,
        Wine,
        Bread
    }

    public enum ProductWeight
    {
        one_liter,
        one_kilo,
        one_bottle,
    }

    public enum ProductProducer
    {
        Zuzu,
        Golden,
        Cotnari,
        Panifcom
    }

    public enum ProductCategory
    {
        Dairy, 
        Fruits, 
        Beverages, 
        Bread
    }
}    
