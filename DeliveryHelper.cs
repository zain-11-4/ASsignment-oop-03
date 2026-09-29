using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
}
