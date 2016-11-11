using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyShop.Models
{
    public class Agency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contact Contact { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}