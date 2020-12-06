using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Phone : Product
    {
        public Phone()
        {
            Name = "Phone";
            Markup = 0.25;
        }

        public Phone(string name, double price, double markup, int amount)
            : base(name, price, markup, amount)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Phone phone = (Phone)obj;

            if (phone.Name == Name)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Phone operator + (Phone p1, Phone p2)
        {
            if (p1.Name == p2.Name)
            {
                double sum1 = p1.TotalCost();
                double sum2 = p2.TotalCost();
                double avrPrice = (sum1 + sum2) / (p1.UnitCost() + p2.UnitCost());

                double avrMarkup = (p1.Markup + p2.Markup) / 2;

                int sumAmount = p1.Amount + p2.Amount;

                return new Phone(p1.Name, avrPrice, avrMarkup, sumAmount);
            }
            else
                throw new Exception();
        }

        public static Phone operator - (Phone p, int sub)
        {
            int num = p.Amount - sub;
            if (num < 0)
                throw new Exception();
            return new Phone(p.Name, p.Price, p.Markup, num);
        }

        public static implicit operator int(Phone p)
        {
            return (int)(p.Price * 100);
        }

        public static implicit operator double(Phone p)
        {
            return p.Price;
        }
    }
}
