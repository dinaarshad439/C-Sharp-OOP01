

using OOP_01.Struct;

namespace OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Theoretical Questions

            #region (Q1) Struct vs Class

            // (a) DeliveryAddress is a struct (value type),DeleiveryAddress variable is not modified only the copied variable changed as it copied only the value.
            // (b) Customer is a class (reference type),Customer variable changed with changing the copied variable as it copies the reference not value.

            #endregion

            #region (Q2) Fields vs Properties

            /* (a) 
             * 1) We cannot perform validation directly on fields when values are assigned.
             * 2) Modifying the internal field implementation/logic will directly break or impact external code.
             * 3) We cannot restrict get without set or vice versa
             */

            /* (b)
             * 1) We can modify internal class implementation without breaking external caller code in Main, as it interacts through properties.
             * 2) Properties allow adding validation logic inside setters (or getters) to ensure fields hold valid business values.
             * 3) we can create read-only (getter only) or write-only (setter only) and both of them.
             */
            #endregion

            #endregion

            #region Practical Questions

            #region  Print all shipment information from user

            // a create object from delivery center
            DeliveryCenter center = new DeliveryCenter();

            // b, c. Read and add three shipments
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"========== Shipment {i + 1} ==========");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress destination =
                    new DeliveryAddress(city, street, buildingNumber);

                Shipment shipment = new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination);

                center.AddShipment(shipment);



            }
            // d. Print the three shipments using the integer indexer
            Console.WriteLine("\n========== All Shipments ==========");

            for (int i = 0; i < 3; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine();
            }

            // e. Ask for tracking code
            Console.Write("Enter Tracking Code to search: ");
            string searchCode = Console.ReadLine();

            // f. Search using string indexer
            Shipment foundShipment = center[searchCode];

            // g. Print if found
            if (!string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
            {
                Console.WriteLine($"Found {foundShipment.TrackingCode} - {foundShipment.Description}");

            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            #region (Q1) Struct copy test

            Console.WriteLine("-------------Struct copy test-------------");

            DeliveryAddress Address = new DeliveryAddress("Cairo", "Maadi", 1);
            DeliveryAddress CopiedAddress = Address;

            Console.WriteLine("==========Before modifying copied variable==============");

            Console.WriteLine($"Copied variable : {CopiedAddress.GetFullAddress()}");
            Console.WriteLine($"Original variable: {Address.GetFullAddress()}");

            CopiedAddress.BuildingNumber = 2;
            CopiedAddress.Street = "Nasr City";
            Console.WriteLine("==========After modifying copied variable==============");

            Console.WriteLine($"Copied address : {CopiedAddress.GetFullAddress()}");
            Console.WriteLine($"Original address: {Address.GetFullAddress()}");



            #endregion



            #endregion


            #endregion






        }
    }
}
