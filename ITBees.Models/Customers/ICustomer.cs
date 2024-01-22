using System;

namespace ITBees.Models.Customers
{
    /// <summary>
    /// Marker interface, for custom implementation i final project Your Customer object
    /// </summary>
    public interface ICustomer
    {
        public Guid Guid { get; set; }
    }
}