using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_api.Models
{
    public class DavetiyeModel
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool? KatılmaDurumu { get; set; }
    }
}