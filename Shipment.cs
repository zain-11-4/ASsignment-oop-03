using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1.0m, 50.0m, new DeliveryAddress("Unknown", "Unknown", 1))
        {
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
            this.description = string.IsNullOrWhiteSpace(description) ? "No Description" : description;
            this.weight = weight > 0 ? weight : 1.0m;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50.0m;
            Destination = destination;
        }

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("The weight is invalid");
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            protected set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5m);
            }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
            else
            {
                Console.WriteLine("Invalid delivery fee");
            }
        }


        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
            else
            {
                Console.WriteLine("Weight must be greater than 0.");
            }
        }

        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {
            if (baseWeight > 0 && extraPackingWeight >= 0)
            {
                weight = baseWeight + extraPackingWeight;
            }
            else
            {
                Console.WriteLine("Invalid weight values for update.");
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} kg");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee}");
            Console.WriteLine($"Destination    : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
            Console.WriteLine("=================================");
        }
    }
}
