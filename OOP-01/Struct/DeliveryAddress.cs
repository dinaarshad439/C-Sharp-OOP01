

namespace OOP_01.Struct
{
    /// <summary>
    /// Represents a delivery address with city, street, and building number.
    /// </summary>

    internal class DeliveryAddress
    {
        //fields
        public string City;
        public string Street;
        public int BuildingNumber;

        // Constructor
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        /// <summary>
        /// method gets the full address 
        /// </summary>
        /// <returns> full address as a single string </returns>
        public string GetFullAddress()
        {
            return $"{City}, {Street}, {BuildingNumber}";
        }
    }

}

