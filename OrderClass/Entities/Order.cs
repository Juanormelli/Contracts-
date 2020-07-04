using OrderClass.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace OrderClass.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ID + "  " + Moment + "  " + Status;
        }

    }
}
