//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Data.Entity.Repository.Testing.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
            this.CustomerDemographics = new HashSet<CustomerDemographic>();
        }
        
        [Key]
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }
    }
}
