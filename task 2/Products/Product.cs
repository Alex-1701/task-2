using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Markup { get; set; }
        public int Amount { get; set; }

        public Product()
        {
            Name = "Product";
        }

        public Product(string name, double price, double markup, int amount)
        {
            Name = name;
            Price = price;
            Markup = markup;
            Amount = amount;
        }

        public double UnitCost()
        {
            return Price * Markup;
        }

        public double TotalCost()
        {
            return UnitCost() * Amount;
        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return new { this.Name, this.Price, this.Markup, this.Amount}.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Product product = (Product)obj;

            if (product.Name == Name)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return (Name + "\t\t" + Price + "\t\t" + Markup + "\t\t" + Amount);
        }

        public static Product operator + (Product p1, Product p2)
        {
            if (p1.Name == p2.Name)
            {
                double sum1 = p1.TotalCost();
                double sum2 = p2.TotalCost();
                double avrPrice = (sum1 + sum2) / (p1.UnitCost() + p2.UnitCost());

                double avrMarkup = (p1.Markup + p2.Markup) / 2;

                int sumAmount = p1.Amount + p2.Amount;

                return new Product(p1.Name, avrPrice, avrMarkup, sumAmount);
            }
            else
                throw new Exception();
        }

        public static Product operator - (Product p, int sub)
        {
            int num = p.Amount - sub;
            if (num < 0) 
                throw new Exception();
            return new Product(p.Name, p.Price, p.Markup, num);
        }

        public static implicit operator int (Product p)
        {
            return (int)(p.Price * 100);
        }

        public static implicit operator double(Product p)
        {
            return p.Price;
        }
    }
}
