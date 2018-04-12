using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabEF.ConsoleApp.Models
{
    [Table("Fatture")]
    public class Fattura
    {

       public int FatturaId { get; set; }

        [Column("Data")]
        public DateTime DataFattura { get; set; }

        [Column("Num")]
        public string NumeroFattura { get; set; }

        public List<VoceFattura> VociFattura { get; set; }
    }
}
