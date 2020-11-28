using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using ServiceA.Domain.Entities;
using ServiceA.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceA.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var customer = new Customer();
            context.Customers.Add(customer);
            Assert.AreEqual(EntityState.Added, context.Entry(customer).State);
        }
    }
}
