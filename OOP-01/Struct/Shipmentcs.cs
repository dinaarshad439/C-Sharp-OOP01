

namespace OOP_01.Struct
{
    /// <summary>
    /// Represents a shipment with tracking, delivery, destination, and cost information.
    /// </summary>

    internal class Shipmentcs
    {
        #region Private Fields

        string? trackingCode;
        string? description;
        double weight;
        decimal deliveryFee;

        #endregion

        #region Properties

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;

            }
        }

        public double Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }
        }

        #endregion

    }
}
