using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Braintreepayments.Models
{
    public class CreateAddressModel
    {
        [StringLength(255)]
        public string company { get; set; }
        [StringLength(2)]
        public string country_code_alpha2 { get; set; }
        [StringLength(3)]
        public string country_code_alpha3 { get; set; }
        [StringLength(3)]
        public string country_code_numeric { get; set; }
        public string country_name { get; set; }
        [Required]
        public string customer_id { get; set; }
        [StringLength(255)]
        public string extended_address { get; set; }
        [StringLength(255)]
        public string first_name { get; set; }
        [StringLength(255)]
        public string last_name { get; set; }
        [StringLength(255)]
        public string locality { get; set; }
        [StringLength(9, MinimumLength = 5)]
        public string postal_code { get; set; }
        [StringLength(255)]
        public string street_address { get; set; }
    }
}