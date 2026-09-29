using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal sealed class CompletedShipment : Shipment
    {
        public DateTime DeliveryDate { get; set; }

        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, DateTime deliveryDate)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DeliveryDate = deliveryDate;
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Delivered On   : {DeliveryDate.ToShortDateString()}");
            Console.WriteLine("=================================");
        }
    }
}
