using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPBM.Models
{
    public class RifaViewModel
    {
        public bool N0 {get;set;}
        public bool N1 {get;set;}
        public bool N2 {get;set;}
        public List<Vendas> vendas { get; set; }
    }
}
