﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPBM.Models
{
    public class RifaViewModel
    {
        public string Numeros {get;set;}
        public string Nome {get;set;}
        public bool Pago {get;set;}
        public List<Vendas> vendas { get; set; }
    }
}
