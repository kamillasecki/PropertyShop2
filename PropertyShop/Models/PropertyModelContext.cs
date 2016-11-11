using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace PropertyShop.Models
{
    public class PropertyModelContext : DbContext
    {
        public PropertyModelContext()
        {

        }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}