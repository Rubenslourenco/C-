using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using projetoOrderEx.Entities.Enums;
using projetoOrderEx.Entities;

namespace projetoOrderEx.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client client { get; set; } = new Client();
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public void addItems(OrderItem item) => items.Add(item);
        public void removeItems(OrderItem item) => items.remove(item);

        public double Total() => items.Sum(item => item.SubTotal());

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("'dd/MM/yyyy HH:mm:ss'"));
            sb.AppendLine("Order Status:" + Status);
            sb.AppendLine("Client" : +client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}