using System;
using System.Collections.Generic;
using System.Text;

namespace ASsignment_oop_03
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public string CenterName { get; set; }
        public DeliveryAddress Location { get; set; }

        public DeliveryCenter(string centerName, DeliveryAddress location)
        {
            CenterName = string.IsNullOrWhiteSpace(centerName) ? "Main Center" : centerName;
            Location = location;
            shipments = new Shipment[20];
            count = 0;
        }


        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipments[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                        {
                            return shipments[i];
                        }
                    }
                }
                return default;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null)
            {
                return false;
            }

            if (count >= shipments.Length)
            {
                return false;
            }

            shipments[count] = shipment;
            count++;
            return true;
        }


        public bool RemoveShipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                return false;
            }

            int targetIndex = -1;

            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                {
                    targetIndex = i;
                    break;
                }
            }

            if (targetIndex == -1)
            {
                return false;
            }

            for (int i = targetIndex; i < count - 1; i++)
            {
                shipments[i] = shipments[i + 1];
            }

            shipments[count - 1] = null;
            count--;

            return true;
        }


        public void PrintAllShipments()
        {
            Console.WriteLine($"\n========== SHIPMENTS AT {CenterName.ToUpper()} ==========");

            if (count == 0)
            {
                Console.WriteLine("No shipments available in this center.");
                Console.WriteLine("=================================================");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
            }
        }

        public void PrintCenterDetails()
        {
            Console.WriteLine($"Center Name : {CenterName}");
            Console.WriteLine($"Location    : {Location.GetFullAddress()}");
            Console.WriteLine($"Total Stored: {count}/20 Shipments");
        }
    }
}
