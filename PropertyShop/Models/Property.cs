using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyShop.Models
{
    public class Property
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public DateTime DateCreated { get; set; }
        public int Bedrooms { get; set; }
        public string Desctiption { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public Address Address { get; set; }
        public string type { get; set; }
    }
}