namespace ASsignment_oop_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // method overriding is a late binding (run time) 
            // method overLoading is a Early binding (compile time)















             




            Console.WriteLine("==================================================");
            Console.WriteLine("    SMART DELIVERY MANAGEMENT SYSTEM (ASSIGNMENT 03)   ");
            Console.WriteLine("==================================================\n");

            Driver driver = new Driver("Ahmed Hassan", "LIC-998877");

            DeliveryAddress centerAddress = new DeliveryAddress("Cairo", "El-Nasr Road", 45);
            DeliveryCenter center = new DeliveryCenter("Cairo Main Hub", centerAddress);

            Console.WriteLine($"Assigned Driver '{driver.Name}' to Center '{center.CenterName}'.\n");

            DeliveryAddress dest1 = new DeliveryAddress("Giza", "Pyramids St", 12);
            DeliveryAddress dest2 = new DeliveryAddress("Alexandria", "Corniche Rd", 88);
            DeliveryAddress dest3 = new DeliveryAddress("Riyadh", "King Fahd Rd", 300);

            StandardShipment std = new StandardShipment("STD-1001", "Books", 3.0m, 30.0m, dest1);

            ExpressShipment exp = new ExpressShipment("EXP-2002", "Laptop", 2.5m, 60.0m, dest2, 25.0m);

            InternationalShipment intl = new InternationalShipment("INT-3003", "Medical Equipment", 10.0m, 150.0m, dest3, "KSA", 100.0m);

            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(intl);

            Console.WriteLine("=================== h. PRINT VIA DELIVERY CENTER ===================");
            center.PrintAllShipments();


            Console.WriteLine("\n=================== i. PRINT VIA DELIVERY HELPER ===================");
            DeliveryHelper.PrintShipmentDetails(std);
            DeliveryHelper.PrintShipmentDetails(exp);
            DeliveryHelper.PrintShipmentDetails(intl);

            Console.WriteLine("\n=================== j. METHOD OVERLOADING DEMO ===================");
            Console.WriteLine($"Original Weight: {std.Weight} kg");

            std.UpdateWeight(5.0m);
            Console.WriteLine($"After UpdateWeight(5.0m): {std.Weight} kg");

            std.UpdateWeight(5.0m, 1.5m);
            Console.WriteLine($"After UpdateWeight(5.0m, 1.5m extra packing): {std.Weight} kg");

            Console.WriteLine("\n=================== k. MIXED SHIPMENT ARRAY LOOP ===================");
            Shipment[] mixedShipments = new Shipment[]
            {
                new StandardShipment("MIX-01", "Documents", 1.0m, 20.0m, dest1),
                new ExpressShipment("MIX-02", "Smartphones", 4.0m, 80.0m, dest2, 40.0m),
                new InternationalShipment("MIX-03", "Clothing", 7.0m, 120.0m, dest3, "UAE", 50.0m),
                new CompletedShipment("CMP-04", "Spare Parts", 6.0m, 50.0m, dest1, DateTime.Now)
            };

            foreach (Shipment ship in mixedShipments)
            {
                ship.PrintShipment();
            }

            Console.WriteLine("\n=================== l. SEALED CLASS & METHOD DEMO ===================");

            CompletedShipment completed = new CompletedShipment("CMP-99", "Delivered Package", 2.0m, 25.0m, dest1, DateTime.Now);
            completed.PrintShipment();

            PriorityInternationalShipment priorityIntl = new PriorityInternationalShipment("PRI-88", "Urgent Vaccines", 5.0m, 200.0m, dest3, "UK", 150.0m);
            priorityIntl.GenerateCustomsReport();

            Console.WriteLine("\nAssignment 03 execution completed successfully!");
            Console.ReadLine();
        }
    }
}
