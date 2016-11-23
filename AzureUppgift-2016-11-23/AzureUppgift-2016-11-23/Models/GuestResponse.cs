using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AzureUppgift_2016_11_23.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Ange ditt namn!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Ange din adress!")]
        public string Adress { get; set; }

        [Required(ErrorMessage ="Ange ditt Telefonnummer!")]
        public string Telephone { get; set; }
    }
}