using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PostApiWeb.Models
{
    [Table("Coches")]
    public class Coche
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Id")]
        public int Idcoche { get; set; }
        [Column("Marca")]
        public String Marca { get; set; }
        [Column("Modelo")]
        public String Modelo { get; set; }
        [Column("Color")]
        public String Color { get; set; }


    }
}