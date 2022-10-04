using System;
using System.ComponentModel.DataAnnotations;
using AppCore8137.Records.Bases;

namespace DataAccess.Entities
{
    public class Marka:Record
    {
        [Required]
        public string? Adi { get; set; }
    }
}

