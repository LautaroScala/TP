﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThingsLoan.MVC.Models
{
    public class ThingsViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Desc { get; set; }
        public int CategoryId { get; set; }
    }
}
