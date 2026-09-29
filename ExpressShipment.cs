using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
                else
                {
                    Console.WriteLine("Extra fee must be greater than or equal to 0.");
                }
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + extraFee;
            }
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee      : {ExtraFee}");
            Console.WriteLine("=================================");
        }
    }
}
