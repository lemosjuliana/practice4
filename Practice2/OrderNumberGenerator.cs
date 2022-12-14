using System;

namespace Practice2
{

    public class OrderNumberGenerator
    {
        private static int _orderNumber;

        private OrderNumberGenerator() { }

        public static int NewOrderNumber()
        {
            return ++_orderNumber;
        }

    }


}