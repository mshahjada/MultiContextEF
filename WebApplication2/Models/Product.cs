using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [Table("Products", Schema = "config")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}