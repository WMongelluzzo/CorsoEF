using System.ComponentModel.DataAnnotations.Schema;

namespace LabEF.ConsoleApp.Models
{
    [Table("VociFatture")]
    public class VoceFattura
    {
        public int VoceFatturaId { get; set; }

        public int Qta { get; set; }

        public string Descrizione { get; set; }

        public double Imponibile { get; set; }
    }
}
