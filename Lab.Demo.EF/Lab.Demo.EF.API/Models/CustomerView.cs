using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Demo.EF.API.Models
{
    public class CustomerView
    {
        [Required]
        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string companyName { get; set; }

        [Required]
        [StringLength(20)]
        public string contactName { get; set; }

        [Required]
        [StringLength(20)]
        public string contactTitle { get; set; }

        [Required]
        [StringLength(20)]
        public string address { get; set; }

        [Required]
        [StringLength(20)]
        public string city { get; set; }

        [Required]
        [StringLength(20)]
        public string region { get; set; }

        [Required]
        [StringLength(10)]
        public string postalCode { get; set; }

        [Required]
        [StringLength(20)]
        public string country { get; set; }

        [Required]
        [StringLength(12)]
        public string contactPhone { get; set; }

        [Required]
        [StringLength(12)]
        public string fax { get; set; }
    }
}