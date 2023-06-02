using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devdayapi.Model;
using Microsoft.EntityFrameworkCore;

namespace devdayapi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customer {get; set;}
    }
}