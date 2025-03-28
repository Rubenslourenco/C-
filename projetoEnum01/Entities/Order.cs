using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoEnum01.Entities.Enums;

namespace projetoEnum01.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


        override public string ToString()
        {
            return Id
            + ", "
            + Moment
            + ", "
            + Status;
        }
    }
}