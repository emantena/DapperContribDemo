﻿using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace DapperContribDemo.Domain.Entities
{
    [Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        [Write(false)]
        public virtual ICollection<Order> Order { get; set; }
    }
}