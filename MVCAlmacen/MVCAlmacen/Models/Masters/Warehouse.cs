using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAlmacen.Models.Masters
{
    [Table(name:"Warehouse")]
    public class Warehouse
    {
        [Key]
        public string ID { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}