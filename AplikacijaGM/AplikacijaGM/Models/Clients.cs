using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacijaGM.Models
{
    public class Clients
    {
        [Key]
        public int KlijentID { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="Ovo polje je obavezno!")]
        public string Vlasnik { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Ljubimac { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Vrsta { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Adresa { get; set; }
    }
}
