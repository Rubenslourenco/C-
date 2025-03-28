using projetoEnum01.Entities;
using projetoEnum01.Entities.Enums;
using System;

namespace projetoEnum01
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            //convertendo Enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            //convertendo string para Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            System.Console.WriteLine(txt);
            System.Console.WriteLine(os);
        }
    }
}