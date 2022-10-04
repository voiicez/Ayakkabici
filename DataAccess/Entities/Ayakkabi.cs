using System;
using System.ComponentModel.DataAnnotations;
using AppCore8137.Records.Bases;

namespace DataAccess.Entities
{
    public class Ayakkabi:Record
    {
        [Required]
        public string? Model { get; set; }
        [Required]
        public int? MarkaId { get; set; }
        [Required]
        public byte Numara { get; set; }
        [Required]
        public List<Renk> Renk { get; set; }
        [Required]
        public bool ErkekMi { get; set; }
    }
}

