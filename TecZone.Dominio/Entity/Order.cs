using System;
using System.Collections.Generic;
using System.Linq;
using TecZone.Dominio.Value;

namespace TecZone.Dominio.Entidades
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int IdUser { get; set; }
        public DateTime ExpectedArrival { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        ICollection<OrderItem> Items { get; set; } // one or multiples item orders
        public int IdPaymentMethod { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public override void Validate()
        {
            ClearMessage();

            if (!Items.Any())
            {
                AddMessage("Warning: Items not be null");
            }

            if (string.IsNullOrEmpty(PostalCode))
            {
                AddMessage("Warning: PostalCode not be null");
            }
        }
    }
}
