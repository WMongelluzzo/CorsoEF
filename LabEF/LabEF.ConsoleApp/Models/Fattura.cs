﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.ConsoleApp.Models
{
    public class Fattura
    {
        public int FatturaId { get; set; }

        public DateTime DataFattura { get; set; }

        public string NumeroFattura { get; set; }

        public List<VoceFattura> VociFattura { get; set; }
    }
}
