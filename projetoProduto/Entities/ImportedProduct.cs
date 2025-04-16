using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoProduto.Entities;
namespace projetoProduto.Entities
{
    public class ImportedProduct : Product
    {
        public Double customsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + customsFee;
        }

        public override string ToString()
        {
            return Name + " $" + TotalPrice().ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + " (Customs fee: $" + customsFee.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + ")";
        }
    }
}