using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAlmacen.Models.Masters
{
    [Table(name:"Company")]
    public class Company
    {
        [Key]
        public Guid ID { get; set; }
        public string CompanyName { get; set; }
        public string Direction { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Logo2 { get; set; }
        public string QualityLogo { get; set; }
        public string FreeText1 { get; set; }
        public string FreeText2 { get; set; }
        public string FreeText3 { get; set; }
        public string FreeText4 { get; set; }
    }
}