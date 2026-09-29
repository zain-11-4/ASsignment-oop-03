using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
                else
                {
                    Console.WriteLine("Destination country cannot be null or empty.");
                    destinationCountry = "UNKNOWN_COUNTRY";
                }
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
                else
                {
                    Console.WriteLine("Customs fee must be greater than or equal to 0.");
                }
            }
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"[Customs Report] Country: {DestinationCountry}, Fee: {CustomsFee}");
        }

        public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Dest. Country  : {DestinationCountry}");
            Console.WriteLine($"Customs Fee    : {CustomsFee}");
            Console.WriteLine("=================================");
        }
    }
}
