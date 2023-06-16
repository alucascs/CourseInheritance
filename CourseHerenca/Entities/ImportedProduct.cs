using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHeranca.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustumsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double custumsFee) : base(name, price)
        {
            CustumsFee = custumsFee;
        }

        public double TotalPrice()
        {
            return Price += CustumsFee;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("f2", CultureInfo.InvariantCulture) + " (Customs fee : $ " + CustumsFee + ")";
        }
    }
}
