using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class WristWatch : Product
    {
        public WristWatch()
        {
            Name = "Wrist Watch";
            Markup = 0.1;
        }

        public WristWatch(string name, double price, double markup, int amount)
            : base(name, price, markup, amount)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            WristWatch watch = (WristWatch)obj;

            if (watch.Name == Name)
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

        /*public static Phone operator +(Phone p1, Phone p2)
        {
            if (p1.Name == p2.Name)
            {
                double sum1 = (p1.Amount * p1.Price * p1.Markup);
                double sum2 = (p2.Amount * p2.Price * p2.Markup);
                double avrPrice = (sum1 + sum2) / (p1.Price * p1.Markup + p2.Price * p2.Markup);

                double avrMarkup = (p1.Markup + p2.Markup) / 2;

                int sumAmount = p1.Amount + p2.Amount;

                return new Phone(p1.Name, avrPrice, avrMarkup, sumAmount);
            }
            else
                throw new Exception();
        }*/
    }
}
