using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.ConsoleApp.Models
{
    public class VoceFattura
    {
        public int VoceFatturaId { get; set; }

        public int Qta { get; set; }

        public string Descrizione { get; set; }

        public double Imponibile { get; set; }
    }
}
