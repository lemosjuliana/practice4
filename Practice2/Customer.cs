using System;

namespace Practice2
{
    /// <summary>
    /// <para>Someone buying products</para>
    /// <para>
    /// The responsibility of an Client is to keep track of its name and address.
    /// </para>
    /// </summary>
    public class Customer
    {
        private string _name;
        private Address _address;

        /// <summary>
        /// Constructs a new instance of Customer.
        /// </summary>
        /// <param name="name">The given name.</param>
        /// <param name="address">The given address.</param>
        public Customer(string name, Address address)
        {
            _name = name.ToUpper();
            _address = address;
        }
        /// <summary>
        /// Gets location of the customer.
        /// </summary>
        /// <returns>returns true for address if the customer lives in theUSA</returns>
        public bool IsLocationUsa()
        {
            return _address.IsLocationUsa();
        }
        /// <summary>
        /// Gets name.
        /// </summary>
        /// <returns>returns a name</returns>
        public string Name { get { return _name; } }

        /// <summary>
        /// Gets Address.
        /// </summary>
        /// <returns>returns a address</returns>
        public Address Address { get { return _address; } }
    }
}