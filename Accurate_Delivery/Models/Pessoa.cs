using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accurate_Delivery.Models
{
    public class Pessoa
    {
        public string Email { get; set; }
        
        public string SenhaAcesso { get; set; }
    }
}