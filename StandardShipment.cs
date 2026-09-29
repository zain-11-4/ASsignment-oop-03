using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
                    : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
        }
    }
}
