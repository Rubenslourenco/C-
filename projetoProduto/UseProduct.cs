using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoProduto.Entities;
using System.Globalization;
namespace projetoProduto
{
    public class UseProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UseProduct() { }

        public UseProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return Name + " $" + Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}