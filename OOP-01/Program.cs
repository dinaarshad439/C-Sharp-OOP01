

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





        }
    }
}
