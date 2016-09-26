using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Web.Models.ViewModels
{

    public class VMPalendrome
    {
        [Required]
        public string InputString { get; set; }
    }


    public class ViewModels
    {

    }
}