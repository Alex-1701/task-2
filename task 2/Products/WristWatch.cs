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

        public static WristWatch operator + (WristWatch p1, WristWatch p2)
        {
            if (p1.Name == p2.Name)
            {
                double sum1 = p1.TotalCost();
                double sum2 = p2.TotalCost();
                double avrPrice = (sum1 + sum2) / (p1.UnitCost() + p2.UnitCost());

                double avrMarkup = (p1.Markup + p2.Markup) / 2;

                int sumAmount = p1.Amount + p2.Amount;

                return new WristWatch(p1.Name, avrPrice, avrMarkup, sumAmount);
            }
            else
                throw new Exception();
        }

        public static WristWatch operator - (WristWatch p, int sub)
        {
            int num = p.Amount - sub;
            if (num < 0)
                throw new Exception();
            return new WristWatch(p.Name, p.Price, p.Markup, num);
        }

        public static implicit operator int(WristWatch p)
        {
            return (int)(p.Price * 100);
        }

        public static implicit operator double(WristWatch p)
        {
            return p.Price;
        }
    }
}
